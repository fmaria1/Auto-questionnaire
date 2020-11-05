/**************************************************************************
 *                                                                        *
 *  File:        LogInForm.cs                                             *
 *  Autors:      Frantescu Maria, Moraru Andrei Sebastian, Luca Teodora   *
 *               Stefania, Bejan Florina Oana                             *
 *  Description: Conține form-ul principal al aplicației.                 *
 *               Acest fișier conține cod și informații pentru conexiunea *
 *               interfeței (principalele componente ce se găsesc în      *
 *               interfața cu utilizatorul) cu principalele funcții și    *
 *               funcționalități implementate în sistem.                  *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace ChestionarAuto
{
    public partial class LogInForm : Form
    {
        public List<Test> Questions;
        private ProxyDocumentManager _proxyDocumentManager;
        private OpenFileDialog _openFileDialog;

        #region Public Methods

		public void LoadQuestions(string path)
		{
			try
			{
				//citirea fișierului cu întrebări de tip json
				string text = File.ReadAllText(path);
				if (String.IsNullOrEmpty(text))
				{
					//se arunca exceptie daca fisierul este gol
					throw new Exception("Fisierul selectat este gol. \nIncearca din nou!");
				}
				//parsarea fisierului json
				this.Questions = JsonConvert.DeserializeObject<List<Test>>(text);
			}
			catch (IOException)
			{
				showInputError();
				throw new IOException();
			}
			//fișierul a fost încărcat
			startButton.Enabled = true;
		}

		public void LogIn(string username, string password)
		{
			if (_proxyDocumentManager.Login(username, password)) //verificare dacă numele de utilizator și parola sunt corecte
			{
				//afișare în interfață mesaj de logare reușită 
				logInMsg.ForeColor = Color.Green;
				logInMsg.Text = "Logare reusita!";
				logInMsg.Visible = true;
			}
			else
			{
				//afișare în interfață mesaj de logare nereușită
				logInMsg.ForeColor = Color.Red;
				logInMsg.Text = "Utilizator inexistent sau parola incorecta!";
				logInMsg.Visible = true;

				//iese de functie
				return;
			}
			//la logarea administratorului se deblocheaza campul groupBox
			if (_proxyDocumentManager.CurrentAccessLevel() == -1)
				groupBox.Enabled = true;
		}

		//adaugare utilizator nou. Această operație poate fi facută doar de pe un cont de administrator
		public void AddUser(string username, string password)
		{
			if (_proxyDocumentManager.AddUser(username, password)) //se adauga utilizator nou 
			{
				//afișare în interfață mesaj în cazul in care noul cont a fost adăugat cu succes
				addUserMsg.ForeColor = Color.Green;
				addUserMsg.Text = "Utilizatorul a fost adaugat cu succes!";
				addUserMsg.Visible = true;
			}
			else
			{
				//afișare în interfață mesaj în cazul in care contul există deja
				addUserMsg.ForeColor = Color.Red;
				addUserMsg.Text = "Utilizatorul exista deja!";
				addUserMsg.Visible = true;
			}
		}

        #endregion

        #region Constructor

        public LogInForm()
        {
            InitializeComponent();
            _proxyDocumentManager = new ProxyDocumentManager();
        }

        #endregion

        #region Private Methods

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle; //prevenire redimensionare
        }

        //metodă care se apelează in cazul în care extensia fișierului este invalidă
        private void showInputError()
        {
            MessageBox.Show("Fisierul selectat este invalid. \nIncearca din nou!",
                "Eroare la fisier",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk
                );
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //lansarea unui form nou cu chestionarul
            TestForm quizUI = new TestForm(Questions);
            quizUI.Show();
            this.Hide();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            //preluare nume de utilizator și parolă din interfață
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            //apelare funcție de verificare a corectitudinii acestora
            LogIn(username, password);

            //se incarca fisierul json cu intrebarile testului
            LoadQuestions("F:/ChestionarAuto/ChestionarAuto/Test_Files/Test.json");
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            //preluare din interfață nume de utilizator nou și parolă
            string username = textBoxAddUserUsername.Text;
            string password = textBoxAddUserPassword.Text;

            //apel funcție pentru adăugarea unui nou utilizator
            AddUser(username, password);
        }

        // funcție pentru delogare și actualizarea interfeței în mod corespunzător acestei acțiuni
        private void logOutButton_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            startButton.Enabled = false;
            logInMsg.Visible = false;

            textBoxAddUserUsername.Text = "";
            textBoxAddUserPassword.Text = "";
            groupBox.Enabled = false;
            addUserMsg.Visible = false;

            _proxyDocumentManager = new ProxyDocumentManager();
        }

        //metodă care permite utilizatorului accesarea unor noțiuni teoretice
		private void mediuInvatareToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				_openFileDialog = new OpenFileDialog();
				_openFileDialog.Filter = "Text documents (*.txd)|*.txd|Graphic documents (*.grd)|*.grd";
				if (_openFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}

				Document doc;
				// crearea obiectului document (creatorul concret)
				if (_openFileDialog.FilterIndex == 1) // tip de fisier TXD
				{
					doc = new TextDocument(_openFileDialog.FileName);
				}
				else // tip de fisier GRD
				{
					doc = new GraphicDocument(_openFileDialog.FileName);
				}

				//afișarea paginilor în obiectul tab control
				tabControl.Controls.Clear();
				foreach (Page p in doc.Pages)
				{
					TabPage tp = new TabPage(p.Name);
					p.Control.Dock = DockStyle.Fill;
					tp.Controls.Add(p.Control);
					tabControl.TabPages.Add(tp);
				}
			}
			//tratare excepție pentru cazul în care pot apărea probleme la deschiderea fișierului, se poate să nu conțină căi valide 
			//sau fișierele preluate să nu aibă conținutul așteptat
			catch (Exception ex)
			{
				MessageBox.Show("EROARE: " + ex.Message);
			}
		}

        private void instructiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instrucțiunile de utilizare ale aplicației
            MessageBox.Show(" Acesta este un chestionar auto, foarte util pentru persoanele" +
                " ce se pregatesc pentru examenul auto si dobandirea permisului de conducere." +
                " \n Pentru a accesa chestionarul auto trebuie sa va logati completand in campurile" +
                " Utilizator si Parola. \n Daca nu aveti cont, administratorii va pot crea un cont " +
                "nou. \n Dupa logare puteti incepe chestionarul auto. Acesta contine 10 intrebari " +
                "cu raspuns simplu. \n Dupa rezolvarea celor 10 intrebari, veti primi rezultatul" +
                " chestionarului. \n Succes!");
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //închiderea aplicației
            if (MessageBox.Show("Sigur doriti sa iesiti?", "Iesire", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        #endregion
    }

}




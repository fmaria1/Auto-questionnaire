/**************************************************************************
 *                                                                        *
 *  File:        Document.cs                                              *
 *  Autors:      Frantescu Maria, Moraru Andrei Sebastian, Luca Teodora   *
 *               Stefania, Bejan Florina Oana                             *
 *  Description: Contine funcțiile (constructor și alte metode)           *
 *               folositoare pentru citirea fișierului de intrare.        *
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChestionarAuto
{
    public abstract class Document
    {
        #region Protected members

        protected List<Page> _pages;

        #endregion

        #region Constructor

        //constructorul clasei Document
        protected Document(string indexFileName)
        {
            _pages = new List<Page>();

            try
            {
                StreamReader sr = new StreamReader(indexFileName); //instatiere obiect de tip StreamReader
                string line;

                //citirea fișierului index linie cu linie și crearea paginilor corespunzătoare
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != string.Empty)
                    {
                        Page p = CreatePage(line); //creare pagină nouă
                        if (p != null)
                        {
                            _pages.Add(p); //adăugarea paginii în listă
                        }
                        else
                        {
                            //se arunca exceptie în cazul în care extensia fișierului nu este cunoscută
                            throw new IOException();
                        }
                    }
                }
                sr.Close();
            }
            catch (IOException FileExtensionException)
            {
                MessageBox.Show(FileExtensionException.Message);
                throw new IOException();
            }
        }

        #endregion

        #region Protected methods

        //deoarece această metoda este una abstractă tipul efectiv al pagini va fi decis de către clasele derivate din Document
        protected abstract Page CreatePage(string fileName);

        #endregion

        #region Getters

        public List<Page> Pages
        {
            get
            {
                return _pages;
            }
        }

        #endregion
    }
}

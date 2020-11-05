/**************************************************************************
 *                                                                        *
 *  File:        JpegPage.cs                                              *
 *  Autors:      Frantescu Maria, Moraru Andrei Sebastian, Luca Teodora   *
 *               Stefania, Bejan Florina Oana                             *
 *  Description: Conține un constructor pentru creare noii pagini         *
 *               cu extensia „.jpg”.                                      *
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
    public class JpegPage : Page
    {
        #region Constructor

        public JpegPage(string fileName)
        {
            _name = Path.GetFileNameWithoutExtension(fileName); //preluare nume fișier

            PictureBox pbx = new PictureBox();

            //încarcarea fișierului de tip .jpeg
            pbx.ImageLocation = fileName;
            pbx.Load();
            _control = pbx;
        }

        #endregion
    }
}

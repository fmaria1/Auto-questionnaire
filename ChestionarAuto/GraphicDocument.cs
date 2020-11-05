/**************************************************************************
 *                                                                        *
 *  File:        GraphicDocument.cs                                       *
 *  Autors:      Frantescu Maria, Moraru Andrei Sebastian, Luca Teodora   *
 *               Stefania, Bejan Florina Oana                             *
 *  Description: Conține un constructor și o metodă ce identifică         *
 *               extensia pentru noua pagină ce va fi creată.             *
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
    public class GraphicDocument : Document
    {
        #region Constructor

        //constructorul clasei GraphicDocument
        public GraphicDocument(string indexFileName) : base(indexFileName)
        {
        }

        #endregion

        #region Protected methods

        protected override Page CreatePage(string fileName)
        {
            // creare paginilor grafice de tip .bmp si .jpeg
            Page p = null;
            switch (Path.GetExtension(fileName)) //verificarea tipului de extensie
            {
                case ".bmp":
                    p = new BitmapPage(fileName);
                    break;
                case ".jpg":
                    p = new JpegPage(fileName);
                    break;
            }
            return p;
        }

        #endregion
    }
}

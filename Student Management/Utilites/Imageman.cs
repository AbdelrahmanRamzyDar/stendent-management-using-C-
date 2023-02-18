using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.Utilites
{
   public  class Imageman
    {
 
    public static byte[] GetPhoto(PictureBox pb)
    {
            MemoryStream ms = new MemoryStream();
            return ms.GetBuffer();

    }

        public static Image PutPhoto(byte[]photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);

        }
    }
}
 
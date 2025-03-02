using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_School_Library
{
    internal class DataStorage
    {
        public static DataClassesDataContext dcdc = new DataClassesDataContext();

        public static int id;
        public static bool role;
        public static void LoadImage(PictureBox a, Category b)
        {
            if (b != null)
            {
                // Get Image
                Binary imageDataBinary = b.Image;


                if (imageDataBinary != null)
                {
                    byte[] imageData = imageDataBinary.ToArray(); // KONVERSI Binary ke byte[]

                    // Gunakan MemoryStream untuk mengubah byte[] ke Image
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        a.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            else
            {
                return;
            }
            
        }

        public static void LoadImageBook(PictureBox a, Book b)
        {
            try
            {


                if (b != null)
                {
                    // Get Image
                    Binary imageDataBinary = b.Image;

                    if (imageDataBinary != null)
                    {
                        byte[] imageData = imageDataBinary.ToArray(); // KONVERSI Binary ke byte[]

                        // Gunakan MemoryStream untuk mengubah byte[] ke Image
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            a.Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            catch
            {

            }
        }

        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        


    }
}

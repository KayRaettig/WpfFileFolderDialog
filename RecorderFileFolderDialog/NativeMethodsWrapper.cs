using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RecorderFileFolderDialog
{
    public class NativeMethodsWrapper
    {


        private NativeMethodsWrapper(){}


   

        public static void GetIcon(System.Windows.Controls.Image img)
        {
            var error = System.Drawing.SystemIcons.Application;
            ImageSource image = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(error.Handle, Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            img.Source = image;
            
        }

    }
}

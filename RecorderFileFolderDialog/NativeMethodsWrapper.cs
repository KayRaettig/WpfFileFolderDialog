using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Interop;

namespace RecorderFileFolderDialog
{
    public class NativeMethodsWrapper
    {
        [Flags]
        public enum SystemButton
        {
            Minimize = 1,
            Maximize = 2
        }

        private NativeMethodsWrapper(){}

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_STYLE = -16;
        private const int WS_MAXIMIZEBOX = 0x10000;
        private const int WS_MINIMIZEBOX = 0x20000;




        public static void DisableSystemButtons(Window window, SystemButton buttons)
        {
            var hwnd = new WindowInteropHelper(window).Handle;
            var value = GetWindowLong(hwnd, GWL_STYLE);

            var btns = (int)buttons;


            if (btns == 2)
            {
                value = value & ~WS_MAXIMIZEBOX;
            }


            if (btns == 1)
            {
                value = value & ~WS_MINIMIZEBOX;
            }

            if (btns == 3)
            {
                value = value & ~WS_MAXIMIZEBOX & ~ WS_MINIMIZEBOX;
            }


            SetWindowLong(hwnd, GWL_STYLE, (value));
        }


    }
}

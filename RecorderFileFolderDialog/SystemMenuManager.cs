using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Interop;

namespace RecorderFileFolderDialog
{
    /// <summary>
    /// Encapsulates access to the system menu of a window
    /// </summary>
    public class SystemMenuManager
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);
        [DllImport("user32.dll")]
        private static extern IntPtr DestroyMenu(IntPtr hWnd);

        private const int GWL_STYLE = -16;
        private const int WS_MAXIMIZEBOX = 0x10000;
        private const int WS_MINIMIZEBOX = 0x20000;
        private const int WS_SYSMENU = 0x80000;


        private const uint MF_BYCOMMAND = 0x00000000;
        private const uint MF_GRAYED = 0x00000001;
        private const uint MF_ENABLED = 0x00000000;

        private const uint SC_CLOSE = 0xF060;


        [Flags]
        public enum SystemButton
        {
            Minimize = 1,
            Maximize = 2,
            Close = 4
        }


        public static void DisableSystemButtons(Window window, SystemButton buttons)
        {
            var hwnd = GetWindowHwnd(window);
            var value = GetWindowLong(hwnd, GWL_STYLE);


            if (buttons.IsSet<SystemButton>(SystemButton.Minimize))
            {
                value = value & ~WS_MINIMIZEBOX;
            }

            if (buttons.IsSet<SystemButton>(SystemButton.Maximize))
            {
                value = value & ~WS_MAXIMIZEBOX;
            }

            if (buttons.IsSet<SystemButton>(SystemButton.Close))
            {
                DisableCloseButton(window);
            }


            SetWindowLong(hwnd, GWL_STYLE, value);
        }




        #region Close button



        public static void EnableCloseButton(Window window)
        {
            var hwnd = GetWindowHwnd(window);
            var menuHwnd = GetSystemMenu(hwnd, false);

            EnableMenuItem(menuHwnd, SC_CLOSE, MF_ENABLED);
            DestroyMenu(menuHwnd);
        }

        public static void DisableCloseButton(Window window)
        {
            var hwnd = GetWindowHwnd(window);
            var menuHwnd = GetSystemMenu(hwnd, false);

            EnableMenuItem(menuHwnd, SC_CLOSE, MF_BYCOMMAND | MF_GRAYED);
        }


        #endregion




        public static void DisableSystemMenu(Window window)
        {
            var hwnd = GetWindowHwnd(window);
            var value = GetWindowLong(hwnd, GWL_STYLE);

            value = value & ~WS_SYSMENU;
            SetWindowLong(hwnd, GWL_STYLE, value);
        }

        public static void EnableSystemMenu(Window window)
        {
            var hwnd = GetWindowHwnd(window);
            var value = GetWindowLong(hwnd, GWL_STYLE);

            value = value | WS_SYSMENU;
        }

        private static IntPtr GetWindowHwnd(Window window)
        {
            var tmp = new WindowInteropHelper(window);
            tmp.EnsureHandle();
            return new WindowInteropHelper(window).Handle;

        }
    }
}

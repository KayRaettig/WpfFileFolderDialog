﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RecorderFileFolderDialog
{
    /// <summary>
    /// Interaction logic for Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        public Dialog()
        {
            this.SourceInitialized += Dialog_SourceInitialized;
            InitializeComponent();
        }


        private void Dialog_SourceInitialized(object sender, EventArgs e)
        {
            NativeMethodsWrapper.DisableSystemButtons(this, NativeMethodsWrapper.SystemButton.Maximize | NativeMethodsWrapper.SystemButton.Minimize);
        }
    }
}

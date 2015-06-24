using System;
using System.Collections.Generic;
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
using WindowCustomization;

namespace RecorderFileFolderDialog
{
    /// <summary>
    /// Interaction logic for Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        private HelpButtonClicked callback;
        public Dialog()
        {
            SourceInitialized += Dialog_SourceInitialized;
            InitializeComponent();
            callback = new HelpButtonClicked(Help_Clicked);
        }

        void Dialog_SourceInitialized(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.ShowHelpButton(new HelpButtonClicked(Help_Clicked));
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.HideHelpButton(true, true);
        }

        private void Help_Clicked(object sender, object context)
        {
            MessageBox.Show((sender as Window).Title + " asked for help.");
        }
    }
}

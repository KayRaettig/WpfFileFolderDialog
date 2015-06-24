using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowCustomization;

namespace RecorderFileFolderDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SourceInitialized += MainWindow_SourceInitialized;
            InitializeComponent();
        }

        void MainWindow_SourceInitialized(object sender, EventArgs e)
        {
            this.HideWindowIcon();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Dialog dlg = new Dialog();
            
            dlg.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;


namespace CHashWPFEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
           
        }

        private void Menu_Save_click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {  
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void Menu_Open_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {

                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }

        }

       

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyboardDevice.Modifiers == ModifierKeys.Control) &&
             (e.Key == Key.O))
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == true)
                {
                    //textBox.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void Menu_Close_Click(object sender, RoutedEventArgs e)
        {
            glowneOkno.Close();
        }

      
        private void Menu_SearchReplace_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow searchReplaceWindow = new SearchWindow();
            searchReplaceWindow.Show();
        }

        private void Menu_Help_OProgr_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Prosty edytor Tekstowy", "O Programie ...");
        }

        private void glowneOkno_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

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
using System.Windows.Shapes;

namespace CHashWPFEditor
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            Window window_egz = new Window();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    window_egz = window;         
                }
            }


            MyRegex reg = new MyRegex();
            reg.setString((window_egz as MainWindow).textBox.Text);
                       
            reg.Zamien(textSearch.Text, textReplace.Text);
            

            (window_egz as MainWindow).textBox.Text = reg.getString(); 

        }
    }
}

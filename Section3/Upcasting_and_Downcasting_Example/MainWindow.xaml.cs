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

namespace Upcasting_and_Downcasting_Example
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello Wrold!");

            //sender. has no members, but we can downcast it
            //to a button to get access to all the button properties

            //unsafe method
            var button = (Button) sender;

            //Safer method, where we check to see if button1 has been downcasted succesfully 
            var button1 = sender as Button;

            if (button1 != null)
            {
                MessageBox.Show(button1.ActualHeight.ToString());
            }

        }
    }
}

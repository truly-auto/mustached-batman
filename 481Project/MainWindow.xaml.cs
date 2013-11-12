using System;
using System.Collections.Generic;
using System.Linq;
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

namespace _481Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //call the login procedure
            login();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            tabControl1.Items.Add("New Team");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void expander1_Expanded(object sender, RoutedEventArgs e)
        {

        }

        private void expander2_Expanded(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {            
            this.tabControl1.Items.Add(textBox1.Text);
        }

        /// <summary>
        /// User must login before they can do anything
        /// </summary>
        private void login()
        {
            LogInWindow loginWindow = new LogInWindow();
            bool? success = loginWindow.ShowDialog();

            //If the login fails then the app should close immediately, without doing anything else
            if (success == null || success == false)
                Application.Current.Shutdown();

            //else return as everything is ok
            return;
        }
    }
}

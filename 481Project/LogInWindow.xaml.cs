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
using System.Windows.Shapes;

namespace _481Project
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
         //   if (textBox1.Text == "admin" && passwordBox1.Password == "admin")
           // {
                DialogResult = true;
           // }
            //else 
            //{
             //   string s = "Incorrect password and/or email.";
              //  textBlock1.Text = s;
               // textBlock1.Foreground = Brushes.Red;
            //}
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
                accountCreationFlag.Foreground = Brushes.Green;
                accountCreationFlag.Content = "A verification email has been sent";

        }
    }
}

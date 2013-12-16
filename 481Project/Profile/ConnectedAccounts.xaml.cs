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

namespace _481Project.Profile
{
    /// <summary>
    /// Interaction logic for ConnectedAccounts.xaml
    /// </summary>
    public partial class ConnectedAccounts : Window
    {
        public ConnectedAccounts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void facebookCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            facebookUsername.IsEnabled = true;
            facebookPassword.IsEnabled = true;

        }

        private void facebookCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            facebookUsername.IsEnabled = false;
            facebookPassword.IsEnabled = false;
        }

        private void twitterCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            twitterUsername.IsEnabled = true;
            twitterPassword.IsEnabled = true;

        }

        private void twitterCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            twitterUsername.IsEnabled = false;
            twitterPassword.IsEnabled = false;
        }

        private void googleCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            googleUsername.IsEnabled = true;
            googlePassword.IsEnabled = true;

        }

        private void googleCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            googleUsername.IsEnabled = false;
            googlePassword.IsEnabled = false;
        }


    }
}

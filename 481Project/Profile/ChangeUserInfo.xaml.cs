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
    /// Interaction logic for ChangeUserInfo.xaml
    /// </summary>
    public partial class ChangeUserInfo : Window
    {
        public ChangeUserInfo()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "Saved";
        }
    }
}

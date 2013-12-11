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
    /// Interaction logic for Tab.xaml
    /// </summary>
    public partial class Tab : UserControl
    {
        public Tab()
        {
            InitializeComponent();
        }

        private void stats1_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void grid2_MouseEnter(object sender, MouseEventArgs e)
        {
            teamInformation.Visibility = Visibility.Visible;
        }

        private void grid2_MouseLeave(object sender, MouseEventArgs e)
        {
            teamInformation.Visibility = Visibility.Hidden;
        }
    }
}

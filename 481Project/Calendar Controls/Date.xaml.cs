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
using _481Project.Calendar_Controls;

namespace _481Project
{
    /// <summary>
    /// Interaction logic for Date.xaml
    /// </summary>
    public partial class Date : UserControl
    {
        public Date()
        {
            InitializeComponent();
        }

        private void border1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Use this to open up our modal window.
            var EditWindow = new EditCalendarWindow();
            EditWindow.ShowDialog();
        }

    }
}

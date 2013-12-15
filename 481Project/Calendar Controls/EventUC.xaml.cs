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

namespace _481Project.Calendar_Controls
{
    /// <summary>
    /// Interaction logic for EventUC.xaml
    /// </summary>
    public partial class EventUC : UserControl
    {
        private EditCalendarWindow edit;

        public EventUC(EditCalendarWindow parent)
        {
            InitializeComponent();
            edit = parent;
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            edit.button4.IsEnabled = true;
        }
    }
}

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
    /// Interaction logic for CustomCalendar.xaml
    /// </summary>
    public partial class CustomCalendar : UserControl
    {
        public CustomCalendar()
        {
            InitializeComponent();
            weekDay1.Day.Content = "Sunday";
            weekDay2.Day.Content = "Monday";
            weekDay3.Day.Content = "Tuesday";
            weekDay4.Day.Content = "Wednesday";
            weekDay5.Day.Content = "Thursday";
            weekDay6.Day.Content = "Friday";
            weekDay7.Day.Content = "Saturday";
        }
    }
}

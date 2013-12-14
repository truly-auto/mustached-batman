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
            date1.Day.Text = "1";
            date2.Day.Text = "2";
            date3.Day.Text = "3";
            date4.Day.Text = "4";
            date5.Day.Text = "5";
            date6.Day.Text = "6";
            date7.Day.Text = "7";
            date8.Day.Text = "8";
            date9.Day.Text = "9";
            date10.Day.Text = "10";
            date11.Day.Text = "11";
            date12.Day.Text = "12";
            date13.Day.Text = "13";
            date14.Day.Text = "14";
            date15.Day.Text = "15";
            date16.Day.Text = "16";
            date17.Day.Text = "17";
            date18.Day.Text = "18";
            date19.Day.Text = "19";
            date20.Day.Text = "20";
            date21.Day.Text = "21";
            date22.Day.Text = "22";
            date23.Day.Text = "23";
            date24.Day.Text = "24";
            date25.Day.Text = "25";
            date26.Day.Text = "26";
            date27.Day.Text = "27";
            date28.Day.Text = "28";
            date29.Day.Text = "29";
            date30.Day.Text = "30";
        }
    }
}

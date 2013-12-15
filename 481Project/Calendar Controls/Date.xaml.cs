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

        public List<string> Events = new List<string>();
        public List<string> Available = new List<string>();
        public List<string> Unavailable = new List <string>();


        public Date()
        {
            InitializeComponent();
        }

        private void UpdateDayColour(List<String> s) 
        {
            var bc = new BrushConverter();             
            foreach (string str in s) 
            {
                if (str.Contains("Game"))
                {

                    this.Background = (Brush)bc.ConvertFrom("#FF40CC00");
                }
                else if (str.Contains("Practice")) 
                {

                }
            }
        }

        private void border1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Use this to open up our modal window.
            String text = this.Day.Text;
            int num = Convert.ToInt32(text);
            text = getDay(num);
            var EditWindow = new EditCalendarWindow(this, text);
            EditWindow.ShowDialog();
 
        }

        private void border1_MouseEnter(object sender, MouseEventArgs e)
        {
            this.border1.BorderBrush = Brushes.Black;
        }

        private void border1_MouseLeave(object sender, MouseEventArgs e)
        {
            this.border1.BorderBrush = Brushes.Silver;
        }

        private string getDay(int day) 
        {
            string fulldate = "November ";
            //Quick check of day to make correct date string
            if (day == 1) { fulldate += day.ToString() + "st"; }
            else if (day == 2) { fulldate += day.ToString() + "nd"; }
            else if (day == 3) { fulldate += day.ToString() + "rd"; }
            else if (day == 21) { fulldate += day.ToString() + "st"; }
            else if (day == 22) { fulldate += day.ToString() + "nd"; }
            else if (day == 23) { fulldate += day.ToString() + "rd"; }
            else if (day == 31) { fulldate += day.ToString() + "st"; }
            else { fulldate += day.ToString() + "th"; }
            return fulldate;
        }

    }
}

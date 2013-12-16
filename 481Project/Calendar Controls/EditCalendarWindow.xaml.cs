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

namespace _481Project.Calendar_Controls
{
    /// <summary>
    /// Interaction logic for EditCalendarWindow.xaml
    /// </summary>
    public partial class EditCalendarWindow : Window
    {
        private int CurrentDay = System.DateTime.Now.Day;
        private Date owner;

        public EditCalendarWindow(Date d,String text)
        {
            InitializeComponent();
            
            try 
            {
                int day = Convert.ToInt32(owner.Day.Text);
                if (CurrentDay > day)
                {
                    TimeComboBox.IsEnabled = false;
                    locationTextBox.IsEnabled = false;
                    descTextBox.IsEnabled = false;
                    button2.IsEnabled = false;
                    button4.IsEnabled = false;
                    radioButton1.IsEnabled = false;
                    radioButton2.IsEnabled = false;
                    radioButton3.IsEnabled = false;
                }
            }
            catch (NullReferenceException e) { }

            owner = d;
            this.label1.Content = text;
            PopulateSP();
            
        }

        private void PopulateSP()
        {
            foreach (EventUC s in owner.Events) 
            {
                listBox1.Items.Add(s.ToString());
            }
            foreach (string s in owner.Available)
            {
                EventUC evt = new EventUC(this);
                evt.textBlock1.Text = s;
                evt.BorderBrush = Brushes.Black;
                listBox1.Items.Add(evt);
            }
            foreach (string s in owner.Unavailable)
            {
                EventUC evt = new EventUC(this);
                evt.textBlock1.Text = s;
                evt.BorderBrush = Brushes.Black;
                stackPanel2.Children.Add(evt);
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            owner.UpdateDayColour();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string einfo = "";
            if (TimeComboBox.Text != "" && locationTextBox.Text != "")
            {
                foreach (EventUC s in owner.Events) 
                {
                    if (s.info.Date.Contains(TimeComboBox.Text)) 
                    {
                        string error = "Event already scheduled for that time";
                        textBlock1.Text = error;
                        textBlock1.Foreground = Brushes.Red;
                        return;
                    }
                }

                if (radioButton1.IsChecked == true) 
                {                    
                    einfo +="Game";

                }
                else if (radioButton2.IsChecked == true)
                {
                    einfo += "Practice";

                }
                else { einfo += "Event"; }

                Event E = new Event(einfo, TimeComboBox.Text, locationTextBox.Text, descTextBox.Text);
                EventUC evt = new EventUC(this);
                evt.info = E;

                einfo += TimeComboBox.Text + " at " + locationTextBox.Text + ". " + descTextBox.Text;

                evt.textBlock1.Text = evt.ToString();
                
                evt.BorderBrush = Brushes.Black;
                owner.Events.Add(evt);
                listBox1.Items.Add(evt.ToString());
                ClearText();
            }
            else 
            {
                string error = "";
                if (TimeComboBox.Text == "") 
                {
                    error = "Please select a time for the event.";                  
                    textBlock1.Text = error;
                    textBlock1.Foreground = Brushes.Red;
                }
                if (locationTextBox.Text == "")
                {
                    error = "Please enter a location for the event.";
                    textBlock1.Text = error;
                    textBlock1.Foreground = Brushes.Red;
                }
            }
        }

        private void ClearText() 
        {
            TimeComboBox.Text = "";
            descTextBox.Text = "";
            locationTextBox.Text = "";
            textBlock1.Text = "";
            textBlock2.Text = "";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

            Object a = listBox1.SelectedItem;
            EventUC b = null;
            foreach (EventUC p in owner.Events)
            {
                if (p.ToString() == a.ToString()) { b = p; }
            }
          
            string s = "You removed " + a.ToString();
            this.textBlock2.Text = s;
            this.textBlock2.Foreground = Brushes.Red;

            owner.Events.Remove(b);
            listBox1.Items.Remove(a);

            button4.IsEnabled = false;
            ShareButton.IsEnabled = false;
           
        }

        private void ShareButton_Click(object sender, RoutedEventArgs e)
        {
            Object a = listBox1.SelectedItem;
            string s = a.ToString() + " has been Shared!";
            this.textBlock2.Text = s;
            this.textBlock2.Foreground = Brushes.Green;

        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox1.HasItems)
            {
                ShareButton.IsEnabled = true;
                button4.IsEnabled = true;
            }


        }        

    }
}

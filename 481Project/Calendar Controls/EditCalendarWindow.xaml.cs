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
        private int CurrentDay = 16;
        private Date owner;

        public EditCalendarWindow(Date d,String text)
        {
            InitializeComponent();
            //Disables interaction if day from the past.
            if (CurrentDay < 16)
            {
                comboBox1.IsEnabled = false;
                textBox1.IsEnabled = false;
                textBox2.IsEnabled = false;
                button2.IsEnabled = false;
                button4.IsEnabled = false;
                radioButton1.IsEnabled = false;
                radioButton2.IsEnabled = false;
                radioButton3.IsEnabled = false;
            }

            owner = d;
            this.label1.Content = text;
            PopulateSP();
            
        }

        private void PopulateSP()
        {
            foreach (string s in owner.Events) 
            {
                EventUC evt = new EventUC(this);
                evt.textBlock1.Text = s;
                evt.BorderBrush = Brushes.Black;
                stackPanel.Children.Add(evt);
            }
            foreach (string s in owner.Available)
            {
                EventUC evt = new EventUC(this);
                evt.textBlock1.Text = s;
                evt.BorderBrush = Brushes.Black;
                stackPanel1.Children.Add(evt);
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
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string einfo = "";
            if (comboBox1.Text != "" && textBox1.Text != "")
            {
                Event E = new Event(comboBox1.Text, textBox1.Text, textBox2.Text);
                EventUC evt = new EventUC(this);
                if (radioButton1.IsChecked == true) 
                {                    
                    einfo +="Game: ";

                }
                else if (radioButton2.IsChecked == true)
                {
                    einfo += "Practice: ";
                }
                else {einfo += "Event: ";}
                einfo += comboBox1.Text + " at " + textBox1.Text + ". " + textBox2.Text;
                evt.textBlock1.Text = einfo;
                evt.BorderBrush = Brushes.Black;
                owner.Events.Add(einfo);
                stackPanel.Children.Add(evt);
                ClearText();
            }
            else 
            {
                string error = "";
                if (comboBox1.Text == "") 
                {
                    error = "Please select a time for the event.";                  
                    textBlock1.Text = error;
                    textBlock1.Foreground = Brushes.Red;
                }
                if (textBox1.Text == "")
                {
                    error = "Please enter a location for the event.";
                    textBlock1.Text = error;
                    textBlock1.Foreground = Brushes.Red;
                }
            }
        }

        private void ClearText() 
        {
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            textBlock1.Text = "";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            List<EventUC> removeEvent = new List<EventUC>();
            foreach (EventUC evnt in stackPanel.Children) 
            {
                if (evnt.checkBox1.IsChecked == true) 
                {
                    removeEvent.Add(evnt); 
                }
            }
            foreach (EventUC evnt in removeEvent)
            {
                stackPanel.Children.Remove(evnt);
            }

            button4.IsEnabled = false;
           
        }        

    }
}

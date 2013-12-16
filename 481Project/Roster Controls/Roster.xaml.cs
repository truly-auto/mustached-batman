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
using _481Project.Roster_Controls;

namespace _481Project
{
    /// <summary>
    /// Interaction logic for Roster.xaml
    /// </summary>
    public partial class Roster : UserControl
    {
        public Roster()
        {
            InitializeComponent();
        }
/* Used for basic demonstration
        private void add_Click(object sender, RoutedEventArgs e)
        {

            string c = this.stackPanel.Children.Count.ToString();                 //Gets number of elements from stackPanel
            TextBlock b = new TextBlock();                                              //TODO: Make acutal player elements 
            b.Text = "Fake Player "+c;                                                  
            this.stackPanel.Children.Add(b);
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            int c = this.stackPanel.Children.Count;                               
            if (c > 0) { this.stackPanel.Children.RemoveAt(c-1); }                //Removes last added elements
        }
*/

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //var EditWindow = new RosterAddWindow();
            //var p = new Point();
            //EditWindow.Top = this.PointToScreen(p).Y;
            //EditWindow.Left = this.PointToScreen(p).X;
            //EditWindow.ShowDialog();

            string message = "";
            if (!String.IsNullOrEmpty(emailTextbox.Text))
            {
                message = "Player has been invited to your team";
                playerAddedLabel.Foreground = System.Windows.Media.Brushes.SeaGreen;// "#FF00775F";
            }
            else
            {
                message = "Please enter an email address to add a player";
                playerAddedLabel.Foreground = System.Windows.Media.Brushes.Red;
            }
            playerAddedLabel.Content = message;
            playerAddedLabel.Visibility = System.Windows.Visibility.Visible;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var EditWindow = new RosterRemoveWindow();
            var p = new Point();
            EditWindow.Top = this.PointToScreen(p).Y;
            EditWindow.Left = this.PointToScreen(p).X;
            EditWindow.ShowDialog();
        }

    }
}

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
    /// Interaction logic for Stats.xaml
    /// </summary>
    public partial class Stats : UserControl
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(StatDatePicker.Text) || String.IsNullOrEmpty(opponentTextbox.Text) || String.IsNullOrEmpty(ScoreTextbox.Text))
            {
                return;
            }
            string c = this.stackPanel.Children.Count.ToString();                 //Gets number of elements from stackPanel
            TextBlock b = new TextBlock();                                              //TODO: Make acutal player elements 
            b.Text = StatDatePicker.SelectedDate.Value.Date.ToString("dd/MM/yyyy") + "  " + opponentTextbox.Text + " " + ScoreTextbox.Text;
            this.stackPanel.Children.Add(b);

            StatDatePicker.Text = opponentTextbox.Text = ScoreTextbox.Text = "";
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            int c = this.stackPanel.Children.Count;
            if (c > 0) { this.stackPanel.Children.RemoveAt(c - 1); }                //Removes last added elements

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ScoreTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            CheckIsNumeric(e);
        }

        private void CheckIsNumeric(TextCompositionEventArgs e)
        {
            int result;

            if (!(int.TryParse(e.Text, out result) || e.Text == "/"))
            {
                e.Handled = true;
            }
        }
    }
}

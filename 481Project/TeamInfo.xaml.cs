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
    /// Interaction logic for TeamInfo.xaml
    /// </summary>
    public partial class TeamInfo : Window
    {
        private Tab owner;
        public TeamInfo(Tab o)
        {
            owner = o;
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                owner.bannerTitle.Content = this.textBox1.Text;
                owner.label1.Content = this.textBox2.Text;
                owner.Description = this.textBox4.Text;
                owner.image1 = this.image1;
                this.textBlock1.Text = "Team information saved";
                owner.ti.Header = this.textBox1.Text;
            }catch(NullReferenceException ex){}

            
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.textBlock1.Text = "";
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.textBlock1.Text = "";
        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.textBlock1.Text = "";
        }
    }
}

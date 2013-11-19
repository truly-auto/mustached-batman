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
    /// Interaction logic for CreateTeam.xaml
    /// </summary>
    public partial class CreateTeam : UserControl
    {
        public CreateTeam()
        {
            InitializeComponent();

        }


        private void teamCreateButton_Click(object sender, RoutedEventArgs e)
        {

            UIElement parent = App.Current.MainWindow;
            UIElement tc = App.Current.TryFindResource(t);
 
            TabItem ti = new TabItem();
            ti.Header = this.textBox1.Text;
            ti.Content = new Tab();
   
            //parent.tabControl1.Items.Insert(tabControl1.Items.Count - 1, ti);


            //After a new team is created, clear the name textbox
            this.textBox1.Text = parent.ToString();
        }

        public DependencyObject userControlRefernce { get; set; }
    }
}

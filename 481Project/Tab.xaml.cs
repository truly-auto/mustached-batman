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
    /// Interaction logic for Tab.xaml
    /// </summary>
    public partial class Tab : UserControl
    {

        public string Description;
        public TabItem ti;

        public Tab() 
        {
            InitializeComponent();
        }

        public Tab(TabItem t)
        {
            ti = t;
            InitializeComponent();
        }

        private void stats1_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void teamInformation_Click(object sender, RoutedEventArgs e)
        {
            TeamInfo ti = new TeamInfo(this);
            var p = new Point();
            ti.Top = this.grid2.PointToScreen(p).Y;
            ti.Left = this.grid2.PointToScreen(p).X;
            ti.textBox1.Text = (string)this.bannerTitle.Content;
            ti.textBox2.Text = (string)this.label1.Content;
            ti.textBox4.Text = Description;
            ti.image1 = this.image1;
            ti.ShowDialog();
        }

    }
}

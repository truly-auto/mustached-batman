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

using _481Project.Profile;
using _481Project.Help;

namespace _481Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //call the login procedure
            login();

            //Simulate somethings
                //Pending Team Invites
                pendingTeams.Items.Add("TeamOne");
                pendingTeams.Items.Add("TeamTwo");
                pendingTeams.Items.Add("TeamThree");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            tabControl1.Items.Add("New Team");
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            //Hide the main window and run the login process again
            //If the login succeeds then show the window again
            this.Hide();
            login();
            this.Show();
        }

        private void expander1_Expanded(object sender, RoutedEventArgs e)
        {

        }

        private void expander2_Expanded(object sender, RoutedEventArgs e)
        {

        }

        private void teamCreateButton_Click(object sender, RoutedEventArgs e)
        {
            TabItem ti = new TabItem();
            Tab t = new Tab(ti);
            ti.Header = this.textBox1.Text;
            t.bannerTitle.Content = this.textBox1.Text;
            ti.Content  = t;
            t.label1.Content = this.textBox2.Text;
            
            this.tabControl1.Items.Insert(tabControl1.Items.Count - 1, ti);
            
            //After a new team is created, clear the name textbox
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        /// <summary>
        /// User must login before they can do anything
        /// </summary>
        private void login()
        {
            LogInWindow loginWindow = new LogInWindow();
            bool? success = loginWindow.ShowDialog();

            //If the login fails then the app should close immediately, without doing anything else
            if (success == null || success == false)
                Application.Current.Shutdown();

            //else return as everything is ok
            return;
        }

        private void tabControl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //Change password
            ChangePassword changePass = new ChangePassword();
            var p = new Point();
            changePass.Top = this.PointToScreen(p).Y;
            changePass.Left = this.PointToScreen(p).X;
            changePass.ShowDialog();
        }

        private void tabItem1_Loaded(object sender, RoutedEventArgs e)
        {
            tab1.bannerTitle.Content = this.tabItem1.Header; // Set premade tab Banner
            UserControl player = new Images.examplePlayer();
            tab1.roster1.stackPanel.Children.Add(player);

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            //Change info
            ChangeUserInfo changeUserInfo = new ChangeUserInfo();
            var p = new Point();
            changeUserInfo.Top = this.PointToScreen(p).Y;
            changeUserInfo.Left = this.PointToScreen(p).X;
            changeUserInfo.ShowDialog();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            //Connected accounts
            ConnectedAccounts connectedAccounts = new ConnectedAccounts();
            var p = new Point();
            connectedAccounts.Top = this.PointToScreen(p).Y;
            connectedAccounts.Left = this.PointToScreen(p).X;
            connectedAccounts.ShowDialog();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            //Alert settings
            NotificationSettings notifySettings = new NotificationSettings();
            var p = new Point();
            notifySettings.Top = this.PointToScreen(p).Y;
            notifySettings.Left = this.PointToScreen(p).X;
            notifySettings.ShowDialog();
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }

        private void pendingTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (pendingTeams.HasItems)
            {
                acceptTeam.IsEnabled = true;
                ignoreTeam.IsEnabled = true;
            }
        }

        private void acceptTeam_Click(object sender, RoutedEventArgs e)
        {
            //add to tabs

        }

        private void ignoreTeam_Click(object sender, RoutedEventArgs e)
        {
            //remove from list
            Object a = pendingTeams.SelectedItem;

            string s = "You removed " + a.ToString();
            this.textBlock1.Text = s;
            this.textBlock1.Foreground = Brushes.Red;

            pendingTeams.Items.Remove(a);
            acceptTeam.IsEnabled = false;
            ignoreTeam.IsEnabled = false;
        }

     }
}

﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //call the login procedure
            login();
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
            Tab t = new Tab();
            ti.Header = this.textBox1.Text;
            t.bannerTitle.Content = this.textBox1.Text;
            ti.Content  = t;
            
            this.tabControl1.Items.Insert(tabControl1.Items.Count - 1, ti);
            
            //After a new team is created, clear the name textbox
            this.textBox1.Text = "";
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

        }

        private void tabItem1_Loaded(object sender, RoutedEventArgs e)
        {
            tab1.bannerTitle.Content = this.tabItem1.Header; // Set premade tab Banner
            UserControl player = new Images.examplePlayer();
            tab1.roster1.stackPanel.Children.Add(player);

        }

     }
}

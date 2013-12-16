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

namespace _481Project.Message_Control
{
    /// <summary>
    /// Interaction logic for Messages.xaml
    /// </summary>
    public partial class Messages : UserControl
    {
        bool warnOnce = false;

        public Messages()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            clearMessage();
        }

        private void clearMessage()
        {
            //Clear all fields
            EmailCheckbox.IsChecked = SMSCheckbox.IsChecked = false;

            ToText.Text = SubjectText.Text = BodyText.Text = "";
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            if (ToText.Text.Length == 0)
            {
                MessageBox.Show("You must select recipients for this message");
                return;
            }

            string message = "";
            if (BodyText.Text.Length > 320 && SMSCheckbox.IsChecked == true)
            {
                message += "Your message exceeds the 320 character limit for SMS Text messages, an SMS message cannot be sent.\n\n";
            }
            else if (SMSCheckbox.IsChecked == true)
            {
                message += "Your SMS message has been sent.\n\n";
            }

            if (EmailCheckbox.IsChecked == true)
            {
                message += "Your email has been sent.";
            }

            if (EmailCheckbox.IsChecked.Value == false && SMSCheckbox.IsChecked.Value == false)
            {
                message += "Your message has been sent through the internal messaging system";
            }

            MessageBox.Show(message);

            warnOnce = false;
            clearMessage();
        }

        private void BodyText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SMSCheckbox.IsChecked == true)
            {
                if (BodyText.Text.Length > 320 && !warnOnce)
                {
                    MessageBox.Show("SMS messages can be a maximum of 320 characters long. This message cannot be sent as a text, but can still be sent as an email.");
                    warnOnce = true;
                }
            }
        }

        private void EmailCheckbox_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

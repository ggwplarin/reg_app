using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControlLibrary1
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        bool[] oks = new bool[8] { false, false, false, false, false, false, false, false };
        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void LoginBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var temp = ((TextBox)sender);
            if (!Char.IsDigit(temp.Text.FirstOrDefault()) && temp.Text.All(c => Char.IsLetterOrDigit(c))) { temp.Foreground = new SolidColorBrush(Colors.Black); oks[0] = true; }
            else { temp.Foreground = new SolidColorBrush(Colors.Red); oks[0] = false; }
        }

        private void PasswBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var temp = (PasswordBox)sender;
            if (temp.Password.Any(c => Char.IsDigit(c)) && temp.Password.Length >= 8 && temp.Password.Intersect("!@#$%&?{}*-_".ToCharArray()).Count() > 0)
            {
                temp.Foreground = new SolidColorBrush(Colors.Black); oks[1] = true;
            }
            else { temp.Foreground = new SolidColorBrush(Colors.Red); oks[1] = false; }
        }

        private void RepeatPasswBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (RepeatPasswBox.Password == PasswBox.Password) { RepeatPasswBox.Foreground = new SolidColorBrush(Colors.Black); oks[2] = true; }
            else { RepeatPasswBox.Foreground = new SolidColorBrush(Colors.Red); oks[2] = false; }
        }

        private void SectetQBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            oks[3] = true;
        }

        private void SectetABox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (((TextBox)sender).Text.Length > 0) { oks[4] = true; }
            else { oks[4] = false; }
        }

        private void EMailBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(EMailBox.Text))
            {
                try
                {
                    var gg = new System.Net.Mail.MailAddress(EMailBox.Text);
                    EMailBox.Foreground = new SolidColorBrush(Colors.Black); oks[5] = true;
                }
                catch (FormatException)
                {
                    EMailBox.Foreground = new SolidColorBrush(Colors.Red); oks[5] = false;
                }
            }
        }

        private void PhoneBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PhoneBox.IsMaskFull) { PhoneBox.Foreground = new SolidColorBrush(Colors.Black); oks[6] = true; }
            else { PhoneBox.Foreground = new SolidColorBrush(Colors.Red); oks[6] = false; }
        }

        private void PassportBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PassportBox.IsMaskFull) { PassportBox.Foreground = new SolidColorBrush(Colors.Black); oks[7] = true; }
            else { PassportBox.Foreground = new SolidColorBrush(Colors.Red); oks[7] = false; }
        }


    }
}

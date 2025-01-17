using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MainWpfApp
{
    /// <summary>
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            Authorization_Button.Click += Authorization_Button_Click;
        }

        private void Authorization_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Password_TextBox.Text == string.Empty || Login_TextBox.Text == string.Empty)
            {
                MessageBox.Show("Поле Логин и (или) Пароль не могут быть пустыми!");
                return;
            }
            else {
                if (Password_TextBox.Text.Contains(' ') || Login_TextBox.Text.Contains(' '))
                {
                    MessageBox.Show("В полях Логин и (или) Пароль не могут быть пробелы!");
                    return;
                }
            }


        }
    }
}

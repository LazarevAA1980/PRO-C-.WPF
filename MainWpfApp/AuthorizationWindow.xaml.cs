using Authorization;
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
        private UserStorage userStorage { get; } = new UserStorage();
        public AuthorizationWindow()
        {
            InitializeComponent();
            Authorization_Button.Click += Authorization_Button_Click;
            Loaded += AuthorizationWindow_Loaded;
        }

        private void AuthorizationWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var lastSignInUser = userStorage.GetLastSignInUser();

            if (lastSignInUser != null)
            {
                Login_TextBox.Text = lastSignInUser.Login;
            }
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

            var checkUser = userStorage.GetExistingUser(Login_TextBox.Text);

            if (checkUser != null)
            {
                if (checkUser.Password == Password_TextBox.Text)
                {
                    if (checkUser.IsSignIn == true)
                    {
                        MessageBox.Show("Пользователь уже был авторизован!");
                        return;
                    }

                    if (Remember_CheckBox.IsChecked == true)
                    {
                        checkUser.LastSignIn = true;
                    }
                    else
                    {
                        checkUser.LastSignIn = false;
                    }

                    userStorage.SignInUser(checkUser);
                    MessageBox.Show("Пользователь авторизован!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Некорректный пароль!");
                    Password_TextBox.Text = string.Empty;
                    Login_TextBox.Text = string.Empty;
                    Remember_CheckBox.IsChecked = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Пользователя не существует! Зарегистрируйтесь!");
                Password_TextBox.Text = string.Empty;
                Login_TextBox.Text = string.Empty;
                Remember_CheckBox.IsChecked = false;
                return;
            }
        }
    }
}

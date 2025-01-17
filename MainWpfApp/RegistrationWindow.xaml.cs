using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Authorization;

namespace MainWpfApp
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private UserStorage userStorage { get; } = new UserStorage();
        public RegistrationWindow()
        {
            InitializeComponent();
            Registration_Button.Click += Registration_Button_Click;
        }

        private void Registration_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Password_TextBox.Text == string.Empty || Login_TextBox.Text == string.Empty || ConfirmPassword_TextBox.Text == string.Empty)
            {
                MessageBox.Show("Поле Логин и (или) Пароль не могут быть пустыми!");
                return;
            }
            else
            {
                if (Password_TextBox.Text.Contains(' ') || Login_TextBox.Text.Contains(' ') || ConfirmPassword_TextBox.Text.Contains(' '))
                {
                    MessageBox.Show("В полях Логин и (или) Пароль не могут быть пробелы!");
                    return;
                }
            }

            string inputLogin = Login_TextBox.Text;
            string inputPassword = Password_TextBox.Text;
            string confirmPassword = ConfirmPassword_TextBox.Text;

            if (inputPassword != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают! Проверьте введенные данные!");
                return;
            }

            var registeredUser = new User();// inputLogin, inputPassword);
            registeredUser.Login = inputLogin;
            registeredUser.Password = inputPassword;
            registeredUser.IsSignIn = true;
            userStorage.Add(registeredUser);
            MessageBox.Show("Аккаунт успешно зарегистрирован!");
            Close();

        }
    }
}

//namespace Authorization
//{
//    public static class FileProvider
//    {
//        public static void Save(object data, string fileName)
//        { 
//        string serializedData = JsonSerializer.Serialize(data);

//            if (File.Exists(fileName))
//            {
//                File.WriteAllText(fileName, serializedData);
//            }
//            else 
//            {
//                File.Create(fileName).Close();
//                File.WriteAllText(fileName, serializedData);
//        }
//    }

//}

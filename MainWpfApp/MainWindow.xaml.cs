using Authorization;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private UserStorage userStorage {  get; } = new UserStorage();
        public MainWindow()
        {
            InitializeComponent();
            SignIn_Button.Click += SignIn_Button_Click;
            Registration_Button.Click += Registration_Button_Click;
            SignOut_Button.Click += SignOut_Button_Click;
            Loaded += MainWindow_Loaded;

            LoginName_Label.Visibility = Visibility.Visible;
            SignIn_Button.Visibility = Visibility.Collapsed;
            //SignIn_Button.Visibility = Visibility.Hidden;
            SignOut_Button.Visibility = Visibility.Visible;
            Registration_Button.Visibility = Visibility.Visible;
            PersonalDesk_Label.Visibility = Visibility.Visible;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var signInUser = userStorage.GetSignInUser();
            if (signInUser != null)
            {
                AuthorizeUser(signInUser);
            }
            else
            {
                UnAuthorizeUser();
            }
        }

        private void SignOut_Button_Click(object sender, RoutedEventArgs e)
        {
            userStorage.SignOut();
            LoginName_Label.Visibility = Visibility.Collapsed;
            SignIn_Button.Visibility = Visibility.Visible;
            SignOut_Button.Visibility = Visibility.Collapsed;
            Registration_Button.Visibility = Visibility.Visible;
            PersonalDesk_Label.Visibility = Visibility.Collapsed;
        }

        private void Registration_Button_Click(object sender, RoutedEventArgs e)
        {
            var registration = new RegistrationWindow();
            registration.ShowDialog();

            CheckUser();
        }

        private void CheckUser()
        {
            var user = userStorage.GetSignInUser();

            if (user != null)
            {

                AuthorizeUser(user);
            }
            else
            {

                UnAuthorizeUser();
            }
        }

        private void SignIn_Button_Click(object sender, RoutedEventArgs e)
        {
            var authorization = new AuthorizationWindow();
            authorization.ShowDialog();
            CheckUser();
        }

        private void UnAuthorizeUser()
        {
            LoginName_Label.Visibility = Visibility.Collapsed;
            SignIn_Button.Visibility = Visibility.Visible;
            SignOut_Button.Visibility = Visibility.Collapsed;
            Registration_Button.Visibility = Visibility.Visible;
            PersonalDesk_Label.Visibility = Visibility.Collapsed    ;
        }

        private void AuthorizeUser(User user)
        {
            user.LastSignIn = true;
            LoginName_Label.Content = user.Login;
            LoginName_Label.Visibility = Visibility.Visible;
            SignIn_Button.Visibility = Visibility.Collapsed;
            SignOut_Button.Visibility = Visibility.Visible;
            Registration_Button.Visibility = Visibility.Collapsed;
            PersonalDesk_Label.Visibility = Visibility.Visible;
        }
    }
}
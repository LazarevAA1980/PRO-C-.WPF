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

namespace MainWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SignIn_Button.Click += SignIn_Button_Click;
            Registration_Button.Click += Registration_Button_Click;
        }

        private void Registration_Button_Click(object sender, RoutedEventArgs e)
        {
            var registration = new RegistrationWindow();
            registration.Show();
        }

        private void SignIn_Button_Click(object sender, RoutedEventArgs e)
        {
            var authorization = new AuthorizationWindow();
            authorization.Show();
        }
    }
}
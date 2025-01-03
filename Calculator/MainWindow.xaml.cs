using System.Windows;
using System.Windows.Controls;
using System.Windows.Resources;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string calculateString = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
            digit1Button.Click += DigitButton_Click;
            digit2Button.Click += DigitButton_Click;
            digit3Button.Click += DigitButton_Click;
            digit4Button.Click += DigitButton_Click;
            digit5Button.Click += DigitButton_Click;
            digit6Button.Click += DigitButton_Click;
            digit7Button.Click += DigitButton_Click;
            digit8Button.Click += DigitButton_Click;
            digit9Button.Click += DigitButton_Click;
            digit0Button.Click += DigitButton_Click;
            addOperationButton.Click += OperationButtons_Click;
            subOperationButton.Click += OperationButtons_Click;
            multOperationButton.Click += OperationButtons_Click;
            divOperationButton.Click += OperationButtons_Click;
            equalOperationButton.Click += EqualOperationButton_Click;
            resetOperationButton.Click += ResetOperationButton_Click;
        }

        private void ResetOperationButton_Click(object sender, RoutedEventArgs e)
        {
            calculateString = string.Empty;
            answerValueLabel.Content = calculateString;
        }

        private void EqualOperationButton_Click(object sender, RoutedEventArgs e)
        {
                var values = calculateString.Split(' ');
            switch (values[1])
            {
                case "+": calculateString += $" = {Int32.Parse(values[0]) + Int32.Parse(values[2])}"; break;
                case "-": calculateString += $" = {Int32.Parse(values[0]) - Int32.Parse(values[2])}"; break;
                case "x": calculateString += $" = {Int32.Parse(values[0]) * Int32.Parse(values[2])}"; break;
                case "/": calculateString += $" = {Int32.Parse(values[0]) / Int32.Parse(values[2])}"; break;
            }

            answerValueLabel.Content = calculateString;
            calculateString = string.Empty;
        }

        private void OperationButtons_Click(object sender, RoutedEventArgs e)
        {
            if (calculateString != string.Empty)
            {
                var operationButton = (Button)e.Source;
                calculateString += " " + operationButton.Content + " ";
            }
            answerValueLabel.Content = calculateString;
        }

        private void DigitButton_Click(object sender, RoutedEventArgs e)
        {
            var sourceButton = (Button)e.Source;
            calculateString += sourceButton.Content;//"1";
            answerValueLabel.Content = calculateString;
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void AddOne(object sender, RoutedEventArgs args) {
            int number = Convert.ToInt32(Counter.Text);
            number++;
            Counter.Text = number.ToString();
        }

        private void MinusOne(Object sender, RoutedEventArgs args) {
            int number = Convert.ToInt32(Counter.Text);
            number--;
            Counter.Text = number.ToString();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            AnswerTextBlock.Text = "Your answer will appear here";
            input1.Text = "";
            input2.Text = "";
        }

        private void ChangeAnswer(Int32 number) {
            AnswerTextBlock.Text = number.ToString();
        }

        private void Calc(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            string operation = button.Content.ToString();
            Int32 num1 = Convert.ToInt32(input1.Text);
            Int32 num2 = Convert.ToInt32(input2.Text);

            switch (operation) {
                case "+":
                    ChangeAnswer(num1 + num2);
                    break;
                case "-":
                    ChangeAnswer(num1 - num2);
                    break;
                case "*":
                    ChangeAnswer(num1 * num2);
                    break;
                case "/":
                    ChangeAnswer(num1 / num2);
                    break;
            }
        }
    }
}

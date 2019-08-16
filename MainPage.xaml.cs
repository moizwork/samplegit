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

namespace find_vovel
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

        private void T1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string check = t1.Text;
            switch (check)
            {
                case "a":
                    lb.Text = "THIS IS A VOVEL LETTER";
                    break;
                case "e":
                    lb.Text = "THIS IS A VOVEL LETTER";
                    break;
                case "i":
                    lb.Text = "THIS IS A VOVEL LETTER";
                    break;
                case "o":
                    lb.Text = "THIS IS A VOVEL LETTER";
                    break;
                case "u":
                    lb.Text = "THIS IS A VOVEL LETTER";
                    break;
                default:
                    lb.Text = "THIS IS A COMMON ALPHABET";
                    break;

            }
        }
    }
}

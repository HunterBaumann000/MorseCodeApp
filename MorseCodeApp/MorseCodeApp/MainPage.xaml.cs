using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace MorseCodeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private String morseText = "";
        private String message = "";

        void Handle_Clicked(Object sender, System.EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Dot":
                    morseText = morseText + ".";
                    break;

                case "Line":
                    morseText = morseText + "-";
                    break;

                case "Gap":
                    char englishString = Morse.MorseCoder(morseText);
                    message += englishString;
                    morseText = "";
                    EnglishT.Text = message;
                    break;

                default:
                    morseText = morseText + " ";
                    break;
            }

            MorseT.Text = morseText;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LegalDrinkingAgeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        int CurrentYear = DateTime.Today.Year;
        int BirthYear;
        int Age;
        int LegalAgeUS = 21; 

        void Handle_Clicked(Object sender, System.EventArgs e)
        {
            BirthYear = Birthday.Date.Year;
            Age = CurrentYear - BirthYear;

            if(Age >= LegalAgeUS)
            {
                Text.Text = $"Right now!";
            }
            else
            {
                Text.Text = $"You will be able to drink legally in {LegalAgeUS - Age} years!";
            }
        }
    }
}

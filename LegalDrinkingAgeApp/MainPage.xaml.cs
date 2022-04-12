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
        int LegalDrinkingAge; 

        void Handle_Clicked(Object sender, System.EventArgs e)
        {
            if(UnitedStates.IsChecked) { LegalDrinkingAge = 21; }
            else if (Iceland.IsChecked) { LegalDrinkingAge = 20; }
            else if (Spain.IsChecked) { LegalDrinkingAge = 18; }
            else if (Italy.IsChecked) { LegalDrinkingAge = 16; }

            BirthYear = Birthday.Date.Year;
            Age = CurrentYear - BirthYear;

            if(Age >= LegalDrinkingAge)
            {
                Text.Text = $"Right now!";
            }
            else
            {
                Text.Text = $"You will be able to drink legally in {LegalDrinkingAge - Age} years!";
            }
        }
    }
}

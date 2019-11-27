using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Labb3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //TODO More refactoring, DRY coding
        private void BtnEightPercentVAT(object sender, EventArgs args)
        {
            if (inputUser.Text != null)
            {
                double amount = double.Parse(inputUser.Text);
                double vat = 0.08;
                Calculate(amount, vat);
            }
            else
            {
                inputUser.Placeholder = "0 / 8% = 0, försök igen!";
                inputUser.PlaceholderColor = Color.Red;
            }
        }

        private void BtnTwelvePercentVAT(object sender, EventArgs args)
        {
            if (inputUser.Text != null)
            {
                double amount = double.Parse(inputUser.Text);
                double vat = 0.12;
                Calculate(amount, vat);
            }
            else
            {
                inputUser.Placeholder = "0 / 12% = 0, försök igen!";
                inputUser.PlaceholderColor = Color.Red;
            }
        }

        private void BtnTwentyFivePercentVAT(object sender, EventArgs args)
        {
            if (inputUser.Text != null)
            {
                double amount = double.Parse(inputUser.Text);
                double vat = 0.25;
                Calculate(amount, vat);
            }
            else
            {
                inputUser.Placeholder = "0 / 25% = 0, försök igen!";
                inputUser.PlaceholderColor = Color.Red;
            }
        }

        private void Calculate(double amount, double vat)
        {
            double VAT = amount / (1 + vat);
            double amountWithoutVAT = amount - VAT;
            inputAmount.Text = inputUser.Text + " SEK";
            vatRate.Text = (vat * 100).ToString("0") + " %";
            calculatedVAT.Text = VAT.ToString("0.00") + " SEK";
            calculatedAmount.Text = amountWithoutVAT.ToString("0.00") + " SEK";
        }
    }
}

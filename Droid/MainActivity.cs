using Android.App;
using Android.Widget;
using Android.OS;

namespace CompoundInterestCalculator.Droid
{
    [Activity(Label = "Compound Interest Calculator", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        EditText principalInvestmentText;
        EditText interestRateText;
        EditText compoundsPerYearText;
        EditText yearsInvestedText;
        Button calculateButton;
        TextView finalInvestmentText;

        double principalInvestment;
        double interestRate;
        double compoundsPerYear;
        double yearsInvested;
        double finalInvestment;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            principalInvestmentText = FindViewById<EditText>(Resource.Id.txtPrincipalInvestment);
            interestRateText = FindViewById<EditText>(Resource.Id.txtInterestRate);
            compoundsPerYearText = FindViewById<EditText>(Resource.Id.txtTimesCompounded);
            yearsInvestedText = FindViewById<EditText>(Resource.Id.txtYearsInvested);
            calculateButton = FindViewById<Button>(Resource.Id.btnCalculate);
            finalInvestmentText = FindViewById<TextView>(Resource.Id.txtFinalInvestment);

            clickButton();
        }

        void clickButton() {
            calculateButton.Click += delegate {
                principalInvestment = double.Parse(principalInvestmentText.Text);
                interestRate = double.Parse(interestRateText.Text);
                compoundsPerYear = double.Parse(compoundsPerYearText.Text);
                yearsInvested = double.Parse(yearsInvestedText.Text);

                calculateFinalInvestment();
            };
        }

        void calculateFinalInvestment() {
            // A = P(1 + r/n)^nt
            interestRate = interestRate / 100;
            finalInvestment = principalInvestment * System.Math.Pow((1 + interestRate / compoundsPerYear), (compoundsPerYear * yearsInvested));

            printFunction();
        }

        void printFunction() {
            finalInvestment = double.Parse(string.Format("{0:0.##}", finalInvestment));
            finalInvestmentText.Text = "Final investment value is: $" + finalInvestment;
        }
    }
}


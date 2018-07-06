using System;

using UIKit;

namespace CompoundInterestCalculator.iOS
{
    public partial class ViewController : UIViewController
    {
        double principalInvestment;
        double interestRate;
        double compoundsPerYear;
        double yearsInvested;
        double finalInvestment;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.

        }

        partial void BtnCalculate_TouchUpInside(UIButton sender)
        {
            btnCalculate.AccessibilityIdentifier = "calculateButton";
            clickButton();
        }

        void clickButton() {
            btnCalculate.TouchUpInside += delegate
            {
                principalInvestment = double.Parse(txtPrincipalInvestment.Text);
                interestRate = double.Parse(txtInterestRate.Text);
                compoundsPerYear = double.Parse(txtCompoundsPerYear.Text);
                yearsInvested = double.Parse(txtYearsInvested.Text);
                    
                calculateFinalInvestment();
            };
        }

        void calculateFinalInvestment() {
            // A = P (1 + r/n)^nt
            interestRate = interestRate / 100;
            finalInvestment = principalInvestment * Math.Pow(1 + (interestRate / compoundsPerYear), (compoundsPerYear * yearsInvested));

            printFunction();
        }

        void printFunction() {
            finalInvestment = double.Parse(string.Format("{0:0.##}", finalInvestment));
            lblFinalInvestment.Text = "Final investment value is: $" + finalInvestment;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}

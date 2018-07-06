// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace CompoundInterestCalculator.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCalculate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFinalInvestment { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCompoundsPerYear { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtInterestRate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPrincipalInvestment { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtYearsInvested { get; set; }

        [Action ("BtnCalculate_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnCalculate_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnCalculate != null) {
                btnCalculate.Dispose ();
                btnCalculate = null;
            }

            if (lblFinalInvestment != null) {
                lblFinalInvestment.Dispose ();
                lblFinalInvestment = null;
            }

            if (txtCompoundsPerYear != null) {
                txtCompoundsPerYear.Dispose ();
                txtCompoundsPerYear = null;
            }

            if (txtInterestRate != null) {
                txtInterestRate.Dispose ();
                txtInterestRate = null;
            }

            if (txtPrincipalInvestment != null) {
                txtPrincipalInvestment.Dispose ();
                txtPrincipalInvestment = null;
            }

            if (txtYearsInvested != null) {
                txtYearsInvested.Dispose ();
                txtYearsInvested = null;
            }
        }
    }
}
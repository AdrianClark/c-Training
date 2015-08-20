using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Phoneword_IOS
{
	public partial class Phoneword_IOSViewController : UIViewController
	{
		public Phoneword_IOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			//initialize an empty string variable to be used 
			string translatedNumber = "";
			//On the TouchUpInside event(?), take whatever the text value is for the PhoneNumberText field and assign it
			//to the translatedNumber variable. .ToNumber is a method we created in the PhoneTranslator.cs file.
			TranslateButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				translatedNumber = PhoneTranslator.ToNumber (PhoneNumberText.Text);
			};
			//Dismiss the keyboard if text field was tapped.
			PhoneNumberText.ResignFirstResponder ();

			//if the translatedNumber variable is empty, meaning there's nothing in the PhoneNumberText field, set the title
			//of the CallButton to "Call", set its UIControlState to Normal, and disable the callButton button.
			if (translatedNumber == "") 
			{
				CallButton.SetTitle ("Call ", UIControlState.Normal);
				CallButton.Enabled = false;
			}
			//otherwise if there is something in the PhoneNumberText field, append the translatedNumber string to the string "Call",
			//set it's UIControlState to Normal, and ENABLE the CallButton button. It makes no sense to allow the button to be pressable
			//if it's going to be processing an empty string. 
			else 
			{
				CallButton.SetTitle ("Call " + translatedNumber, UIControlState.Normal);
				CallButton.Enabled = true;
			}

			//On the TouchUpInside event(?) for the CallButton button, attempt to open the translatedNumber in the phone app, adding the
			//prefix for the the phone app. 
			CallButton.TouchUpInside += (object sender, EventArgs e) => 
			{
				// Use URL handler with tel: prefix to invoke Apple's Phone app
				var url = new NSUrl ("tel:" + translatedNumber);
				//If for whatever reason this doesn't work(how?), create an alert stating that the operation couldn't be done,
				//and show it to the user (?)
				if (!UIApplication.SharedApplication.OpenUrl(url)) 
				{
					var alert = UIAlertController.Create ("Not supported", "Scheme 'tel:' is not supported on this device", UIAlertControllerStyle.Alert);
					alert.AddAction (UIAlertAction.Create ("Ok", UIAlertActionStyle.Default, null));
					PresentViewController (alert, true, null);
				}
			};
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


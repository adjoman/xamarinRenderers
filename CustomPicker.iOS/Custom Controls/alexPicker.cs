using System;
using Xamarin.Forms;
using CustomPicker.CustomControl;
using Xamarin.Forms.Platform.iOS;
using System.Runtime.CompilerServices;

namespace CustomPicker.iOS.CustomControls
{
	public class alexPicker : PickerRenderer
    {

		protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			base.OnPropertyChanged(propertyName);
		}

		protected override SizeRequest OnSizeRequest(double widthConstraint, double heightConstraint)
		{
			return base.OnSizeRequest(widthConstraint, heightConstraint);
		}
        
		//protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
		//{
		//    base.OnElementChanged(e);

		//    //if (Control != null)
		//    //{
		//    //    // set the text to be indented some
		//    //    Control.LeftView = new UIView(new CGRect(0, 0, 0, 0));
		//    //    Control.LeftViewMode = UITextFieldViewMode.Always;
		//    //    Control.RightView = new UIView(new CGRect(0, 0, 0, 0));
		//    //    Control.RightViewMode = UITextFieldViewMode.Always;

		//    //    // change the background color to fit the customer specifics
		//    //    Control.BackgroundColor = UIColor.White;
		//    //    Control.TextColor = UIColor.FromRGB(73, 73, 73);

		//    //    Control.Layer.BorderWidth = 0;
		//    //    Control.BorderStyle = UITextBorderStyle.None;

		//    //    Control.BorderStyle = UITextBorderStyle.None;

		//    //    var view = (Element as BottomBorderEntryField);

		//    //}
		//}
	}
}

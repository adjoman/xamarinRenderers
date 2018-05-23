
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.Runtime.Remoting.Contexts;
using CustomPicker.iOS.CustomControls;
using UIKit;

namespace CustomPicker.iOS.CustomControls
{
    public class AlexLabelRenderer : LabelRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor     = UIColor.FromRGB(119, 171, 233);
                Control.Font                = UIFont.FromName("VeteranTypewriter", 20);

            }
        }
    }
}

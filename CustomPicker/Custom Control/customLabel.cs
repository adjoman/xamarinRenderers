using UIKit;
using Xamarin.Forms;

namespace CustomPicker.CustomControl
{
	public class customLabel : Xamarin.Forms.Label
    {
        public customLabel()
        {
			this.TextColor          = Color.White;
            this.FontFamily         = "VeteranTypewriter";
            this.FontSize           = 30;   
			//this.BackgroundColor    = Color.Purple;
		}
    }
}

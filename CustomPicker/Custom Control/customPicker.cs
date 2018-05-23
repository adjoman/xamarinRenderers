using System;
using Xamarin.Forms;

namespace CustomPicker.CustomControl
{
        public class customPicker : UIPioc
        {
       	         
		    public customPicker()
            {
                this.HeightRequest = 25;

			    this.FontFamily = "VeteranTypewriter";
        
                //Control.TextSize = 14f;
                //Control.SetTypeface(fontFace, TypefaceStyle.Normal);
            }

            public static readonly BindableProperty BorderColorProperty =
			BindableProperty.Create<customPicker, Color>(p => p.BorderColor, Color.FromHex("999999"));

            public Color BorderColor
            {
                get { return (Color)GetValue(BorderColorProperty); }
                set { SetValue(BorderColorProperty, value); }
            }

            public Color BackgroundColor
            {
                get { return (Color)GetValue(BackgroundColorProperty); }
                set { SetValue(BackgroundColorProperty, value); }
            }

            public static readonly BindableProperty FontSizeProperty =
			BindableProperty.Create<customPicker, double>(p => p.FontSize, Font.Default.FontSize);

            public double FontSize
            {
                get { return (double)GetValue(FontSizeProperty); }
                set { SetValue(FontSizeProperty, value); }
            }

            public static readonly BindableProperty PlaceholderColorProperty =
			BindableProperty.Create<customPicker, Color>(p => p.PlaceholderColor, Color.Default);

            public Color PlaceholderColor
            {
                get { return (Color)GetValue(PlaceholderColorProperty); }
                set { SetValue(PlaceholderColorProperty, value); }
            }
        }
    }

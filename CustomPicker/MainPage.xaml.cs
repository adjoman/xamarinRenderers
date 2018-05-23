using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CustomPicker.ViewModels;

namespace CustomPicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
			BindingContext = new MainFormViewModel();

			List<string> testItems = new List<string>();
            
			testItems.Add("Test From 1");
			testItems.Add("Test From 2");
			testItems.Add("Test From 3");

			//works to set the data w/n the container
			testPicker.ItemsSource = ((MainFormViewModel)(this.BindingContext)).pickerListItems;

			//testPicker.ItemsSource = testItems;

			// custom controls
			testCustomPicker.BackgroundColor    = Color.Brown;
			testCustomPicker.BorderColor        = Color.Orange;
			testCustomPicker.ItemsSource        = testItems;
            
        }
    }
}

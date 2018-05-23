using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomPicker.ViewModels
{
	public class MainFormViewModel : INotifyPropertyChanged
    {

		public List<string> _pickerList = new List<string>();

		public event PropertyChangedEventHandler PropertyChanged;

        public MainFormViewModel()
        {
            _pickerList.Add("Baboon");
			_pickerList.Add("Capuchin Monkey");
			_pickerList.Add("Blue Monkey");
			_pickerList.Add("Squirrel Monkey");
			_pickerList.Add("Golden Lion Tamarin");
			_pickerList.Add("Howler Monkey");
			_pickerList.Add("Japanese Macaque");
		}

		public List<string> pickerListItems
        {
            protected set
            {
				if (_pickerList != value)
                {
					_pickerList = value;
					//OnPropertyChanged("pickerListItems");
                }
            }
			get { return _pickerList; }
        }

		protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
  
    }
}

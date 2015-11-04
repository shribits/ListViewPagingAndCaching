using System;
using System.ComponentModel;

namespace Yahooooo
{
	public class BaseViewModel
		:XLabs.Forms.Mvvm.ViewModel, INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged (string propertyName)
		{
			try {
				if (PropertyChanged != null) {
					PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
				}
			} catch {
			}
		}
			
	}
}


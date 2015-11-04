using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Yahooooo
{
	public partial class ExamplePage : ContentPage
	{
		public ExamplePage ()
		{
			InitializeComponent ();
			Title="Yahooo!";
			list.ItemAppearing += (sender, e) =>
			{ 
				MessagingCenter.Send<ExamplePage,Result>(this,"LoadItems",e.Item as Result);

			};

			list.ItemTapped+=(sender, e) => 
			{
				if(e.Item!=null)
					list.SelectedItem=null;
			};
				

		}
	}
}


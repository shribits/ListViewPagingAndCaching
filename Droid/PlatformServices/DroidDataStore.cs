using System;
using Yahooooo.Droid;
using SQLite.Net.Interop;

[assembly: Xamarin.Forms.Dependency(typeof(DroidDataStore))]
namespace Yahooooo.Droid
{
	public class DroidDataStore
		: IDataStore
	{
		public ISQLitePlatform SqlitePlatform
		{
			get
			{
				return new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
			}
		}


	}
}
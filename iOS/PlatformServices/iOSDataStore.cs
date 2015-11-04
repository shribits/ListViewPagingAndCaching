using System;
using Yahooooo.iOS;
using SQLite.Net.Interop;

[assembly: Xamarin.Forms.Dependency(typeof(iOSDataStore))]
namespace Yahooooo.iOS
{
	public class iOSDataStore
		: IDataStore
	{
		public ISQLitePlatform SqlitePlatform
		{
			get
			{
				return new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
			}
		}

	}
}

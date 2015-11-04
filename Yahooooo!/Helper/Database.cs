using System;
using SQLite;
using Xamarin.Forms;
using SQLite.Net;

namespace Yahooooo
{
	public static class Database
	{
		public static int ItemLimit = 5;

		public static SQLiteConnection CreateDB()
		{
			//var s = DependencyService.Get<IDataStore> ().SqlitePlatform;
			var localDB =  DependencyService.Get<IDocumentPathService>().CreateDocumentPath("ShriYahoo.db3");
			return new SQLiteConnection (DependencyService.Get<IDataStore>().SqlitePlatform,localDB.ToString(),true);
		}
	}
}


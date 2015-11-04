using System;
using SQLite;
using SQLite.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace Yahooooo
{
	public class CacheService
		:ICacheService
	{
		SQLiteConnection db;

		public CacheService ()
		{
			db = Database.CreateDB ();
			db.CreateTable<Result>(); 
		}

		#region CacheServiceImpementation

		public Task AddOrUpdateExampleItem(List<Result> Items)
		{
			return Task.Factory.StartNew (() => {
				foreach (Result item in Items) {
					db.Insert (item);
				}
			});
	
		}

		public List<Result> GetExampleItem()
		{ 
			List<Result> resultList=new List<Result>();
			var listCount = db.Table<Result> ().Count ();
			for(int i=0; i<listCount; i++)
			{
				var item = db.Table<Result> ().ElementAt(i);
				resultList.Add(item);
			}

			return resultList;
		}

		#endregion
	}
}


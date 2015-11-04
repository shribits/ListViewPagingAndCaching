using System;
using SQLite.Net.Interop;

namespace Yahooooo
{
	public interface IDataStore
	{
		ISQLitePlatform SqlitePlatform { get; }
	}
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace Yahooooo
{
	public class LazyList<T> 
		: IList<T>
	{
		private IQueryable<T> _query = null;
		private IList<T> _inner = null;
		private int? _iqueryableCountCache = null;


		public LazyList()
		{
			this._inner = new List<T>();
		}

		public LazyList(IList<T> inner)
		{
			this._inner = inner;
		}

		public LazyList(IQueryable<T> query)
		{
			if (query == null)
				throw new ArgumentNullException();
			this._query = query;
		}
	}
}
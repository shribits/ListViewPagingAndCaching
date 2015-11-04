using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Yahooooo
{
	public interface ICacheService
	{
		Task AddOrUpdateExampleItem(List<Result> Items);

		List<Result> GetExampleItem();
	}
}


using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Yahooooo
{
	public interface IExampleService
	{
		Task<List<Result>> GetItems ();
	}
}


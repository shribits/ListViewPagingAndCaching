using System;
using System.Threading.Tasks;
using RestSharp.Portable;
using System.Diagnostics;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace Yahooooo
{
	public class ExampleService
		:IExampleService
	{
		private ICacheService cacheService;

		public List<Result> exampleItems {
			get;
			set;
		}

		public IList<Result> Items {
			get;
			set;
		}
		public ExampleService (ICacheService cacheService)
		{
			this.cacheService = cacheService;
		}

		public async Task<List<Result>> GetItems()
		{
			exampleItems = new List<Result> ();
			try{
				
				await GetActivityItems ();
				await cacheService.AddOrUpdateExampleItem (exampleItems);


			}
			catch
			{
				
			}
			return cacheService.GetExampleItem ();
			//return exampleItems;
		}

		private async Task GetActivityItems()
		{
			try{

				var client = new RestClient ("http://www.whatsbeef.net");
				var request = new RestRequest ("/wabz/guide.php?start="+AppConfig.AppElementCounter);
				IRestResponse response = await client.Execute (request);
				RestSharp.Portable.Deserializers.JsonDeserializer deserial = new RestSharp.Portable.Deserializers.JsonDeserializer ();
				var deserializedResponse= deserial.Deserialize<Example> (response);
				Items= deserializedResponse.results ;
				foreach (var item in Items) {
					exampleItems.Add (item);
				}
				AppConfig.AppElementCounter+=10;

			}
			catch(Exception ex){
				#if DEBUG
				Debug.WriteLine (ex);
				#endif
			}
		}


	}
}


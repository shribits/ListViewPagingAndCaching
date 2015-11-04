using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;

namespace Yahooooo
{
	public class ExampleViewModel
		:BaseViewModel
	{
		private List<Result> resultItems;
		public List<Result> ResultItems {
			get { return resultItems; } 
			set {
				resultItems = value;
				OnPropertyChanged ("ResultItems");
			}
		}

		private bool isLoading;
		public bool IsLoading {
			get { return isLoading; } 
			set {
				isLoading = value;
				OnPropertyChanged ("IsLoading");
			}
		}

		public string name {
			get;
			set;
		}

		private ObservableCollection<Result> collectionItems;
		public ObservableCollection<Result> CollectionItems {
			get { return collectionItems; } 
			set {
				collectionItems = value;
				OnPropertyChanged ("CollectionItems");
			}
		}

		private ExampleService exampleService;

		public ICommand LoadMoreCommand{ private set; get; }

		public ExampleViewModel ()
		{
			CollectionItems = new ObservableCollection<Result> ();
			IsLoading = false;
			exampleService = new ExampleService (App.Database);

			MessagingCenter.Subscribe<ExamplePage,Result> (this, "LoadItems", (sender, e) => {
				LoadMoreItems(e);
			});

			LoadMoreCommand = new Command(() => {
				UpdateViewModel ();
			});

			UpdateViewModel ();
		}

		public async Task UpdateViewModel()
		{
			IsLoading = true;
			ResultItems =  await exampleService.GetItems ();
			Debug.WriteLine(ResultItems[0].channel);
			foreach (var item in ResultItems) {
				CollectionItems.Add (item);
			}
			Debug.WriteLine(CollectionItems[0].channel);
			IsLoading = false;
		}

		public async Task LoadMoreItems(Result e)
		{
			if (e == CollectionItems [CollectionItems.Count - 1] && IsLoading==false) {
				await UpdateViewModel ();

			}
		}
	}

}


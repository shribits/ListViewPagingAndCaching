using Android.Content.PM;
using Android.OS;
using XLabs.Ioc;
using Android.App;
using Android.Runtime;

namespace Yahooooo.Droid
{
	[Activity (Label = "Yahooooo", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			if(!Resolver.IsSet) SetIoc();
			LoadApplication (new App ());
		}

		private void SetIoc()
		{
			var resolverContainer = new SimpleContainer();
			Resolver.SetResolver(resolverContainer.GetResolver());
		}

	}
}


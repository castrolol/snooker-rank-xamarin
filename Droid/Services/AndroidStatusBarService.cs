using System;
using Android.App;
using SnookerRank.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(AndroidStatusBarService))]
namespace SnookerRank.Droid
{

	public class AndroidStatusBarService : IStatusBarService
	{
		public AndroidStatusBarService()
		{
		}

		public void SetColor(Color color)
		{

			var activity = Forms.Context as Activity;
			var window = activity.Window;

			window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);
			window.AddFlags(Android.Views.WindowManagerFlags.DrawsSystemBarBackgrounds);


			// finally change the color
			window.SetStatusBarColor(color.ToAndroid());
		}
	}
}

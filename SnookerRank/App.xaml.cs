using Xamarin.Forms;

namespace SnookerRank
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage())
			{
				BackgroundColor = Color.FromHex("#204F20#"),
				BarBackgroundColor = Color.FromHex("#482500")

			};


			if (Device.OS == TargetPlatform.Android)
			{
				DependencyService.Get<IStatusBarService>().SetColor(Color.FromHex("#271500"));
			}
			 
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ApiContractExplorer
{
	sealed partial class App : Application
	{
		public App()
		{
			this.InitializeComponent();
		}

		protected override void OnLaunched(LaunchActivatedEventArgs e)
		{
			var frame = new Frame();

			frame.Navigate(typeof(MainPage));

			Window.Current.Content = frame;

			Window.Current.Activate();
		}
	}
}
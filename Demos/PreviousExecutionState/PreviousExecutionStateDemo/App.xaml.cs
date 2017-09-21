using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PreviousExecutionStateDemo
{
	sealed partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
        }

		protected override void OnLaunched(LaunchActivatedEventArgs e)
		{
			// NotRunning
			// ClosedByUser
			// Running
			// Suspended
			// Terminated
			string state = e.PreviousExecutionState.ToString();

			Window.Current.Content = new TextBlock() { Text = state, VerticalAlignment=VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center };

			Window.Current.Activate();
		}
	}
}
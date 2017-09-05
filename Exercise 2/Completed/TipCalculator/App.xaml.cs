using Windows.ApplicationModel.Activation;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TipCalculator
{
    sealed partial class App : Application
    {
		public static string SavedBillAmount { get; set; }

        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame == null)
            {
                rootFrame = new Frame();

                if (e.PreviousExecutionState == ApplicationExecutionState.ClosedByUser
				 || e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
					if (ApplicationData.Current.LocalSettings.Values.ContainsKey(nameof(SavedBillAmount)))
					{
						SavedBillAmount = (string)ApplicationData.Current.LocalSettings.Values[nameof(SavedBillAmount)];
					}
                }

                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }

                Window.Current.Activate();
            }
        }
    }
}
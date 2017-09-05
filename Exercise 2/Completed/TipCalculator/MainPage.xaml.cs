using Windows.ApplicationModel;
using Windows.Storage;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TipCalculator
{
	public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			App.Current.EnteredBackground += OnEnteredBackground;

			if (!string.IsNullOrEmpty(App.SavedBillAmount))
			{
				billInput.Text = App.SavedBillAmount;
			}
		}

		protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
		{
			App.Current.EnteredBackground -= OnEnteredBackground;
		}

		void OnEnteredBackground(object sender, EnteredBackgroundEventArgs e)
		{
			if (string.IsNullOrEmpty(billInput.Text))
				return;

			ApplicationData.Current.LocalSettings.Values[nameof(App.SavedBillAmount)] = billInput.Text;
		}

		void OnBillChanged(object sender, TextChangedEventArgs e)
		{
			double bill;

			if (!double.TryParse(billInput.Text, out bill))
				return;

			double tip = bill * 0.15;

			tipOutput.Text = string.Format("{0:C}", tip);
		}
	}
}
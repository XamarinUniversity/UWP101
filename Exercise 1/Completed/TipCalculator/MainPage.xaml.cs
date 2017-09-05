using Windows.UI.Xaml.Controls;

namespace TipCalculator
{
	public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
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
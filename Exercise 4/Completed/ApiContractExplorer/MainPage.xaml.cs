using System.Collections.ObjectModel;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ApiContractExplorer
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

			DataContext = availableContracts;
        }

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			foreach (var contract in allContracts)
			{
				string result = "";

				if (ApiInformation.IsApiContractPresent(contract, 1)) result += contract + " v1";
				if (ApiInformation.IsApiContractPresent(contract, 2)) result += " v2";
				if (ApiInformation.IsApiContractPresent(contract, 3)) result += " v3";

				if (result != "")
					availableContracts.Add(result);
			}
		}

		ObservableCollection<string> availableContracts = new ObservableCollection<string>();

		string[] allContracts =
		{
			"Windows.ApplicationModel.Activation.ActivatedEventsContract",
			"Windows.ApplicationModel.Activation.ActivationCameraSettingsContract",
			"Windows.ApplicationModel.Activation.ContactActivatedEventsContract",
			"Windows.ApplicationModel.Activation.WebUISearchActivatedEventsContract",
			"Windows.ApplicationModel.Background.BackgroundAlarmApplicationContract",
			"Windows.ApplicationModel.Calls.Background.CallsBackgroundContract",
			"Windows.ApplicationModel.Calls.CallsPhoneContract",
			"Windows.ApplicationModel.Calls.CallsVoipContract",
			"Windows.ApplicationModel.Calls.LockScreenCallContract",
			"Windows.ApplicationModel.CommunicationBlocking.CommunicationBlockingContract",
			"Windows.ApplicationModel.FullTrustAppContract",
			"Windows.ApplicationModel.Resources.Management.ResourceIndexerContract",
			"Windows.ApplicationModel.Preview.Notes.PreviewNotesContract",
			"Windows.ApplicationModel.Search.SearchContract",
			"Windows.ApplicationModel.Search.Core.SearchCoreContract",
			"Windows.ApplicationModel.SocialInfo.SocialInfoContract",
			"Windows.ApplicationModel.StartupTaskContract",
			"Windows.ApplicationModel.Wallet.WalletContract",
			"Windows.Devices.Custom.CustomDeviceContract",
			"Windows.Devices.DevicesLowLevelContract",
			"Windows.Devices.Printers.Extensions.ExtensionsContract",
			"Windows.Devices.Printers.PrintersContract",
			"Windows.Devices.Portable.PortableDeviceContract",
			"Windows.Devices.Scanners.ScannerDeviceContract",
			"Windows.Devices.SmartCards.SmartCardBackgroundTriggerContract",
			"Windows.Devices.SmartCards.SmartCardEmulatorContract",
			"Windows.Devices.Sms.LegacySmsApiContract",
			"Windows.Embedded.DeviceLockdown.DeviceLockdownContract",
			"Windows.Foundation.FoundationContract",
			"Windows.Gaming.Preview.GamesEnumerationContract",
			"Windows.Gaming.XboxLive.StorageApiContract",
			"Windows.Foundation.UniversalApiContract",
			"Windows.Globalization.GlobalizationJapanesePhoneticAnalyzerContract",
			"Windows.Graphics.Printing3D.Printing3DContract",
			"Windows.Management.Deployment.Preview.DeploymentPreviewContract",
			"Windows.Management.Orchestration.OrchestrationContract",
			"Windows.Management.Workplace.WorkplaceSettingsContract",
			"Windows.Media.Capture.AppCaptureContract",
			"Windows.Media.Capture.CameraCaptureUIContract",
			"Windows.Media.Devices.CallControlContract",
			"Windows.Media.MediaControlContract",
			"Windows.Media.Playlists.PlaylistsContract",
			"Windows.Media.Protection.ProtectionRenewalContract",
			"Windows.Networking.Connectivity.WwanContract",
			"Windows.Networking.NetworkOperators.LegacyNetworkOperatorsContract",
			"Windows.Networking.NetworkOperators.NetworkOperatorsFdnContract",
			"Windows.Networking.Sockets.ControlChannelTriggerContract",
			"Windows.Networking.XboxLive.XboxLiveSecureSocketsContract",
			"Windows.Phone.PhoneContract",
			"Windows.Perception.Automation.Core.PerceptionAutomationCoreContract",
			"Windows.Phone.StartScreen.DualSimTileContract",
			"Windows.Security.EnterpriseData.EnterpriseDataContract",
			"Windows.Security.ExchangeActiveSyncProvisioning.EasContract",
			"Windows.Services.Maps.GuidanceContract",
			"Windows.Services.Maps.LocalSearchContract",
			"Windows.System.Profile.ProfileHardwareTokenContract",
			"Windows.Services.Store.StoreContract",
			"Windows.System.Profile.ProfileRetailInfoContract",
			"Windows.System.Profile.ProfileSharedModeContract",
			"Windows.System.Profile.SystemManufacturers.SystemManufacturersContract",
			"Windows.System.SystemManagementContract",
			"Windows.System.UserProfile.UserProfileContract",
			"Windows.System.UserProfile.UserProfileLockScreenContract",
			"Windows.UI.ApplicationSettings.ApplicationsSettingsContract",
			"Windows.UI.Core.AnimationMetrics.AnimationMetricsContract",
			"Windows.UI.Core.CoreWindowDialogsContract",
			"Windows.UI.ViewManagement.ViewManagementViewScalingContract",
			"Windows.UI.WebUI.Core.WebUICommandBarContract",
			"Windows.UI.Xaml.Hosting.HostingContract",
			"Windows.Web.Http.Diagnostics.HttpDiagnosticsContract",
		};
	}
}
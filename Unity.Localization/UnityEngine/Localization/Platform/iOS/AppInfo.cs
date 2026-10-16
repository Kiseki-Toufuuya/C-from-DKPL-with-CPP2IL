namespace UnityEngine.Localization.Platform.iOS;

[DisplayName("iOS App Info", null)]
[Metadata(AllowedTypes = MetadataType::LocalizationSettings (256), AllowMultiple = False, MenuItem = "iOS/App Info")]
public class AppInfo : IMetadata
{
	[SerializeField]
	[Tooltip("The user-visible name for the bundle, used by Siri and visible on the iOS Home screen.\nThis name can contain up to 15 characters.\nCFBundleName field in xcode projects info.plist file.")]
	private LocalizedString m_ShortName; //Field offset: 0x8
	[SerializeField]
	[Tooltip("The user-visible name for the bundle, used by Siri and visible on the iOS Home screen.\nUse this key if you want a product name that's longer than Bundle Name.\nCFBundleDisplayName field in xcode projects info.plist file.")]
	private LocalizedString m_DisplayName; //Field offset: 0xC
	[SerializeField]
	[Tooltip("A message that tells the user why the app is requesting access to the device’s camera.\nNSCameraUsageDescription field in xcode projects info.plist file.")]
	private LocalizedString m_CameraUsageDescription; //Field offset: 0x10
	[SerializeField]
	[Tooltip("A message that tells the user why the app is requesting access to the device’s microphone.\nNSMicrophoneUsageDescription field in xcode projects info.plist file.")]
	private LocalizedString m_MicrophoneUsageDescription; //Field offset: 0x14
	[SerializeField]
	[Tooltip("A message that tells the user why the app is requesting access to the user’s location information while the app is running in the foreground.\nNSLocationWhenInUseUsageDescription field in xcode projects info.plist file.")]
	private LocalizedString m_LocationUsageDescription; //Field offset: 0x18
	[SerializeField]
	[Tooltip("A message that informs the user why an app is requesting permission to use data for tracking the user or the device.\nNSUserTrackingUsageDescription field in xcode projects info.plist file.")]
	private LocalizedString m_UserTrackingUsageDescription; //Field offset: 0x1C

	public LocalizedString CameraUsageDescription
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedString DisplayName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedString LocationUsageDescription
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedString MicrophoneUsageDescription
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedString ShortName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedString UserTrackingUsageDescription
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public AppInfo() { }

	public LocalizedString get_CameraUsageDescription() { }

	public LocalizedString get_DisplayName() { }

	public LocalizedString get_LocationUsageDescription() { }

	public LocalizedString get_MicrophoneUsageDescription() { }

	public LocalizedString get_ShortName() { }

	public LocalizedString get_UserTrackingUsageDescription() { }

	public void set_CameraUsageDescription(LocalizedString value) { }

	public void set_DisplayName(LocalizedString value) { }

	public void set_LocationUsageDescription(LocalizedString value) { }

	public void set_MicrophoneUsageDescription(LocalizedString value) { }

	public void set_ShortName(LocalizedString value) { }

	public void set_UserTrackingUsageDescription(LocalizedString value) { }

}


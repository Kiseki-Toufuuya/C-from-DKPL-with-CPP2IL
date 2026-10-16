namespace UnityEngine.Localization.Platform.Android;

[DisplayName("Android App Info", "Packages/com.unity.localization/Editor/Icons/Android/Android.png")]
[Metadata(AllowedTypes = MetadataType::LocalizationSettings (256), AllowMultiple = False, MenuItem = "Android/App Info")]
public class AppInfo : IMetadata
{
	[SerializeField]
	[Tooltip("The user-visible name for the bundle, used by Google Assistant and visible on the Android Home screen.\n")]
	private LocalizedString m_DisplayName; //Field offset: 0x8

	public LocalizedString DisplayName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public AppInfo() { }

	public LocalizedString get_DisplayName() { }

	public void set_DisplayName(LocalizedString value) { }

}


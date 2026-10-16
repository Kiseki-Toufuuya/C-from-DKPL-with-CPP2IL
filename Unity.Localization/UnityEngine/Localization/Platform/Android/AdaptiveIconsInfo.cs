namespace UnityEngine.Localization.Platform.Android;

[DisplayName("Android Adaptive Icon Info", null)]
[Metadata(AllowedTypes = MetadataType::LocalizationSettings (256), AllowMultiple = False, MenuItem = "Android/Adaptive Icon")]
public class AdaptiveIconsInfo : IMetadata
{
	[SerializeField]
	private AdaptiveIcon m_Adaptive_idpi; //Field offset: 0x8
	[SerializeField]
	private AdaptiveIcon m_Adaptive_mdpi; //Field offset: 0xC
	[SerializeField]
	private AdaptiveIcon m_Adaptive_hdpi; //Field offset: 0x10
	[SerializeField]
	private AdaptiveIcon m_Adaptive_xhdpi; //Field offset: 0x14
	[SerializeField]
	private AdaptiveIcon m_Adaptive_xxhdpi; //Field offset: 0x18
	[SerializeField]
	private AdaptiveIcon m_Adaptive_xxxhdpi; //Field offset: 0x1C
	internal List<AdaptiveIcon> AdaptiveIcons; //Field offset: 0x20

	public AdaptiveIcon AdaptiveHdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public AdaptiveIcon AdaptiveIdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public AdaptiveIcon AdaptiveMdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public AdaptiveIcon AdaptiveXhdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public AdaptiveIcon AdaptiveXXHdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public AdaptiveIcon AdaptiveXXXHdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public AdaptiveIconsInfo() { }

	public AdaptiveIcon get_AdaptiveHdpi() { }

	public AdaptiveIcon get_AdaptiveIdpi() { }

	public AdaptiveIcon get_AdaptiveMdpi() { }

	public AdaptiveIcon get_AdaptiveXhdpi() { }

	public AdaptiveIcon get_AdaptiveXXHdpi() { }

	public AdaptiveIcon get_AdaptiveXXXHdpi() { }

	internal void RefreshAdaptiveIcons() { }

	public void set_AdaptiveHdpi(AdaptiveIcon value) { }

	public void set_AdaptiveIdpi(AdaptiveIcon value) { }

	public void set_AdaptiveMdpi(AdaptiveIcon value) { }

	public void set_AdaptiveXhdpi(AdaptiveIcon value) { }

	public void set_AdaptiveXXHdpi(AdaptiveIcon value) { }

	public void set_AdaptiveXXXHdpi(AdaptiveIcon value) { }

}


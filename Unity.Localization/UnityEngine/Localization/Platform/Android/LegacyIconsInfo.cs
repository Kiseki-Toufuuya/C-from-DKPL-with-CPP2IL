namespace UnityEngine.Localization.Platform.Android;

[DisplayName("Android Legacy Icon Info", null)]
[Metadata(AllowedTypes = MetadataType::LocalizationSettings (256), AllowMultiple = False, MenuItem = "Android/Legacy Icon")]
public class LegacyIconsInfo : IMetadata
{
	[SerializeField]
	private LocalizedTexture m_Legacy_idpi; //Field offset: 0x8
	[SerializeField]
	private LocalizedTexture m_Legacy_mdpi; //Field offset: 0xC
	[SerializeField]
	private LocalizedTexture m_Legacy_hdpi; //Field offset: 0x10
	[SerializeField]
	private LocalizedTexture m_Legacy_xhdpi; //Field offset: 0x14
	[SerializeField]
	private LocalizedTexture m_Legacy_xxhdpi; //Field offset: 0x18
	[SerializeField]
	private LocalizedTexture m_Legacy_xxxhdpi; //Field offset: 0x1C
	internal List<LocalizedTexture> LegacyIcons; //Field offset: 0x20

	public LocalizedTexture LegacyHdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedTexture LegacyIdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedTexture LegacyMdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedTexture LegacyXhdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedTexture LegacyXXHdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedTexture LegacyXXXHdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LegacyIconsInfo() { }

	public LocalizedTexture get_LegacyHdpi() { }

	public LocalizedTexture get_LegacyIdpi() { }

	public LocalizedTexture get_LegacyMdpi() { }

	public LocalizedTexture get_LegacyXhdpi() { }

	public LocalizedTexture get_LegacyXXHdpi() { }

	public LocalizedTexture get_LegacyXXXHdpi() { }

	internal void RefreshLegacyIcons() { }

	public void set_LegacyHdpi(LocalizedTexture value) { }

	public void set_LegacyIdpi(LocalizedTexture value) { }

	public void set_LegacyMdpi(LocalizedTexture value) { }

	public void set_LegacyXhdpi(LocalizedTexture value) { }

	public void set_LegacyXXHdpi(LocalizedTexture value) { }

	public void set_LegacyXXXHdpi(LocalizedTexture value) { }

}


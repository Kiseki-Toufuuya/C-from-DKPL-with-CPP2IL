namespace UnityEngine.Localization.Platform.Android;

[DisplayName("Android Round Icon Info", null)]
[Metadata(AllowedTypes = MetadataType::LocalizationSettings (256), AllowMultiple = False, MenuItem = "Android/Round Icon")]
public class RoundIconsInfo : IMetadata
{
	[SerializeField]
	private LocalizedTexture m_Round_idpi; //Field offset: 0x8
	[SerializeField]
	private LocalizedTexture m_Round_mdpi; //Field offset: 0xC
	[SerializeField]
	private LocalizedTexture m_Round_hdpi; //Field offset: 0x10
	[SerializeField]
	private LocalizedTexture m_Round_xhdpi; //Field offset: 0x14
	[SerializeField]
	private LocalizedTexture m_Round_xxhdpi; //Field offset: 0x18
	[SerializeField]
	private LocalizedTexture m_Round_xxxhdpi; //Field offset: 0x1C
	internal List<LocalizedTexture> RoundIcons; //Field offset: 0x20

	public LocalizedTexture RoundHdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedTexture RoundIdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedTexture RoundMdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedTexture RoundXhdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedTexture RoundXXHdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedTexture RoundXXXHdpi
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public RoundIconsInfo() { }

	public LocalizedTexture get_RoundHdpi() { }

	public LocalizedTexture get_RoundIdpi() { }

	public LocalizedTexture get_RoundMdpi() { }

	public LocalizedTexture get_RoundXhdpi() { }

	public LocalizedTexture get_RoundXXHdpi() { }

	public LocalizedTexture get_RoundXXXHdpi() { }

	internal void RefreshRoundIcons() { }

	public void set_RoundHdpi(LocalizedTexture value) { }

	public void set_RoundIdpi(LocalizedTexture value) { }

	public void set_RoundMdpi(LocalizedTexture value) { }

	public void set_RoundXhdpi(LocalizedTexture value) { }

	public void set_RoundXXHdpi(LocalizedTexture value) { }

	public void set_RoundXXXHdpi(LocalizedTexture value) { }

}


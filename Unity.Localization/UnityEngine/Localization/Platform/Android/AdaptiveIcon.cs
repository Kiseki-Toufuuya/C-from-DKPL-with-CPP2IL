namespace UnityEngine.Localization.Platform.Android;

public class AdaptiveIcon
{
	[SerializeField]
	private LocalizedTexture m_Background; //Field offset: 0x8
	[SerializeField]
	private LocalizedTexture m_Foreground; //Field offset: 0xC

	public LocalizedTexture Background
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedTexture Foreground
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public AdaptiveIcon() { }

	public LocalizedTexture get_Background() { }

	public LocalizedTexture get_Foreground() { }

	public void set_Background(LocalizedTexture value) { }

	public void set_Foreground(LocalizedTexture value) { }

}


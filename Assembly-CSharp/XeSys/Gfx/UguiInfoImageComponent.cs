namespace XeSys.Gfx;

public class UguiInfoImageComponent : UguiInfoComponent
{
	protected ImageView m_imageView; //Field offset: 0x34
	protected IAlphaTexture m_image; //Field offset: 0x38
	[CompilerGenerated]
	private TexUVListManager <UvMan>k__BackingField; //Field offset: 0x3C

	public string TextureName
	{
		 get { } //Length: 66
	}

	public TexUVListManager UvMan
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public UguiInfoImageComponent() { }

	public string get_TextureName() { }

	[CompilerGenerated]
	public TexUVListManager get_UvMan() { }

	public void OnDestroy() { }

	[CompilerGenerated]
	public void set_UvMan(TexUVListManager value) { }

	public virtual void Setup(ViewBase view, bool setView = true) { }

	public virtual void UpdateIntended() { }

}


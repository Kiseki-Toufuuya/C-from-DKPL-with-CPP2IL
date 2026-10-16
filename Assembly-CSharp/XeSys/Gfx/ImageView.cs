namespace XeSys.Gfx;

public class ImageView : ViewBase
{
	private string m_ImageName; //Field offset: 0x60
	private TexUVList m_Tex; //Field offset: 0x64
	private TexUVData m_UVData; //Field offset: 0x68
	private bool m_IsRender; //Field offset: 0x6C
	[CompilerGenerated]
	private TexUVListManager <UvMan>k__BackingField; //Field offset: 0x70
	public bool m_IsRawImage; //Field offset: 0x74
	private bool m_IsFlipX; //Field offset: 0x75
	private bool m_IsFlipY; //Field offset: 0x76

	public string ImageName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool IsFlipX
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsFlipY
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsRawImage
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsRender
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public virtual bool IsVisible
	{
		 get { } //Length: 14
	}

	public TexUVList Tex
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TexUVData UVData
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TexUVListManager UvMan
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public ImageView() { }

	public virtual void Clear() { }

	public virtual void CopyTo(ViewBase view) { }

	public virtual ViewBase DeepClone() { }

	public string get_ImageName() { }

	public bool get_IsFlipX() { }

	public bool get_IsFlipY() { }

	public bool get_IsRawImage() { }

	public bool get_IsRender() { }

	public virtual bool get_IsVisible() { }

	public TexUVList get_Tex() { }

	public TexUVData get_UVData() { }

	[CompilerGenerated]
	public TexUVListManager get_UvMan() { }

	public virtual void Serialize(List<SerializableView> list, int parent) { }

	public void set_ImageName(string value) { }

	public void set_IsFlipX(bool value) { }

	public void set_IsFlipY(bool value) { }

	public void set_IsRawImage(bool value) { }

	public void set_IsRender(bool value) { }

	public void set_Tex(TexUVList value) { }

	public void set_UVData(TexUVData value) { }

	[CompilerGenerated]
	public void set_UvMan(TexUVListManager value) { }

	public void SetTexture(TexUVList tex, string name) { }

	public void SetTexture(TexUVList tex, TexUVData uvdata) { }

	public virtual bool UpdateAnim(float dt) { }

}


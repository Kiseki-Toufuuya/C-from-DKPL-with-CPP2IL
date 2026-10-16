namespace XeSys.Gfx;

public class MaskView : AbsoluteLayout
{
	private string m_ImageName; //Field offset: 0x74
	private TexUVList m_Tex; //Field offset: 0x78
	private TexUVData m_UVData; //Field offset: 0x7C
	private bool m_IsFlipX; //Field offset: 0x80
	private bool m_IsFlipY; //Field offset: 0x81

	public string ImageName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool IsFlipX
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool IsFlipY
	{
		 get { } //Length: 14
		 set { } //Length: 17
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

	public MaskView() { }

	public virtual void Clear() { }

	public virtual void CopyTo(ViewBase view) { }

	public virtual ViewBase DeepClone() { }

	public string get_ImageName() { }

	public bool get_IsFlipX() { }

	public bool get_IsFlipY() { }

	public TexUVList get_Tex() { }

	public TexUVData get_UVData() { }

	public virtual void Serialize(List<SerializableView> list, int parent) { }

	public void set_ImageName(string value) { }

	public void set_IsFlipX(bool value) { }

	public void set_IsFlipY(bool value) { }

	public void set_Tex(TexUVList value) { }

	public void set_UVData(TexUVData value) { }

	public void SetTexture(TexUVList tex, TexUVData uvdata) { }

	public void SetTexture(TexUVList tex, string name) { }

	public virtual void UpdateAll(Color parentCol) { }

	public virtual bool UpdateAnim(float dt) { }

}


namespace XeSys.Gfx;

public class ScrollBar : ImageView
{
	private string m_BarImageName; //Field offset: 0x78
	private TexUVList m_BarTex; //Field offset: 0x7C
	private TexUVData m_BarUVData; //Field offset: 0x80

	public string BarImageName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TexUVList BarTex
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TexUVData BarUVData
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public ScrollBar() { }

	public virtual void Clear() { }

	public virtual void CopyTo(ViewBase view) { }

	public virtual ViewBase DeepClone() { }

	public string get_BarImageName() { }

	public TexUVList get_BarTex() { }

	public TexUVData get_BarUVData() { }

	public virtual void Serialize(List<SerializableView> list, int parent) { }

	public void set_BarImageName(string value) { }

	public void set_BarTex(TexUVList value) { }

	public void set_BarUVData(TexUVData value) { }

	public void SetBarTexture(TexUVList tex, TexUVData uvdata) { }

}


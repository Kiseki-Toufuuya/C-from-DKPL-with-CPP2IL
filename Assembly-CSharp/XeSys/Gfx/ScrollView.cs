namespace XeSys.Gfx;

public class ScrollView : AbsoluteLayout
{
	private static StringBuilder s_strWork; //Field offset: 0x0
	protected ScrollBar m_ScrollBarV; //Field offset: 0x74
	protected ScrollBar m_ScrollBarH; //Field offset: 0x78
	[CompilerGenerated]
	private float <ScrollDecRate>k__BackingField; //Field offset: 0x7C

	public ScrollBar ScrollBarH
	{
		 get { } //Length: 11
	}

	public ScrollBar ScrollBarV
	{
		 get { } //Length: 11
	}

	public float ScrollDecRate
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 18
	}

	private static ScrollView() { }

	public ScrollView() { }

	public virtual void CopyTo(ViewBase view) { }

	public virtual ViewBase DeepClone() { }

	public ScrollBar get_ScrollBarH() { }

	public ScrollBar get_ScrollBarV() { }

	[CompilerGenerated]
	public float get_ScrollDecRate() { }

	public static string GetScrollBarAccessoryName(string nameV) { }

	public string GetScrollBarAccessoryName() { }

	private static string GetScrollBarHName(string nameV) { }

	public virtual void Serialize(List<SerializableView> list, int parent) { }

	[CompilerGenerated]
	public void set_ScrollDecRate(float value) { }

	public virtual void SettingTexture(TexUVListManager texManager) { }

	public virtual void Update(Color parentCol) { }

}


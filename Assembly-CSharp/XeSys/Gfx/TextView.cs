namespace XeSys.Gfx;

public class TextView : ViewBase
{
	public static TextAnchor[2] AnchorTbl; //Field offset: 0x0
	protected Font m_font; //Field offset: 0x60
	[CompilerGenerated]
	private Func<String, String> <getTextFromIdDelegate>k__BackingField; //Field offset: 0x64
	private int m_TextSize; //Field offset: 0x68
	protected EAlignH m_TextAlignH; //Field offset: 0x6C
	protected EAlignV m_TextAlignV; //Field offset: 0x70
	protected string m_TextId; //Field offset: 0x74
	protected string m_Text; //Field offset: 0x78
	protected int m_fontSize; //Field offset: 0x7C
	protected float m_LineSpace; //Field offset: 0x80

	public virtual bool enabled
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Font font
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int FontSize
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Func<String, String> getTextFromIdDelegate
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public float LineSpace
	{
		 get { } //Length: 14
		 set { } //Length: 21
	}

	public override string Text
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public EAlignH TextAlignH
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public EAlignV TextAlignV
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string TextId
	{
		 get { } //Length: 11
		 set { } //Length: 298
	}

	public int TextSize
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static TextView() { }

	public TextView() { }

	public virtual void CopyTo(ViewBase view) { }

	public virtual ViewBase DeepClone() { }

	public virtual bool get_enabled() { }

	public Font get_font() { }

	public int get_FontSize() { }

	[CompilerGenerated]
	public Func<String, String> get_getTextFromIdDelegate() { }

	public float get_LineSpace() { }

	public override string get_Text() { }

	public EAlignH get_TextAlignH() { }

	public EAlignV get_TextAlignV() { }

	public string get_TextId() { }

	public int get_TextSize() { }

	public void InitFont(FontInfo fontInfo) { }

	public virtual void Serialize(List<SerializableView> list, int parent) { }

	public virtual void set_enabled(bool value) { }

	public void set_font(Font value) { }

	public void set_FontSize(int value) { }

	[CompilerGenerated]
	public void set_getTextFromIdDelegate(Func<String, String> value) { }

	public void set_LineSpace(float value) { }

	public override void set_Text(string value) { }

	public void set_TextAlignH(EAlignH value) { }

	public void set_TextAlignV(EAlignV value) { }

	public void set_TextId(string value) { }

	public void set_TextSize(int value) { }

}


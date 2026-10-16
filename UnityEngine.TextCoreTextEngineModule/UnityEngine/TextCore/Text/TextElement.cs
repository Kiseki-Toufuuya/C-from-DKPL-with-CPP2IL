namespace UnityEngine.TextCore.Text;

public abstract class TextElement
{
	[SerializeField]
	protected TextElementType m_ElementType; //Field offset: 0x8
	[SerializeField]
	internal uint m_Unicode; //Field offset: 0xC
	internal TextAsset m_TextAsset; //Field offset: 0x10
	internal Glyph m_Glyph; //Field offset: 0x14
	[SerializeField]
	internal uint m_GlyphIndex; //Field offset: 0x18
	[SerializeField]
	internal float m_Scale; //Field offset: 0x1C

	public TextElementType elementType
	{
		 get { } //Length: 11
	}

	public Glyph glyph
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public uint glyphIndex
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public float scale
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public TextAsset textAsset
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public uint unicode
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	protected TextElement() { }

	public TextElementType get_elementType() { }

	public Glyph get_glyph() { }

	public uint get_glyphIndex() { }

	public float get_scale() { }

	public TextAsset get_textAsset() { }

	public uint get_unicode() { }

	public void set_glyph(Glyph value) { }

	public void set_glyphIndex(uint value) { }

	public void set_scale(float value) { }

	public void set_textAsset(TextAsset value) { }

	public void set_unicode(uint value) { }

}


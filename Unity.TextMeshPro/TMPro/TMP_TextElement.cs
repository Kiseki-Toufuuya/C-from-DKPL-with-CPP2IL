namespace TMPro;

public class TMP_TextElement
{
	[SerializeField]
	internal TextElementType m_ElementType; //Field offset: 0x8
	[SerializeField]
	internal uint m_Unicode; //Field offset: 0xC
	internal TMP_Asset m_TextAsset; //Field offset: 0x10
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

	public TMP_Asset textAsset
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public uint unicode
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public TMP_TextElement() { }

	public TextElementType get_elementType() { }

	public Glyph get_glyph() { }

	public uint get_glyphIndex() { }

	public float get_scale() { }

	public TMP_Asset get_textAsset() { }

	public uint get_unicode() { }

	public void set_glyph(Glyph value) { }

	public void set_glyphIndex(uint value) { }

	public void set_scale(float value) { }

	public void set_textAsset(TMP_Asset value) { }

	public void set_unicode(uint value) { }

}


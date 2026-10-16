namespace TMPro;

[DebuggerDisplay("{DebuggerDisplay()}")]
internal struct TextProcessingElement
{
	private TextProcessingElementType m_ElementType; //Field offset: 0x0
	private int m_StartIndex; //Field offset: 0x4
	private int m_Length; //Field offset: 0x8
	private CharacterElement m_CharacterElement; //Field offset: 0xC
	private MarkupElement m_MarkupElement; //Field offset: 0x14

	public CharacterElement CharacterElement
	{
		 get { } //Length: 14
	}

	public TextProcessingElementType ElementType
	{
		 get { } //Length: 10
		 set { } //Length: 13
	}

	public int Length
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public MarkupElement MarkupElement
	{
		 get { } //Length: 11
		 set { } //Length: 47
	}

	public int StartIndex
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public static TextProcessingElement Undefined
	{
		 get { } //Length: 19
	}

	public TextProcessingElement(TextProcessingElementType elementType, int startIndex, int length) { }

	public TextProcessingElement(TMP_TextElement textElement, int startIndex, int length) { }

	public TextProcessingElement(CharacterElement characterElement, int startIndex, int length) { }

	public TextProcessingElement(MarkupElement markupElement) { }

	private string DebuggerDisplay() { }

	public CharacterElement get_CharacterElement() { }

	public TextProcessingElementType get_ElementType() { }

	public int get_Length() { }

	public MarkupElement get_MarkupElement() { }

	public int get_StartIndex() { }

	public static TextProcessingElement get_Undefined() { }

	public void set_ElementType(TextProcessingElementType value) { }

	public void set_Length(int value) { }

	public void set_MarkupElement(MarkupElement value) { }

	public void set_StartIndex(int value) { }

}


namespace TMPro;

[DebuggerDisplay("Unicode '{character}'  ({((uint)character).ToString(\"X\")})")]
public struct TMP_CharacterInfo
{
	public TMP_TextElementType elementType; //Field offset: 0x0
	public char character; //Field offset: 0x4
	public int index; //Field offset: 0x8
	public int stringLength; //Field offset: 0xC
	public TMP_TextElement textElement; //Field offset: 0x10
	public Glyph alternativeGlyph; //Field offset: 0x14
	public TMP_FontAsset fontAsset; //Field offset: 0x18
	public Material material; //Field offset: 0x1C
	public int materialReferenceIndex; //Field offset: 0x20
	public bool isUsingAlternateTypeface; //Field offset: 0x24
	public float pointSize; //Field offset: 0x28
	public int lineNumber; //Field offset: 0x2C
	public int pageNumber; //Field offset: 0x30
	public int vertexIndex; //Field offset: 0x34
	public TMP_Vertex vertex_BL; //Field offset: 0x38
	public TMP_Vertex vertex_TL; //Field offset: 0x60
	public TMP_Vertex vertex_TR; //Field offset: 0x88
	public TMP_Vertex vertex_BR; //Field offset: 0xB0
	public Vector3 topLeft; //Field offset: 0xD8
	public Vector3 bottomLeft; //Field offset: 0xE4
	public Vector3 topRight; //Field offset: 0xF0
	public Vector3 bottomRight; //Field offset: 0xFC
	public float origin; //Field offset: 0x108
	public float xAdvance; //Field offset: 0x10C
	public float ascender; //Field offset: 0x110
	public float baseLine; //Field offset: 0x114
	public float descender; //Field offset: 0x118
	internal float adjustedAscender; //Field offset: 0x11C
	internal float adjustedDescender; //Field offset: 0x120
	internal float adjustedHorizontalAdvance; //Field offset: 0x124
	public float aspectRatio; //Field offset: 0x128
	public float scale; //Field offset: 0x12C
	public Color32 color; //Field offset: 0x130
	public Color32 underlineColor; //Field offset: 0x134
	public int underlineVertexIndex; //Field offset: 0x138
	public Color32 strikethroughColor; //Field offset: 0x13C
	public int strikethroughVertexIndex; //Field offset: 0x140
	public Color32 highlightColor; //Field offset: 0x144
	public HighlightState highlightState; //Field offset: 0x148
	public FontStyles style; //Field offset: 0x15C
	public bool isVisible; //Field offset: 0x160

}


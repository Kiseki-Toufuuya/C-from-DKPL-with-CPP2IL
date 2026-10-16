namespace UnityEngine.TextCore.Text;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct TextElementInfo
{
	public uint character; //Field offset: 0x0
	public int index; //Field offset: 0x4
	public TextElementType elementType; //Field offset: 0x8
	public int stringLength; //Field offset: 0xC
	public TextElement textElement; //Field offset: 0x10
	public Glyph alternativeGlyph; //Field offset: 0x14
	public FontAsset fontAsset; //Field offset: 0x18
	public SpriteAsset spriteAsset; //Field offset: 0x1C
	public Material material; //Field offset: 0x20
	public int materialReferenceIndex; //Field offset: 0x24
	public bool isUsingAlternateTypeface; //Field offset: 0x28
	public float pointSize; //Field offset: 0x2C
	public int lineNumber; //Field offset: 0x30
	public int vertexIndex; //Field offset: 0x34
	public TextVertex vertexTopLeft; //Field offset: 0x38
	public TextVertex vertexBottomLeft; //Field offset: 0x60
	public TextVertex vertexTopRight; //Field offset: 0x88
	public TextVertex vertexBottomRight; //Field offset: 0xB0
	public Vector3 topLeft; //Field offset: 0xD8
	public Vector3 bottomLeft; //Field offset: 0xE4
	public Vector3 topRight; //Field offset: 0xF0
	public Vector3 bottomRight; //Field offset: 0xFC
	public float origin; //Field offset: 0x108
	public float ascender; //Field offset: 0x10C
	public float baseLine; //Field offset: 0x110
	public float descender; //Field offset: 0x114
	internal float adjustedAscender; //Field offset: 0x118
	internal float adjustedDescender; //Field offset: 0x11C
	internal float adjustedHorizontalAdvance; //Field offset: 0x120
	public float xAdvance; //Field offset: 0x124
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

	public virtual string ToString() { }

}


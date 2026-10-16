namespace UnityEngine.UI;

[AddComponentMenu("UI/Legacy/Text", 100)]
[RequireComponent(typeof(CanvasRenderer))]
public class Text : MaskableGraphic, ILayoutElement
{
	protected static Material s_DefaultText; //Field offset: 0x0
	[SerializeField]
	private FontData m_FontData; //Field offset: 0x84
	[SerializeField]
	[TextArea(3, 10)]
	protected string m_Text; //Field offset: 0x88
	private TextGenerator m_TextCache; //Field offset: 0x8C
	private TextGenerator m_TextCacheForLayout; //Field offset: 0x90
	protected bool m_DisableFontTextureRebuiltCallback; //Field offset: 0x94
	private readonly UIVertex[] m_TempVerts; //Field offset: 0x98

	public bool alignByGeometry
	{
		 get { } //Length: 26
		 set { } //Length: 54
	}

	public TextAnchor alignment
	{
		 get { } //Length: 26
		 set { } //Length: 73
	}

	public TextGenerator cachedTextGenerator
	{
		 get { } //Length: 151
	}

	public TextGenerator cachedTextGeneratorForLayout
	{
		 get { } //Length: 96
	}

	public override float flexibleHeight
	{
		 get { } //Length: 7
	}

	public override float flexibleWidth
	{
		 get { } //Length: 7
	}

	public Font font
	{
		 get { } //Length: 26
		 set { } //Length: 253
	}

	public int fontSize
	{
		 get { } //Length: 26
		 set { } //Length: 73
	}

	public FontStyle fontStyle
	{
		 get { } //Length: 26
		 set { } //Length: 73
	}

	public HorizontalWrapMode horizontalOverflow
	{
		 get { } //Length: 26
		 set { } //Length: 73
	}

	public override int layoutPriority
	{
		 get { } //Length: 3
	}

	public float lineSpacing
	{
		 get { } //Length: 26
		 set { } //Length: 92
	}

	public virtual Texture mainTexture
	{
		 get { } //Length: 465
	}

	public override float minHeight
	{
		 get { } //Length: 3
	}

	public override float minWidth
	{
		 get { } //Length: 3
	}

	public float pixelsPerUnit
	{
		 get { } //Length: 329
	}

	public override float preferredHeight
	{
		 get { } //Length: 222
	}

	public override float preferredWidth
	{
		 get { } //Length: 249
	}

	public bool resizeTextForBestFit
	{
		 get { } //Length: 26
		 set { } //Length: 73
	}

	public int resizeTextMaxSize
	{
		 get { } //Length: 26
		 set { } //Length: 73
	}

	public int resizeTextMinSize
	{
		 get { } //Length: 26
		 set { } //Length: 73
	}

	public bool supportRichText
	{
		 get { } //Length: 26
		 set { } //Length: 73
	}

	public override string text
	{
		 get { } //Length: 14
		 set { } //Length: 203
	}

	public VerticalWrapMode verticalOverflow
	{
		 get { } //Length: 26
		 set { } //Length: 73
	}

	protected Text() { }

	internal void AssignDefaultFont() { }

	internal void AssignDefaultFontIfNecessary() { }

	public override void CalculateLayoutInputHorizontal() { }

	public override void CalculateLayoutInputVertical() { }

	public void FontTextureChanged() { }

	public bool get_alignByGeometry() { }

	public TextAnchor get_alignment() { }

	public TextGenerator get_cachedTextGenerator() { }

	public TextGenerator get_cachedTextGeneratorForLayout() { }

	public override float get_flexibleHeight() { }

	public override float get_flexibleWidth() { }

	public Font get_font() { }

	public int get_fontSize() { }

	public FontStyle get_fontStyle() { }

	public HorizontalWrapMode get_horizontalOverflow() { }

	public override int get_layoutPriority() { }

	public float get_lineSpacing() { }

	public virtual Texture get_mainTexture() { }

	public override float get_minHeight() { }

	public override float get_minWidth() { }

	public float get_pixelsPerUnit() { }

	public override float get_preferredHeight() { }

	public override float get_preferredWidth() { }

	public bool get_resizeTextForBestFit() { }

	public int get_resizeTextMaxSize() { }

	public int get_resizeTextMinSize() { }

	public bool get_supportRichText() { }

	public override string get_text() { }

	public VerticalWrapMode get_verticalOverflow() { }

	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnPopulateMesh(VertexHelper toFill) { }

	public void set_alignByGeometry(bool value) { }

	public void set_alignment(TextAnchor value) { }

	public void set_font(Font value) { }

	public void set_fontSize(int value) { }

	public void set_fontStyle(FontStyle value) { }

	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	public void set_lineSpacing(float value) { }

	public void set_resizeTextForBestFit(bool value) { }

	public void set_resizeTextMaxSize(int value) { }

	public void set_resizeTextMinSize(int value) { }

	public void set_supportRichText(bool value) { }

	public override void set_text(string value) { }

	public void set_verticalOverflow(VerticalWrapMode value) { }

	protected virtual void UpdateGeometry() { }

}


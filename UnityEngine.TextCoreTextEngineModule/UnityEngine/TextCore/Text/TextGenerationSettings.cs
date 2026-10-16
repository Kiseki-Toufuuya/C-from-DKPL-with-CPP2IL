namespace UnityEngine.TextCore.Text;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal class TextGenerationSettings : IEquatable<TextGenerationSettings>
{
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static Func<Boolean> IsEditorTextRenderingModeBitmap; //Field offset: 0x0
	public const bool useMaxVisibleDescender = False; //Field offset: 0x0
	public const int firstVisibleCharacter = 0; //Field offset: 0x0
	public const int maxVisibleLines = 99999; //Field offset: 0x0
	public const int maxVisibleWords = 99999; //Field offset: 0x0
	public const int maxVisibleCharacters = 99999; //Field offset: 0x0
	public const float lineSpacingMax = 0; //Field offset: 0x0
	public const float lineSpacing = 0; //Field offset: 0x0
	public const bool tagNoParsing = False; //Field offset: 0x0
	public const float fontSizeMax = 0; //Field offset: 0x0
	public const float fontSizeMin = 0; //Field offset: 0x0
	public const bool autoSize = False; //Field offset: 0x0
	public const float charWidthMaxAdj = 0; //Field offset: 0x0
	public const float wordWrappingRatio = 0.4; //Field offset: 0x0
	internal static readonly List<OTL_FeatureTag> fontFeatures; //Field offset: 0x4
	private RenderedText m_RenderedText; //Field offset: 0x8
	private string m_CachedRenderedText; //Field offset: 0x20
	public Rect screenRect; //Field offset: 0x24
	public float pixelsPerPoint; //Field offset: 0x34
	public bool isEditorRenderingModeBitmap; //Field offset: 0x38
	public FontAsset fontAsset; //Field offset: 0x3C
	public FontStyles fontStyle; //Field offset: 0x40
	public TextSettings textSettings; //Field offset: 0x44
	public TextAlignment textAlignment; //Field offset: 0x48
	public TextOverflowMode overflowMode; //Field offset: 0x4C
	public Color color; //Field offset: 0x50
	public bool shouldConvertToLinearSpace; //Field offset: 0x60
	public float fontSize; //Field offset: 0x64
	public bool emojiFallbackSupport; //Field offset: 0x68
	public bool richText; //Field offset: 0x69
	public bool isRightToLeft; //Field offset: 0x6A
	public float extraPadding; //Field offset: 0x6C
	public bool parseControlCharacters; //Field offset: 0x70
	public bool isPlaceholder; //Field offset: 0x71
	public float characterSpacing; //Field offset: 0x74
	public float wordSpacing; //Field offset: 0x78
	public float paragraphSpacing; //Field offset: 0x7C
	public TextWrappingMode textWrappingMode; //Field offset: 0x80
	public TextFontWeight fontWeight; //Field offset: 0x84
	public bool isIMGUI; //Field offset: 0x88

	public RenderedText renderedText
	{
		 get { } //Length: 28
		 set { } //Length: 60
	}

	public string text
	{
		 get { } //Length: 72
		 set { } //Length: 212
	}

	private static TextGenerationSettings() { }

	public TextGenerationSettings() { }

	public override bool Equals(TextGenerationSettings other) { }

	public virtual bool Equals(object obj) { }

	public RenderedText get_renderedText() { }

	public string get_text() { }

	public virtual int GetHashCode() { }

	public static bool op_Inequality(TextGenerationSettings left, TextGenerationSettings right) { }

	public void set_renderedText(RenderedText value) { }

	public void set_text(string value) { }

	public virtual string ToString() { }

}


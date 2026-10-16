namespace TMPro;

public abstract class TMP_Text : MaskableGraphic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<TMP_TextInfo> <>9__649_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__649_0(TMP_TextInfo <p0>) { }

	}

	internal struct CharacterSubstitution
	{
		public int index; //Field offset: 0x0
		public uint unicode; //Field offset: 0x4

		public CharacterSubstitution(int index, uint unicode) { }

	}

	internal sealed class MissingCharacterEventCallback : MulticastDelegate
	{

		public MissingCharacterEventCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int unicode, int stringIndex, string text, TMP_FontAsset fontAsset, TMP_Text textComponent, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int unicode, int stringIndex, string text, TMP_FontAsset fontAsset, TMP_Text textComponent) { }

	}

	internal struct SpecialCharacter
	{
		public TMP_Character character; //Field offset: 0x0
		public TMP_FontAsset fontAsset; //Field offset: 0x4
		public Material material; //Field offset: 0x8
		public int materialIndex; //Field offset: 0xC

		public SpecialCharacter(TMP_Character character, int materialIndex) { }

	}

	[DefaultMember("Item")]
	private struct TextBackingContainer
	{
		private UInt32[] m_Array; //Field offset: 0x0
		private int m_Index; //Field offset: 0x4

		public int Capacity
		{
			 get { } //Length: 22
		}

		public int Count
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public uint Item
		{
			 get { } //Length: 35
			 set { } //Length: 66
		}

		public UInt32[] Text
		{
			 get { } //Length: 10
		}

		public TextBackingContainer(int size) { }

		public int get_Capacity() { }

		public int get_Count() { }

		public uint get_Item(int index) { }

		public UInt32[] get_Text() { }

		public void Resize(int size) { }

		public void set_Count(int value) { }

		public void set_Item(int index, uint value) { }

	}

	public enum TextInputSources
	{
		TextInputBox = 0,
		SetText = 1,
		SetTextArray = 2,
		TextString = 3,
	}

	[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
	public struct TextProcessingElement
	{
		public TextProcessingElementType elementType; //Field offset: 0x0
		public uint unicode; //Field offset: 0x4
		public int stringIndex; //Field offset: 0x8
		public int length; //Field offset: 0xC

	}

	protected static MaterialReference[] m_materialReferences; //Field offset: 0x0
	protected static Dictionary<Int32, Int32> m_materialReferenceIndexLookup; //Field offset: 0x4
	protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; //Field offset: 0x8
	protected static Color32 s_colorWhite; //Field offset: 0x3C
	[CompilerGenerated]
	private static Func<Int32, String, TMP_FontAsset> OnFontAssetRequest; //Field offset: 0x40
	[CompilerGenerated]
	private static Func<Int32, String, TMP_SpriteAsset> OnSpriteAssetRequest; //Field offset: 0x44
	[CompilerGenerated]
	private static MissingCharacterEventCallback OnMissingCharacter; //Field offset: 0x48
	private static Char[] m_htmlTag; //Field offset: 0x4C
	private static RichTextTagAttribute[] m_xmlAttribute; //Field offset: 0x50
	private static Single[] m_attributeParameterValues; //Field offset: 0x54
	internal static WordWrapState m_SavedWordWrapState; //Field offset: 0x58
	internal static WordWrapState m_SavedLineState; //Field offset: 0x358
	internal static WordWrapState m_SavedEllipsisState; //Field offset: 0x658
	internal static WordWrapState m_SavedLastValidState; //Field offset: 0x958
	internal static WordWrapState m_SavedSoftLineBreakState; //Field offset: 0xC58
	internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; //Field offset: 0xF58
	[SerializeField]
	[TextArea(5, 10)]
	protected string m_text; //Field offset: 0x84
	private bool m_IsTextBackingStringDirty; //Field offset: 0x88
	[SerializeField]
	protected ITextPreprocessor m_TextPreprocessor; //Field offset: 0x8C
	[SerializeField]
	protected bool m_isRightToLeft; //Field offset: 0x90
	[SerializeField]
	protected TMP_FontAsset m_fontAsset; //Field offset: 0x94
	protected TMP_FontAsset m_currentFontAsset; //Field offset: 0x98
	protected bool m_isSDFShader; //Field offset: 0x9C
	[SerializeField]
	protected Material m_sharedMaterial; //Field offset: 0xA0
	protected Material m_currentMaterial; //Field offset: 0xA4
	protected int m_currentMaterialIndex; //Field offset: 0xA8
	[SerializeField]
	protected Material[] m_fontSharedMaterials; //Field offset: 0xAC
	[SerializeField]
	protected Material m_fontMaterial; //Field offset: 0xB0
	[SerializeField]
	protected Material[] m_fontMaterials; //Field offset: 0xB4
	protected bool m_isMaterialDirty; //Field offset: 0xB8
	[SerializeField]
	protected Color32 m_fontColor32; //Field offset: 0xBC
	[SerializeField]
	protected Color m_fontColor; //Field offset: 0xC0
	protected Color32 m_underlineColor; //Field offset: 0xD0
	protected Color32 m_strikethroughColor; //Field offset: 0xD4
	internal HighlightState m_HighlightState; //Field offset: 0xD8
	internal bool m_ConvertToLinearSpace; //Field offset: 0xEC
	[SerializeField]
	protected bool m_enableVertexGradient; //Field offset: 0xED
	[SerializeField]
	protected ColorMode m_colorMode; //Field offset: 0xF0
	[SerializeField]
	protected VertexGradient m_fontColorGradient; //Field offset: 0xF4
	[SerializeField]
	protected TMP_ColorGradient m_fontColorGradientPreset; //Field offset: 0x134
	[SerializeField]
	protected TMP_SpriteAsset m_spriteAsset; //Field offset: 0x138
	[SerializeField]
	protected bool m_tintAllSprites; //Field offset: 0x13C
	protected bool m_tintSprite; //Field offset: 0x13D
	protected Color32 m_spriteColor; //Field offset: 0x140
	[SerializeField]
	protected TMP_StyleSheet m_StyleSheet; //Field offset: 0x144
	internal TMP_Style m_TextStyle; //Field offset: 0x148
	[SerializeField]
	protected int m_TextStyleHashCode; //Field offset: 0x14C
	[SerializeField]
	protected bool m_overrideHtmlColors; //Field offset: 0x150
	[SerializeField]
	protected Color32 m_faceColor; //Field offset: 0x154
	protected Color32 m_outlineColor; //Field offset: 0x158
	protected float m_outlineWidth; //Field offset: 0x15C
	protected Vector3 m_currentEnvMapRotation; //Field offset: 0x160
	protected bool m_hasEnvMapProperty; //Field offset: 0x16C
	[SerializeField]
	protected float m_fontSize; //Field offset: 0x170
	protected float m_currentFontSize; //Field offset: 0x174
	[SerializeField]
	protected float m_fontSizeBase; //Field offset: 0x178
	protected TMP_TextProcessingStack<Single> m_sizeStack; //Field offset: 0x17C
	[SerializeField]
	protected FontWeight m_fontWeight; //Field offset: 0x194
	protected FontWeight m_FontWeightInternal; //Field offset: 0x198
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; //Field offset: 0x19C
	[SerializeField]
	protected bool m_enableAutoSizing; //Field offset: 0x1B4
	protected float m_maxFontSize; //Field offset: 0x1B8
	protected float m_minFontSize; //Field offset: 0x1BC
	protected int m_AutoSizeIterationCount; //Field offset: 0x1C0
	protected int m_AutoSizeMaxIterationCount; //Field offset: 0x1C4
	protected bool m_IsAutoSizePointSizeSet; //Field offset: 0x1C8
	[SerializeField]
	protected float m_fontSizeMin; //Field offset: 0x1CC
	[SerializeField]
	protected float m_fontSizeMax; //Field offset: 0x1D0
	[SerializeField]
	protected FontStyles m_fontStyle; //Field offset: 0x1D4
	protected FontStyles m_FontStyleInternal; //Field offset: 0x1D8
	protected TMP_FontStyleStack m_fontStyleStack; //Field offset: 0x1DC
	protected bool m_isUsingBold; //Field offset: 0x1E6
	[SerializeField]
	protected HorizontalAlignmentOptions m_HorizontalAlignment; //Field offset: 0x1E8
	[SerializeField]
	protected VerticalAlignmentOptions m_VerticalAlignment; //Field offset: 0x1EC
	[FormerlySerializedAs("m_lineJustification")]
	[SerializeField]
	protected TextAlignmentOptions m_textAlignment; //Field offset: 0x1F0
	protected HorizontalAlignmentOptions m_lineJustification; //Field offset: 0x1F4
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; //Field offset: 0x1F8
	protected Vector3[] m_textContainerLocalCorners; //Field offset: 0x210
	[SerializeField]
	protected float m_characterSpacing; //Field offset: 0x214
	protected float m_cSpacing; //Field offset: 0x218
	protected float m_monoSpacing; //Field offset: 0x21C
	protected bool m_duoSpace; //Field offset: 0x220
	[SerializeField]
	 float m_characterHorizontalScale; //Field offset: 0x224
	[SerializeField]
	protected float m_wordSpacing; //Field offset: 0x228
	[SerializeField]
	protected float m_lineSpacing; //Field offset: 0x22C
	protected float m_lineSpacingDelta; //Field offset: 0x230
	protected float m_lineHeight; //Field offset: 0x234
	protected bool m_IsDrivenLineSpacing; //Field offset: 0x238
	[SerializeField]
	protected float m_lineSpacingMax; //Field offset: 0x23C
	[SerializeField]
	protected float m_paragraphSpacing; //Field offset: 0x240
	[SerializeField]
	protected float m_charWidthMaxAdj; //Field offset: 0x244
	protected float m_charWidthAdjDelta; //Field offset: 0x248
	[FormerlySerializedAs("m_enableWordWrapping")]
	[SerializeField]
	protected TextWrappingModes m_TextWrappingMode; //Field offset: 0x24C
	protected bool m_isCharacterWrappingEnabled; //Field offset: 0x250
	protected bool m_isNonBreakingSpace; //Field offset: 0x251
	protected bool m_isIgnoringAlignment; //Field offset: 0x252
	[SerializeField]
	protected float m_wordWrappingRatios; //Field offset: 0x254
	[SerializeField]
	protected TextOverflowModes m_overflowMode; //Field offset: 0x258
	protected int m_firstOverflowCharacterIndex; //Field offset: 0x25C
	[SerializeField]
	protected TMP_Text m_linkedTextComponent; //Field offset: 0x260
	[SerializeField]
	internal TMP_Text parentLinkedComponent; //Field offset: 0x264
	protected bool m_isTextTruncated; //Field offset: 0x268
	[SerializeField]
	protected bool m_enableKerning; //Field offset: 0x269
	private static ProfilerMarker k_ParseTextMarker; //Field offset: 0x126C
	protected int m_LastBaseGlyphIndex; //Field offset: 0x26C
	private static ProfilerMarker k_InsertNewLineMarker; //Field offset: 0x1270
	[SerializeField]
	protected List<OTL_FeatureTag> m_ActiveFontFeatures; //Field offset: 0x270
	protected static Vector2 k_LargePositiveVector2; //Field offset: 0x1274
	[SerializeField]
	protected bool m_enableExtraPadding; //Field offset: 0x274
	[SerializeField]
	protected bool checkPaddingRequired; //Field offset: 0x275
	[SerializeField]
	protected bool m_isRichText; //Field offset: 0x276
	[SerializeField]
	private bool m_EmojiFallbackSupport; //Field offset: 0x277
	[SerializeField]
	protected bool m_parseCtrlCharacters; //Field offset: 0x278
	protected bool m_isOverlay; //Field offset: 0x279
	[SerializeField]
	protected bool m_isOrthographic; //Field offset: 0x27A
	[SerializeField]
	protected bool m_isCullingEnabled; //Field offset: 0x27B
	protected bool m_isMaskingEnabled; //Field offset: 0x27C
	protected static Vector2 k_LargeNegativeVector2; //Field offset: 0x127C
	protected bool isMaskUpdateRequired; //Field offset: 0x27D
	protected bool m_ignoreCulling; //Field offset: 0x27E
	[SerializeField]
	protected TextureMappingOptions m_horizontalMapping; //Field offset: 0x280
	protected static float k_LargePositiveFloat; //Field offset: 0x1284
	[SerializeField]
	protected TextureMappingOptions m_verticalMapping; //Field offset: 0x284
	protected static float k_LargeNegativeFloat; //Field offset: 0x1288
	[SerializeField]
	protected float m_uvLineOffset; //Field offset: 0x288
	protected static int k_LargePositiveInt; //Field offset: 0x128C
	protected TextRenderFlags m_renderMode; //Field offset: 0x28C
	protected static int k_LargeNegativeInt; //Field offset: 0x1290
	[SerializeField]
	protected VertexSortingOrder m_geometrySortingOrder; //Field offset: 0x290
	[SerializeField]
	protected bool m_IsTextObjectScaleStatic; //Field offset: 0x294
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction; //Field offset: 0x295
	protected int m_firstVisibleCharacter; //Field offset: 0x298
	protected int m_maxVisibleCharacters; //Field offset: 0x29C
	protected int m_maxVisibleWords; //Field offset: 0x2A0
	protected int m_maxVisibleLines; //Field offset: 0x2A4
	[SerializeField]
	protected bool m_useMaxVisibleDescender; //Field offset: 0x2A8
	[SerializeField]
	protected int m_pageToDisplay; //Field offset: 0x2AC
	protected bool m_isNewPage; //Field offset: 0x2B0
	[SerializeField]
	protected Vector4 m_margin; //Field offset: 0x2B4
	protected float m_marginLeft; //Field offset: 0x2C4
	protected float m_marginRight; //Field offset: 0x2C8
	protected float m_marginWidth; //Field offset: 0x2CC
	protected float m_marginHeight; //Field offset: 0x2D0
	protected float m_width; //Field offset: 0x2D4
	protected TMP_TextInfo m_textInfo; //Field offset: 0x2D8
	protected bool m_havePropertiesChanged; //Field offset: 0x2DC
	[SerializeField]
	protected bool m_isUsingLegacyAnimationComponent; //Field offset: 0x2DD
	protected Transform m_transform; //Field offset: 0x2E0
	protected RectTransform m_rectTransform; //Field offset: 0x2E4
	protected Vector2 m_PreviousRectTransformSize; //Field offset: 0x2E8
	protected Vector2 m_PreviousPivotPosition; //Field offset: 0x2F0
	[CompilerGenerated]
	private bool <autoSizeTextContainer>k__BackingField; //Field offset: 0x2F8
	protected bool m_autoSizeTextContainer; //Field offset: 0x2F9
	protected Mesh m_mesh; //Field offset: 0x2FC
	[SerializeField]
	protected bool m_isVolumetricText; //Field offset: 0x300
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; //Field offset: 0x304
	protected TMP_SpriteAnimator m_spriteAnimator; //Field offset: 0x308
	protected float m_flexibleHeight; //Field offset: 0x30C
	protected float m_flexibleWidth; //Field offset: 0x310
	protected float m_minWidth; //Field offset: 0x314
	protected float m_minHeight; //Field offset: 0x318
	protected float m_maxWidth; //Field offset: 0x31C
	protected float m_maxHeight; //Field offset: 0x320
	protected LayoutElement m_LayoutElement; //Field offset: 0x324
	protected float m_preferredWidth; //Field offset: 0x328
	protected float m_RenderedWidth; //Field offset: 0x32C
	protected bool m_isPreferredWidthDirty; //Field offset: 0x330
	protected float m_preferredHeight; //Field offset: 0x334
	protected float m_RenderedHeight; //Field offset: 0x338
	protected bool m_isPreferredHeightDirty; //Field offset: 0x33C
	protected bool m_isCalculatingPreferredValues; //Field offset: 0x33D
	protected int m_layoutPriority; //Field offset: 0x340
	protected bool m_isLayoutDirty; //Field offset: 0x344
	protected bool m_isAwake; //Field offset: 0x345
	internal bool m_isWaitingOnResourceLoad; //Field offset: 0x346
	internal TextInputSources m_inputSource; //Field offset: 0x348
	protected float m_fontScaleMultiplier; //Field offset: 0x34C
	protected float tag_LineIndent; //Field offset: 0x350
	protected float tag_Indent; //Field offset: 0x354
	protected TMP_TextProcessingStack<Single> m_indentStack; //Field offset: 0x358
	protected bool tag_NoParsing; //Field offset: 0x370
	protected bool m_isTextLayoutPhase; //Field offset: 0x371
	protected Quaternion m_FXRotation; //Field offset: 0x374
	protected Vector3 m_FXScale; //Field offset: 0x384
	internal TextProcessingElement[] m_TextProcessingArray; //Field offset: 0x390
	internal int m_InternalTextProcessingArraySize; //Field offset: 0x394
	private TMP_CharacterInfo[] m_internalCharacterInfo; //Field offset: 0x398
	protected int m_totalCharacterCount; //Field offset: 0x39C
	protected int m_characterCount; //Field offset: 0x3A0
	protected int m_firstCharacterOfLine; //Field offset: 0x3A4
	protected int m_firstVisibleCharacterOfLine; //Field offset: 0x3A8
	protected int m_lastCharacterOfLine; //Field offset: 0x3AC
	protected int m_lastVisibleCharacterOfLine; //Field offset: 0x3B0
	protected int m_lineNumber; //Field offset: 0x3B4
	protected int m_lineVisibleCharacterCount; //Field offset: 0x3B8
	protected int m_lineVisibleSpaceCount; //Field offset: 0x3BC
	protected int m_pageNumber; //Field offset: 0x3C0
	protected float m_PageAscender; //Field offset: 0x3C4
	protected float m_maxTextAscender; //Field offset: 0x3C8
	protected float m_maxCapHeight; //Field offset: 0x3CC
	protected float m_ElementAscender; //Field offset: 0x3D0
	protected float m_ElementDescender; //Field offset: 0x3D4
	protected float m_maxLineAscender; //Field offset: 0x3D8
	protected float m_maxLineDescender; //Field offset: 0x3DC
	protected float m_startOfLineAscender; //Field offset: 0x3E0
	protected float m_startOfLineDescender; //Field offset: 0x3E4
	protected float m_lineOffset; //Field offset: 0x3E8
	protected Extents m_meshExtents; //Field offset: 0x3EC
	protected Color32 m_htmlColor; //Field offset: 0x3FC
	protected TMP_TextProcessingStack<Color32> m_colorStack; //Field offset: 0x400
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; //Field offset: 0x418
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; //Field offset: 0x430
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; //Field offset: 0x448
	protected TMP_ColorGradient m_colorGradientPreset; //Field offset: 0x470
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; //Field offset: 0x474
	protected bool m_colorGradientPresetIsTinted; //Field offset: 0x48C
	protected float m_tabSpacing; //Field offset: 0x490
	protected float m_spacing; //Field offset: 0x494
	protected TMP_TextProcessingStack<Int32>[] m_TextStyleStacks; //Field offset: 0x498
	protected int m_TextStyleStackDepth; //Field offset: 0x49C
	protected TMP_TextProcessingStack<Int32> m_ItalicAngleStack; //Field offset: 0x4A0
	protected int m_ItalicAngle; //Field offset: 0x4B8
	protected TMP_TextProcessingStack<Int32> m_actionStack; //Field offset: 0x4BC
	protected float m_padding; //Field offset: 0x4D4
	protected float m_baselineOffset; //Field offset: 0x4D8
	protected TMP_TextProcessingStack<Single> m_baselineOffsetStack; //Field offset: 0x4DC
	protected float m_xAdvance; //Field offset: 0x4F4
	protected TMP_TextElementType m_textElementType; //Field offset: 0x4F8
	protected TMP_TextElement m_cached_TextElement; //Field offset: 0x4FC
	protected SpecialCharacter m_Ellipsis; //Field offset: 0x500
	protected SpecialCharacter m_Underline; //Field offset: 0x510
	protected TMP_SpriteAsset m_defaultSpriteAsset; //Field offset: 0x520
	protected TMP_SpriteAsset m_currentSpriteAsset; //Field offset: 0x524
	protected int m_spriteCount; //Field offset: 0x528
	protected int m_spriteIndex; //Field offset: 0x52C
	protected int m_spriteAnimationID; //Field offset: 0x530
	protected bool m_ignoreActiveState; //Field offset: 0x534
	private TextBackingContainer m_TextBackingArray; //Field offset: 0x538
	private readonly Decimal[] k_Power; //Field offset: 0x540

	public static event Func<Int32, String, TMP_FontAsset> OnFontAssetRequest
	{
		[CompilerGenerated]
		 add { } //Length: 196
		[CompilerGenerated]
		 remove { } //Length: 196
	}

	public static event MissingCharacterEventCallback OnMissingCharacter
	{
		[CompilerGenerated]
		 add { } //Length: 177
		[CompilerGenerated]
		 remove { } //Length: 177
	}

	public override event Action<TMP_TextInfo> OnPreRenderText
	{
		[CompilerGenerated]
		 add { } //Length: 130
		[CompilerGenerated]
		 remove { } //Length: 130
	}

	public static event Func<Int32, String, TMP_SpriteAsset> OnSpriteAssetRequest
	{
		[CompilerGenerated]
		 add { } //Length: 196
		[CompilerGenerated]
		 remove { } //Length: 196
	}

	public TextAlignmentOptions alignment
	{
		 get { } //Length: 20
		 set { } //Length: 74
	}

	public float alpha
	{
		 get { } //Length: 14
		 set { } //Length: 65
	}

	public override bool autoSizeTextContainer
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public Bounds bounds
	{
		 get { } //Length: 154
	}

	public float characterHorizontalScale
	{
		 get { } //Length: 14
		 set { } //Length: 84
	}

	public float characterSpacing
	{
		 get { } //Length: 14
		 set { } //Length: 84
	}

	public float characterWidthAdjustment
	{
		 get { } //Length: 14
		 set { } //Length: 84
	}

	public virtual Color color
	{
		 get { } //Length: 21
		 set { } //Length: 135
	}

	public VertexGradient colorGradient
	{
		 get { } //Length: 54
		 set { } //Length: 79
	}

	public TMP_ColorGradient colorGradientPreset
	{
		 get { } //Length: 14
		 set { } //Length: 59
	}

	public bool emojiFallbackSupport
	{
		 get { } //Length: 14
		 set { } //Length: 71
	}

	public bool enableAutoSizing
	{
		 get { } //Length: 14
		 set { } //Length: 64
	}

	public bool enableCulling
	{
		 get { } //Length: 14
		 set { } //Length: 54
	}

	[Obsolete("The \"enableKerning\" property has been deprecated. Use the \"fontFeatures\" property to control what features are enabled on the text component.")]
	public bool enableKerning
	{
		 get { } //Length: 72
		 set { } //Length: 229
	}

	public bool enableVertexGradient
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	[Obsolete("The enabledWordWrapping property is now obsolete. Please use the textWrappingMode property instead.")]
	public bool enableWordWrapping
	{
		 get { } //Length: 31
		 set { } //Length: 72
	}

	public bool extraPadding
	{
		 get { } //Length: 14
		 set { } //Length: 71
	}

	public Color32 faceColor
	{
		 get { } //Length: 199
		 set { } //Length: 104
	}

	public int firstOverflowCharacterIndex
	{
		 get { } //Length: 14
	}

	public int firstVisibleCharacter
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public override float flexibleHeight
	{
		 get { } //Length: 14
	}

	public override float flexibleWidth
	{
		 get { } //Length: 14
	}

	public TMP_FontAsset font
	{
		 get { } //Length: 14
		 set { } //Length: 168
	}

	public List<OTL_FeatureTag> fontFeatures
	{
		 get { } //Length: 14
		 set { } //Length: 80
	}

	public Material fontMaterial
	{
		 get { } //Length: 34
		 set { } //Length: 230
	}

	public override Material[] fontMaterials
	{
		 get { } //Length: 34
		 set { } //Length: 74
	}

	public override Material fontSharedMaterial
	{
		 get { } //Length: 14
		 set { } //Length: 149
	}

	public override Material[] fontSharedMaterials
	{
		 get { } //Length: 28
		 set { } //Length: 74
	}

	public float fontSize
	{
		 get { } //Length: 14
		 set { } //Length: 101
	}

	public float fontSizeMax
	{
		 get { } //Length: 14
		 set { } //Length: 77
	}

	public float fontSizeMin
	{
		 get { } //Length: 14
		 set { } //Length: 77
	}

	public FontStyles fontStyle
	{
		 get { } //Length: 14
		 set { } //Length: 71
	}

	public FontWeight fontWeight
	{
		 get { } //Length: 14
		 set { } //Length: 71
	}

	public VertexSortingOrder geometrySortingOrder
	{
		 get { } //Length: 14
		 set { } //Length: 44
	}

	public bool havePropertiesChanged
	{
		 get { } //Length: 14
		 set { } //Length: 45
	}

	public HorizontalAlignmentOptions horizontalAlignment
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public TextureMappingOptions horizontalMapping
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public bool ignoreVisibility
	{
		 get { } //Length: 14
		 set { } //Length: 32
	}

	public bool isOrthographic
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public bool isOverlay
	{
		 get { } //Length: 14
		 set { } //Length: 71
	}

	public bool isRightToLeftText
	{
		 get { } //Length: 14
		 set { } //Length: 71
	}

	public bool isTextObjectScaleStatic
	{
		 get { } //Length: 14
		 set { } //Length: 112
	}

	public bool isTextOverflowing
	{
		 get { } //Length: 18
	}

	public bool isTextTruncated
	{
		 get { } //Length: 14
	}

	public bool isUsingBold
	{
		 get { } //Length: 14
	}

	public bool isUsingLegacyAnimationComponent
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool isVolumetricText
	{
		 get { } //Length: 14
		 set { } //Length: 88
	}

	protected LayoutElement layoutElement
	{
		 get { } //Length: 134
	}

	public override int layoutPriority
	{
		 get { } //Length: 14
	}

	public float lineSpacing
	{
		 get { } //Length: 14
		 set { } //Length: 84
	}

	public float lineSpacingAdjustment
	{
		 get { } //Length: 14
		 set { } //Length: 84
	}

	public TMP_Text linkedTextComponent
	{
		 get { } //Length: 14
		 set { } //Length: 245
	}

	public float mappingUvLineOffset
	{
		 get { } //Length: 14
		 set { } //Length: 65
	}

	public override Vector4 margin
	{
		 get { } //Length: 21
		 set { } //Length: 154
	}

	public float maxHeight
	{
		 get { } //Length: 14
	}

	public int maxVisibleCharacters
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public int maxVisibleLines
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public int maxVisibleWords
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public float maxWidth
	{
		 get { } //Length: 14
	}

	public override Mesh mesh
	{
		 get { } //Length: 14
	}

	public override float minHeight
	{
		 get { } //Length: 14
	}

	public override float minWidth
	{
		 get { } //Length: 14
	}

	public Color32 outlineColor
	{
		 get { } //Length: 199
		 set { } //Length: 87
	}

	public float outlineWidth
	{
		 get { } //Length: 180
		 set { } //Length: 95
	}

	public TextOverflowModes overflowMode
	{
		 get { } //Length: 14
		 set { } //Length: 71
	}

	public bool overrideColorTags
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public int pageToDisplay
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public float paragraphSpacing
	{
		 get { } //Length: 14
		 set { } //Length: 84
	}

	public bool parseCtrlCharacters
	{
		 get { } //Length: 14
		 set { } //Length: 71
	}

	public float pixelsPerUnit
	{
		 get { } //Length: 420
	}

	public override float preferredHeight
	{
		 get { } //Length: 40
	}

	public override float preferredWidth
	{
		 get { } //Length: 40
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 134
	}

	public override float renderedHeight
	{
		 get { } //Length: 55
	}

	public override float renderedWidth
	{
		 get { } //Length: 55
	}

	public TextRenderFlags renderMode
	{
		 get { } //Length: 14
		 set { } //Length: 32
	}

	public bool richText
	{
		 get { } //Length: 14
		 set { } //Length: 71
	}

	protected TMP_SpriteAnimator spriteAnimator
	{
		 get { } //Length: 241
	}

	public TMP_SpriteAsset spriteAsset
	{
		 get { } //Length: 14
		 set { } //Length: 76
	}

	public TMP_StyleSheet styleSheet
	{
		 get { } //Length: 14
		 set { } //Length: 76
	}

	public override string text
	{
		 get { } //Length: 208
		 set { } //Length: 152
	}

	public Bounds textBounds
	{
		 get { } //Length: 76
	}

	public TMP_TextInfo textInfo
	{
		 get { } //Length: 100
	}

	public ITextPreprocessor textPreprocessor
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public TMP_Style textStyle
	{
		 get { } //Length: 114
		 set { } //Length: 103
	}

	public TextWrappingModes textWrappingMode
	{
		 get { } //Length: 14
		 set { } //Length: 71
	}

	public bool tintAllSprites
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public Transform transform
	{
		 get { } //Length: 134
	}

	public bool useMaxVisibleDescender
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public bool vertexBufferAutoSizeReduction
	{
		 get { } //Length: 14
		 set { } //Length: 44
	}

	public VerticalAlignmentOptions verticalAlignment
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public TextureMappingOptions verticalMapping
	{
		 get { } //Length: 14
		 set { } //Length: 52
	}

	public float wordSpacing
	{
		 get { } //Length: 14
		 set { } //Length: 84
	}

	public float wordWrappingRatios
	{
		 get { } //Length: 14
		 set { } //Length: 84
	}

	private static TMP_Text() { }

	protected TMP_Text() { }

	[CompilerGenerated]
	public static void add_OnFontAssetRequest(Func<Int32, String, TMP_FontAsset> value) { }

	[CompilerGenerated]
	public static void add_OnMissingCharacter(MissingCharacterEventCallback value) { }

	[CompilerGenerated]
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	public static void add_OnSpriteAssetRequest(Func<Int32, String, TMP_SpriteAsset> value) { }

	private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) { }

	private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) { }

	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	protected override Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingModes textWrapMode) { }

	private void ClearMarkupTagAttributes() { }

	public override void ClearMesh(bool uploadGeometry) { }

	public override void ClearMesh() { }

	public override void ComputeMarginSize() { }

	protected float ConvertToFloat(Char[] chars, int startIndex, int length, out int lastIndex) { }

	protected float ConvertToFloat(Char[] chars, int startIndex, int length) { }

	protected override Material CreateMaterialInstance(Material source) { }

	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	protected override void DestroySubMeshObjects() { }

	protected void DoMissingGlyphCallback(int unicode, int stringIndex, TMP_FontAsset fontAsset) { }

	protected override void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	protected override void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	protected override void FillCharacterVertexBuffers(int i, bool isVolumetric) { }

	protected override void FillCharacterVertexBuffers(int i) { }

	protected override void FillSpriteVertexBuffers(int i) { }

	public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false) { }

	public TextAlignmentOptions get_alignment() { }

	public float get_alpha() { }

	[CompilerGenerated]
	public override bool get_autoSizeTextContainer() { }

	public Bounds get_bounds() { }

	public float get_characterHorizontalScale() { }

	public float get_characterSpacing() { }

	public float get_characterWidthAdjustment() { }

	public virtual Color get_color() { }

	public VertexGradient get_colorGradient() { }

	public TMP_ColorGradient get_colorGradientPreset() { }

	public bool get_emojiFallbackSupport() { }

	public bool get_enableAutoSizing() { }

	public bool get_enableCulling() { }

	public bool get_enableKerning() { }

	public bool get_enableVertexGradient() { }

	public bool get_enableWordWrapping() { }

	public bool get_extraPadding() { }

	public Color32 get_faceColor() { }

	public int get_firstOverflowCharacterIndex() { }

	public int get_firstVisibleCharacter() { }

	public override float get_flexibleHeight() { }

	public override float get_flexibleWidth() { }

	public TMP_FontAsset get_font() { }

	public List<OTL_FeatureTag> get_fontFeatures() { }

	public Material get_fontMaterial() { }

	public override Material[] get_fontMaterials() { }

	public override Material get_fontSharedMaterial() { }

	public override Material[] get_fontSharedMaterials() { }

	public float get_fontSize() { }

	public float get_fontSizeMax() { }

	public float get_fontSizeMin() { }

	public FontStyles get_fontStyle() { }

	public FontWeight get_fontWeight() { }

	public VertexSortingOrder get_geometrySortingOrder() { }

	public bool get_havePropertiesChanged() { }

	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	public TextureMappingOptions get_horizontalMapping() { }

	public bool get_ignoreVisibility() { }

	public bool get_isOrthographic() { }

	public bool get_isOverlay() { }

	public bool get_isRightToLeftText() { }

	public bool get_isTextObjectScaleStatic() { }

	public bool get_isTextOverflowing() { }

	public bool get_isTextTruncated() { }

	public bool get_isUsingBold() { }

	public bool get_isUsingLegacyAnimationComponent() { }

	public bool get_isVolumetricText() { }

	protected LayoutElement get_layoutElement() { }

	public override int get_layoutPriority() { }

	public float get_lineSpacing() { }

	public float get_lineSpacingAdjustment() { }

	public TMP_Text get_linkedTextComponent() { }

	public float get_mappingUvLineOffset() { }

	public override Vector4 get_margin() { }

	public float get_maxHeight() { }

	public int get_maxVisibleCharacters() { }

	public int get_maxVisibleLines() { }

	public int get_maxVisibleWords() { }

	public float get_maxWidth() { }

	public override Mesh get_mesh() { }

	public override float get_minHeight() { }

	public override float get_minWidth() { }

	public Color32 get_outlineColor() { }

	public float get_outlineWidth() { }

	public TextOverflowModes get_overflowMode() { }

	public bool get_overrideColorTags() { }

	public int get_pageToDisplay() { }

	public float get_paragraphSpacing() { }

	public bool get_parseCtrlCharacters() { }

	public float get_pixelsPerUnit() { }

	public override float get_preferredHeight() { }

	public override float get_preferredWidth() { }

	public RectTransform get_rectTransform() { }

	public override float get_renderedHeight() { }

	public override float get_renderedWidth() { }

	public TextRenderFlags get_renderMode() { }

	public bool get_richText() { }

	protected TMP_SpriteAnimator get_spriteAnimator() { }

	public TMP_SpriteAsset get_spriteAsset() { }

	public TMP_StyleSheet get_styleSheet() { }

	public override string get_text() { }

	public Bounds get_textBounds() { }

	public TMP_TextInfo get_textInfo() { }

	public ITextPreprocessor get_textPreprocessor() { }

	public TMP_Style get_textStyle() { }

	public TextWrappingModes get_textWrappingMode() { }

	public bool get_tintAllSprites() { }

	public Transform get_transform() { }

	public bool get_useMaxVisibleDescender() { }

	public bool get_vertexBufferAutoSizeReduction() { }

	public VerticalAlignmentOptions get_verticalAlignment() { }

	public TextureMappingOptions get_verticalMapping() { }

	public float get_wordSpacing() { }

	public float get_wordWrappingRatios() { }

	private int GetAttributeParameters(Char[] chars, int startIndex, int length, ref Single[] parameters) { }

	internal override Rect GetCanvasSpaceClippingRect() { }

	protected override Bounds GetCompoundBounds() { }

	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	private int GetMarkupTagHashCode(UInt32[] styleDefinition, int readIndex) { }

	private int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	protected override Material GetMaterial(Material mat) { }

	protected override Material[] GetMaterials(Material[] mats) { }

	protected override float GetPaddingForMaterial(Material mat) { }

	protected override float GetPaddingForMaterial() { }

	public override string GetParsedText() { }

	private float GetPreferredHeight(Vector2 margin) { }

	protected float GetPreferredHeight() { }

	public Vector2 GetPreferredValues() { }

	public Vector2 GetPreferredValues(float width, float height) { }

	public Vector2 GetPreferredValues(string text) { }

	public Vector2 GetPreferredValues(string text, float width, float height) { }

	private float GetPreferredWidth(Vector2 margin) { }

	private float GetPreferredWidth(Vector2 margin, TextWrappingModes wrapMode) { }

	protected float GetPreferredWidth() { }

	private float GetRenderedHeight() { }

	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	public Vector2 GetRenderedValues() { }

	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	private float GetRenderedWidth() { }

	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	protected override Material[] GetSharedMaterials() { }

	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	private TMP_Style GetStyle(int hashCode) { }

	private int GetStyleHashCode(ref UInt32[] text, int index, out int closeIndex) { }

	private int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	protected Bounds GetTextBounds() { }

	protected override Vector3[] GetTextContainerLocalCorners() { }

	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	public override TMP_TextInfo GetTextInfo(string text) { }

	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	private uint GetUTF16(TextBackingContainer text, int i) { }

	private uint GetUTF16(UInt32[] text, int i) { }

	private uint GetUTF32(TextBackingContainer text, int i) { }

	private uint GetUTF32(UInt32[] text, int i) { }

	protected Color32 HexCharsToColor(Char[] hexChars, int startIndex, int length) { }

	protected Color32 HexCharsToColor(Char[] hexChars, int tagCount) { }

	protected uint HexToInt(char hex) { }

	private void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	private void InsertClosingTextStyle(TMP_Style style, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	internal void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	private void InsertOpeningStyleTag(TMP_Style style, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	private void InsertOpeningTextStyle(TMP_Style style, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	private void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, UInt32[] styleDefinition) { }

	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	private string InternalTextBackingArrayToString() { }

	internal override void InternalUpdate() { }

	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	private bool IsValidUTF16(TextBackingContainer text, int index) { }

	private bool IsValidUTF32(TextBackingContainer text, int index) { }

	protected void LoadDefaultSettings() { }

	protected override void LoadFontAsset() { }

	protected Vector2 PackUV(float x, float y, float scale) { }

	protected float PackUV(float x, float y) { }

	protected void ParseInputText() { }

	private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) { }

	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	private void PopulateTextBackingArray(Char[] sourceText, int start, int length) { }

	private void PopulateTextBackingArray(string sourceText) { }

	private void PopulateTextProcessingArray() { }

	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	[CompilerGenerated]
	public static void remove_OnFontAssetRequest(Func<Int32, String, TMP_FontAsset> value) { }

	[CompilerGenerated]
	public static void remove_OnMissingCharacter(MissingCharacterEventCallback value) { }

	[CompilerGenerated]
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	public static void remove_OnSpriteAssetRequest(Func<Int32, String, TMP_SpriteAsset> value) { }

	private void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	private bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	private bool ReplaceOpeningStyleTag(ref UInt32[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	protected void ReplaceTagWithCharacter(Int32[] chars, int insertionIndex, int tagLength, char c) { }

	private void ResizeInternalArray(ref T[] array) { }

	private void ResizeInternalArray(ref T[] array, int size) { }

	protected void ResizeLineExtents(int size) { }

	internal int RestoreWordWrappingState(ref WordWrapState state) { }

	protected override void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	protected override void SaveSpriteVertexInfo(Color32 vertexColor) { }

	internal void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	public void set_alignment(TextAlignmentOptions value) { }

	public void set_alpha(float value) { }

	[CompilerGenerated]
	public override void set_autoSizeTextContainer(bool value) { }

	public void set_characterHorizontalScale(float value) { }

	public void set_characterSpacing(float value) { }

	public void set_characterWidthAdjustment(float value) { }

	public virtual void set_color(Color value) { }

	public void set_colorGradient(VertexGradient value) { }

	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	public void set_emojiFallbackSupport(bool value) { }

	public void set_enableAutoSizing(bool value) { }

	public void set_enableCulling(bool value) { }

	public void set_enableKerning(bool value) { }

	public void set_enableVertexGradient(bool value) { }

	public void set_enableWordWrapping(bool value) { }

	public void set_extraPadding(bool value) { }

	public void set_faceColor(Color32 value) { }

	public void set_firstVisibleCharacter(int value) { }

	public void set_font(TMP_FontAsset value) { }

	public void set_fontFeatures(List<OTL_FeatureTag> value) { }

	public void set_fontMaterial(Material value) { }

	public override void set_fontMaterials(Material[] value) { }

	public override void set_fontSharedMaterial(Material value) { }

	public override void set_fontSharedMaterials(Material[] value) { }

	public void set_fontSize(float value) { }

	public void set_fontSizeMax(float value) { }

	public void set_fontSizeMin(float value) { }

	public void set_fontStyle(FontStyles value) { }

	public void set_fontWeight(FontWeight value) { }

	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	public void set_havePropertiesChanged(bool value) { }

	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	public void set_horizontalMapping(TextureMappingOptions value) { }

	public void set_ignoreVisibility(bool value) { }

	public void set_isOrthographic(bool value) { }

	public void set_isOverlay(bool value) { }

	public void set_isRightToLeftText(bool value) { }

	public void set_isTextObjectScaleStatic(bool value) { }

	public void set_isUsingLegacyAnimationComponent(bool value) { }

	public void set_isVolumetricText(bool value) { }

	public void set_lineSpacing(float value) { }

	public void set_lineSpacingAdjustment(float value) { }

	public void set_linkedTextComponent(TMP_Text value) { }

	public void set_mappingUvLineOffset(float value) { }

	public override void set_margin(Vector4 value) { }

	public void set_maxVisibleCharacters(int value) { }

	public void set_maxVisibleLines(int value) { }

	public void set_maxVisibleWords(int value) { }

	public void set_outlineColor(Color32 value) { }

	public void set_outlineWidth(float value) { }

	public void set_overflowMode(TextOverflowModes value) { }

	public void set_overrideColorTags(bool value) { }

	public void set_pageToDisplay(int value) { }

	public void set_paragraphSpacing(float value) { }

	public void set_parseCtrlCharacters(bool value) { }

	public void set_renderMode(TextRenderFlags value) { }

	public void set_richText(bool value) { }

	public void set_spriteAsset(TMP_SpriteAsset value) { }

	public void set_styleSheet(TMP_StyleSheet value) { }

	public override void set_text(string value) { }

	public void set_textPreprocessor(ITextPreprocessor value) { }

	public void set_textStyle(TMP_Style value) { }

	public void set_textWrappingMode(TextWrappingModes value) { }

	public void set_tintAllSprites(bool value) { }

	public void set_useMaxVisibleDescender(bool value) { }

	public void set_vertexBufferAutoSizeReduction(bool value) { }

	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	public void set_verticalMapping(TextureMappingOptions value) { }

	public void set_wordSpacing(float value) { }

	public void set_wordWrappingRatios(float value) { }

	protected override void SetActiveSubMeshes(bool state) { }

	internal override int SetArraySizes(TextProcessingElement[] unicodeChars) { }

	public void SetCharArray(Char[] sourceText, int start, int length) { }

	public void SetCharArray(Char[] sourceText) { }

	protected override void SetCulling() { }

	protected override void SetFaceColor(Color32 color) { }

	protected override void SetFontBaseMaterial(Material mat) { }

	protected override void SetOutlineColor(Color32 color) { }

	protected override void SetOutlineThickness(float thickness) { }

	protected override void SetShaderDepth() { }

	protected override void SetSharedMaterial(Material mat) { }

	protected override void SetSharedMaterials(Material[] materials) { }

	public void SetText(string sourceText) { }

	public void SetText(string sourceText, float arg0, float arg1, float arg2) { }

	public void SetText(Char[] sourceText, int start, int length) { }

	public void SetText(Char[] sourceText) { }

	private void SetText(StringBuilder sourceText, int start, int length) { }

	public void SetText(StringBuilder sourceText) { }

	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	[Obsolete("Use the SetText(string) function instead.")]
	public void SetText(string sourceText, bool syncTextInputBox = true) { }

	public void SetText(string sourceText, float arg0) { }

	public void SetText(string sourceText, float arg0, float arg1) { }

	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) { }

	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	private void SetTextInternal(string sourceText) { }

	protected void SetTextSortingOrder(Int32[] order) { }

	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	public override void SetVertices(Vector3[] vertices) { }

	internal override void UpdateCulling() { }

	public override void UpdateGeometry(Mesh mesh, int index) { }

	public override void UpdateMeshPadding() { }

	public override void UpdateVertexData() { }

	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	internal bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex) { }

}


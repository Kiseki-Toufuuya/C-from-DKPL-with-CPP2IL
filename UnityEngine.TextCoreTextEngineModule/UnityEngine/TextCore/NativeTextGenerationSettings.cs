namespace UnityEngine.TextCore;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextGenerationSettings.h")]
[UsedByNativeCode("TextGenerationSettings")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct NativeTextGenerationSettings
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<TextSpan> <>9__20_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <get_hasLink>b__20_0(TextSpan span) { }

	}

	public IntPtr fontAsset; //Field offset: 0x0
	public IntPtr textSettings; //Field offset: 0x4
	public string text; //Field offset: 0x8
	public int screenWidth; //Field offset: 0xC
	public int screenHeight; //Field offset: 0x10
	public WhiteSpace wordWrap; //Field offset: 0x14
	public TextOverflow overflow; //Field offset: 0x18
	public LanguageDirection languageDirection; //Field offset: 0x1C
	public int vertexPadding; //Field offset: 0x20
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal HorizontalAlignment horizontalAlignment; //Field offset: 0x24
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal VerticalAlignment verticalAlignment; //Field offset: 0x28
	public int fontSize; //Field offset: 0x2C
	public FontStyles fontStyle; //Field offset: 0x30
	public TextFontWeight fontWeight; //Field offset: 0x34
	public TextSpan[] textSpans; //Field offset: 0x38
	public Color32 color; //Field offset: 0x3C
	public int characterSpacing; //Field offset: 0x40
	public int wordSpacing; //Field offset: 0x44
	public int paragraphSpacing; //Field offset: 0x48

	public static NativeTextGenerationSettings Default
	{
		 get { } //Length: 172
	}

	public bool hasLink
	{
		 get { } //Length: 225
	}

	[IsReadOnly]
	public TextSpan CreateTextSpan() { }

	public static NativeTextGenerationSettings get_Default() { }

	public bool get_hasLink() { }

	public virtual string ToString() { }

}


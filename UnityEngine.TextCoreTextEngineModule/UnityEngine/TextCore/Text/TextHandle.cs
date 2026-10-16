namespace UnityEngine.TextCore.Text;

[DebuggerDisplay("{settings.text}")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal class TextHandle
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TextGenerationSettings> <>9__4_0; //Field offset: 0x4
		public static Func<TextGenerator> <>9__4_1; //Field offset: 0x8
		public static Func<TextInfo> <>9__4_2; //Field offset: 0xC
		public static Func<TextGenerationSettings> <>9__7_0; //Field offset: 0x10
		public static Func<TextGenerator> <>9__10_0; //Field offset: 0x14
		public static Func<TextInfo> <>9__13_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal TextGenerator <get_generators>b__10_0() { }

		internal TextGenerationSettings <get_settingsArray>b__7_0() { }

		internal TextInfo <get_textInfosCommon>b__13_0() { }

		internal TextGenerationSettings <InitThreadArrays>b__4_0() { }

		internal TextGenerator <InitThreadArrays>b__4_1() { }

		internal TextInfo <InitThreadArrays>b__4_2() { }

	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static TextHandleTemporaryCache s_TemporaryCache; //Field offset: 0x0
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static TextHandlePermanentCache s_PermanentCache; //Field offset: 0x4
	private static TextGenerationSettings[] s_Settings; //Field offset: 0x8
	private static TextGenerator[] s_Generators; //Field offset: 0xC
	private static TextInfo[] s_TextInfosCommon; //Field offset: 0x10
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal NativeTextGenerationSettings nativeSettings; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <preferredSize>k__BackingField; //Field offset: 0x54
	private Rect m_ScreenRect; //Field offset: 0x5C
	private float m_LineHeightDefault; //Field offset: 0x6C
	private bool m_IsPlaceholder; //Field offset: 0x70
	protected bool m_IsEllided; //Field offset: 0x71
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal IntPtr textGenerationInfo; //Field offset: 0x74
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LinkedListNode<TextInfo> <TextInfoNode>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <IsCachedPermanent>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <IsCachedTemporary>k__BackingField; //Field offset: 0x7D
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal int m_PreviousGenerationSettingsHash; //Field offset: 0x80
	protected bool isDirty; //Field offset: 0x84

	internal int characterCount
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 62
	}

	private static TextGenerator generator
	{
		private get { } //Length: 431
	}

	internal static TextGenerator[] generators
	{
		internal get { } //Length: 348
	}

	internal bool IsCachedPermanent
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	internal bool IsCachedTemporary
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public override bool IsPlaceholder
	{
		 get { } //Length: 11
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Vector2 preferredSize
	{
		[CompilerGenerated]
		internal get { } //Length: 39
		[CompilerGenerated]
		internal set { } //Length: 20
	}

	internal static TextGenerationSettings settings
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 431
	}

	internal static TextGenerationSettings[] settingsArray
	{
		internal get { } //Length: 348
	}

	internal TextInfo textInfo
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 91
	}

	internal static TextInfo textInfoCommon
	{
		internal get { } //Length: 431
	}

	internal LinkedListNode<TextInfo> TextInfoNode
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	internal static TextInfo[] textInfosCommon
	{
		internal get { } //Length: 348
	}

	internal bool useAdvancedText
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 28
	}

	private static TextHandle() { }

	public TextHandle() { }

	public override void AddTextInfoToPermanentCache() { }

	public void AddTextInfoToTemporaryCache(int hashCode) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static float ConvertPixelUnitsToTextCoreRelativeUnits(float fontSize, FontAsset fontAsset) { }

	protected virtual void Finalize() { }

	public int FindIntersectingLink(Vector3 position, bool inverseYAxis = true) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal int get_characterCount() { }

	private static TextGenerator get_generator() { }

	internal static TextGenerator[] get_generators() { }

	[CompilerGenerated]
	internal bool get_IsCachedPermanent() { }

	[CompilerGenerated]
	internal bool get_IsCachedTemporary() { }

	public override bool get_IsPlaceholder() { }

	[CompilerGenerated]
	internal Vector2 get_preferredSize() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static TextGenerationSettings get_settings() { }

	internal static TextGenerationSettings[] get_settingsArray() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal TextInfo get_textInfo() { }

	internal static TextInfo get_textInfoCommon() { }

	[CompilerGenerated]
	internal LinkedListNode<TextInfo> get_TextInfoNode() { }

	internal static TextInfo[] get_textInfosCommon() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool get_useAdvancedText() { }

	public float GetCharacterHeightFromIndex(int index) { }

	public int GetCorrespondingStringIndex(int index) { }

	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = true) { }

	public override Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = true) { }

	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = false, bool inverseYAxis = true) { }

	public int GetEndOfPreviousWord(int currentIndex) { }

	public int GetFirstCharacterIndexOnLine(int currentIndex) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Rect[] GetHighlightRectangles(int cursorIndex, int selectIndex) { }

	public int GetLastCharacterIndexOnLine(int currentIndex) { }

	public float GetLineHeight(int lineNumber) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal static float GetLineHeightDefault(TextGenerationSettings settings) { }

	public float GetLineHeightFromCharacterIndex(int index) { }

	public LineInfo GetLineInfoFromCharacterIndex(int index) { }

	public int GetLineNumber(int index) { }

	public int GetStartOfNextWord(int currentIndex) { }

	public int IndexOf(char value, int startIndex) { }

	private static void InitArray(ref T[] array, Func<T> createInstance) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static void InitThreadArrays() { }

	internal override bool IsAdvancedTextEnabledForElement() { }

	public bool IsDirty(int hashCode) { }

	public int LastIndexOf(char value, int startIndex) { }

	public int LineDownCharacterPosition(int originalLogicalPos) { }

	public int LineUpCharacterPosition(int originalLogicalPos) { }

	public int NextCodePointIndex(int currentIndex) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool PrepareFontAsset() { }

	public int PreviousCodePointIndex(int currentIndex) { }

	public void RemoveTextInfoFromPermanentCache() { }

	public void RemoveTextInfoFromTemporaryCache() { }

	public void SelectCurrentParagraph(ref int cursorIndex, ref int selectIndex) { }

	public void SelectCurrentWord(int index, ref int cursorIndex, ref int selectIndex) { }

	public void SelectToEndOfParagraph(ref int cursorIndex) { }

	public void SelectToNextParagraph(ref int cursorIndex) { }

	public void SelectToPreviousParagraph(ref int cursorIndex) { }

	public void SelectToStartOfParagraph(ref int cursorIndex) { }

	[CompilerGenerated]
	internal void set_IsCachedPermanent(bool value) { }

	[CompilerGenerated]
	internal void set_IsCachedTemporary(bool value) { }

	[CompilerGenerated]
	internal void set_preferredSize(Vector2 value) { }

	[CompilerGenerated]
	internal void set_TextInfoNode(LinkedListNode<TextInfo> value) { }

	public void SetDirty() { }

	public string Substring(int startIndex, int length) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal TextInfo Update() { }

	public static void UpdateCurrentFrame() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal void UpdatePreferredSize() { }

	protected void UpdatePreferredValues(TextGenerationSettings tgs) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal TextInfo UpdateWithHash(int hashCode) { }

}


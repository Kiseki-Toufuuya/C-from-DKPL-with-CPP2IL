namespace UnityEngine;

[NativeHeader("IMGUIScriptingClasses.h")]
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[RequiredByNativeCode]
public sealed class GUIStyle
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(GUIStyle guiStyle) { }

	}

	internal static bool showKeyboardFocus; //Field offset: 0x0
	private static GUIStyle s_None; //Field offset: 0x4
	internal IntPtr m_Ptr; //Field offset: 0x8
	private GUIStyleState m_Normal; //Field offset: 0xC
	private GUIStyleState m_Hover; //Field offset: 0x10
	private GUIStyleState m_Active; //Field offset: 0x14
	private GUIStyleState m_Focused; //Field offset: 0x18
	private GUIStyleState m_OnNormal; //Field offset: 0x1C
	private GUIStyleState m_OnHover; //Field offset: 0x20
	private GUIStyleState m_OnActive; //Field offset: 0x24
	private GUIStyleState m_OnFocused; //Field offset: 0x28
	private RectOffset m_Border; //Field offset: 0x2C
	private RectOffset m_Padding; //Field offset: 0x30
	private RectOffset m_Margin; //Field offset: 0x34
	private RectOffset m_Overflow; //Field offset: 0x38
	private string m_Name; //Field offset: 0x3C

	[NativeProperty("m_Alignment", False, TargetType::Field (1))]
	public TextAnchor alignment
	{
		 get { } //Length: 118
		 set { } //Length: 121
	}

	[NativeProperty("m_Clipping", False, TargetType::Field (1))]
	public TextClipping clipping
	{
		 get { } //Length: 118
	}

	[NativeProperty("m_ContentOffset", False, TargetType::Field (1))]
	public Vector2 contentOffset
	{
		 get { } //Length: 141
		 set { } //Length: 122
	}

	[NativeProperty("m_FixedHeight", False, TargetType::Field (1))]
	public float fixedHeight
	{
		 get { } //Length: 122
		 set { } //Length: 129
	}

	[NativeProperty("m_FixedWidth", False, TargetType::Field (1))]
	public float fixedWidth
	{
		 get { } //Length: 122
		 set { } //Length: 129
	}

	[NativeProperty("Font", False, TargetType::Function (0))]
	public Font font
	{
		 get { } //Length: 140
	}

	[NativeProperty("m_FontSize", False, TargetType::Field (1))]
	public int fontSize
	{
		 get { } //Length: 118
	}

	[NativeProperty("m_FontStyle", False, TargetType::Field (1))]
	public FontStyle fontStyle
	{
		 get { } //Length: 118
	}

	[NativeProperty("m_ImagePosition", False, TargetType::Field (1))]
	public ImagePosition imagePosition
	{
		 get { } //Length: 118
	}

	[NativeProperty("m_ClipOffset", False, TargetType::Field (1))]
	internal Vector2 Internal_clipOffset
	{
		internal get { } //Length: 141
		internal set { } //Length: 122
	}

	public bool isHeightDependantOnWidth
	{
		 get { } //Length: 369
	}

	public float lineHeight
	{
		 get { } //Length: 91
	}

	public RectOffset margin
	{
		 get { } //Length: 194
	}

	public string name
	{
		 get { } //Length: 46
		 set { } //Length: 40
	}

	public static GUIStyle none
	{
		 get { } //Length: 145
	}

	public GUIStyleState normal
	{
		 get { } //Length: 211
	}

	public RectOffset padding
	{
		 get { } //Length: 194
	}

	[NativeProperty("Name", False, TargetType::Function (0))]
	internal string rawName
	{
		internal get { } //Length: 299
		internal set { } //Length: 440
	}

	[NativeProperty("m_RichText", False, TargetType::Field (1))]
	public bool richText
	{
		 get { } //Length: 118
	}

	[NativeProperty("m_StretchHeight", False, TargetType::Field (1))]
	public bool stretchHeight
	{
		 get { } //Length: 118
		 set { } //Length: 121
	}

	[NativeProperty("m_StretchWidth", False, TargetType::Field (1))]
	public bool stretchWidth
	{
		 get { } //Length: 118
		 set { } //Length: 121
	}

	[NativeProperty("m_WordWrap", False, TargetType::Field (1))]
	public bool wordWrap
	{
		 get { } //Length: 118
	}

	private static GUIStyle() { }

	public GUIStyle() { }

	public float CalcHeight(GUIContent content, float width) { }

	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	public Vector2 CalcSize(GUIContent content) { }

	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, int controlID) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	[RequiredByNativeCode]
	internal static void EmptyManagedCache() { }

	protected virtual void Finalize() { }

	public TextAnchor get_alignment() { }

	private static TextAnchor get_alignment_Injected(IntPtr _unity_self) { }

	public TextClipping get_clipping() { }

	private static TextClipping get_clipping_Injected(IntPtr _unity_self) { }

	public Vector2 get_contentOffset() { }

	private static void get_contentOffset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public float get_fixedHeight() { }

	private static float get_fixedHeight_Injected(IntPtr _unity_self) { }

	public float get_fixedWidth() { }

	private static float get_fixedWidth_Injected(IntPtr _unity_self) { }

	public Font get_font() { }

	private static IntPtr get_font_Injected(IntPtr _unity_self) { }

	public int get_fontSize() { }

	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	public FontStyle get_fontStyle() { }

	private static FontStyle get_fontStyle_Injected(IntPtr _unity_self) { }

	public ImagePosition get_imagePosition() { }

	private static ImagePosition get_imagePosition_Injected(IntPtr _unity_self) { }

	internal Vector2 get_Internal_clipOffset() { }

	private static void get_Internal_clipOffset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public bool get_isHeightDependantOnWidth() { }

	public float get_lineHeight() { }

	public RectOffset get_margin() { }

	public string get_name() { }

	public static GUIStyle get_none() { }

	public GUIStyleState get_normal() { }

	public RectOffset get_padding() { }

	internal string get_rawName() { }

	private static void get_rawName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	public bool get_richText() { }

	private static bool get_richText_Injected(IntPtr _unity_self) { }

	public bool get_stretchHeight() { }

	private static bool get_stretchHeight_Injected(IntPtr _unity_self) { }

	public bool get_stretchWidth() { }

	private static bool get_stretchWidth_Injected(IntPtr _unity_self) { }

	public bool get_wordWrap() { }

	private static bool get_wordWrap_Injected(IntPtr _unity_self) { }

	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunction(Name = "GUIStyle::GetDefaultFont")]
	internal static Font GetDefaultFont() { }

	private static IntPtr GetDefaultFont_Injected() { }

	[RequiredByNativeCode]
	internal static void GetDimensions(GUIStyle style, Color color, string content, Rect rect, ref Vector2 dimensions) { }

	[RequiredByNativeCode]
	internal static void GetLineHeight(GUIStyle style, ref float lineHeight) { }

	[RequiredByNativeCode]
	internal static void GetMeshInfo(GUIStyle style, Color color, string content, Rect rect, ref MeshInfoBindings[] meshInfos, ref Vector2 dimensions, ref int generationId) { }

	internal Vector2 GetPreferredSize(string content, Rect rect) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	private IntPtr GetRectOffsetPtr(int idx) { }

	private static IntPtr GetRectOffsetPtr_Injected(IntPtr _unity_self, int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	private IntPtr GetStyleStatePtr(int idx) { }

	private static IntPtr GetStyleStatePtr_Injected(IntPtr _unity_self, int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = True)]
	private float Internal_CalcHeight(GUIContent content, float width) { }

	private static float Internal_CalcHeight_Injected(IntPtr _unity_self, GUIContent content, float width) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = True)]
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	private static void Internal_CalcMinMaxWidth_Injected(IntPtr _unity_self, GUIContent content, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSize", HasExplicitThis = True)]
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	private static void Internal_CalcSize_Injected(IntPtr _unity_self, GUIContent content, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = True)]
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	private static void Internal_CalcSizeWithConstraints_Injected(IntPtr _unity_self, GUIContent content, in Vector2 maxSize, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DestroyTextGenerator")]
	internal static void Internal_DestroyTextGenerator(int meshInfoId) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = True)]
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	private static void Internal_Draw_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = True)]
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	private static void Internal_Draw2_Injected(IntPtr _unity_self, in Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawCursor", HasExplicitThis = True)]
	private void Internal_DrawCursor(Rect position, GUIContent content, Vector2 pos, Color cursorColor) { }

	private static void Internal_DrawCursor_Injected(IntPtr _unity_self, in Rect position, GUIContent content, in Vector2 pos, in Color cursorColor) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawWithTextSelection", HasExplicitThis = True)]
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, Vector2 cursorFirstPosition, Vector2 cursorLastPosition, Color cursorColor, Color selectionColor) { }

	private static void Internal_DrawWithTextSelection_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, in Vector2 cursorFirstPosition, in Vector2 cursorLastPosition, in Color cursorColor, in Color selectionColor) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorFlashOffset")]
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetTextRectOffset", HasExplicitThis = True)]
	internal Vector2 Internal_GetTextRectOffset(Rect screenRect, GUIContent content, Vector2 textSize) { }

	private static void Internal_GetTextRectOffset_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, in Vector2 textSize, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	internal static bool IsTooltipActive(string tooltip) { }

	private static bool IsTooltipActive_Injected(ref ManagedSpanWrapper tooltip) { }

	public void set_alignment(TextAnchor value) { }

	private static void set_alignment_Injected(IntPtr _unity_self, TextAnchor value) { }

	public void set_contentOffset(Vector2 value) { }

	private static void set_contentOffset_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_fixedHeight(float value) { }

	private static void set_fixedHeight_Injected(IntPtr _unity_self, float value) { }

	public void set_fixedWidth(float value) { }

	private static void set_fixedWidth_Injected(IntPtr _unity_self, float value) { }

	internal void set_Internal_clipOffset(Vector2 value) { }

	private static void set_Internal_clipOffset_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_name(string value) { }

	internal void set_rawName(string value) { }

	private static void set_rawName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public void set_stretchHeight(bool value) { }

	private static void set_stretchHeight_Injected(IntPtr _unity_self, bool value) { }

	public void set_stretchWidth(bool value) { }

	private static void set_stretchWidth_Injected(IntPtr _unity_self, bool value) { }

	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	internal static void SetDefaultFont(Font font) { }

	private static void SetDefaultFont_Injected(IntPtr font) { }

	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	private static void SetMouseTooltip_Injected(ref ManagedSpanWrapper tooltip, in Rect screenRect) { }

	public virtual string ToString() { }

}


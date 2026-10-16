namespace UnityEngine;

[NativeClass("TextRendering::Font")]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[StaticAccessor("TextRenderingPrivate", StaticAccessorType::DoubleColon (2))]
public sealed class Font : object
{
	internal sealed class FontTextureRebuildCallback : MulticastDelegate
	{

		public FontTextureRebuildCallback(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Font> textureRebuilt; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; //Field offset: 0xC

	private event FontTextureRebuildCallback m_FontTextureRebuildCallback
	{
		[CompilerGenerated]
		private add { } //Length: 116
		[CompilerGenerated]
		private remove { } //Length: 116
	}

	public static event Action<Font> textureRebuilt
	{
		[CompilerGenerated]
		 add { } //Length: 144
		[CompilerGenerated]
		 remove { } //Length: 144
	}

	public int ascent
	{
		 get { } //Length: 98
	}

	public CharacterInfo[] characterInfo
	{
		[FreeFunction("TextRenderingPrivate::GetFontCharacterInfo", HasExplicitThis = True)]
		 get { } //Length: 294
		[FreeFunction("TextRenderingPrivate::SetFontCharacterInfo", HasExplicitThis = True)]
		 set { } //Length: 202
	}

	public bool dynamic
	{
		 get { } //Length: 98
	}

	public String[] fontNames
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int fontSize
	{
		 get { } //Length: 98
	}

	[NativeProperty("LineSpacing", False, TargetType::Function (0))]
	public int lineHeight
	{
		 get { } //Length: 98
	}

	public Material material
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	[Obsolete("Font.textureRebuildCallback has been deprecated. Use Font.textureRebuilt instead.")]
	public FontTextureRebuildCallback textureRebuildCallback
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	private Font(String[] names, int size) { }

	public Font(string name) { }

	public Font() { }

	[CompilerGenerated]
	private void add_m_FontTextureRebuildCallback(FontTextureRebuildCallback value) { }

	[CompilerGenerated]
	public static void add_textureRebuilt(Action<Font> value) { }

	public static Font CreateDynamicFontFromOSFont(string fontname, int size) { }

	public static Font CreateDynamicFontFromOSFont(String[] fontnames, int size) { }

	public int get_ascent() { }

	private static int get_ascent_Injected(IntPtr _unity_self) { }

	[FreeFunction("TextRenderingPrivate::GetFontCharacterInfo", HasExplicitThis = True)]
	public CharacterInfo[] get_characterInfo() { }

	private static void get_characterInfo_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	public bool get_dynamic() { }

	private static bool get_dynamic_Injected(IntPtr _unity_self) { }

	public String[] get_fontNames() { }

	private static String[] get_fontNames_Injected(IntPtr _unity_self) { }

	public int get_fontSize() { }

	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	public int get_lineHeight() { }

	private static int get_lineHeight_Injected(IntPtr _unity_self) { }

	public Material get_material() { }

	private static IntPtr get_material_Injected(IntPtr _unity_self) { }

	public FontTextureRebuildCallback get_textureRebuildCallback() { }

	[ExcludeFromDocs]
	public bool GetCharacterInfo(char ch, out CharacterInfo info) { }

	[ExcludeFromDocs]
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size) { }

	[FreeFunction("TextRenderingPrivate::GetCharacterInfo", HasExplicitThis = True)]
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { }

	private static bool GetCharacterInfo_Injected(IntPtr _unity_self, char ch, out CharacterInfo info, int size, FontStyle style) { }

	internal static Font GetDefault() { }

	private static IntPtr GetDefault_Injected() { }

	public static int GetMaxVertsForString(string str) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static String[] GetOSFallbacks() { }

	public static String[] GetOSInstalledFontNames() { }

	public static String[] GetPathsToOSFonts() { }

	private bool HasCharacter(int c) { }

	public bool HasCharacter(char c) { }

	private static bool HasCharacter_Injected(IntPtr _unity_self, int c) { }

	private static void Internal_CreateDynamicFont(Font self, String[] _names, int size) { }

	private static void Internal_CreateFont(Font self, string name) { }

	private static void Internal_CreateFont_Injected(Font self, ref ManagedSpanWrapper name) { }

	private static void Internal_CreateFontFromPath(Font self, string fontPath) { }

	private static void Internal_CreateFontFromPath_Injected(Font self, ref ManagedSpanWrapper fontPath) { }

	[RequiredByNativeCode]
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	[CompilerGenerated]
	private void remove_m_FontTextureRebuildCallback(FontTextureRebuildCallback value) { }

	[CompilerGenerated]
	public static void remove_textureRebuilt(Action<Font> value) { }

	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

	[ExcludeFromDocs]
	public void RequestCharactersInTexture(string characters, int size) { }

	[ExcludeFromDocs]
	public void RequestCharactersInTexture(string characters) { }

	private static void RequestCharactersInTexture_Injected(IntPtr _unity_self, ref ManagedSpanWrapper characters, int size, FontStyle style) { }

	[FreeFunction("TextRenderingPrivate::SetFontCharacterInfo", HasExplicitThis = True)]
	public void set_characterInfo(CharacterInfo[] value) { }

	private static void set_characterInfo_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public void set_fontNames(String[] value) { }

	private static void set_fontNames_Injected(IntPtr _unity_self, String[] value) { }

	public void set_material(Material value) { }

	private static void set_material_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_textureRebuildCallback(FontTextureRebuildCallback value) { }

}


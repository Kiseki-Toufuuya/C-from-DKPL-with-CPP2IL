namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[NativeHeader("Modules/TextCoreTextEngine/Native/TextSettings.h")]
public class TextSettings : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass96_0
	{
		public List<IntPtr> globalFontAssetFallbacks; //Field offset: 0x8

		public <>c__DisplayClass96_0() { }

		internal void <GetGlobalFallbacks>b__0(FontAsset fallback) { }

		internal void <GetGlobalFallbacks>b__1(FontAsset fallback) { }

		internal void <GetGlobalFallbacks>b__2(TextAsset fallback) { }

	}

	public struct FontReferenceMap
	{
		public Font font; //Field offset: 0x0
		public FontAsset fontAsset; //Field offset: 0x4

		public FontReferenceMap(Font font, FontAsset fontAsset) { }

	}

	private static List<FontAsset> s_FallbackOSFontAssetInternal; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static SpriteAsset <s_GlobalSpriteAsset>k__BackingField; //Field offset: 0x4
	[SerializeField]
	protected string m_Version; //Field offset: 0xC
	[FormerlySerializedAs("m_defaultFontAsset")]
	[SerializeField]
	protected FontAsset m_DefaultFontAsset; //Field offset: 0x10
	[FormerlySerializedAs("m_defaultFontAssetPath")]
	[SerializeField]
	protected string m_DefaultFontAssetPath; //Field offset: 0x14
	[FormerlySerializedAs("m_fallbackFontAssets")]
	[SerializeField]
	protected List<FontAsset> m_FallbackFontAssets; //Field offset: 0x18
	[FormerlySerializedAs("m_matchMaterialPreset")]
	[SerializeField]
	protected bool m_MatchMaterialPreset; //Field offset: 0x1C
	[FormerlySerializedAs("m_missingGlyphCharacter")]
	[SerializeField]
	protected int m_MissingCharacterUnicode; //Field offset: 0x20
	[SerializeField]
	protected bool m_ClearDynamicDataOnBuild; //Field offset: 0x24
	[SerializeField]
	private bool m_EnableEmojiSupport; //Field offset: 0x25
	[SerializeField]
	private List<TextAsset> m_EmojiFallbackTextAssets; //Field offset: 0x28
	[FormerlySerializedAs("m_defaultSpriteAsset")]
	[SerializeField]
	protected SpriteAsset m_DefaultSpriteAsset; //Field offset: 0x2C
	[FormerlySerializedAs("m_defaultSpriteAssetPath")]
	[SerializeField]
	protected string m_DefaultSpriteAssetPath; //Field offset: 0x30
	[SerializeField]
	protected List<SpriteAsset> m_FallbackSpriteAssets; //Field offset: 0x34
	[SerializeField]
	protected uint m_MissingSpriteCharacterUnicode; //Field offset: 0x38
	[FormerlySerializedAs("m_defaultStyleSheet")]
	[SerializeField]
	protected TextStyleSheet m_DefaultStyleSheet; //Field offset: 0x3C
	[SerializeField]
	protected string m_StyleSheetsResourcePath; //Field offset: 0x40
	[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
	[SerializeField]
	protected string m_DefaultColorGradientPresetsPath; //Field offset: 0x44
	[SerializeField]
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; //Field offset: 0x48
	[FormerlySerializedAs("m_warningsDisabled")]
	[SerializeField]
	protected bool m_DisplayWarnings; //Field offset: 0x4C
	internal Dictionary<Int32, FontAsset> m_FontLookup; //Field offset: 0x50
	internal List<FontReferenceMap> m_FontReferences; //Field offset: 0x54
	private IntPtr m_NativeTextSettings; //Field offset: 0x58
	private bool m_IsNativeTextSettingsDirty; //Field offset: 0x5C

	public bool clearDynamicDataOnBuild
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string defaultColorGradientPresetsPath
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public FontAsset defaultFontAsset
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string defaultFontAssetPath
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public SpriteAsset defaultSpriteAsset
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string defaultSpriteAssetPath
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TextStyleSheet defaultStyleSheet
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool displayWarnings
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public List<TextAsset> emojiFallbackTextAssets
	{
		 get { } //Length: 11
		 set { } //Length: 33
	}

	public bool enableEmojiSupport
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public List<FontAsset> fallbackFontAssets
	{
		 get { } //Length: 11
		 set { } //Length: 33
	}

	internal List<FontAsset> fallbackOSFontAssets
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 148
	}

	[Obsolete("The Fallback Sprite Assets list is now obsolete. Use the emojiFallbackTextAssets instead.", True)]
	public List<SpriteAsset> fallbackSpriteAssets
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public UnicodeLineBreakingRules lineBreakingRules
	{
		 get { } //Length: 110
		 set { } //Length: 27
	}

	public bool matchMaterialPreset
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int missingCharacterUnicode
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public uint missingSpriteCharacterUnicode
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	internal IntPtr nativeTextSettings
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 392
	}

	internal static SpriteAsset s_GlobalSpriteAsset
	{
		[CompilerGenerated]
		internal get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	public string styleSheetsResourcePath
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public internal string version
	{
		 get { } //Length: 11
		internal set { } //Length: 27
	}

	public TextSettings() { }

	[NativeMethod(Name = "TextSettings::Create")]
	private static IntPtr CreateNativeObject(IntPtr[] fallbacks) { }

	private static IntPtr CreateNativeObject_Injected(ref ManagedSpanWrapper fallbacks) { }

	[NativeMethod(Name = "TextSettings::Destroy")]
	private static void DestroyNativeObject(IntPtr m_NativeTextSettings) { }

	public bool get_clearDynamicDataOnBuild() { }

	public string get_defaultColorGradientPresetsPath() { }

	public FontAsset get_defaultFontAsset() { }

	public string get_defaultFontAssetPath() { }

	public SpriteAsset get_defaultSpriteAsset() { }

	public string get_defaultSpriteAssetPath() { }

	public TextStyleSheet get_defaultStyleSheet() { }

	public bool get_displayWarnings() { }

	public List<TextAsset> get_emojiFallbackTextAssets() { }

	public bool get_enableEmojiSupport() { }

	public List<FontAsset> get_fallbackFontAssets() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal List<FontAsset> get_fallbackOSFontAssets() { }

	public List<SpriteAsset> get_fallbackSpriteAssets() { }

	public UnicodeLineBreakingRules get_lineBreakingRules() { }

	public bool get_matchMaterialPreset() { }

	public int get_missingCharacterUnicode() { }

	public uint get_missingSpriteCharacterUnicode() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal IntPtr get_nativeTextSettings() { }

	[CompilerGenerated]
	internal static SpriteAsset get_s_GlobalSpriteAsset() { }

	public string get_styleSheetsResourcePath() { }

	public string get_version() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal FontAsset GetCachedFontAsset(Font font) { }

	internal override List<FontAsset> GetFallbackFontAssets(int textPixelSize = -1) { }

	private IntPtr[] GetGlobalFallbacks() { }

	private List<FontAsset> GetOSFontAssetList() { }

	internal override List<FontAsset> GetStaticFallbackOSFontAsset() { }

	protected void InitializeFontReferenceLookup() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	public void set_clearDynamicDataOnBuild(bool value) { }

	public void set_defaultColorGradientPresetsPath(string value) { }

	public void set_defaultFontAsset(FontAsset value) { }

	public void set_defaultFontAssetPath(string value) { }

	public void set_defaultSpriteAsset(SpriteAsset value) { }

	public void set_defaultSpriteAssetPath(string value) { }

	public void set_defaultStyleSheet(TextStyleSheet value) { }

	public void set_displayWarnings(bool value) { }

	public void set_emojiFallbackTextAssets(List<TextAsset> value) { }

	public void set_enableEmojiSupport(bool value) { }

	public void set_fallbackFontAssets(List<FontAsset> value) { }

	public void set_fallbackSpriteAssets(List<SpriteAsset> value) { }

	public void set_lineBreakingRules(UnicodeLineBreakingRules value) { }

	public void set_matchMaterialPreset(bool value) { }

	public void set_missingCharacterUnicode(int value) { }

	public void set_missingSpriteCharacterUnicode(uint value) { }

	[CompilerGenerated]
	private static void set_s_GlobalSpriteAsset(SpriteAsset value) { }

	public void set_styleSheetsResourcePath(string value) { }

	internal void set_version(string value) { }

	internal override void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets) { }

	private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks) { }

	private static void UpdateFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper fallbacks) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void UpdateNativeTextSettings() { }

}


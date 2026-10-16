namespace UnityEngine.TextCore.Text;

[ExcludeFromPreset]
[NativeHeader("Modules/TextCoreTextEngine/Native/FontAsset.h")]
public class FontAsset : TextAsset
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Character, UInt32> <>9__189_0; //Field offset: 0x4
		public static Func<Glyph, UInt32> <>9__190_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal uint <SortCharacterTable>b__189_0(Character c) { }

		internal uint <SortGlyphTable>b__190_0(Glyph c) { }

	}

	private static Dictionary<Int32, FontAsset> kFontAssetByInstanceId; //Field offset: 0x0
	private static readonly List<WeakReference`1<FontAsset>> s_CallbackInstances; //Field offset: 0x4
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; //Field offset: 0x8
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; //Field offset: 0xC
	private static ProfilerMarker k_TryAddGlyphMarker; //Field offset: 0x10
	private static ProfilerMarker k_TryAddCharacterMarker; //Field offset: 0x14
	private static ProfilerMarker k_TryAddCharactersMarker; //Field offset: 0x18
	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker; //Field offset: 0x1C
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; //Field offset: 0x20
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; //Field offset: 0x24
	private static ProfilerMarker k_ClearFontAssetDataMarker; //Field offset: 0x28
	private static ProfilerMarker k_UpdateFontAssetDataMarker; //Field offset: 0x2C
	private static string s_DefaultMaterialSuffix; //Field offset: 0x30
	private static HashSet<Int32> k_SearchedFontAssetLookup; //Field offset: 0x34
	private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue; //Field offset: 0x38
	private static HashSet<Int32> k_FontAssets_FontFeaturesUpdateQueueLookup; //Field offset: 0x3C
	private static List<FontAsset> k_FontAssets_KerningUpdateQueue; //Field offset: 0x40
	private static HashSet<Int32> k_FontAssets_KerningUpdateQueueLookup; //Field offset: 0x44
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; //Field offset: 0x48
	private static HashSet<Int32> k_FontAssets_AtlasTexturesUpdateQueueLookup; //Field offset: 0x4C
	internal static UInt32[] k_GlyphIndexArray; //Field offset: 0x50
	private static HashSet<Int32> visitedFontAssets; //Field offset: 0x54
	[SerializeField]
	internal string m_SourceFontFileGUID; //Field offset: 0x20
	[SerializeField]
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; //Field offset: 0x24
	[SerializeField]
	private Font m_SourceFontFile; //Field offset: 0x68
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal string m_SourceFontFilePath; //Field offset: 0x6C
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; //Field offset: 0x70
	[SerializeField]
	internal bool InternalDynamicOS; //Field offset: 0x74
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool IsEditorFont; //Field offset: 0x75
	[SerializeField]
	internal FaceInfo m_FaceInfo; //Field offset: 0x78
	private int m_FamilyNameHashCode; //Field offset: 0xCC
	private int m_StyleNameHashCode; //Field offset: 0xD0
	[Nullable(1)]
	[SerializeField]
	internal List<Glyph> m_GlyphTable; //Field offset: 0xD4
	internal Dictionary<UInt32, Glyph> m_GlyphLookupDictionary; //Field offset: 0xD8
	[SerializeField]
	internal List<Character> m_CharacterTable; //Field offset: 0xDC
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Dictionary<UInt32, Character> m_CharacterLookupDictionary; //Field offset: 0xE0
	internal Texture2D m_AtlasTexture; //Field offset: 0xE4
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; //Field offset: 0xE8
	[SerializeField]
	internal int m_AtlasTextureIndex; //Field offset: 0xEC
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; //Field offset: 0xF0
	[SerializeField]
	private bool m_GetFontFeatures; //Field offset: 0xF1
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; //Field offset: 0xF2
	[SerializeField]
	internal int m_AtlasWidth; //Field offset: 0xF4
	[SerializeField]
	internal int m_AtlasHeight; //Field offset: 0xF8
	[SerializeField]
	internal int m_AtlasPadding; //Field offset: 0xFC
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; //Field offset: 0x100
	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects; //Field offset: 0x104
	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects; //Field offset: 0x108
	[SerializeField]
	internal FontFeatureTable m_FontFeatureTable; //Field offset: 0x10C
	[SerializeField]
	internal bool m_ShouldReimportFontFeatures; //Field offset: 0x110
	[SerializeField]
	internal List<FontAsset> m_FallbackFontAssetTable; //Field offset: 0x114
	[SerializeField]
	private FontWeightPair[] m_FontWeightTable; //Field offset: 0x118
	[FormerlySerializedAs("normalStyle")]
	[SerializeField]
	internal float m_RegularStyleWeight; //Field offset: 0x11C
	[FormerlySerializedAs("normalSpacingOffset")]
	[SerializeField]
	internal float m_RegularStyleSpacing; //Field offset: 0x120
	[FormerlySerializedAs("boldStyle")]
	[SerializeField]
	internal float m_BoldStyleWeight; //Field offset: 0x124
	[FormerlySerializedAs("boldSpacing")]
	[SerializeField]
	internal float m_BoldStyleSpacing; //Field offset: 0x128
	[FormerlySerializedAs("italicStyle")]
	[SerializeField]
	internal byte m_ItalicStyleSlant; //Field offset: 0x12C
	[FormerlySerializedAs("tabSize")]
	[SerializeField]
	internal byte m_TabMultiple; //Field offset: 0x12D
	internal bool IsFontAssetLookupTablesDirty; //Field offset: 0x12E
	private IntPtr m_NativeFontAsset; //Field offset: 0x130
	private List<Glyph> m_GlyphsToRender; //Field offset: 0x134
	private List<Glyph> m_GlyphsRendered; //Field offset: 0x138
	private List<UInt32> m_GlyphIndexList; //Field offset: 0x13C
	private List<UInt32> m_GlyphIndexListNewlyAdded; //Field offset: 0x140
	internal List<UInt32> m_GlyphsToAdd; //Field offset: 0x144
	internal HashSet<UInt32> m_GlyphsToAddLookup; //Field offset: 0x148
	internal List<Character> m_CharactersToAdd; //Field offset: 0x14C
	internal HashSet<UInt32> m_CharactersToAddLookup; //Field offset: 0x150
	internal List<UInt32> s_MissingCharacterList; //Field offset: 0x154
	internal HashSet<UInt32> m_MissingUnicodesFromFontFile; //Field offset: 0x158
	internal Dictionary<ValueTuple`2<UInt32, UInt32>, UInt32> m_VariantGlyphIndexes; //Field offset: 0x15C
	internal bool m_IsClone; //Field offset: 0x160

	public internal int atlasHeight
	{
		 get { } //Length: 14
		internal set { } //Length: 17
	}

	public internal int atlasPadding
	{
		 get { } //Length: 14
		internal set { } //Length: 17
	}

	public AtlasPopulationMode atlasPopulationMode
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public internal GlyphRenderMode atlasRenderMode
	{
		 get { } //Length: 14
		internal set { } //Length: 17
	}

	public Texture2D atlasTexture
	{
		 get { } //Length: 141
	}

	public int atlasTextureCount
	{
		 get { } //Length: 15
	}

	public Texture2D[] atlasTextures
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public internal int atlasWidth
	{
		 get { } //Length: 14
		internal set { } //Length: 17
	}

	public float boldStyleSpacing
	{
		 get { } //Length: 14
		 set { } //Length: 21
	}

	public float boldStyleWeight
	{
		 get { } //Length: 14
		 set { } //Length: 21
	}

	public Dictionary<UInt32, Character> characterLookupTable
	{
		 get { } //Length: 36
	}

	public internal List<Character> characterTable
	{
		 get { } //Length: 14
		internal set { } //Length: 33
	}

	internal bool clearDynamicDataOnBuild
	{
		internal get { } //Length: 14
		internal set { } //Length: 17
	}

	public FaceInfo faceInfo
	{
		 get { } //Length: 71
		 set { } //Length: 354
	}

	public List<FontAsset> fallbackFontAssetTable
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	internal int familyNameHashCode
	{
		internal get { } //Length: 56
		internal set { } //Length: 17
	}

	public FontAssetCreationEditorSettings fontAssetCreationEditorSettings
	{
		 get { } //Length: 48
		 set { } //Length: 60
	}

	public internal FontFeatureTable fontFeatureTable
	{
		 get { } //Length: 14
		internal set { } //Length: 33
	}

	public internal FontWeightPair[] fontWeightTable
	{
		 get { } //Length: 14
		internal set { } //Length: 33
	}

	internal List<GlyphRect> freeGlyphRects
	{
		internal get { } //Length: 14
		internal set { } //Length: 33
	}

	public bool getFontFeatures
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public Dictionary<UInt32, Glyph> glyphLookupTable
	{
		 get { } //Length: 36
	}

	[Nullable(1)]
	public internal List<Glyph> glyphTable
	{
		[NullableContext(1)]
		 get { } //Length: 14
		[NullableContext(1)]
		internal set { } //Length: 33
	}

	public bool isMultiAtlasTexturesEnabled
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public byte italicStyleSlant
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	internal IntPtr nativeFontAsset
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 330
	}

	public float regularStyleSpacing
	{
		 get { } //Length: 14
		 set { } //Length: 21
	}

	public float regularStyleWeight
	{
		 get { } //Length: 14
		 set { } //Length: 21
	}

	public internal Font sourceFontFile
	{
		 get { } //Length: 11
		internal set { } //Length: 27
	}

	internal int styleNameHashCode
	{
		internal get { } //Length: 56
		internal set { } //Length: 17
	}

	public byte tabMultiple
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	internal List<GlyphRect> usedGlyphRects
	{
		internal get { } //Length: 14
		internal set { } //Length: 33
	}

	private static FontAsset() { }

	public FontAsset() { }

	internal void AddCharacterToLookupCache(uint unicode, Character character, FontStyles fontStyle, TextFontWeight fontWeight) { }

	internal void AddCharacterToLookupCache(uint unicode, Character character) { }

	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false) { }

	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	internal void ClearAtlasTextures(bool setAtlasSizeToZero = false) { }

	private void ClearCharacterAndGlyphTables() { }

	internal void ClearCharacterAndGlyphTablesInternal() { }

	internal void ClearFallbackCharacterTable() { }

	public void ClearFontAssetData(bool setAtlasSizeToZero = false) { }

	private void ClearFontFeaturesTables() { }

	internal bool ContainsCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	private static IntPtr Create(FaceInfo faceInfo, Font sourceFontFile, Font sourceFont_EditorRef, string sourceFontFilePath, int fontInstanceID, IntPtr[] fallbacks, IntPtr[] weightFallbacks, IntPtr[] italicFallbacks) { }

	private static IntPtr Create_Injected(in FaceInfo faceInfo, IntPtr sourceFontFile, IntPtr sourceFont_EditorRef, ref ManagedSpanWrapper sourceFontFilePath, int fontInstanceID, ref ManagedSpanWrapper fallbacks, ref ManagedSpanWrapper weightFallbacks, ref ManagedSpanWrapper italicFallbacks) { }

	private Character CreateCharacterAndAddToCache(uint unicode, Glyph glyph, FontStyles fontStyle, TextFontWeight fontWeight) { }

	private uint CreateCompositeKey(uint unicode, FontStyles fontStyle = 0, TextFontWeight fontWeight = 400) { }

	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	[NullableContext(1)]
	internal static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize, int padding, GlyphRenderMode renderMode) { }

	public static FontAsset CreateFontAsset(Font font) { }

	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = true) { }

	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	private static FontAsset CreateFontAssetFromFamilyName(string familyName, int pointSize = 90) { }

	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	[NullableContext(1)]
	internal static FontAsset CreateFontAssetInternal(string familyName, string styleName, int pointSize = 90) { }

	internal static List<FontAsset> CreateFontAssetOSFallbackList(String[] fallbacksFamilyNames, int pointSize = 90) { }

	internal static FontAsset CreateFontAssetWithOSFallbackList(String[] fallbacksFamilyNames, int pointSize = 90) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void CreateHbFaceIfNeeded() { }

	[FreeFunction("FontAsset::Destroy")]
	private static void Destroy(IntPtr ptr) { }

	private void DestroyAtlasTextures() { }

	private static void EnsureAdditionalCapacity(List<T> container, int additionalCapacity) { }

	private static void EnsureAdditionalCapacity(Dictionary<TKey, TValue> container, int additionalCapacity) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void EnsureNativeFontAssetIsCreated() { }

	public int get_atlasHeight() { }

	public int get_atlasPadding() { }

	public AtlasPopulationMode get_atlasPopulationMode() { }

	public GlyphRenderMode get_atlasRenderMode() { }

	public Texture2D get_atlasTexture() { }

	public int get_atlasTextureCount() { }

	public Texture2D[] get_atlasTextures() { }

	public int get_atlasWidth() { }

	public float get_boldStyleSpacing() { }

	public float get_boldStyleWeight() { }

	public Dictionary<UInt32, Character> get_characterLookupTable() { }

	public List<Character> get_characterTable() { }

	internal bool get_clearDynamicDataOnBuild() { }

	public FaceInfo get_faceInfo() { }

	public List<FontAsset> get_fallbackFontAssetTable() { }

	internal int get_familyNameHashCode() { }

	public FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }

	public FontFeatureTable get_fontFeatureTable() { }

	public FontWeightPair[] get_fontWeightTable() { }

	internal List<GlyphRect> get_freeGlyphRects() { }

	public bool get_getFontFeatures() { }

	public Dictionary<UInt32, Glyph> get_glyphLookupTable() { }

	[NullableContext(1)]
	public List<Glyph> get_glyphTable() { }

	public bool get_isMultiAtlasTexturesEnabled() { }

	public byte get_italicStyleSlant() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal IntPtr get_nativeFontAsset() { }

	public float get_regularStyleSpacing() { }

	public float get_regularStyleWeight() { }

	public Font get_sourceFontFile() { }

	internal int get_styleNameHashCode() { }

	public byte get_tabMultiple() { }

	internal List<GlyphRect> get_usedGlyphRects() { }

	internal bool GetCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character) { }

	public static string GetCharacters(FontAsset fontAsset) { }

	public static Int32[] GetCharactersArray(FontAsset fontAsset) { }

	internal IntPtr[] GetFallbacks() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static FontAsset GetFontAssetByID(int id) { }

	internal uint GetGlyphIndex(uint unicode, out bool success) { }

	internal uint GetGlyphIndex(uint unicode) { }

	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode) { }

	private ValueTuple<IntPtr[], IntPtr[]> GetWeightFallbacks() { }

	public bool HasCharacter(uint character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	public bool HasCharacter(int character) { }

	private bool HasCharacter_Internal(uint character, FontStyles fontStyle = 0, TextFontWeight fontWeight = 400, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	public bool HasCharacters(string text, out UInt32[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	public bool HasCharacters(string text) { }

	public bool HasCharacters(string text, out List<Char>& missingCharacters) { }

	private bool HasCharacterWithStyle_Internal(uint character, FontStyles fontStyle, TextFontWeight fontWeight, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	private bool HasRecursion(FontAsset fontAsset) { }

	private bool HasRecursionInternal(FontAsset fontAsset) { }

	internal void ImportFontFeatures() { }

	internal void InitializeCharacterLookupDictionary() { }

	internal void InitializeDictionaryLookupTables() { }

	internal void InitializeGlyphLookupDictionary() { }

	internal void InitializeGlyphPairAdjustmentRecordsLookupDictionary() { }

	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	private static void InitializeList(ICollection source, ref List<T>& list, int defaultCapacity = 16) { }

	private static void InitializeLookup(ICollection source, ref Dictionary<UInt32, T>& lookup, int defaultCapacity = 16) { }

	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	internal FontEngineError LoadFontFace() { }

	private void OnDestroy() { }

	public void ReadFontAssetDefinition() { }

	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	private void RegisterCallbackInstance(FontAsset instance) { }

	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) { }

	internal static void RegisterFontAssetForKerningUpdate(FontAsset fontAsset) { }

	internal void RemoveCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	internal void set_atlasHeight(int value) { }

	internal void set_atlasPadding(int value) { }

	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	public void set_atlasTextures(Texture2D[] value) { }

	internal void set_atlasWidth(int value) { }

	public void set_boldStyleSpacing(float value) { }

	public void set_boldStyleWeight(float value) { }

	internal void set_characterTable(List<Character> value) { }

	internal void set_clearDynamicDataOnBuild(bool value) { }

	public void set_faceInfo(FaceInfo value) { }

	public void set_fallbackFontAssetTable(List<FontAsset> value) { }

	internal void set_familyNameHashCode(int value) { }

	public void set_fontAssetCreationEditorSettings(FontAssetCreationEditorSettings value) { }

	internal void set_fontFeatureTable(FontFeatureTable value) { }

	internal void set_fontWeightTable(FontWeightPair[] value) { }

	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	public void set_getFontFeatures(bool value) { }

	[NullableContext(1)]
	internal void set_glyphTable(List<Glyph> value) { }

	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	public void set_italicStyleSlant(byte value) { }

	public void set_regularStyleSpacing(float value) { }

	public void set_regularStyleWeight(float value) { }

	internal void set_sourceFontFile(Font value) { }

	internal void set_styleNameHashCode(int value) { }

	public void set_tabMultiple(byte value) { }

	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	private void SetupNewAtlasTexture() { }

	internal void SortAllTables() { }

	internal void SortCharacterTable() { }

	internal void SortFontFeatureTable() { }

	internal void SortGlyphTable() { }

	internal bool TryAddCharacterInternal(uint unicode, out Character character) { }

	internal bool TryAddCharacterInternal(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character, bool populateLigatures = true) { }

	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false) { }

	public bool TryAddCharacters(string characters, bool includeFontFeatures = false) { }

	public bool TryAddCharacters(UInt32[] unicodes, out UInt32[] missingUnicodes, bool includeFontFeatures = false) { }

	public bool TryAddCharacters(UInt32[] unicodes, bool includeFontFeatures = false) { }

	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	private bool TryAddGlyphsToNewAtlasTexture() { }

	private bool TryAddGlyphToAtlas(uint glyphIndex, out Glyph glyph, bool populateLigatures = true) { }

	private bool TryAddGlyphToTexture(uint glyphIndex, out Glyph glyph, bool populateLigatures = true) { }

	internal bool TryAddGlyphVariantIndexInternal(uint unicode, uint nextCharacter, uint variantGlyphIndex) { }

	internal bool TryGetGlyphVariantIndexInternal(uint unicode, uint nextCharacter, out uint variantGlyphIndex) { }

	internal static void UpdateAtlasTexturesInQueue() { }

	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	private static void UpdateFaceInfo(IntPtr ptr, FaceInfo faceInfo) { }

	internal void UpdateFaceInfo() { }

	private static void UpdateFaceInfo_Injected(IntPtr ptr, in FaceInfo faceInfo) { }

	internal void UpdateFallbacks() { }

	private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks) { }

	private static void UpdateFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper fallbacks) { }

	internal void UpdateFontAssetData() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static void UpdateFontAssetsInUpdateQueue() { }

	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	internal void UpdateGlyphAdjustmentRecords() { }

	private void UpdateGlyphAdjustmentRecordsForNewGlyphs() { }

	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex) { }

	internal void UpdateLigatureSubstitutionRecords() { }

	internal void UpdateWeightFallbacks() { }

	private static void UpdateWeightFallbacks(IntPtr ptr, IntPtr[] regularFallbacks, IntPtr[] italicFallbacks) { }

	private static void UpdateWeightFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper regularFallbacks, ref ManagedSpanWrapper italicFallbacks) { }

}


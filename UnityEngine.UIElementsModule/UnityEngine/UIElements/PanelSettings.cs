namespace UnityEngine.UIElements;

[HelpURL("UIE-Runtime-Panel-Settings")]
public class PanelSettings : ScriptableObject
{
	private class RuntimePanelAccess
	{
		private readonly PanelSettings m_Settings; //Field offset: 0x8
		private BaseRuntimePanel m_RuntimePanel; //Field offset: 0xC

		internal bool isInitialized
		{
			internal get { } //Length: 15
		}

		internal BaseRuntimePanel panel
		{
			internal get { } //Length: 887
		}

		internal RuntimePanelAccess(PanelSettings settings) { }

		private BaseRuntimePanel CreateRelatedRuntimePanel() { }

		internal void DisposePanel() { }

		private void DisposeRelatedPanel() { }

		internal bool get_isInitialized() { }

		internal BaseRuntimePanel get_panel() { }

		internal void MarkPotentiallyEmpty() { }

		internal void SetPanelChangeReceiver() { }

		internal void SetSortingPriority() { }

		internal void SetTargetDisplay() { }

		internal void SetTargetTexture() { }

	}

	private const int k_DefaultSortingOrder = 0; //Field offset: 0x0
	private const float k_DefaultScaleValue = 1; //Field offset: 0x0
	internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset"; //Field offset: 0x0
	private const float DefaultDpi = 96; //Field offset: 0x0
	[SerializeField]
	private ThemeStyleSheet themeUss; //Field offset: 0xC
	[SerializeField]
	private bool m_DisableNoThemeWarning; //Field offset: 0x10
	[SerializeField]
	private RenderTexture m_TargetTexture; //Field offset: 0x14
	[SerializeField]
	private PanelRenderMode m_RenderMode; //Field offset: 0x18
	[SerializeField]
	private int m_WorldSpaceLayer; //Field offset: 0x1C
	[SerializeField]
	private PanelScaleMode m_ScaleMode; //Field offset: 0x20
	[SerializeField]
	private float m_ReferenceSpritePixelsPerUnit; //Field offset: 0x24
	[SerializeField]
	private float m_PixelsPerUnit; //Field offset: 0x28
	[SerializeField]
	private float m_Scale; //Field offset: 0x2C
	[SerializeField]
	private float m_ReferenceDpi; //Field offset: 0x30
	[SerializeField]
	private float m_FallbackDpi; //Field offset: 0x34
	[SerializeField]
	private Vector2Int m_ReferenceResolution; //Field offset: 0x38
	[SerializeField]
	private PanelScreenMatchMode m_ScreenMatchMode; //Field offset: 0x40
	[Range(0, 1)]
	[SerializeField]
	private float m_Match; //Field offset: 0x44
	[SerializeField]
	private float m_SortingOrder; //Field offset: 0x48
	[SerializeField]
	private int m_TargetDisplay; //Field offset: 0x4C
	[SerializeField]
	private BindingLogLevel m_BindingLogLevel; //Field offset: 0x50
	[SerializeField]
	private bool m_ClearDepthStencil; //Field offset: 0x54
	[SerializeField]
	private bool m_ClearColor; //Field offset: 0x55
	[SerializeField]
	private Color m_ColorClearValue; //Field offset: 0x58
	[SerializeField]
	private uint m_VertexBudget; //Field offset: 0x68
	private RuntimePanelAccess m_PanelAccess; //Field offset: 0x6C
	internal UIDocumentList m_AttachedUIDocumentsList; //Field offset: 0x70
	[HideInInspector]
	[SerializeField]
	private DynamicAtlasSettings m_DynamicAtlasSettings; //Field offset: 0x74
	[HideInInspector]
	[SerializeField]
	private Shader m_AtlasBlitShader; //Field offset: 0x78
	[HideInInspector]
	[SerializeField]
	private Shader m_RuntimeShader; //Field offset: 0x7C
	[HideInInspector]
	[SerializeField]
	private Shader m_RuntimeWorldShader; //Field offset: 0x80
	[HideInInspector]
	[SerializeField]
	private Shader m_SDFShader; //Field offset: 0x84
	[HideInInspector]
	[SerializeField]
	private Shader m_BitmapShader; //Field offset: 0x88
	[HideInInspector]
	[SerializeField]
	private Shader m_SpriteShader; //Field offset: 0x8C
	[HideInInspector]
	[SerializeField]
	internal TextAsset m_ICUDataAsset; //Field offset: 0x90
	[SerializeField]
	public bool forceGammaRendering; //Field offset: 0x94
	[SerializeField]
	public PanelTextSettings textSettings; //Field offset: 0x98
	private Rect m_TargetRect; //Field offset: 0x9C
	private float m_ResolvedScale; //Field offset: 0xAC
	private StyleSheet m_OldThemeUss; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <ScreenDPI>k__BackingField; //Field offset: 0xB4
	private IDebugPanelChangeReceiver m_PanelChangeReceiver; //Field offset: 0xB8
	private Func<Vector2, Vector2> m_AssignedScreenToPanel; //Field offset: 0xBC

	public BindingLogLevel bindingLogLevel
	{
		 get { } //Length: 11
		 set { } //Length: 53
	}

	public bool clearColor
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool clearDepthStencil
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Color colorClearValue
	{
		 get { } //Length: 18
		 set { } //Length: 16
	}

	public float depthClearValue
	{
		 get { } //Length: 7
	}

	public DynamicAtlasSettings dynamicAtlasSettings
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public float fallbackDpi
	{
		 get { } //Length: 11
		 set { } //Length: 44
	}

	internal bool isInitialized
	{
		internal get { } //Length: 28
	}

	public float match
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	internal BaseRuntimePanel panel
	{
		internal get { } //Length: 34
	}

	internal float pixelsPerUnit
	{
		internal get { } //Length: 11
		internal set { } //Length: 18
	}

	public float referenceDpi
	{
		 get { } //Length: 11
		 set { } //Length: 44
	}

	public Vector2Int referenceResolution
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	public float referenceSpritePixelsPerUnit
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	internal PanelRenderMode renderMode
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	public float scale
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public PanelScaleMode scaleMode
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private float ScreenDPI
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 21
	}

	public PanelScreenMatchMode screenMatchMode
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public float sortingOrder
	{
		 get { } //Length: 11
		 set { } //Length: 67
	}

	public int targetDisplay
	{
		 get { } //Length: 11
		 set { } //Length: 51
	}

	public RenderTexture targetTexture
	{
		 get { } //Length: 11
		 set { } //Length: 82
	}

	public ThemeStyleSheet themeStyleSheet
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	public uint vertexBudget
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	internal VisualElement visualTree
	{
		internal get { } //Length: 55
	}

	internal int worldSpaceLayer
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	private PanelSettings() { }

	internal void ApplyPanelSettings() { }

	internal void ApplySortingOrder() { }

	private void ApplyThemeStyleSheet(VisualElement root = null) { }

	internal bool AssignICUData() { }

	internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument) { }

	internal void DetachUIDocument(UIDocument uiDocument) { }

	internal void DisposePanel() { }

	public BindingLogLevel get_bindingLogLevel() { }

	public bool get_clearColor() { }

	public bool get_clearDepthStencil() { }

	public Color get_colorClearValue() { }

	public float get_depthClearValue() { }

	public DynamicAtlasSettings get_dynamicAtlasSettings() { }

	public float get_fallbackDpi() { }

	internal bool get_isInitialized() { }

	public float get_match() { }

	internal BaseRuntimePanel get_panel() { }

	internal float get_pixelsPerUnit() { }

	public float get_referenceDpi() { }

	public Vector2Int get_referenceResolution() { }

	public float get_referenceSpritePixelsPerUnit() { }

	internal PanelRenderMode get_renderMode() { }

	public float get_scale() { }

	public PanelScaleMode get_scaleMode() { }

	[CompilerGenerated]
	private float get_ScreenDPI() { }

	public PanelScreenMatchMode get_screenMatchMode() { }

	public float get_sortingOrder() { }

	public int get_targetDisplay() { }

	public RenderTexture get_targetTexture() { }

	public ThemeStyleSheet get_themeStyleSheet() { }

	public uint get_vertexBudget() { }

	internal VisualElement get_visualTree() { }

	internal int get_worldSpaceLayer() { }

	internal Rect GetDisplayRect() { }

	internal IDebugPanelChangeReceiver GetPanelChangeReceiver() { }

	private void InitializeShaders() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Reset() { }

	internal float ResolveScale(Rect targetRect, float screenDpi) { }

	public void set_bindingLogLevel(BindingLogLevel value) { }

	public void set_clearColor(bool value) { }

	public void set_clearDepthStencil(bool value) { }

	public void set_colorClearValue(Color value) { }

	public void set_dynamicAtlasSettings(DynamicAtlasSettings value) { }

	public void set_fallbackDpi(float value) { }

	public void set_match(float value) { }

	internal void set_pixelsPerUnit(float value) { }

	public void set_referenceDpi(float value) { }

	public void set_referenceResolution(Vector2Int value) { }

	public void set_referenceSpritePixelsPerUnit(float value) { }

	internal void set_renderMode(PanelRenderMode value) { }

	public void set_scale(float value) { }

	public void set_scaleMode(PanelScaleMode value) { }

	[CompilerGenerated]
	private void set_ScreenDPI(float value) { }

	public void set_screenMatchMode(PanelScreenMatchMode value) { }

	public void set_sortingOrder(float value) { }

	public void set_targetDisplay(int value) { }

	public void set_targetTexture(RenderTexture value) { }

	public void set_themeStyleSheet(ThemeStyleSheet value) { }

	public void set_vertexBudget(uint value) { }

	internal void set_worldSpaceLayer(int value) { }

	[Conditional("ENABLE_PROFILER")]
	public void SetPanelChangeReceiver(IDebugPanelChangeReceiver value) { }

	public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screentoPanelSpaceFunction) { }

	internal void UpdateScreenDPI() { }

}


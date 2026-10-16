namespace UnityEngine.Rendering.PostProcessing;

[AddComponentMenu("Rendering/Post-process Layer", 1000)]
[DisallowMultipleComponent]
[ExecuteAlways]
[ImageEffectAllowedInSceneView]
[RequireComponent(typeof(Camera))]
public sealed class PostProcessLayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<Type, PostProcessBundle>, PostProcessBundle> <>9__54_1; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal PostProcessBundle <UpdateBundleSortList>b__54_1(KeyValuePair<Type, PostProcessBundle> kvp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public PostProcessEvent evt; //Field offset: 0x8
		public List<PostProcessBundle> effects; //Field offset: 0xC

		public <>c__DisplayClass54_0() { }

		internal bool <UpdateBundleSortList>b__0(KeyValuePair<Type, PostProcessBundle> kvp) { }

		internal bool <UpdateBundleSortList>b__2(SerializedBundleRef x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_1
	{
		public string searchStr; //Field offset: 0x8

		public <>c__DisplayClass54_1() { }

		internal bool <UpdateBundleSortList>b__3(PostProcessBundle b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_2
	{
		public string typeName; //Field offset: 0x8

		public <>c__DisplayClass54_2() { }

		internal bool <UpdateBundleSortList>b__4(SerializedBundleRef b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_3
	{
		public string typeName; //Field offset: 0x8

		public <>c__DisplayClass54_3() { }

		internal bool <UpdateBundleSortList>b__5(PostProcessBundle b) { }

	}

	internal enum Antialiasing
	{
		None = 0,
		FastApproximateAntialiasing = 1,
		SubpixelMorphologicalAntialiasing = 2,
		TemporalAntialiasing = 3,
	}

	internal sealed class SerializedBundleRef
	{
		public string assemblyQualifiedName; //Field offset: 0x8
		public PostProcessBundle bundle; //Field offset: 0xC

		public SerializedBundleRef() { }

	}

	public Transform volumeTrigger; //Field offset: 0x10
	public LayerMask volumeLayer; //Field offset: 0x14
	public bool stopNaNPropagation; //Field offset: 0x18
	public bool finalBlitToCameraTarget; //Field offset: 0x19
	public Antialiasing antialiasingMode; //Field offset: 0x1C
	public TemporalAntialiasing temporalAntialiasing; //Field offset: 0x20
	public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing; //Field offset: 0x24
	public FastApproximateAntialiasing fastApproximateAntialiasing; //Field offset: 0x28
	public Fog fog; //Field offset: 0x2C
	private Dithering dithering; //Field offset: 0x30
	public PostProcessDebugLayer debugLayer; //Field offset: 0x34
	[SerializeField]
	private PostProcessResources m_Resources; //Field offset: 0x38
	private PostProcessResources m_OldResources; //Field offset: 0x3C
	[Preserve]
	[SerializeField]
	private bool m_ShowToolkit; //Field offset: 0x40
	[Preserve]
	[SerializeField]
	private bool m_ShowCustomSorter; //Field offset: 0x41
	public bool breakBeforeColorGrading; //Field offset: 0x42
	[SerializeField]
	private List<SerializedBundleRef> m_BeforeTransparentBundles; //Field offset: 0x44
	[SerializeField]
	private List<SerializedBundleRef> m_BeforeStackBundles; //Field offset: 0x48
	[SerializeField]
	private List<SerializedBundleRef> m_AfterStackBundles; //Field offset: 0x4C
	[CompilerGenerated]
	private Dictionary<PostProcessEvent, List`1<SerializedBundleRef>> <sortedBundles>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private DepthTextureMode <cameraDepthFlags>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private bool <haveBundlesBeenInited>k__BackingField; //Field offset: 0x58
	private Dictionary<Type, PostProcessBundle> m_Bundles; //Field offset: 0x5C
	private PropertySheetFactory m_PropertySheetFactory; //Field offset: 0x60
	private CommandBuffer m_LegacyCmdBufferBeforeReflections; //Field offset: 0x64
	private CommandBuffer m_LegacyCmdBufferBeforeLighting; //Field offset: 0x68
	private CommandBuffer m_LegacyCmdBufferOpaque; //Field offset: 0x6C
	private CommandBuffer m_LegacyCmdBuffer; //Field offset: 0x70
	private Camera m_Camera; //Field offset: 0x74
	private PostProcessRenderContext m_CurrentContext; //Field offset: 0x78
	private LogHistogram m_LogHistogram; //Field offset: 0x7C
	private bool m_SettingsUpdateNeeded; //Field offset: 0x80
	private bool m_IsRenderingInSceneView; //Field offset: 0x81
	private TargetPool m_TargetPool; //Field offset: 0x84
	private bool m_NaNKilled; //Field offset: 0x88
	private readonly List<PostProcessEffectRenderer> m_ActiveEffects; //Field offset: 0x8C
	private readonly List<RenderTargetIdentifier> m_Targets; //Field offset: 0x90

	public private DepthTextureMode cameraDepthFlags
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private bool haveBundlesBeenInited
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private Dictionary<PostProcessEvent, List`1<SerializedBundleRef>> sortedBundles
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public PostProcessLayer() { }

	private void ApplyDefaultFlip(MaterialPropertyBlock properties) { }

	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties) { }

	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA = false) { }

	private void BuildCommandBuffers() { }

	private bool DynamicResolutionAllowsFinalBlitToCameraTarget() { }

	[CompilerGenerated]
	public DepthTextureMode get_cameraDepthFlags() { }

	[CompilerGenerated]
	public bool get_haveBundlesBeenInited() { }

	[CompilerGenerated]
	public Dictionary<PostProcessEvent, List`1<SerializedBundleRef>> get_sortedBundles() { }

	public PostProcessBundle GetBundle() { }

	public PostProcessBundle GetBundle(Type settingsType) { }

	public T GetSettings() { }

	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context) { }

	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context) { }

	public void Init(PostProcessResources resources) { }

	public void InitBundles() { }

	private void InitLegacy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPostRender() { }

	private void OnPreCull() { }

	private void OnPreRender() { }

	[ImageEffectUsesCommandBuffer]
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor) { }

	public void Render(PostProcessRenderContext context) { }

	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1) { }

	private int RenderEffect(PostProcessRenderContext context, bool useTempTarget = false) { }

	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1) { }

	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1) { }

	private void RenderList(List<SerializedBundleRef> list, PostProcessRenderContext context, string marker) { }

	public void RenderOpaqueOnly(PostProcessRenderContext context) { }

	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context) { }

	private void Reset() { }

	public void ResetHistory() { }

	[CompilerGenerated]
	private void set_cameraDepthFlags(DepthTextureMode value) { }

	[CompilerGenerated]
	private void set_haveBundlesBeenInited(bool value) { }

	[CompilerGenerated]
	private void set_sortedBundles(Dictionary<PostProcessEvent, List`1<SerializedBundleRef>> value) { }

	private void SetLegacyCameraFlags(PostProcessRenderContext context) { }

	private void SetupContext(PostProcessRenderContext context) { }

	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context) { }

	private void UpdateBundleSortList(List<SerializedBundleRef> sortedList, PostProcessEvent evt) { }

	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining) { }

	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd) { }

}


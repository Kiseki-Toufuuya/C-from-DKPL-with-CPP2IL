namespace UnityEngine;

[NativeClass("UI::Canvas")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Modules/UI/UIStructs.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[RequireComponent(typeof(RectTransform))]
public sealed class Canvas : Behaviour
{
	internal sealed class WillRenderCanvases : MulticastDelegate
	{

		public WillRenderCanvases(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static WillRenderCanvases preWillRenderCanvases; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static WillRenderCanvases willRenderCanvases; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32> <externBeginRenderOverlays>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32, Int32> <externRenderOverlaysBefore>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32> <externEndRenderOverlays>k__BackingField; //Field offset: 0x10

	public static event WillRenderCanvases preWillRenderCanvases
	{
		[CompilerGenerated]
		 add { } //Length: 135
		[CompilerGenerated]
		 remove { } //Length: 135
	}

	public static event WillRenderCanvases willRenderCanvases
	{
		[CompilerGenerated]
		 add { } //Length: 139
		[CompilerGenerated]
		 remove { } //Length: 139
	}

	public AdditionalCanvasShaderChannels additionalShaderChannels
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int cachedSortingLayerValue
	{
		 get { } //Length: 98
	}

	internal static Action<Int32> externBeginRenderOverlays
	{
		[CompilerGenerated]
		internal get { } //Length: 41
		[CompilerGenerated]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 69
	}

	internal static Action<Int32> externEndRenderOverlays
	{
		[CompilerGenerated]
		internal get { } //Length: 41
		[CompilerGenerated]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 69
	}

	internal static Action<Int32, Int32> externRenderOverlaysBefore
	{
		[CompilerGenerated]
		internal get { } //Length: 41
		[CompilerGenerated]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 69
	}

	public bool isRootCanvas
	{
		 get { } //Length: 98
	}

	[NativeProperty("SortingBucketNormalizedSize", False, TargetType::Function (0))]
	public float normalizedSortingGridSize
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public bool overridePixelPerfect
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool overrideSorting
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool pixelPerfect
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Rect pixelRect
	{
		 get { } //Length: 112
	}

	public float planeDistance
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public float referencePixelsPerUnit
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public Vector2 renderingDisplaySize
	{
		 get { } //Length: 121
	}

	public RenderMode renderMode
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int renderOrder
	{
		 get { } //Length: 98
	}

	public Canvas rootCanvas
	{
		 get { } //Length: 120
	}

	public float scaleFactor
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	[NativeProperty("SortingBucketNormalizedSize", False, TargetType::Function (0))]
	[Obsolete("Setting normalizedSize via a int is not supported. Please use normalizedSortingGridSize", False)]
	public int sortingGridNormalizedSize
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int sortingLayerID
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public string sortingLayerName
	{
		 get { } //Length: 279
		 set { } //Length: 420
	}

	public int sortingOrder
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int targetDisplay
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public StandaloneRenderResize updateRectTransformForStandalone
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool vertexColorAlwaysGammaSpace
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[NativeProperty("Camera", False, TargetType::Function (0))]
	public Camera worldCamera
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public Canvas() { }

	[CompilerGenerated]
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	[CompilerGenerated]
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	[RequiredByNativeCode]
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[RequiredByNativeCode]
	private static void EndRenderExtraOverlays(int displayIndex) { }

	public static void ForceUpdateCanvases() { }

	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	private static AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(IntPtr _unity_self) { }

	public int get_cachedSortingLayerValue() { }

	private static int get_cachedSortingLayerValue_Injected(IntPtr _unity_self) { }

	[CompilerGenerated]
	internal static Action<Int32> get_externBeginRenderOverlays() { }

	[CompilerGenerated]
	internal static Action<Int32> get_externEndRenderOverlays() { }

	[CompilerGenerated]
	internal static Action<Int32, Int32> get_externRenderOverlaysBefore() { }

	public bool get_isRootCanvas() { }

	private static bool get_isRootCanvas_Injected(IntPtr _unity_self) { }

	public float get_normalizedSortingGridSize() { }

	private static float get_normalizedSortingGridSize_Injected(IntPtr _unity_self) { }

	public bool get_overridePixelPerfect() { }

	private static bool get_overridePixelPerfect_Injected(IntPtr _unity_self) { }

	public bool get_overrideSorting() { }

	private static bool get_overrideSorting_Injected(IntPtr _unity_self) { }

	public bool get_pixelPerfect() { }

	private static bool get_pixelPerfect_Injected(IntPtr _unity_self) { }

	public Rect get_pixelRect() { }

	private static void get_pixelRect_Injected(IntPtr _unity_self, out Rect ret) { }

	public float get_planeDistance() { }

	private static float get_planeDistance_Injected(IntPtr _unity_self) { }

	public float get_referencePixelsPerUnit() { }

	private static float get_referencePixelsPerUnit_Injected(IntPtr _unity_self) { }

	public Vector2 get_renderingDisplaySize() { }

	private static void get_renderingDisplaySize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public RenderMode get_renderMode() { }

	private static RenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	public int get_renderOrder() { }

	private static int get_renderOrder_Injected(IntPtr _unity_self) { }

	public Canvas get_rootCanvas() { }

	private static IntPtr get_rootCanvas_Injected(IntPtr _unity_self) { }

	public float get_scaleFactor() { }

	private static float get_scaleFactor_Injected(IntPtr _unity_self) { }

	public int get_sortingGridNormalizedSize() { }

	private static int get_sortingGridNormalizedSize_Injected(IntPtr _unity_self) { }

	public int get_sortingLayerID() { }

	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	public string get_sortingLayerName() { }

	private static void get_sortingLayerName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	public int get_sortingOrder() { }

	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	public int get_targetDisplay() { }

	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	public StandaloneRenderResize get_updateRectTransformForStandalone() { }

	private static StandaloneRenderResize get_updateRectTransformForStandalone_Injected(IntPtr _unity_self) { }

	public bool get_vertexColorAlwaysGammaSpace() { }

	private static bool get_vertexColorAlwaysGammaSpace_Injected(IntPtr _unity_self) { }

	public Camera get_worldCamera() { }

	private static IntPtr get_worldCamera_Injected(IntPtr _unity_self) { }

	[FreeFunction("UI::GetDefaultUIMaterial")]
	public static Material GetDefaultCanvasMaterial() { }

	private static IntPtr GetDefaultCanvasMaterial_Injected() { }

	[FreeFunction("UI::GetDefaultUIMaterial")]
	[Obsolete("Shared default material now used for text and general UI elements, call Canvas.GetDefaultCanvasMaterial()", False)]
	public static Material GetDefaultCanvasTextMaterial() { }

	private static IntPtr GetDefaultCanvasTextMaterial_Injected() { }

	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	public static Material GetETC1SupportedCanvasMaterial() { }

	private static IntPtr GetETC1SupportedCanvasMaterial_Injected() { }

	[CompilerGenerated]
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	[CompilerGenerated]
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	[RequiredByNativeCode]
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[RequiredByNativeCode]
	private static void SendPreWillRenderCanvases() { }

	[RequiredByNativeCode]
	private static void SendWillRenderCanvases() { }

	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	private static void set_additionalShaderChannels_Injected(IntPtr _unity_self, AdditionalCanvasShaderChannels value) { }

	[CompilerGenerated]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_externBeginRenderOverlays(Action<Int32> value) { }

	[CompilerGenerated]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_externEndRenderOverlays(Action<Int32> value) { }

	[CompilerGenerated]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_externRenderOverlaysBefore(Action<Int32, Int32> value) { }

	public void set_normalizedSortingGridSize(float value) { }

	private static void set_normalizedSortingGridSize_Injected(IntPtr _unity_self, float value) { }

	public void set_overridePixelPerfect(bool value) { }

	private static void set_overridePixelPerfect_Injected(IntPtr _unity_self, bool value) { }

	public void set_overrideSorting(bool value) { }

	private static void set_overrideSorting_Injected(IntPtr _unity_self, bool value) { }

	public void set_pixelPerfect(bool value) { }

	private static void set_pixelPerfect_Injected(IntPtr _unity_self, bool value) { }

	public void set_planeDistance(float value) { }

	private static void set_planeDistance_Injected(IntPtr _unity_self, float value) { }

	public void set_referencePixelsPerUnit(float value) { }

	private static void set_referencePixelsPerUnit_Injected(IntPtr _unity_self, float value) { }

	public void set_renderMode(RenderMode value) { }

	private static void set_renderMode_Injected(IntPtr _unity_self, RenderMode value) { }

	public void set_scaleFactor(float value) { }

	private static void set_scaleFactor_Injected(IntPtr _unity_self, float value) { }

	public void set_sortingGridNormalizedSize(int value) { }

	private static void set_sortingGridNormalizedSize_Injected(IntPtr _unity_self, int value) { }

	public void set_sortingLayerID(int value) { }

	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	public void set_sortingLayerName(string value) { }

	private static void set_sortingLayerName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public void set_sortingOrder(int value) { }

	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	public void set_targetDisplay(int value) { }

	private static void set_targetDisplay_Injected(IntPtr _unity_self, int value) { }

	public void set_updateRectTransformForStandalone(StandaloneRenderResize value) { }

	private static void set_updateRectTransformForStandalone_Injected(IntPtr _unity_self, StandaloneRenderResize value) { }

	public void set_vertexColorAlwaysGammaSpace(bool value) { }

	private static void set_vertexColorAlwaysGammaSpace_Injected(IntPtr _unity_self, bool value) { }

	public void set_worldCamera(Camera value) { }

	private static void set_worldCamera_Injected(IntPtr _unity_self, IntPtr value) { }

	[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void SetExternalCanvasEnabled(bool enabled) { }

	internal void UpdateCanvasRectTransform(bool alignWithCamera) { }

	private static void UpdateCanvasRectTransform_Injected(IntPtr _unity_self, bool alignWithCamera) { }

}


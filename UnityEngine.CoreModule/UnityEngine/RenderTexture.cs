namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[UsedByNativeCode]
public class RenderTexture : Texture
{

	public static RenderTexture active
	{
		 get { } //Length: 74
		 set { } //Length: 103
	}

	public int antiAliasing
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool autoGenerateMips
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool bindTextureMS
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public RenderBuffer colorBuffer
	{
		 get { } //Length: 121
	}

	public int depth
	{
		[FreeFunction("RenderTextureScripting::GetDepth", HasExplicitThis = True)]
		 get { } //Length: 98
		[FreeFunction("RenderTextureScripting::SetDepth", HasExplicitThis = True)]
		 set { } //Length: 101
	}

	public RenderBuffer depthBuffer
	{
		 get { } //Length: 121
	}

	public GraphicsFormat depthStencilFormat
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public RenderTextureDescriptor descriptor
	{
		 get { } //Length: 172
		 set { } //Length: 151
	}

	public virtual TextureDimension dimension
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("RenderTexture.enabled is always now, no need to use it.", False)]
	public static bool enabled
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public bool enableRandomWrite
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public RenderTextureFormat format
	{
		 get { } //Length: 379
		 set { } //Length: 539
	}

	public GraphicsFormat graphicsFormat
	{
		 get { } //Length: 100
		 set { } //Length: 101
	}

	public virtual int height
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[Obsolete("Use RenderTexture.dimension instead.", False)]
	public bool isCubemap
	{
		 get { } //Length: 34
		 set { } //Length: 49
	}

	public bool isPowerOfTwo
	{
		 get { } //Length: 98
		 set { } //Length: 3
	}

	[Obsolete("Use RenderTexture.dimension instead.", False)]
	public bool isVolume
	{
		 get { } //Length: 34
		 set { } //Length: 45
	}

	[NativeProperty("Memoryless")]
	public RenderTextureMemoryless memorylessMode
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[NativeProperty("SRGBReadWrite")]
	public bool sRGB
	{
		 get { } //Length: 98
	}

	public GraphicsFormat stencilFormat
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool useDynamicScale
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool useDynamicScaleExplicit
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[NativeProperty("MipMap")]
	public bool useMipMap
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int volumeDepth
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[NativeProperty("VRUsage")]
	public VRTextureUsage vrUsage
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public virtual int width
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format) { }

	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[RequiredByNativeCode]
	protected private RenderTexture() { }

	public RenderTexture(RenderTextureDescriptor desc) { }

	public RenderTexture(RenderTexture textureToCopy) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, DefaultFormat format) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	public void ApplyDynamicScale() { }

	private static void ApplyDynamicScale_Injected(IntPtr _unity_self) { }

	[NativeThrows]
	public void ConvertToEquirect(RenderTexture equirect, MonoOrStereoscopicEye eye = 2) { }

	private static void ConvertToEquirect_Injected(IntPtr _unity_self, IntPtr equirect, MonoOrStereoscopicEye eye) { }

	public bool Create() { }

	private static bool Create_Injected(IntPtr _unity_self) { }

	public void DiscardContents(bool discardColor, bool discardDepth) { }

	public void DiscardContents() { }

	private static void DiscardContents_Injected(IntPtr _unity_self, bool discardColor, bool discardDepth) { }

	public void GenerateMips() { }

	private static void GenerateMips_Injected(IntPtr _unity_self) { }

	public static RenderTexture get_active() { }

	public int get_antiAliasing() { }

	private static int get_antiAliasing_Injected(IntPtr _unity_self) { }

	public bool get_autoGenerateMips() { }

	private static bool get_autoGenerateMips_Injected(IntPtr _unity_self) { }

	public bool get_bindTextureMS() { }

	private static bool get_bindTextureMS_Injected(IntPtr _unity_self) { }

	public RenderBuffer get_colorBuffer() { }

	[FreeFunction("RenderTextureScripting::GetDepth", HasExplicitThis = True)]
	public int get_depth() { }

	private static int get_depth_Injected(IntPtr _unity_self) { }

	public RenderBuffer get_depthBuffer() { }

	public GraphicsFormat get_depthStencilFormat() { }

	private static GraphicsFormat get_depthStencilFormat_Injected(IntPtr _unity_self) { }

	public RenderTextureDescriptor get_descriptor() { }

	public virtual TextureDimension get_dimension() { }

	private static TextureDimension get_dimension_Injected(IntPtr _unity_self) { }

	public static bool get_enabled() { }

	public bool get_enableRandomWrite() { }

	private static bool get_enableRandomWrite_Injected(IntPtr _unity_self) { }

	public RenderTextureFormat get_format() { }

	public GraphicsFormat get_graphicsFormat() { }

	public virtual int get_height() { }

	private static int get_height_Injected(IntPtr _unity_self) { }

	public bool get_isCubemap() { }

	public bool get_isPowerOfTwo() { }

	public bool get_isVolume() { }

	public RenderTextureMemoryless get_memorylessMode() { }

	private static RenderTextureMemoryless get_memorylessMode_Injected(IntPtr _unity_self) { }

	public bool get_sRGB() { }

	private static bool get_sRGB_Injected(IntPtr _unity_self) { }

	public GraphicsFormat get_stencilFormat() { }

	private static GraphicsFormat get_stencilFormat_Injected(IntPtr _unity_self) { }

	public bool get_useDynamicScale() { }

	private static bool get_useDynamicScale_Injected(IntPtr _unity_self) { }

	public bool get_useDynamicScaleExplicit() { }

	private static bool get_useDynamicScaleExplicit_Injected(IntPtr _unity_self) { }

	public bool get_useMipMap() { }

	private static bool get_useMipMap_Injected(IntPtr _unity_self) { }

	public int get_volumeDepth() { }

	private static int get_volumeDepth_Injected(IntPtr _unity_self) { }

	public VRTextureUsage get_vrUsage() { }

	private static VRTextureUsage get_vrUsage_Injected(IntPtr _unity_self) { }

	public virtual int get_width() { }

	private static int get_width_Injected(IntPtr _unity_self) { }

	[FreeFunction("RenderTexture::GetActiveAsRenderTexture")]
	private static RenderTexture GetActive() { }

	private static IntPtr GetActive_Injected() { }

	[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = True)]
	private RenderBuffer GetColorBuffer() { }

	private static void GetColorBuffer_Injected(IntPtr _unity_self, out RenderBuffer ret) { }

	[NativeName("GetColorFormat")]
	private GraphicsFormat GetColorFormat(bool suppressWarnings) { }

	private static GraphicsFormat GetColorFormat_Injected(IntPtr _unity_self, bool suppressWarnings) { }

	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = True)]
	private RenderBuffer GetDepthBuffer() { }

	private static void GetDepthBuffer_Injected(IntPtr _unity_self, out RenderBuffer ret) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, ShadowSamplingMode shadowSamplingMode) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format, bool disableFallback = false) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	[NativeName("GetRenderTextureDesc")]
	private RenderTextureDescriptor GetDescriptor() { }

	private static void GetDescriptor_Injected(IntPtr _unity_self, out RenderTextureDescriptor ret) { }

	private bool GetIsPowerOfTwo() { }

	private static bool GetIsPowerOfTwo_Injected(IntPtr _unity_self) { }

	public IntPtr GetNativeDepthBufferPtr() { }

	private static IntPtr GetNativeDepthBufferPtr_Injected(IntPtr _unity_self) { }

	internal static ShadowSamplingMode GetShadowSamplingModeForFormat(RenderTextureFormat format) { }

	internal static ShadowSamplingMode GetShadowSamplingModeForFormat(DefaultFormat format) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	private static IntPtr GetTemporary_Internal_Injected(in RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = false, ShadowSamplingMode shadowSamplingMode = 2) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("GetTexelOffset always returns zero now, no point in using it.", False)]
	public Vector2 GetTexelOffset() { }

	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	[FreeFunction("RenderTextureScripting::Create")]
	private static void Internal_Create(RenderTexture rt) { }

	public bool IsCreated() { }

	private static bool IsCreated_Injected(IntPtr _unity_self) { }

	[Obsolete("This function has no effect.", False)]
	public void MarkRestoreExpected() { }

	private static void MarkRestoreExpected_Injected(IntPtr _unity_self) { }

	public void Release() { }

	private static void Release_Injected(IntPtr _unity_self) { }

	[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
	public static void ReleaseTemporary(RenderTexture temp) { }

	private static void ReleaseTemporary_Injected(IntPtr temp) { }

	[NativeName("ResolveAntiAliasedSurface")]
	private void ResolveAA() { }

	private static void ResolveAA_Injected(IntPtr _unity_self) { }

	[NativeName("ResolveAntiAliasedSurface")]
	private void ResolveAATo(RenderTexture rt) { }

	private static void ResolveAATo_Injected(IntPtr _unity_self, IntPtr rt) { }

	public void ResolveAntiAliasedSurface() { }

	public void ResolveAntiAliasedSurface(RenderTexture target) { }

	public static void set_active(RenderTexture value) { }

	public void set_antiAliasing(int value) { }

	private static void set_antiAliasing_Injected(IntPtr _unity_self, int value) { }

	public void set_autoGenerateMips(bool value) { }

	private static void set_autoGenerateMips_Injected(IntPtr _unity_self, bool value) { }

	public void set_bindTextureMS(bool value) { }

	private static void set_bindTextureMS_Injected(IntPtr _unity_self, bool value) { }

	[FreeFunction("RenderTextureScripting::SetDepth", HasExplicitThis = True)]
	public void set_depth(int value) { }

	private static void set_depth_Injected(IntPtr _unity_self, int value) { }

	public void set_depthStencilFormat(GraphicsFormat value) { }

	private static void set_depthStencilFormat_Injected(IntPtr _unity_self, GraphicsFormat value) { }

	public void set_descriptor(RenderTextureDescriptor value) { }

	public virtual void set_dimension(TextureDimension value) { }

	private static void set_dimension_Injected(IntPtr _unity_self, TextureDimension value) { }

	public static void set_enabled(bool value) { }

	public void set_enableRandomWrite(bool value) { }

	private static void set_enableRandomWrite_Injected(IntPtr _unity_self, bool value) { }

	public void set_format(RenderTextureFormat value) { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	public virtual void set_height(int value) { }

	private static void set_height_Injected(IntPtr _unity_self, int value) { }

	public void set_isCubemap(bool value) { }

	public void set_isPowerOfTwo(bool value) { }

	public void set_isVolume(bool value) { }

	public void set_memorylessMode(RenderTextureMemoryless value) { }

	private static void set_memorylessMode_Injected(IntPtr _unity_self, RenderTextureMemoryless value) { }

	public void set_stencilFormat(GraphicsFormat value) { }

	private static void set_stencilFormat_Injected(IntPtr _unity_self, GraphicsFormat value) { }

	public void set_useDynamicScale(bool value) { }

	private static void set_useDynamicScale_Injected(IntPtr _unity_self, bool value) { }

	public void set_useDynamicScaleExplicit(bool value) { }

	private static void set_useDynamicScaleExplicit_Injected(IntPtr _unity_self, bool value) { }

	public void set_useMipMap(bool value) { }

	private static void set_useMipMap_Injected(IntPtr _unity_self, bool value) { }

	public void set_volumeDepth(int value) { }

	private static void set_volumeDepth_Injected(IntPtr _unity_self, int value) { }

	public void set_vrUsage(VRTextureUsage value) { }

	private static void set_vrUsage_Injected(IntPtr _unity_self, VRTextureUsage value) { }

	public virtual void set_width(int value) { }

	private static void set_width_Injected(IntPtr _unity_self, int value) { }

	[FreeFunction("RenderTextureScripting::SetActive")]
	private static void SetActive(RenderTexture rt) { }

	private static void SetActive_Injected(IntPtr rt) { }

	[NativeName("SetColorFormat")]
	private void SetColorFormat(GraphicsFormat format) { }

	private static void SetColorFormat_Injected(IntPtr _unity_self, GraphicsFormat format) { }

	[FreeFunction(Name = "RenderTextureScripting::SetGlobalShaderProperty", HasExplicitThis = True)]
	public void SetGlobalShaderProperty(string propertyName) { }

	private static void SetGlobalShaderProperty_Injected(IntPtr _unity_self, ref ManagedSpanWrapper propertyName) { }

	private void SetMipMapCount(int count) { }

	private static void SetMipMapCount_Injected(IntPtr _unity_self, int count) { }

	[NativeName("SetRenderTextureDescFromScript")]
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	private static void SetRenderTextureDescriptor_Injected(IntPtr _unity_self, in RenderTextureDescriptor desc) { }

	internal void SetShadowSamplingMode(ShadowSamplingMode samplingMode) { }

	private static void SetShadowSamplingMode_Injected(IntPtr _unity_self, ShadowSamplingMode samplingMode) { }

	internal void SetSRGBReadWrite(bool srgb) { }

	private static void SetSRGBReadWrite_Injected(IntPtr _unity_self, bool srgb) { }

	[FreeFunction("RenderTextureSupportsStencil")]
	public static bool SupportsStencil(RenderTexture rt) { }

	private static bool SupportsStencil_Injected(IntPtr rt) { }

	private static void ValidateRenderTextureDesc(ref RenderTextureDescriptor desc) { }

	internal static void WarnAboutFallbackTo16BitsDepth(RenderTextureFormat format) { }

}


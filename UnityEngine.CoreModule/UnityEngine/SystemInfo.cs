namespace UnityEngine;

[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[NativeHeader("Runtime/Misc/SystemInfoMemory.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
public sealed class SystemInfo
{

	[NativeProperty]
	public static float batteryLevel
	{
		 get { } //Length: 33
	}

	public static CopyTextureSupport copyTextureSupport
	{
		 get { } //Length: 29
	}

	public static string deviceModel
	{
		 get { } //Length: 11
	}

	public static DeviceType deviceType
	{
		 get { } //Length: 29
	}

	public static string deviceUniqueIdentifier
	{
		 get { } //Length: 11
	}

	public static string graphicsDeviceName
	{
		 get { } //Length: 11
	}

	public static GraphicsDeviceType graphicsDeviceType
	{
		 get { } //Length: 29
	}

	public static int graphicsMemorySize
	{
		 get { } //Length: 29
	}

	public static int graphicsShaderLevel
	{
		 get { } //Length: 29
	}

	public static bool graphicsUVStartsAtTop
	{
		 get { } //Length: 29
	}

	public static long maxGraphicsBufferSize
	{
		 get { } //Length: 29
	}

	internal static int maxRenderTextureSize
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 29
	}

	public static int maxTextureSize
	{
		 get { } //Length: 29
	}

	public static string operatingSystem
	{
		 get { } //Length: 11
	}

	public static OperatingSystemFamily operatingSystemFamily
	{
		 get { } //Length: 29
	}

	public static int processorCount
	{
		 get { } //Length: 29
	}

	public static string processorType
	{
		 get { } //Length: 11
	}

	public static int supportedRenderTargetCount
	{
		 get { } //Length: 29
	}

	public static bool supports3DRenderTextures
	{
		 get { } //Length: 29
	}

	public static bool supportsComputeShaders
	{
		 get { } //Length: 29
	}

	public static bool supportsMotionVectors
	{
		 get { } //Length: 29
	}

	public static int systemMemorySize
	{
		 get { } //Length: 29
	}

	public static bool usesLoadStoreActions
	{
		 get { } //Length: 29
	}

	public static bool usesReversedZBuffer
	{
		 get { } //Length: 29
	}

	public static float get_batteryLevel() { }

	public static CopyTextureSupport get_copyTextureSupport() { }

	public static string get_deviceModel() { }

	public static DeviceType get_deviceType() { }

	public static string get_deviceUniqueIdentifier() { }

	public static string get_graphicsDeviceName() { }

	public static GraphicsDeviceType get_graphicsDeviceType() { }

	public static int get_graphicsMemorySize() { }

	public static int get_graphicsShaderLevel() { }

	public static bool get_graphicsUVStartsAtTop() { }

	public static long get_maxGraphicsBufferSize() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int get_maxRenderTextureSize() { }

	public static int get_maxTextureSize() { }

	public static string get_operatingSystem() { }

	public static OperatingSystemFamily get_operatingSystemFamily() { }

	public static int get_processorCount() { }

	public static string get_processorType() { }

	public static int get_supportedRenderTargetCount() { }

	public static bool get_supports3DRenderTextures() { }

	public static bool get_supportsComputeShaders() { }

	public static bool get_supportsMotionVectors() { }

	public static int get_systemMemorySize() { }

	public static bool get_usesLoadStoreActions() { }

	public static bool get_usesReversedZBuffer() { }

	[FreeFunction("systeminfo::GetBatteryLevel")]
	private static float GetBatteryLevel() { }

	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[FreeFunction("ScriptingGraphicsCaps::GetCopyTextureSupport")]
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunction("systeminfo::GetDeviceModel")]
	private static string GetDeviceModel() { }

	private static void GetDeviceModel_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("systeminfo::GetDeviceType")]
	private static DeviceType GetDeviceType() { }

	[FreeFunction("systeminfo::GetDeviceUniqueIdentifier")]
	private static string GetDeviceUniqueIdentifier() { }

	private static void GetDeviceUniqueIdentifier_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
	private static string GetGraphicsDeviceName() { }

	private static void GetGraphicsDeviceName_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceType")]
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsMemorySize")]
	private static int GetGraphicsMemorySize() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
	private static int GetGraphicsShaderLevel() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsUVStartsAtTop")]
	private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
	private static int GetMaxRenderTextureSize() { }

	[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
	private static int GetMaxTextureSize() { }

	[FreeFunction("systeminfo::GetOperatingSystem")]
	private static string GetOperatingSystem() { }

	private static void GetOperatingSystem_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
	private static int GetPhysicalMemoryMB() { }

	[FreeFunction("systeminfo::GetProcessorCount")]
	private static int GetProcessorCount() { }

	[FreeFunction("systeminfo::GetProcessorType")]
	private static string GetProcessorType() { }

	private static void GetProcessorType_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("ScriptingGraphicsCaps::HasRenderTexture")]
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	public static bool IsFormatSupported(GraphicsFormat format, GraphicsFormatUsage usage) { }

	private static bool IsValidEnumValue(Enum value) { }

	[FreeFunction("ScriptingGraphicsCaps::MaxGraphicsBufferSize")]
	private static long MaxGraphicsBufferSize() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportedRenderTargetCount")]
	private static int SupportedRenderTargetCount() { }

	[FreeFunction("ScriptingGraphicsCaps::Supports3DRenderTextures")]
	private static bool Supports3DRenderTextures() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsComputeShaders")]
	private static bool SupportsComputeShaders() { }

	[FreeFunction("SupportsMotionVectors")]
	private static bool SupportsMotionVectors() { }

	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	public static bool SupportsTextureFormat(TextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::UsesLoadStoreActions")]
	private static bool UsesLoadStoreActions() { }

	[FreeFunction("ScriptingGraphicsCaps::UsesReversedZBuffer")]
	private static bool UsesReversedZBuffer() { }

}


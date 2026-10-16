namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
[StaticAccessor("GetGraphicsSettings()", StaticAccessorType::Dot (0))]
public sealed class GraphicsSettings : object
{
	private static Lazy<RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings; //Field offset: 0x0

	public static RenderPipelineAsset currentRenderPipeline
	{
		 get { } //Length: 234
	}

	[NativeName("CurrentRenderPipeline")]
	private static ScriptableObject INTERNAL_currentRenderPipeline
	{
		private get { } //Length: 104
	}

	public static bool lightsUseLinearIntensity
	{
		 get { } //Length: 29
	}

	private static GraphicsSettings() { }

	public static RenderPipelineAsset get_currentRenderPipeline() { }

	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	private static IntPtr get_INTERNAL_currentRenderPipeline_Injected() { }

	public static bool get_lightsUseLinearIntensity() { }

	[RequiredByNativeCode]
	[VisibleToOtherModules]
	internal static Material GetDefaultMaterial(DefaultMaterialType type) { }

	[RequiredByNativeCode]
	[VisibleToOtherModules]
	internal static Shader GetDefaultShader(DefaultShaderType type) { }

	[NativeName("GetShaderModeScript")]
	public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type) { }

	private static RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings() { }

	[NativeName("GetSettingsForRenderPipeline")]
	private static object Internal_GetSettingsForRenderPipeline(string renderpipelineName) { }

	private static IntPtr Internal_GetSettingsForRenderPipeline_Injected(ref ManagedSpanWrapper renderpipelineName) { }

}


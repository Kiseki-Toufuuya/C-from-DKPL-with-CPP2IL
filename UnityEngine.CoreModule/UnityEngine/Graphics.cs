namespace UnityEngine;

[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/CopyTexture.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
public class Graphics
{
	internal static readonly int kMaxDrawMeshInstanceCount; //Field offset: 0x0
	internal static Dictionary<Int32, RenderInstancedDataLayout> s_RenderInstancedDataLayouts; //Field offset: 0x4

	[StaticAccessor("GetGfxDevice()", StaticAccessorType::Dot (0))]
	public static GraphicsTier activeTier
	{
		 get { } //Length: 29
		 set { } //Length: 40
	}

	private static Graphics() { }

	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	public static void Blit(Texture source, RenderTexture dest) { }

	[FreeFunction("GraphicsScripting::Blit")]
	private static void Blit2(Texture source, RenderTexture dest) { }

	private static void Blit2_Injected(IntPtr source, IntPtr dest) { }

	[NativeMethod(Name = "GraphicsScripting::ExecuteCommandBuffer", IsFreeFunction = True, ThrowsException = True)]
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	private static void ExecuteCommandBuffer_Injected(IntPtr buffer) { }

	public static GraphicsTier get_activeTier() { }

	[FreeFunction("GraphicsScripting::BlitMaterial")]
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	private static void Internal_BlitMaterial5_Injected(IntPtr source, IntPtr dest, IntPtr mat, int pass, bool setRT) { }

	[FreeFunction("GraphicsScripting::DrawTexture")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = True)]
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[FreeFunction("GraphicsScripting::SetNullRT")]
	private static void Internal_SetNullRT() { }

	[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = True, ThrowsException = True)]
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	private static void Internal_SetRTSimple_Injected(in RenderBuffer color, in RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	public static void set_activeTier(GraphicsTier value) { }

	[ExcludeFromDocs]
	public static void SetRenderTarget(RenderTexture rt) { }

	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

}


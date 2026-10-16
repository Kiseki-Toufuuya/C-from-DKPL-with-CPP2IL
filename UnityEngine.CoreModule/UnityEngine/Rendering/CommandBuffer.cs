namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Export/Graphics/RenderingCommandBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/RayTracing/RayTracingShader.h")]
[NativeType("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[UsedByNativeCode]
public class CommandBuffer : IDisposable
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(CommandBuffer commandBuffer) { }

	}

	public static bool ThrowOnSetRenderTarget; //Field offset: 0x0
	internal IntPtr m_Ptr; //Field offset: 0x8

	public string name
	{
		 set { } //Length: 372
	}

	public CommandBuffer() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample", HasExplicitThis = True)]
	public void BeginSample(string name) { }

	private static void BeginSample_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	public void Blit(Texture source, RenderTargetIdentifier dest) { }

	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Identifier", HasExplicitThis = True)]
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	private static void Blit_Identifier_Injected(IntPtr _unity_self, ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, IntPtr mat, int pass, in Vector2 scale, in Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Texture", HasExplicitThis = True)]
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	private static void Blit_Texture_Injected(IntPtr _unity_self, IntPtr source, ref RenderTargetIdentifier dest, IntPtr mat, int pass, in Vector2 scale, in Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	private static void CheckThrowOnSetRenderTarget() { }

	[NativeMethod("ClearCommands")]
	public void Clear() { }

	private static void Clear_Injected(IntPtr _unity_self) { }

	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth = 1, uint stencil = 0) { }

	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	private void ClearRenderTargetSingle_Internal(RTClearFlags clearFlags, Color color, float depth, uint stencil) { }

	private static void ClearRenderTargetSingle_Internal_Injected(IntPtr _unity_self, RTClearFlags clearFlags, in Color color, float depth, uint stencil) { }

	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) { }

	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::CopyTexture_Internal", HasExplicitThis = True)]
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	private static void CopyTexture_Internal_Injected(IntPtr _unity_self, ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = True)]
	public void DisableShaderKeyword(string keyword) { }

	private static void DisableShaderKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	private void Dispose(bool disposing) { }

	public override void Dispose() { }

	[ExcludeFromDocs]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = True)]
	public void EnableShaderKeyword(string keyword) { }

	private static void EnableShaderKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::EndSample", HasExplicitThis = True)]
	public void EndSample(string name) { }

	private static void EndSample_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	protected virtual void Finalize() { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRT", HasExplicitThis = True)]
	private void GetTemporaryRT(int nameID, int width, int height, FilterMode filter, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale, ShadowSamplingMode shadowSamplingMode) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite) { }

	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	private static void GetTemporaryRT_Injected(IntPtr _unity_self, int nameID, int width, int height, FilterMode filter, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale, ShadowSamplingMode shadowSamplingMode) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRTWithDescriptor", HasExplicitThis = True)]
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	private static void GetTemporaryRTWithDescriptor_Injected(IntPtr _unity_self, int nameID, in RenderTextureDescriptor desc, FilterMode filter) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::InitBuffer")]
	private static IntPtr InitBuffer() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchCompute", HasExplicitThis = True, ThrowsException = True)]
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	private static void Internal_DispatchCompute_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMesh", HasExplicitThis = True)]
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	private static void Internal_DrawMesh_Injected(IntPtr _unity_self, IntPtr mesh, in Matrix4x4 matrix, IntPtr material, int submeshIndex, int shaderPass, IntPtr properties) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = True)]
	private void Internal_SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	private static void Internal_SetComputeBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, IntPtr buffer) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeFloats", HasExplicitThis = True)]
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, Single[] values) { }

	private static void Internal_SetComputeFloats_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeTextureParam", HasExplicitThis = True)]
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	private static void Internal_SetComputeTextureParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetSinglePassStereo", HasExplicitThis = True)]
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	private static void Internal_SetSinglePassStereo_Injected(IntPtr _unity_self, SinglePassStereoMode mode) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseBuffer", HasExplicitThis = True, IsThreadSafe = True)]
	private void ReleaseBuffer() { }

	private static void ReleaseBuffer_Injected(IntPtr _unity_self) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseTemporaryRT", HasExplicitThis = True)]
	public void ReleaseTemporaryRT(int nameID) { }

	private static void ReleaseTemporaryRT_Injected(IntPtr _unity_self, int nameID) { }

	public void set_name(string value) { }

	private static void set_name_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	public void SetComputeFloatParams(ComputeShader computeShader, string name, Single[] values) { }

	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorParam", HasExplicitThis = True)]
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	private static void SetComputeVectorParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, in Vector4 val) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloat", HasExplicitThis = True)]
	public void SetGlobalFloat(int nameID, float value) { }

	private static void SetGlobalFloat_Injected(IntPtr _unity_self, int nameID, float value) { }

	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalTexture_Impl", HasExplicitThis = True)]
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	private static void SetGlobalTexture_Impl_Injected(IntPtr _unity_self, int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVector", HasExplicitThis = True)]
	public void SetGlobalVector(int nameID, Vector4 value) { }

	private static void SetGlobalVector_Injected(IntPtr _unity_self, int nameID, in Vector4 value) { }

	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	private static void SetRenderTargetColorDepth_Internal_Injected(IntPtr _unity_self, in RenderTargetIdentifier color, in RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	private static void SetRenderTargetMulti_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, in RenderTargetIdentifier depth, ref ManagedSpanWrapper colorLoadActions, ref ManagedSpanWrapper colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	private static void SetRenderTargetSingle_Internal_Injected(IntPtr _unity_self, in RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetViewport", HasExplicitThis = True, ThrowsException = True)]
	public void SetViewport(Rect pixelRect) { }

	private static void SetViewport_Injected(IntPtr _unity_self, in Rect pixelRect) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ValidateAgainstExecutionFlags", HasExplicitThis = True, ThrowsException = True)]
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	private static bool ValidateAgainstExecutionFlags_Injected(IntPtr _unity_self, CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

}


namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/Texture.h")]
[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[UsedByNativeCode]
public struct AsyncGPUReadbackRequest
{
	internal IntPtr m_Ptr; //Field offset: 0x0
	internal int m_Version; //Field offset: 0x4

	[RequiredByNativeCode]
	private static void InvokeCallback(Action<AsyncGPUReadbackRequest> callback, AsyncGPUReadbackRequest obj) { }

}


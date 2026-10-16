namespace UnityEngine;

[NativeClass("GraphicsBuffer")]
[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[UsedByNativeCode]
public sealed class ComputeBuffer : IDisposable
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(ComputeBuffer computeBuffer) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x8

	public int count
	{
		 get { } //Length: 69
	}

	public ComputeBuffer(int count, int stride) { }

	private ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	[FreeFunction("GraphicsBuffer_Bindings::DestroyComputeBuffer")]
	private static void DestroyBuffer(ComputeBuffer buf) { }

	private static void DestroyBuffer_Injected(IntPtr buf) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public int get_count() { }

	private static int get_count_Injected(IntPtr _unity_self) { }

	[FreeFunction("GraphicsBuffer_Bindings::InitComputeBuffer")]
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	public void Release() { }

}


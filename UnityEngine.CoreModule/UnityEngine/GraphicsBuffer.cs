namespace UnityEngine;

[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[UsedByNativeCode]
public sealed class GraphicsBuffer : IDisposable
{
	public static class BindingsMarshaller
	{

		public static GraphicsBuffer ConvertToManaged(IntPtr ptr) { }

		public static IntPtr ConvertToNative(GraphicsBuffer graphicsBuffer) { }

	}

	[Flags]
	internal enum Target
	{
		Vertex = 1,
		Index = 2,
		CopySource = 4,
		CopyDestination = 8,
		Structured = 16,
		Raw = 32,
		Append = 64,
		Counter = 128,
		IndirectArguments = 256,
		Constant = 512,
	}

	internal IntPtr m_Ptr; //Field offset: 0x8

	private GraphicsBuffer(IntPtr ptr) { }

	[FreeFunction("GraphicsBuffer_Bindings::DestroyBuffer")]
	private static void DestroyBuffer(GraphicsBuffer buf) { }

	private static void DestroyBuffer_Injected(IntPtr buf) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

}


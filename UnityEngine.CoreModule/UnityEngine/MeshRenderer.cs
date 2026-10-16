namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
public class MeshRenderer : Renderer
{

	public Mesh additionalVertexStreams
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public Mesh enlightenVertexStream
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public int subMeshStartIndex
	{
		[NativeName("GetSubMeshStartIndex")]
		 get { } //Length: 98
	}

	public MeshRenderer() { }

	[RequiredByNativeCode]
	private void DontStripMeshRenderer() { }

	public Mesh get_additionalVertexStreams() { }

	private static IntPtr get_additionalVertexStreams_Injected(IntPtr _unity_self) { }

	public Mesh get_enlightenVertexStream() { }

	private static IntPtr get_enlightenVertexStream_Injected(IntPtr _unity_self) { }

	[NativeName("GetSubMeshStartIndex")]
	public int get_subMeshStartIndex() { }

	private static int get_subMeshStartIndex_Injected(IntPtr _unity_self) { }

	public void set_additionalVertexStreams(Mesh value) { }

	private static void set_additionalVertexStreams_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_enlightenVertexStream(Mesh value) { }

	private static void set_enlightenVertexStream_Injected(IntPtr _unity_self, IntPtr value) { }

}


namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
[RequireComponent(typeof(Transform))]
public sealed class MeshFilter : Component
{

	public Mesh mesh
	{
		[NativeName("GetInstantiatedMeshFromScript")]
		 get { } //Length: 120
		[NativeName("SetInstantiatedMesh")]
		 set { } //Length: 145
	}

	public Mesh sharedMesh
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public MeshFilter() { }

	[RequiredByNativeCode]
	private void DontStripMeshFilter() { }

	[NativeName("GetInstantiatedMeshFromScript")]
	public Mesh get_mesh() { }

	private static IntPtr get_mesh_Injected(IntPtr _unity_self) { }

	public Mesh get_sharedMesh() { }

	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	[NativeName("SetInstantiatedMesh")]
	public void set_mesh(Mesh value) { }

	private static void set_mesh_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_sharedMesh(Mesh value) { }

	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

}


namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
[NativeHeader("Modules/Physics/MeshCollider.h")]
[RequireComponent(typeof(Transform))]
public class MeshCollider : Collider
{

	public bool convex
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public MeshColliderCookingOptions cookingOptions
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("MeshCollider.inflateMesh is no longer supported. The new cooking algorithm doesn't need inflation to be used.")]
	public bool inflateMesh
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public Mesh sharedMesh
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("MeshCollider.skinWidth is no longer used.")]
	public float skinWidth
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Configuring smooth sphere collisions is no longer needed.", True)]
	public bool smoothSphereCollisions
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public MeshCollider() { }

	public bool get_convex() { }

	private static bool get_convex_Injected(IntPtr _unity_self) { }

	public MeshColliderCookingOptions get_cookingOptions() { }

	private static MeshColliderCookingOptions get_cookingOptions_Injected(IntPtr _unity_self) { }

	public bool get_inflateMesh() { }

	public Mesh get_sharedMesh() { }

	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	public float get_skinWidth() { }

	public bool get_smoothSphereCollisions() { }

	public void set_convex(bool value) { }

	private static void set_convex_Injected(IntPtr _unity_self, bool value) { }

	public void set_cookingOptions(MeshColliderCookingOptions value) { }

	private static void set_cookingOptions_Injected(IntPtr _unity_self, MeshColliderCookingOptions value) { }

	public void set_inflateMesh(bool value) { }

	public void set_sharedMesh(Mesh value) { }

	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_skinWidth(float value) { }

	public void set_smoothSphereCollisions(bool value) { }

}


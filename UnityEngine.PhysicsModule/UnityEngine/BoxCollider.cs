namespace UnityEngine;

[NativeHeader("Modules/Physics/BoxCollider.h")]
[RequireComponent(typeof(Transform))]
public class BoxCollider : Collider
{

	public Vector3 center
	{
		 get { } //Length: 120
		 set { } //Length: 102
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use BoxCollider.size instead. (UnityUpgradable) -> size")]
	public Vector3 extents
	{
		 get { } //Length: 196
		 set { } //Length: 161
	}

	public Vector3 size
	{
		 get { } //Length: 120
		 set { } //Length: 102
	}

	public BoxCollider() { }

	public Vector3 get_center() { }

	private static void get_center_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Vector3 get_extents() { }

	public Vector3 get_size() { }

	private static void get_size_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public void set_center(Vector3 value) { }

	private static void set_center_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_extents(Vector3 value) { }

	public void set_size(Vector3 value) { }

	private static void set_size_Injected(IntPtr _unity_self, in Vector3 value) { }

}


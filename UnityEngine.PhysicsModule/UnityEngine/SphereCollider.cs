namespace UnityEngine;

[NativeHeader("Modules/Physics/SphereCollider.h")]
[RequireComponent(typeof(Transform))]
public class SphereCollider : Collider
{

	public Vector3 center
	{
		 get { } //Length: 120
	}

	public float radius
	{
		 get { } //Length: 102
		 set { } //Length: 639
	}

	public Vector3 get_center() { }

	private static void get_center_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public float get_radius() { }

	private static float get_radius_Injected(IntPtr _unity_self) { }

	public void set_radius(float value) { }

	private static void set_radius_Injected(IntPtr _unity_self, float value) { }

}


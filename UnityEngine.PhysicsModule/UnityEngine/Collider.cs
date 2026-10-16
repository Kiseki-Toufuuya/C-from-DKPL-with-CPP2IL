namespace UnityEngine;

[NativeHeader("Modules/Physics/Collider.h")]
public class Collider : Component
{

	public Rigidbody attachedRigidbody
	{
		[NativeMethod("GetRigidbody")]
		 get { } //Length: 120
	}

	public Bounds bounds
	{
		 get { } //Length: 117
	}

	public bool enabled
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool isTrigger
	{
		 set { } //Length: 101
	}

	public Collider() { }

	public Vector3 ClosestPoint(Vector3 position) { }

	private static void ClosestPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	[NativeMethod("GetRigidbody")]
	public Rigidbody get_attachedRigidbody() { }

	private static IntPtr get_attachedRigidbody_Injected(IntPtr _unity_self) { }

	public Bounds get_bounds() { }

	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	public bool get_enabled() { }

	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	private static void Raycast_Injected(IntPtr _unity_self, in Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	public void set_enabled(bool value) { }

	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	public void set_isTrigger(bool value) { }

	private static void set_isTrigger_Injected(IntPtr _unity_self, bool value) { }

}


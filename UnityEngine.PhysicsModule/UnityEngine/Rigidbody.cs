namespace UnityEngine;

[NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
public class Rigidbody : Component
{

	public bool detectCollisions
	{
		 set { } //Length: 101
	}

	public bool isKinematic
	{
		 set { } //Length: 101
	}

	public Vector3 linearVelocity
	{
		 get { } //Length: 120
	}

	public float mass
	{
		 get { } //Length: 102
	}

	public Vector3 position
	{
		 get { } //Length: 120
	}

	public Quaternion rotation
	{
		 get { } //Length: 112
		 set { } //Length: 102
	}

	public Rigidbody() { }

	public Vector3 get_linearVelocity() { }

	private static void get_linearVelocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public float get_mass() { }

	private static float get_mass_Injected(IntPtr _unity_self) { }

	public Vector3 get_position() { }

	private static void get_position_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Quaternion get_rotation() { }

	private static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	public void MovePosition(Vector3 position) { }

	private static void MovePosition_Injected(IntPtr _unity_self, in Vector3 position) { }

	public void MoveRotation(Quaternion rot) { }

	private static void MoveRotation_Injected(IntPtr _unity_self, in Quaternion rot) { }

	public void set_detectCollisions(bool value) { }

	private static void set_detectCollisions_Injected(IntPtr _unity_self, bool value) { }

	public void set_isKinematic(bool value) { }

	private static void set_isKinematic_Injected(IntPtr _unity_self, bool value) { }

	public void set_rotation(Quaternion value) { }

	private static void set_rotation_Injected(IntPtr _unity_self, in Quaternion value) { }

}


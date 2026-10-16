namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
[RequireComponent(typeof(Transform))]
public sealed class Rigidbody2D : Component
{

	public Vector2 linearVelocity
	{
		 get { } //Length: 121
	}

	public float mass
	{
		 get { } //Length: 102
	}

	public Vector2 position
	{
		 get { } //Length: 121
		 set { } //Length: 460
	}

	public float rotation
	{
		 get { } //Length: 102
	}

	public Rigidbody2D() { }

	public Vector2 get_linearVelocity() { }

	private static void get_linearVelocity_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public float get_mass() { }

	private static float get_mass_Injected(IntPtr _unity_self) { }

	public Vector2 get_position() { }

	private static void get_position_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public float get_rotation() { }

	private static float get_rotation_Injected(IntPtr _unity_self) { }

	public void MovePosition(Vector2 position) { }

	private static void MovePosition_Injected(IntPtr _unity_self, in Vector2 position) { }

	public void MoveRotation(float angle) { }

	[NativeMethod("MoveRotation")]
	private void MoveRotation_Angle(float angle) { }

	private static void MoveRotation_Angle_Injected(IntPtr _unity_self, float angle) { }

	public void set_position(Vector2 value) { }

	private static void set_position_Injected(IntPtr _unity_self, in Vector2 value) { }

}


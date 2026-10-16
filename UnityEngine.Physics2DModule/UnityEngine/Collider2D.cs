namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode(Optional = True)]
public class Collider2D : Behaviour
{

	public Rigidbody2D attachedRigidbody
	{
		[NativeMethod("GetAttachedRigidbody_Binding")]
		 get { } //Length: 265
	}

	public Vector2 offset
	{
		 get { } //Length: 121
	}

	public Collider2D() { }

	[NativeMethod("GetAttachedRigidbody_Binding")]
	public Rigidbody2D get_attachedRigidbody() { }

	private static IntPtr get_attachedRigidbody_Injected(IntPtr _unity_self) { }

	public Vector2 get_offset() { }

	private static void get_offset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public bool OverlapPoint(Vector2 point) { }

	private static bool OverlapPoint_Injected(IntPtr _unity_self, in Vector2 point) { }

}


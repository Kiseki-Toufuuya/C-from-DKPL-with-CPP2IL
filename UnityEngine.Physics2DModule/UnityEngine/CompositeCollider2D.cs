namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/CompositeCollider2D.h")]
[RequireComponent(typeof(Rigidbody2D))]
public sealed class CompositeCollider2D : Collider2D
{

	public int pathCount
	{
		 get { } //Length: 98
	}

	public int pointCount
	{
		 get { } //Length: 98
	}

	public int get_pathCount() { }

	private static int get_pathCount_Injected(IntPtr _unity_self) { }

	public int get_pointCount() { }

	private static int get_pointCount_Injected(IntPtr _unity_self) { }

	public int GetPath(int index, Vector2[] points) { }

	[NativeMethod("GetPathArray_Binding")]
	private int GetPathArray_Internal(int index, Vector2[] points) { }

	private static int GetPathArray_Internal_Injected(IntPtr _unity_self, int index, ref ManagedSpanWrapper points) { }

}


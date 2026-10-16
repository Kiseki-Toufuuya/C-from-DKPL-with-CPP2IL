namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
public sealed class PolygonCollider2D : Collider2D
{

	public int pathCount
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int get_pathCount() { }

	private static int get_pathCount_Injected(IntPtr _unity_self) { }

	public Vector2[] GetPath(int index) { }

	[NativeMethod("GetPath_Binding")]
	private Vector2[] GetPath_Internal(int index) { }

	private static void GetPath_Internal_Injected(IntPtr _unity_self, int index, out BlittableArrayWrapper ret) { }

	[NativeMethod("GetPointCount")]
	public int GetTotalPointCount() { }

	private static int GetTotalPointCount_Injected(IntPtr _unity_self) { }

	public void set_pathCount(int value) { }

	private static void set_pathCount_Injected(IntPtr _unity_self, int value) { }

	public void SetPath(int index, Vector2[] points) { }

	[NativeMethod("SetPath_Binding")]
	private void SetPath_Internal(int index, Vector2[] points) { }

	private static void SetPath_Internal_Injected(IntPtr _unity_self, int index, ref ManagedSpanWrapper points) { }

}


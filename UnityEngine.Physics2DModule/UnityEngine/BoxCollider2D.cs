namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/BoxCollider2D.h")]
public sealed class BoxCollider2D : Collider2D
{

	public bool autoTiling
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("BoxCollider2D.center has been deprecated. Use BoxCollider2D.offset instead (UnityUpgradable) -> offset", True)]
	public Vector2 center
	{
		 get { } //Length: 72
		 set { } //Length: 3
	}

	public float edgeRadius
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public Vector2 size
	{
		 get { } //Length: 121
		 set { } //Length: 102
	}

	public BoxCollider2D() { }

	public bool get_autoTiling() { }

	private static bool get_autoTiling_Injected(IntPtr _unity_self) { }

	public Vector2 get_center() { }

	public float get_edgeRadius() { }

	private static float get_edgeRadius_Injected(IntPtr _unity_self) { }

	public Vector2 get_size() { }

	private static void get_size_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public void set_autoTiling(bool value) { }

	private static void set_autoTiling_Injected(IntPtr _unity_self, bool value) { }

	public void set_center(Vector2 value) { }

	public void set_edgeRadius(float value) { }

	private static void set_edgeRadius_Injected(IntPtr _unity_self, float value) { }

	public void set_size(Vector2 value) { }

	private static void set_size_Injected(IntPtr _unity_self, in Vector2 value) { }

}


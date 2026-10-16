namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/CircleCollider2D.h")]
public sealed class CircleCollider2D : Collider2D
{

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("CircleCollider2D.center has been deprecated. Use CircleCollider2D.offset instead (UnityUpgradable) -> offset", True)]
	public Vector2 center
	{
		 get { } //Length: 72
		 set { } //Length: 3
	}

	public float radius
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public CircleCollider2D() { }

	public Vector2 get_center() { }

	public float get_radius() { }

	private static float get_radius_Injected(IntPtr _unity_self) { }

	public void set_center(Vector2 value) { }

	public void set_radius(float value) { }

	private static void set_radius_Injected(IntPtr _unity_self, float value) { }

}


namespace Cinemachine;

public interface ICinemachineTargetGroup
{

	public Bounds BoundingBox
	{
		 get { } //Length: 0
	}

	public bool IsEmpty
	{
		 get { } //Length: 0
	}

	public BoundingSphere Sphere
	{
		 get { } //Length: 0
	}

	public Transform Transform
	{
		 get { } //Length: 0
	}

	public Bounds get_BoundingBox() { }

	public bool get_IsEmpty() { }

	public BoundingSphere get_Sphere() { }

	public Transform get_Transform() { }

	public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange) { }

	public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer) { }

}


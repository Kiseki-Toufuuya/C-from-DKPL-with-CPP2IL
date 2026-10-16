namespace DG.Tweening.Plugins.Options;

public struct PathOptions : IPlugOptions
{
	public PathMode mode; //Field offset: 0x0
	public OrientType orientType; //Field offset: 0x4
	public AxisConstraint lockPositionAxis; //Field offset: 0x8
	public AxisConstraint lockRotationAxis; //Field offset: 0xC
	public bool isClosedPath; //Field offset: 0x10
	public Vector3 lookAtPosition; //Field offset: 0x14
	public Transform lookAtTransform; //Field offset: 0x20
	public float lookAhead; //Field offset: 0x24
	public bool hasCustomForwardDirection; //Field offset: 0x28
	public Quaternion forward; //Field offset: 0x2C
	public bool useLocalPosition; //Field offset: 0x3C
	public Transform parent; //Field offset: 0x40
	public bool isRigidbody; //Field offset: 0x44
	public bool isRigidbody2D; //Field offset: 0x45
	public bool stableZRotation; //Field offset: 0x46
	internal Quaternion startupRot; //Field offset: 0x48
	internal float startupZRot; //Field offset: 0x58
	internal bool addedExtraStartWp; //Field offset: 0x5C
	internal bool addedExtraEndWp; //Field offset: 0x5D

	public override void Reset() { }

}


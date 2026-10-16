namespace Heqet.RG;

public class LocalTransform
{
	public Vector3 Position; //Field offset: 0x8
	public Quaternion Rotation; //Field offset: 0x14
	public Vector3 Scale; //Field offset: 0x24

	public LocalTransform() { }

	public LocalTransform(Transform t) { }

}


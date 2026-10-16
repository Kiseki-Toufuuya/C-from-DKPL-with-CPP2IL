namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysicsCollisionGeometry.h")]
[NativeHeader("Modules/Physics/PhysXContactModification.h")]
public struct ModifiableContactPair
{
	private IntPtr actor; //Field offset: 0x0
	private IntPtr otherActor; //Field offset: 0x4
	private IntPtr shape; //Field offset: 0x8
	private IntPtr otherShape; //Field offset: 0xC
	public Quaternion rotation; //Field offset: 0x10
	public Vector3 position; //Field offset: 0x20
	public Quaternion otherRotation; //Field offset: 0x2C
	public Vector3 otherPosition; //Field offset: 0x3C
	private int numContacts; //Field offset: 0x48
	private IntPtr contacts; //Field offset: 0x4C

}


namespace Live2D.Cubism.Framework.Physics;

public struct CubismPhysicsParticle
{
	[SerializeField]
	public Vector2 InitialPosition; //Field offset: 0x0
	[SerializeField]
	public float Mobility; //Field offset: 0x8
	[SerializeField]
	public float Delay; //Field offset: 0xC
	[SerializeField]
	public float Acceleration; //Field offset: 0x10
	[SerializeField]
	public float Radius; //Field offset: 0x14
	public Vector2 Position; //Field offset: 0x18
	public Vector2 LastPosition; //Field offset: 0x20
	public Vector2 LastGravity; //Field offset: 0x28
	public Vector2 Force; //Field offset: 0x30
	public Vector2 Velocity; //Field offset: 0x38

}


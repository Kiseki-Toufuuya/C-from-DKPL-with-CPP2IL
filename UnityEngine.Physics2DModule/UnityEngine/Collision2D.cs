namespace UnityEngine;

[RequiredByNativeCode]
public class Collision2D
{
	internal int m_Collider; //Field offset: 0x8
	internal int m_OtherCollider; //Field offset: 0xC
	internal int m_Rigidbody; //Field offset: 0x10
	internal int m_OtherRigidbody; //Field offset: 0x14
	internal Vector2 m_RelativeVelocity; //Field offset: 0x18
	internal int m_Enabled; //Field offset: 0x20
	internal int m_ContactCount; //Field offset: 0x24
	internal ContactPoint2D[] m_ReusedContacts; //Field offset: 0x28
	internal ContactPoint2D[] m_LegacyContacts; //Field offset: 0x2C

	public Collider2D collider
	{
		 get { } //Length: 154
	}

	public GameObject gameObject
	{
		 get { } //Length: 261
	}

	public Vector2 relativeVelocity
	{
		 get { } //Length: 39
	}

	public Rigidbody2D rigidbody
	{
		 get { } //Length: 102
	}

	public Collider2D get_collider() { }

	public GameObject get_gameObject() { }

	public Vector2 get_relativeVelocity() { }

	public Rigidbody2D get_rigidbody() { }

}


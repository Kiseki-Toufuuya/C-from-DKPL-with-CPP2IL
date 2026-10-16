namespace UnityEngine;

public class Collision
{
	private ContactPairHeader m_Header; //Field offset: 0x8
	private ContactPair m_Pair; //Field offset: 0x28
	private bool m_Flipped; //Field offset: 0x48
	private ContactPoint[] m_LegacyContacts; //Field offset: 0x4C

	public Component body
	{
		 get { } //Length: 113
	}

	public Collider collider
	{
		 get { } //Length: 105
	}

	internal bool Flipped
	{
		internal set { } //Length: 14
	}

	public GameObject gameObject
	{
		 get { } //Length: 215
	}

	public Vector3 relativeVelocity
	{
		 get { } //Length: 105
	}

	public Collision() { }

	internal Collision(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	public Component get_body() { }

	public Collider get_collider() { }

	public GameObject get_gameObject() { }

	public Vector3 get_relativeVelocity() { }

	internal void Reuse(in ContactPairHeader header, in ContactPair pair) { }

	internal void set_Flipped(bool value) { }

}


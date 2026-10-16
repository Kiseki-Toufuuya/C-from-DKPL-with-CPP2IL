namespace UnityEngine;

[IsReadOnly]
[UsedByNativeCode]
public struct ContactPair
{
	internal readonly int m_ColliderID; //Field offset: 0x0
	internal readonly int m_OtherColliderID; //Field offset: 0x4
	internal readonly IntPtr m_StartPtr; //Field offset: 0x8
	internal readonly uint m_NbPoints; //Field offset: 0xC
	internal readonly CollisionPairFlags m_Flags; //Field offset: 0x10
	internal readonly CollisionPairEventFlags m_Events; //Field offset: 0x12
	internal readonly Vector3 m_ImpulseSum; //Field offset: 0x14

	public Collider collider
	{
		 get { } //Length: 81
	}

	internal bool hasRemovedCollider
	{
		internal get { } //Length: 31
	}

	public bool isCollisionEnter
	{
		 get { } //Length: 15
	}

	public bool isCollisionExit
	{
		 get { } //Length: 15
	}

	public bool isCollisionStay
	{
		 get { } //Length: 15
	}

	public Collider otherCollider
	{
		 get { } //Length: 83
	}

	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	public Collider get_collider() { }

	internal bool get_hasRemovedCollider() { }

	public bool get_isCollisionEnter() { }

	public bool get_isCollisionExit() { }

	public bool get_isCollisionStay() { }

	public Collider get_otherCollider() { }

	public ContactPairPoint GetContactPoint(int index) { }

	internal ContactPairPoint* GetContactPoint_Internal(int index) { }

}


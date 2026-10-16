namespace UnityEngine;

[IsReadOnly]
[UsedByNativeCode]
public struct ContactPairHeader
{
	internal readonly int m_BodyID; //Field offset: 0x0
	internal readonly int m_OtherBodyID; //Field offset: 0x4
	internal readonly IntPtr m_StartPtr; //Field offset: 0x8
	internal readonly uint m_NbPairs; //Field offset: 0xC
	internal readonly CollisionPairHeaderFlags m_Flags; //Field offset: 0x10
	internal readonly Vector3 m_RelativeVelocity; //Field offset: 0x14

	public Component body
	{
		 get { } //Length: 72
	}

	internal bool hasRemovedBody
	{
		internal get { } //Length: 31
	}

	public Component otherBody
	{
		 get { } //Length: 73
	}

	public Component get_body() { }

	internal bool get_hasRemovedBody() { }

	public Component get_otherBody() { }

	public ContactPair GetContactPair(int index) { }

	internal ContactPair* GetContactPair_Internal(int index) { }

}


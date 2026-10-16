namespace UnityEngine.InputSystem.XR;

public struct Bone
{
	public uint m_ParentBoneIndex; //Field offset: 0x0
	public Vector3 m_Position; //Field offset: 0x4
	public Quaternion m_Rotation; //Field offset: 0x10

	public uint parentBoneIndex
	{
		 get { } //Length: 10
		 set { } //Length: 13
	}

	public Vector3 position
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	public Quaternion rotation
	{
		 get { } //Length: 18
		 set { } //Length: 16
	}

	public uint get_parentBoneIndex() { }

	public Vector3 get_position() { }

	public Quaternion get_rotation() { }

	public void set_parentBoneIndex(uint value) { }

	public void set_position(Vector3 value) { }

	public void set_rotation(Quaternion value) { }

}


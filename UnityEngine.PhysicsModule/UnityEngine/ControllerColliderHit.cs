namespace UnityEngine;

[RequiredByNativeCode]
public class ControllerColliderHit
{
	internal CharacterController m_Controller; //Field offset: 0x8
	internal Collider m_Collider; //Field offset: 0xC
	internal Vector3 m_Point; //Field offset: 0x10
	internal Vector3 m_Normal; //Field offset: 0x1C
	internal Vector3 m_MoveDirection; //Field offset: 0x28
	internal float m_MoveLength; //Field offset: 0x34
	internal int m_Push; //Field offset: 0x38

}


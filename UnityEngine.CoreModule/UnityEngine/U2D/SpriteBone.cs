namespace UnityEngine.U2D;

[MovedFrom("UnityEngine.Experimental.U2D")]
[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[NativeType(CodegenOptions::Custom (1), "ScriptingSpriteBone")]
[RequiredByNativeCode]
public struct SpriteBone
{
	[NativeName("name")]
	[SerializeField]
	private string m_Name; //Field offset: 0x0
	[NativeName("guid")]
	[SerializeField]
	private string m_Guid; //Field offset: 0x4
	[NativeName("position")]
	[SerializeField]
	private Vector3 m_Position; //Field offset: 0x8
	[NativeName("rotation")]
	[SerializeField]
	private Quaternion m_Rotation; //Field offset: 0x14
	[NativeName("length")]
	[SerializeField]
	private float m_Length; //Field offset: 0x24
	[NativeName("parentId")]
	[SerializeField]
	private int m_ParentId; //Field offset: 0x28
	[NativeName("color")]
	[SerializeField]
	private Color32 m_Color; //Field offset: 0x2C

}


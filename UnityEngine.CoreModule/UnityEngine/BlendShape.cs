namespace UnityEngine;

[UsedByNativeCode]
internal struct BlendShape
{
	[SerializeField]
	private uint m_FirstVertex; //Field offset: 0x0
	[SerializeField]
	private uint m_VertexCount; //Field offset: 0x4
	[SerializeField]
	private bool m_HasNormals; //Field offset: 0x8
	[SerializeField]
	private bool m_HasTangents; //Field offset: 0x9

	public uint firstVertex
	{
		 get { } //Length: 10
	}

	public uint vertexCount
	{
		 get { } //Length: 11
	}

	public uint get_firstVertex() { }

	public uint get_vertexCount() { }

}


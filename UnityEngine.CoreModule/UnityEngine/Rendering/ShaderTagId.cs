namespace UnityEngine.Rendering;

public struct ShaderTagId : IEquatable<ShaderTagId>
{
	private int m_Id; //Field offset: 0x0

	internal int id
	{
		internal get { } //Length: 10
		internal set { } //Length: 13
	}

	public ShaderTagId(string name) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(ShaderTagId other) { }

	internal int get_id() { }

	public virtual int GetHashCode() { }

	internal void set_id(int value) { }

}


namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
public abstract class TextAsset : ScriptableObject
{
	[SerializeField]
	internal string m_Version; //Field offset: 0xC
	internal int m_InstanceID; //Field offset: 0x10
	internal int m_HashCode; //Field offset: 0x14
	[FormerlySerializedAs("material")]
	[SerializeField]
	internal Material m_Material; //Field offset: 0x18
	internal int m_MaterialHashCode; //Field offset: 0x1C

	public int hashCode
	{
		 get { } //Length: 44
		 set { } //Length: 14
	}

	public int instanceID
	{
		 get { } //Length: 36
	}

	public Material material
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int materialHashCode
	{
		 get { } //Length: 129
		 set { } //Length: 14
	}

	public internal string version
	{
		 get { } //Length: 11
		internal set { } //Length: 27
	}

	protected TextAsset() { }

	public int get_hashCode() { }

	public int get_instanceID() { }

	public Material get_material() { }

	public int get_materialHashCode() { }

	public string get_version() { }

	public void set_hashCode(int value) { }

	public void set_material(Material value) { }

	public void set_materialHashCode(int value) { }

	internal void set_version(string value) { }

}


namespace TMPro;

public abstract class TMP_Asset : ScriptableObject
{
	[SerializeField]
	internal string m_Version; //Field offset: 0xC
	internal int m_InstanceID; //Field offset: 0x10
	internal int m_HashCode; //Field offset: 0x14
	[SerializeField]
	internal FaceInfo m_FaceInfo; //Field offset: 0x18
	[FormerlySerializedAs("material")]
	[SerializeField]
	internal Material m_Material; //Field offset: 0x6C
	internal int m_MaterialHashCode; //Field offset: 0x70

	public FaceInfo faceInfo
	{
		 get { } //Length: 56
		 set { } //Length: 68
	}

	public int hashCode
	{
		 get { } //Length: 97
		 set { } //Length: 14
	}

	public int instanceID
	{
		 get { } //Length: 33
	}

	public Material material
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int materialHashCode
	{
		 get { } //Length: 165
		 set { } //Length: 14
	}

	public internal string version
	{
		 get { } //Length: 11
		internal set { } //Length: 27
	}

	protected TMP_Asset() { }

	public FaceInfo get_faceInfo() { }

	public int get_hashCode() { }

	public int get_instanceID() { }

	public Material get_material() { }

	public int get_materialHashCode() { }

	public string get_version() { }

	public void set_faceInfo(FaceInfo value) { }

	public void set_hashCode(int value) { }

	public void set_material(Material value) { }

	public void set_materialHashCode(int value) { }

	internal void set_version(string value) { }

}


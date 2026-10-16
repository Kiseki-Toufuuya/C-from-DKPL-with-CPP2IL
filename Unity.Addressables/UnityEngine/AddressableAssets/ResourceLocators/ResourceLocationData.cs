namespace UnityEngine.AddressableAssets.ResourceLocators;

public class ResourceLocationData
{
	[FormerlySerializedAs("m_keys")]
	[SerializeField]
	private String[] m_Keys; //Field offset: 0x8
	[FormerlySerializedAs("m_internalId")]
	[SerializeField]
	private string m_InternalId; //Field offset: 0xC
	[FormerlySerializedAs("m_provider")]
	[SerializeField]
	private string m_Provider; //Field offset: 0x10
	[FormerlySerializedAs("m_dependencies")]
	[SerializeField]
	private String[] m_Dependencies; //Field offset: 0x14
	[SerializeField]
	private SerializedType m_ResourceType; //Field offset: 0x18
	[SerializeField]
	private Byte[] SerializedData; //Field offset: 0x28
	private object _Data; //Field offset: 0x2C

	public object Data
	{
		 get { } //Length: 65
		 set { } //Length: 135
	}

	public String[] Dependencies
	{
		 get { } //Length: 11
	}

	public string InternalId
	{
		 get { } //Length: 11
	}

	public String[] Keys
	{
		 get { } //Length: 11
	}

	public string Provider
	{
		 get { } //Length: 11
	}

	public Type ResourceType
	{
		 get { } //Length: 20
	}

	public ResourceLocationData(String[] keys, string id, Type provider, Type t, String[] dependencies = null) { }

	public object get_Data() { }

	public String[] get_Dependencies() { }

	public string get_InternalId() { }

	public String[] get_Keys() { }

	public string get_Provider() { }

	public Type get_ResourceType() { }

	public void set_Data(object value) { }

}


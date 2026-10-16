namespace UnityEngine.ResourceManagement.Util;

public struct ObjectInitializationData
{
	public class Serializer : ISerializationAdapter<ObjectInitializationData>, ISerializationAdapter
	{
		private struct Data
		{
			public uint id; //Field offset: 0x0
			public uint type; //Field offset: 0x4
			public uint data; //Field offset: 0x8

		}


		public override IEnumerable<ISerializationAdapter> Dependencies
		{
			 get { } //Length: 3
		}

		public Serializer() { }

		public override object Deserialize(Reader reader, Type t, uint offset) { }

		public override IEnumerable<ISerializationAdapter> get_Dependencies() { }

		public override uint Serialize(Writer writer, object val) { }

	}

	[FormerlySerializedAs("m_id")]
	[SerializeField]
	private string m_Id; //Field offset: 0x0
	[FormerlySerializedAs("m_objectType")]
	[SerializeField]
	private SerializedType m_ObjectType; //Field offset: 0x4
	[FormerlySerializedAs("m_data")]
	[SerializeField]
	private string m_Data; //Field offset: 0x14

	public string Data
	{
		 get { } //Length: 11
	}

	public string Id
	{
		 get { } //Length: 10
	}

	public SerializedType ObjectType
	{
		 get { } //Length: 18
	}

	public TObject CreateInstance(string idOverride = null) { }

	public string get_Data() { }

	public string get_Id() { }

	public SerializedType get_ObjectType() { }

	public AsyncOperationHandle GetAsyncInitHandle(ResourceManager rm, string idOverride = null) { }

	public virtual string ToString() { }

}


namespace UnityEngine.ResourceManagement.ResourceLocations;

public class ResourceLocationBase : IResourceLocation
{
	private string m_Name; //Field offset: 0x8
	private string m_Id; //Field offset: 0xC
	private string m_ProviderId; //Field offset: 0x10
	private object m_Data; //Field offset: 0x14
	private int m_DependencyHashCode; //Field offset: 0x18
	private int m_HashCode; //Field offset: 0x1C
	private Type m_Type; //Field offset: 0x20
	private List<IResourceLocation> m_Dependencies; //Field offset: 0x24
	private string m_PrimaryKey; //Field offset: 0x28

	public override object Data
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override IList<IResourceLocation> Dependencies
	{
		 get { } //Length: 11
	}

	public override int DependencyHashCode
	{
		 get { } //Length: 11
	}

	public override bool HasDependencies
	{
		 get { } //Length: 57
	}

	public override string InternalId
	{
		 get { } //Length: 11
	}

	public override string PrimaryKey
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override string ProviderId
	{
		 get { } //Length: 11
	}

	public override Type ResourceType
	{
		 get { } //Length: 11
	}

	public ResourceLocationBase(string name, string id, string providerId, Type t, IResourceLocation[] dependencies) { }

	public void ComputeDependencyHash() { }

	public override object get_Data() { }

	public override IList<IResourceLocation> get_Dependencies() { }

	public override int get_DependencyHashCode() { }

	public override bool get_HasDependencies() { }

	public override string get_InternalId() { }

	public override string get_PrimaryKey() { }

	public override string get_ProviderId() { }

	public override Type get_ResourceType() { }

	public override int Hash(Type t) { }

	public void set_Data(object value) { }

	public void set_PrimaryKey(string value) { }

	public virtual string ToString() { }

}


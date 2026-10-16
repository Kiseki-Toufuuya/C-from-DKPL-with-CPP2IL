namespace System.Runtime.Serialization;

public class DataContractSerializerSettings
{
	private int maxItemsInObjectGraph; //Field offset: 0x8
	[CompilerGenerated]
	private XmlDictionaryString <RootName>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private XmlDictionaryString <RootNamespace>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private IEnumerable<Type> <KnownTypes>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <IgnoreExtensionDataObject>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <PreserveObjectReferences>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	private IDataContractSurrogate <DataContractSurrogate>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private DataContractResolver <DataContractResolver>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <SerializeReadOnlyTypes>k__BackingField; //Field offset: 0x24

	public DataContractResolver DataContractResolver
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public IDataContractSurrogate DataContractSurrogate
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool IgnoreExtensionDataObject
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public IEnumerable<Type> KnownTypes
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int MaxItemsInObjectGraph
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool PreserveObjectReferences
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public XmlDictionaryString RootName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public XmlDictionaryString RootNamespace
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool SerializeReadOnlyTypes
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public DataContractSerializerSettings() { }

	[CompilerGenerated]
	public DataContractResolver get_DataContractResolver() { }

	[CompilerGenerated]
	public IDataContractSurrogate get_DataContractSurrogate() { }

	[CompilerGenerated]
	public bool get_IgnoreExtensionDataObject() { }

	[CompilerGenerated]
	public IEnumerable<Type> get_KnownTypes() { }

	public int get_MaxItemsInObjectGraph() { }

	[CompilerGenerated]
	public bool get_PreserveObjectReferences() { }

	[CompilerGenerated]
	public XmlDictionaryString get_RootName() { }

	[CompilerGenerated]
	public XmlDictionaryString get_RootNamespace() { }

	[CompilerGenerated]
	public bool get_SerializeReadOnlyTypes() { }

	[CompilerGenerated]
	public void set_DataContractResolver(DataContractResolver value) { }

	[CompilerGenerated]
	public void set_DataContractSurrogate(IDataContractSurrogate value) { }

	[CompilerGenerated]
	public void set_IgnoreExtensionDataObject(bool value) { }

	[CompilerGenerated]
	public void set_KnownTypes(IEnumerable<Type> value) { }

	public void set_MaxItemsInObjectGraph(int value) { }

	[CompilerGenerated]
	public void set_PreserveObjectReferences(bool value) { }

	[CompilerGenerated]
	public void set_RootName(XmlDictionaryString value) { }

	[CompilerGenerated]
	public void set_RootNamespace(XmlDictionaryString value) { }

	[CompilerGenerated]
	public void set_SerializeReadOnlyTypes(bool value) { }

}


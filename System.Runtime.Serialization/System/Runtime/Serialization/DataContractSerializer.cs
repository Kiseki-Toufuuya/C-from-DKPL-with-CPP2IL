namespace System.Runtime.Serialization;

public sealed class DataContractSerializer : XmlObjectSerializer
{
	private Type rootType; //Field offset: 0x8
	private DataContract rootContract; //Field offset: 0xC
	private bool needsContractNsAtRoot; //Field offset: 0x10
	private XmlDictionaryString rootName; //Field offset: 0x14
	private XmlDictionaryString rootNamespace; //Field offset: 0x18
	private int maxItemsInObjectGraph; //Field offset: 0x1C
	private bool ignoreExtensionDataObject; //Field offset: 0x20
	private bool preserveObjectReferences; //Field offset: 0x21
	private IDataContractSurrogate dataContractSurrogate; //Field offset: 0x24
	private ReadOnlyCollection<Type> knownTypeCollection; //Field offset: 0x28
	internal IList<Type> knownTypeList; //Field offset: 0x2C
	internal Dictionary<XmlQualifiedName, DataContract> knownDataContracts; //Field offset: 0x30
	private DataContractResolver dataContractResolver; //Field offset: 0x34
	private bool serializeReadOnlyTypes; //Field offset: 0x38

	public DataContractResolver DataContractResolver
	{
		 get { } //Length: 11
	}

	public IDataContractSurrogate DataContractSurrogate
	{
		 get { } //Length: 11
	}

	public bool IgnoreExtensionDataObject
	{
		 get { } //Length: 11
	}

	internal virtual Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
	{
		internal get { } //Length: 51
	}

	public ReadOnlyCollection<Type> KnownTypes
	{
		 get { } //Length: 206
	}

	public int MaxItemsInObjectGraph
	{
		 get { } //Length: 11
	}

	public bool PreserveObjectReferences
	{
		 get { } //Length: 11
	}

	private DataContract RootContract
	{
		private get { } //Length: 132
	}

	public bool SerializeReadOnlyTypes
	{
		 get { } //Length: 11
	}

	public DataContractSerializer(Type type) { }

	public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver) { }

	public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate) { }

	public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes) { }

	public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace) { }

	public DataContractSerializer(Type type, string rootName, string rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver) { }

	public DataContractSerializer(Type type, DataContractSerializerSettings settings) { }

	public DataContractSerializer(Type type, string rootName, string rootNamespace, IEnumerable<Type> knownTypes) { }

	public DataContractSerializer(Type type, string rootName, string rootNamespace) { }

	public DataContractSerializer(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver) { }

	public DataContractSerializer(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate) { }

	public DataContractSerializer(Type type, IEnumerable<Type> knownTypes) { }

	public DataContractSerializer(Type type, string rootName, string rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate) { }

	public DataContractResolver get_DataContractResolver() { }

	public IDataContractSurrogate get_DataContractSurrogate() { }

	public bool get_IgnoreExtensionDataObject() { }

	internal virtual Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

	public ReadOnlyCollection<Type> get_KnownTypes() { }

	public int get_MaxItemsInObjectGraph() { }

	public bool get_PreserveObjectReferences() { }

	private DataContract get_RootContract() { }

	public bool get_SerializeReadOnlyTypes() { }

	internal static DataContract GetDataContract(DataContract declaredTypeContract, Type declaredType, Type objectType) { }

	internal virtual Type GetDeserializeType() { }

	internal virtual Type GetSerializeType(object graph) { }

	internal static Type GetSurrogatedType(IDataContractSurrogate dataContractSurrogate, Type type) { }

	private void Initialize(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver, bool serializeReadOnlyTypes) { }

	private void Initialize(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver, bool serializeReadOnlyTypes) { }

	internal virtual bool InternalIsStartObject(XmlReaderDelegator reader) { }

	internal virtual object InternalReadObject(XmlReaderDelegator xmlReader, bool verifyObjectName, DataContractResolver dataContractResolver) { }

	internal virtual object InternalReadObject(XmlReaderDelegator xmlReader, bool verifyObjectName) { }

	internal virtual void InternalWriteEndObject(XmlWriterDelegator writer) { }

	internal virtual void InternalWriteObject(XmlWriterDelegator writer, object graph) { }

	internal virtual void InternalWriteObject(XmlWriterDelegator writer, object graph, DataContractResolver dataContractResolver) { }

	internal virtual void InternalWriteObjectContent(XmlWriterDelegator writer, object graph) { }

	internal void InternalWriteObjectContent(XmlWriterDelegator writer, object graph, DataContractResolver dataContractResolver) { }

	internal virtual void InternalWriteStartObject(XmlWriterDelegator writer, object graph) { }

	public virtual bool IsStartObject(XmlReader reader) { }

	public virtual bool IsStartObject(XmlDictionaryReader reader) { }

	public virtual object ReadObject(XmlReader reader) { }

	public virtual object ReadObject(XmlReader reader, bool verifyObjectName) { }

	public virtual object ReadObject(XmlDictionaryReader reader, bool verifyObjectName) { }

	public object ReadObject(XmlDictionaryReader reader, bool verifyObjectName, DataContractResolver dataContractResolver) { }

	internal void SetDataContractSurrogate(IDataContractSurrogate adapter) { }

	internal static object SurrogateToDataContractType(IDataContractSurrogate dataContractSurrogate, object oldObj, Type surrogatedDeclaredType, ref Type objType) { }

	public virtual void WriteEndObject(XmlDictionaryWriter writer) { }

	public virtual void WriteEndObject(XmlWriter writer) { }

	public void WriteObject(XmlDictionaryWriter writer, object graph, DataContractResolver dataContractResolver) { }

	public virtual void WriteObject(XmlWriter writer, object graph) { }

	public virtual void WriteObjectContent(XmlDictionaryWriter writer, object graph) { }

	public virtual void WriteObjectContent(XmlWriter writer, object graph) { }

	public virtual void WriteStartObject(XmlDictionaryWriter writer, object graph) { }

	public virtual void WriteStartObject(XmlWriter writer, object graph) { }

}


namespace System.Runtime.Serialization.Json;

[TypeForwardedFrom("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
public sealed class DataContractJsonSerializer : XmlObjectSerializer
{
	internal IList<Type> knownTypeList; //Field offset: 0x8
	internal Dictionary<XmlQualifiedName, DataContract> knownDataContracts; //Field offset: 0xC
	private EmitTypeInformation emitTypeInformation; //Field offset: 0x10
	private IDataContractSurrogate dataContractSurrogate; //Field offset: 0x14
	private bool ignoreExtensionDataObject; //Field offset: 0x18
	private ReadOnlyCollection<Type> knownTypeCollection; //Field offset: 0x1C
	private int maxItemsInObjectGraph; //Field offset: 0x20
	private DataContract rootContract; //Field offset: 0x24
	private XmlDictionaryString rootName; //Field offset: 0x28
	private bool rootNameRequiresMapping; //Field offset: 0x2C
	private Type rootType; //Field offset: 0x30
	private bool serializeReadOnlyTypes; //Field offset: 0x34
	private DateTimeFormat dateTimeFormat; //Field offset: 0x38
	private bool useSimpleDictionaryFormat; //Field offset: 0x3C

	internal bool AlwaysEmitTypeInformation
	{
		internal get { } //Length: 15
	}

	public IDataContractSurrogate DataContractSurrogate
	{
		 get { } //Length: 11
	}

	public DateTimeFormat DateTimeFormat
	{
		 get { } //Length: 11
	}

	public EmitTypeInformation EmitTypeInformation
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

	private DataContract RootContract
	{
		private get { } //Length: 80
	}

	private XmlDictionaryString RootName
	{
		private get { } //Length: 75
	}

	public bool SerializeReadOnlyTypes
	{
		 get { } //Length: 11
	}

	public bool UseSimpleDictionaryFormat
	{
		 get { } //Length: 11
	}

	public DataContractJsonSerializer(Type type) { }

	public DataContractJsonSerializer(Type type, string rootName) { }

	public DataContractJsonSerializer(Type type, XmlDictionaryString rootName) { }

	public DataContractJsonSerializer(Type type, IEnumerable<Type> knownTypes) { }

	public DataContractJsonSerializer(Type type, string rootName, IEnumerable<Type> knownTypes) { }

	public DataContractJsonSerializer(Type type, XmlDictionaryString rootName, IEnumerable<Type> knownTypes) { }

	public DataContractJsonSerializer(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation) { }

	public DataContractJsonSerializer(Type type, string rootName, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation) { }

	public DataContractJsonSerializer(Type type, XmlDictionaryString rootName, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation) { }

	public DataContractJsonSerializer(Type type, DataContractJsonSerializerSettings settings) { }

	private void AddCollectionItemTypeToKnownTypes(Type knownType) { }

	internal static bool CheckIfJsonNameRequiresMapping(XmlDictionaryString jsonName) { }

	internal static bool CheckIfJsonNameRequiresMapping(string jsonName) { }

	internal static void CheckIfTypeIsReference(DataContract dataContract) { }

	internal static bool CheckIfXmlNameRequiresMapping(XmlDictionaryString xmlName) { }

	internal static bool CheckIfXmlNameRequiresMapping(string xmlName) { }

	internal static XmlDictionaryString ConvertXmlNameToJsonName(XmlDictionaryString xmlName) { }

	internal static string ConvertXmlNameToJsonName(string xmlName) { }

	internal bool get_AlwaysEmitTypeInformation() { }

	public IDataContractSurrogate get_DataContractSurrogate() { }

	public DateTimeFormat get_DateTimeFormat() { }

	public EmitTypeInformation get_EmitTypeInformation() { }

	public bool get_IgnoreExtensionDataObject() { }

	internal virtual Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

	public ReadOnlyCollection<Type> get_KnownTypes() { }

	public int get_MaxItemsInObjectGraph() { }

	private DataContract get_RootContract() { }

	private XmlDictionaryString get_RootName() { }

	public bool get_SerializeReadOnlyTypes() { }

	public bool get_UseSimpleDictionaryFormat() { }

	internal static DataContract GetDataContract(DataContract declaredTypeContract, Type declaredType, Type objectType) { }

	internal virtual Type GetDeserializeType() { }

	internal virtual Type GetSerializeType(object graph) { }

	private void Initialize(Type type, XmlDictionaryString rootName, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, EmitTypeInformation emitTypeInformation, bool serializeReadOnlyTypes, DateTimeFormat dateTimeFormat, bool useSimpleDictionaryFormat) { }

	private void Initialize(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, EmitTypeInformation emitTypeInformation, bool serializeReadOnlyTypes, DateTimeFormat dateTimeFormat, bool useSimpleDictionaryFormat) { }

	internal virtual bool InternalIsStartObject(XmlReaderDelegator reader) { }

	internal virtual object InternalReadObject(XmlReaderDelegator xmlReader, bool verifyObjectName) { }

	internal virtual void InternalWriteEndObject(XmlWriterDelegator writer) { }

	internal virtual void InternalWriteObject(XmlWriterDelegator writer, object graph) { }

	internal virtual void InternalWriteObjectContent(XmlWriterDelegator writer, object graph) { }

	internal virtual void InternalWriteStartObject(XmlWriterDelegator writer, object graph) { }

	internal static bool IsJsonLocalName(XmlReaderDelegator reader, string elementName) { }

	public virtual bool IsStartObject(XmlReader reader) { }

	public virtual bool IsStartObject(XmlDictionaryReader reader) { }

	internal static object ReadJsonValue(DataContract contract, XmlReaderDelegator reader, XmlObjectSerializerReadContextComplexJson context) { }

	public virtual object ReadObject(XmlReader reader) { }

	public virtual object ReadObject(XmlDictionaryReader reader) { }

	public virtual object ReadObject(XmlDictionaryReader reader, bool verifyObjectName) { }

	public virtual object ReadObject(Stream stream) { }

	public virtual object ReadObject(XmlReader reader, bool verifyObjectName) { }

	public virtual void WriteEndObject(XmlDictionaryWriter writer) { }

	public virtual void WriteEndObject(XmlWriter writer) { }

	internal static void WriteJsonNull(XmlWriterDelegator writer) { }

	internal static void WriteJsonValue(JsonDataContract contract, XmlWriterDelegator writer, object graph, XmlObjectSerializerWriteContextComplexJson context, RuntimeTypeHandle declaredTypeHandle) { }

	public virtual void WriteObject(XmlDictionaryWriter writer, object graph) { }

	public virtual void WriteObject(XmlWriter writer, object graph) { }

	public virtual void WriteObject(Stream stream, object graph) { }

	public virtual void WriteObjectContent(XmlDictionaryWriter writer, object graph) { }

	public virtual void WriteObjectContent(XmlWriter writer, object graph) { }

	public virtual void WriteStartObject(XmlDictionaryWriter writer, object graph) { }

	public virtual void WriteStartObject(XmlWriter writer, object graph) { }

}


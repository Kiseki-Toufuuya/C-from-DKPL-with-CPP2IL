namespace System.Runtime.Serialization;

internal class XmlObjectSerializerReadContext : XmlObjectSerializerContext
{
	internal Attributes attributes; //Field offset: 0x44
	private HybridObjectCache deserializedObjects; //Field offset: 0x48
	private XmlSerializableReader xmlSerializableReader; //Field offset: 0x4C
	private XmlDocument xmlDocument; //Field offset: 0x50
	private Attributes attributesInXmlData; //Field offset: 0x54
	private XmlReaderDelegator extensionDataReader; //Field offset: 0x58
	private object getOnlyCollectionValue; //Field offset: 0x5C
	private bool isGetOnlyCollection; //Field offset: 0x60

	private HybridObjectCache DeserializedObjects
	{
		private get { } //Length: 87
	}

	private XmlDocument Document
	{
		private get { } //Length: 87
	}

	internal virtual bool IsGetOnlyCollection
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal XmlObjectSerializerReadContext(XmlObjectSerializer serializer, int maxItemsInObjectGraph, StreamingContext streamingContext, bool ignoreExtensionDataObject) { }

	internal XmlObjectSerializerReadContext(DataContractSerializer serializer, DataContract rootTypeDataContract, DataContractResolver dataContractResolver) { }

	protected XmlObjectSerializerReadContext(NetDataContractSerializer serializer) { }

	private XmlAttribute AddNamespaceDeclaration(string prefix, string ns) { }

	public void AddNewObject(object obj) { }

	public void AddNewObjectWithId(string id, object obj) { }

	public void CheckEndOfArray(XmlReaderDelegator xmlReader, int arraySize, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	internal static XmlObjectSerializerReadContext CreateContext(NetDataContractSerializer serializer) { }

	internal static XmlObjectSerializerReadContext CreateContext(DataContractSerializer serializer, DataContract rootTypeDataContract, DataContractResolver dataContractResolver) { }

	protected override XmlReaderDelegator CreateReaderDelegatorForReader(XmlReader xmlReader) { }

	internal XmlReaderDelegator CreateReaderOverChildNodes(IList<XmlAttribute> xmlAttributes, IList<XmlNode> xmlChildNodes) { }

	public static Exception CreateUnexpectedStateException(XmlNodeType expectedState, XmlReaderDelegator xmlReader) { }

	internal static XmlNode CreateWrapperXmlElement(XmlDocument document, IList<XmlAttribute> xmlAttributes, IList<XmlNode> xmlChildNodes, string prefix, string localName, string ns) { }

	private object DeserializeFromExtensionData(IDataNode dataNode, Type type, string name, string ns) { }

	public static T[] EnsureArraySize(T[] array, int index) { }

	private HybridObjectCache get_DeserializedObjects() { }

	private XmlDocument get_Document() { }

	internal virtual bool get_IsGetOnlyCollection() { }

	internal override int GetArraySize() { }

	internal object GetCollectionMember() { }

	public object GetExistingObject(string id, Type type, string name, string ns) { }

	private object GetExistingObjectOrExtensionData(string id) { }

	public int GetMemberIndex(XmlReaderDelegator xmlReader, XmlDictionaryString[] memberNames, XmlDictionaryString[] memberNamespaces, int memberIndex, ExtensionDataObject extensionData) { }

	public int GetMemberIndexWithRequiredMembers(XmlReaderDelegator xmlReader, XmlDictionaryString[] memberNames, XmlDictionaryString[] memberNamespaces, int memberIndex, int requiredIndex, ExtensionDataObject extensionData) { }

	public string GetObjectId() { }

	public object GetRealObject(IObjectReference obj, string id) { }

	protected void HandleMemberNotFound(XmlReaderDelegator xmlReader, ExtensionDataObject extensionData, int memberIndex) { }

	internal void HandleUnknownElement(XmlReaderDelegator xmlReader, ExtensionDataObject extensionData, int memberIndex) { }

	protected void InitializeExtensionDataNode(IDataNode dataNode, string dataContractName, string dataContractNamespace) { }

	public override object InternalDeserialize(XmlReaderDelegator xmlReader, int id, RuntimeTypeHandle declaredTypeHandle, string name, string ns) { }

	internal override object InternalDeserialize(XmlReaderDelegator xmlReader, Type declaredType, string name, string ns) { }

	internal override object InternalDeserialize(XmlReaderDelegator xmlReader, Type declaredType, DataContract dataContract, string name, string ns) { }

	protected object InternalDeserialize(XmlReaderDelegator reader, string name, string ns, Type declaredType, ref DataContract dataContract) { }

	private bool IsContentNode(XmlNodeType nodeType) { }

	protected override bool IsReadingClassExtensionData(XmlReaderDelegator xmlReader) { }

	protected override bool IsReadingCollectionExtensionData(XmlReaderDelegator xmlReader) { }

	public static bool MoveToNextElement(XmlReaderDelegator xmlReader) { }

	internal static void ParseQualifiedName(string qname, XmlReaderDelegator xmlReader, out string name, out string ns, out string prefix) { }

	public static void Read(XmlReaderDelegator xmlReader) { }

	private IDataNode ReadAndResolveUnknownXmlData(XmlReaderDelegator xmlReader, IDictionary<String, String> namespaces, string dataContractName, string dataContractNamespace) { }

	internal override void ReadAttributes(XmlReaderDelegator xmlReader) { }

	protected override object ReadDataContractValue(DataContract dataContract, XmlReaderDelegator reader) { }

	private ExtensionDataMember ReadExtensionDataMember(XmlReaderDelegator xmlReader, int memberIndex) { }

	private IDataNode ReadExtensionDataValue(XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace) { }

	public IDataNode ReadExtensionDataValue(XmlReaderDelegator xmlReader) { }

	public string ReadIfNullOrRef(XmlReaderDelegator xmlReader, Type memberType, bool isMemberTypeSerializable) { }

	internal object ReadIXmlSerializable(XmlReaderDelegator xmlReader, XmlDataContract xmlDataContract, bool isMemberType) { }

	internal static object ReadIXmlSerializable(XmlSerializableReader xmlSerializableReader, XmlReaderDelegator xmlReader, XmlDataContract xmlDataContract, bool isMemberType) { }

	protected override IDataNode ReadPrimitiveExtensionDataValue(XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace) { }

	internal static object ReadRootIXmlSerializable(XmlReaderDelegator xmlReader, XmlDataContract xmlDataContract, bool isMemberType) { }

	public SerializationInfo ReadSerializationInfo(XmlReaderDelegator xmlReader, Type type) { }

	private ClassDataNode ReadUnknownClassData(XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace) { }

	private CollectionDataNode ReadUnknownCollectionData(XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace) { }

	private ISerializableDataNode ReadUnknownISerializableData(XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace) { }

	private IDataNode ReadUnknownPrimitiveData(XmlReaderDelegator xmlReader, Type type, string dataContractName, string dataContractNamespace) { }

	private IDataNode ReadUnknownXmlData(XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace) { }

	public void ReplaceDeserializedObject(string id, object oldObj, object newObj) { }

	private bool ReplaceScopedKnownTypesTop(Dictionary<XmlQualifiedName, DataContract> knownDataContracts, bool knownTypesAddedInCurrentScope) { }

	public void ResetAttributes() { }

	protected override DataContract ResolveDataContractFromTypeName() { }

	internal virtual void set_IsGetOnlyCollection(bool value) { }

	public void SkipUnknownElement(XmlReaderDelegator xmlReader) { }

	protected override void StartReadExtensionDataValue(XmlReaderDelegator xmlReader) { }

	internal void StoreCollectionMemberInfo(object collectionMember) { }

	internal static void ThrowArrayExceededSizeException(int arraySize, Type type) { }

	internal static void ThrowNullValueReturnedForGetOnlyCollectionException(Type type) { }

	public static void ThrowRequiredMemberMissingException(XmlReaderDelegator xmlReader, int memberIndex, int requiredIndex, XmlDictionaryString[] memberNames) { }

	public static T[] TrimArraySize(T[] array, int size) { }

	protected bool TryHandleNullOrRef(XmlReaderDelegator reader, Type declaredType, string name, string ns, ref object retObj) { }

}


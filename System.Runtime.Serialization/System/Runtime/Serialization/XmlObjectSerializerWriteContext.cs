namespace System.Runtime.Serialization;

internal class XmlObjectSerializerWriteContext : XmlObjectSerializerContext
{
	private const int depthToCheckCyclicReference = 512; //Field offset: 0x0
	private ObjectReferenceStack byValObjectsInScope; //Field offset: 0x44
	private XmlSerializableWriter xmlSerializableWriter; //Field offset: 0x54
	protected bool preserveObjectReferences; //Field offset: 0x58
	private ObjectToIdCache serializedObjects; //Field offset: 0x5C
	private bool isGetOnlyCollection; //Field offset: 0x60
	private readonly bool unsafeTypeForwardingEnabled; //Field offset: 0x61
	protected bool serializeReadOnlyTypes; //Field offset: 0x62

	internal virtual bool IsGetOnlyCollection
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	protected ObjectToIdCache SerializedObjects
	{
		 get { } //Length: 87
	}

	internal bool SerializeReadOnlyTypes
	{
		internal get { } //Length: 11
	}

	internal bool UnsafeTypeForwardingEnabled
	{
		internal get { } //Length: 11
	}

	protected XmlObjectSerializerWriteContext(DataContractSerializer serializer, DataContract rootTypeDataContract, DataContractResolver resolver) { }

	protected XmlObjectSerializerWriteContext(NetDataContractSerializer serializer) { }

	internal XmlObjectSerializerWriteContext(XmlObjectSerializer serializer, int maxItemsInObjectGraph, StreamingContext streamingContext, bool ignoreExtensionDataObject) { }

	internal static XmlObjectSerializerWriteContext CreateContext(DataContractSerializer serializer, DataContract rootTypeDataContract, DataContractResolver dataContractResolver) { }

	internal static XmlObjectSerializerWriteContext CreateContext(NetDataContractSerializer serializer, Hashtable surrogateDataContracts) { }

	internal virtual bool get_IsGetOnlyCollection() { }

	protected ObjectToIdCache get_SerializedObjects() { }

	internal bool get_SerializeReadOnlyTypes() { }

	internal bool get_UnsafeTypeForwardingEnabled() { }

	public static T GetDefaultValue() { }

	public static bool GetHasValue(Nullable<T> value) { }

	public static T GetNullableValue(Nullable<T> value) { }

	internal void GetObjectData(ISerializable obj, SerializationInfo serInfo, StreamingContext context) { }

	internal void HandleGraphAtTopLevel(XmlWriterDelegator writer, object obj, DataContract contract) { }

	public void IncrementArrayCount(XmlWriterDelegator xmlWriter, Array array) { }

	private void IncrementCollectionCount(XmlWriterDelegator xmlWriter, int size) { }

	public void IncrementCollectionCount(XmlWriterDelegator xmlWriter, ICollection collection) { }

	public void IncrementCollectionCountGeneric(XmlWriterDelegator xmlWriter, ICollection<T> collection) { }

	public override void InternalSerialize(XmlWriterDelegator xmlWriter, object obj, bool isDeclaredType, bool writeXsiType, int declaredTypeID, RuntimeTypeHandle declaredTypeHandle) { }

	public void InternalSerializeReference(XmlWriterDelegator xmlWriter, object obj, bool isDeclaredType, bool writeXsiType, int declaredTypeID, RuntimeTypeHandle declaredTypeHandle) { }

	internal override void OnEndHandleReference(XmlWriterDelegator xmlWriter, object obj, bool canContainCyclicReference) { }

	internal bool OnHandleIsReference(XmlWriterDelegator xmlWriter, DataContract contract, object obj) { }

	internal override bool OnHandleReference(XmlWriterDelegator xmlWriter, object obj, bool canContainCyclicReference) { }

	private bool ResolveType(Type objectType, Type declaredType, out XmlDictionaryString typeName, out XmlDictionaryString typeNamespace) { }

	protected void SerializeAndVerifyType(DataContract dataContract, XmlWriterDelegator xmlWriter, object obj, bool verifyKnownType, RuntimeTypeHandle declaredTypeHandle, Type declaredType) { }

	internal void SerializeWithoutXsiType(DataContract dataContract, XmlWriterDelegator xmlWriter, object obj, RuntimeTypeHandle declaredTypeHandle) { }

	protected override void SerializeWithXsiType(XmlWriterDelegator xmlWriter, object obj, RuntimeTypeHandle objectTypeHandle, Type objectType, int declaredTypeID, RuntimeTypeHandle declaredTypeHandle, Type declaredType) { }

	internal override void SerializeWithXsiTypeAtTopLevel(DataContract dataContract, XmlWriterDelegator xmlWriter, object obj, RuntimeTypeHandle originalDeclaredTypeHandle, Type graphType) { }

	internal virtual void set_IsGetOnlyCollection(bool value) { }

	internal void StoreIsGetOnlyCollection() { }

	public static void ThrowRequiredMemberMustBeEmitted(string memberName, Type type) { }

	internal bool TryWriteDeserializedExtensionData(XmlWriterDelegator xmlWriter, IDataNode dataNode) { }

	public override void WriteAnyType(XmlWriterDelegator xmlWriter, object value) { }

	internal override void WriteArraySize(XmlWriterDelegator xmlWriter, int size) { }

	public override void WriteBase64(XmlWriterDelegator xmlWriter, Byte[] value) { }

	public override void WriteBase64(XmlWriterDelegator xmlWriter, Byte[] value, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal override bool WriteClrTypeInfo(XmlWriterDelegator xmlWriter, DataContract dataContract) { }

	internal override bool WriteClrTypeInfo(XmlWriterDelegator xmlWriter, Type dataContractType, string clrTypeName, string clrAssemblyName) { }

	internal override bool WriteClrTypeInfo(XmlWriterDelegator xmlWriter, Type dataContractType, SerializationInfo serInfo) { }

	protected override void WriteDataContractValue(DataContract dataContract, XmlWriterDelegator xmlWriter, object obj, RuntimeTypeHandle declaredTypeHandle) { }

	private void WriteExtensionClassData(XmlWriterDelegator xmlWriter, ClassDataNode dataNode) { }

	private void WriteExtensionCollectionData(XmlWriterDelegator xmlWriter, CollectionDataNode dataNode) { }

	public void WriteExtensionData(XmlWriterDelegator xmlWriter, ExtensionDataObject extensionData, int memberIndex) { }

	private void WriteExtensionDataMember(XmlWriterDelegator xmlWriter, ExtensionDataMember member) { }

	internal override void WriteExtensionDataTypeInfo(XmlWriterDelegator xmlWriter, IDataNode dataNode) { }

	internal void WriteExtensionDataValue(XmlWriterDelegator xmlWriter, IDataNode dataNode) { }

	private void WriteExtensionISerializableData(XmlWriterDelegator xmlWriter, ISerializableDataNode dataNode) { }

	private void WriteExtensionXmlData(XmlWriterDelegator xmlWriter, XmlDataNode dataNode) { }

	public void WriteISerializable(XmlWriterDelegator xmlWriter, ISerializable obj) { }

	internal void WriteIXmlSerializable(XmlWriterDelegator xmlWriter, object obj) { }

	private static void WriteIXmlSerializable(XmlWriterDelegator xmlWriter, object obj, XmlSerializableWriter xmlSerializableWriter) { }

	public void WriteNull(XmlWriterDelegator xmlWriter, Type memberType, bool isMemberTypeSerializable) { }

	internal void WriteNull(XmlWriterDelegator xmlWriter, Type memberType, bool isMemberTypeSerializable, XmlDictionaryString name, XmlDictionaryString ns) { }

	protected override void WriteNull(XmlWriterDelegator xmlWriter) { }

	public override void WriteQName(XmlWriterDelegator xmlWriter, XmlQualifiedName value) { }

	public override void WriteQName(XmlWriterDelegator xmlWriter, XmlQualifiedName value, XmlDictionaryString name, XmlDictionaryString ns) { }

	private void WriteResolvedTypeInfo(XmlWriterDelegator writer, Type objectType, Type declaredType) { }

	internal static void WriteRootIXmlSerializable(XmlWriterDelegator xmlWriter, object obj) { }

	internal void WriteSerializationInfo(XmlWriterDelegator xmlWriter, Type objType, SerializationInfo serInfo) { }

	public override void WriteString(XmlWriterDelegator xmlWriter, string value) { }

	public override void WriteString(XmlWriterDelegator xmlWriter, string value, XmlDictionaryString name, XmlDictionaryString ns) { }

	protected override void WriteTypeInfo(XmlWriterDelegator writer, string dataContractName, string dataContractNamespace) { }

	protected override bool WriteTypeInfo(XmlWriterDelegator writer, DataContract contract, DataContract declaredContract) { }

	protected override void WriteTypeInfo(XmlWriterDelegator writer, XmlDictionaryString dataContractName, XmlDictionaryString dataContractNamespace) { }

	public override void WriteUri(XmlWriterDelegator xmlWriter, Uri value) { }

	public override void WriteUri(XmlWriterDelegator xmlWriter, Uri value, XmlDictionaryString name, XmlDictionaryString ns) { }

}


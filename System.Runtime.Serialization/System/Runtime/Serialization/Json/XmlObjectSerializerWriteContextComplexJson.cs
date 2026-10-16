namespace System.Runtime.Serialization.Json;

internal class XmlObjectSerializerWriteContextComplexJson : XmlObjectSerializerWriteContextComplex
{
	private EmitTypeInformation emitXsiType; //Field offset: 0x80
	private bool perCallXsiTypeAlreadyEmitted; //Field offset: 0x84
	private bool useSimpleDictionaryFormat; //Field offset: 0x85

	internal XmlDictionaryString CollectionItemName
	{
		internal get { } //Length: 818
	}

	internal IList<Type> SerializerKnownTypeList
	{
		internal get { } //Length: 11
	}

	public bool UseSimpleDictionaryFormat
	{
		 get { } //Length: 14
	}

	public XmlObjectSerializerWriteContextComplexJson(DataContractJsonSerializer serializer, DataContract rootTypeDataContract) { }

	internal static XmlObjectSerializerWriteContextComplexJson CreateContext(DataContractJsonSerializer serializer, DataContract rootTypeDataContract) { }

	internal XmlDictionaryString get_CollectionItemName() { }

	internal IList<Type> get_SerializerKnownTypeList() { }

	public bool get_UseSimpleDictionaryFormat() { }

	internal virtual DataContract GetDataContract(int id, RuntimeTypeHandle typeHandle) { }

	internal virtual DataContract GetDataContract(RuntimeTypeHandle typeHandle, Type type) { }

	internal virtual DataContract GetDataContractSkipValidation(int typeId, RuntimeTypeHandle typeHandle, Type type) { }

	internal static DataContract GetRevisedItemContract(DataContract oldItemContract) { }

	private void HandleCollectionAssignedToObject(Type declaredType, ref DataContract dataContract, ref object obj, ref bool verifyKnownType) { }

	private static bool RequiresJsonTypeInfo(DataContract contract) { }

	protected virtual DataContract ResolveDataContractFromRootDataContract(XmlQualifiedName typeQName) { }

	internal static DataContract ResolveJsonDataContractFromRootDataContract(XmlObjectSerializerContext context, XmlQualifiedName typeQName, DataContract rootTypeDataContract) { }

	protected virtual void SerializeWithXsiType(XmlWriterDelegator xmlWriter, object obj, RuntimeTypeHandle objectTypeHandle, Type objectType, int declaredTypeID, RuntimeTypeHandle declaredTypeHandle, Type declaredType) { }

	internal virtual void SerializeWithXsiTypeAtTopLevel(DataContract dataContract, XmlWriterDelegator xmlWriter, object obj, RuntimeTypeHandle originalDeclaredTypeHandle, Type graphType) { }

	internal static string TruncateDefaultDataContractNamespace(string dataContractNamespace) { }

	private static void VerifyObjectCompatibilityWithInterface(DataContract contract, object graph, Type declaredType) { }

	private void VerifyType(DataContract dataContract, Type declaredType) { }

	internal virtual void WriteArraySize(XmlWriterDelegator xmlWriter, int size) { }

	internal virtual bool WriteClrTypeInfo(XmlWriterDelegator xmlWriter, Type dataContractType, string clrTypeName, string clrAssemblyName) { }

	internal virtual bool WriteClrTypeInfo(XmlWriterDelegator xmlWriter, DataContract dataContract) { }

	protected virtual void WriteDataContractValue(DataContract dataContract, XmlWriterDelegator xmlWriter, object obj, RuntimeTypeHandle declaredTypeHandle) { }

	internal virtual void WriteExtensionDataTypeInfo(XmlWriterDelegator xmlWriter, IDataNode dataNode) { }

	internal void WriteJsonISerializable(XmlWriterDelegator xmlWriter, ISerializable obj) { }

	internal static void WriteJsonNameWithMapping(XmlWriterDelegator xmlWriter, XmlDictionaryString[] memberNames, int index) { }

	protected virtual void WriteNull(XmlWriterDelegator xmlWriter) { }

	protected virtual bool WriteTypeInfo(XmlWriterDelegator writer, DataContract contract, DataContract declaredContract) { }

	private void WriteTypeInfo(XmlWriterDelegator writer, string typeInformation) { }

	protected virtual void WriteTypeInfo(XmlWriterDelegator writer, string dataContractName, string dataContractNamespace) { }

}


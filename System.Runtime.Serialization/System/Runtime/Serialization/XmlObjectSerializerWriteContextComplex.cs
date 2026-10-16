namespace System.Runtime.Serialization;

internal class XmlObjectSerializerWriteContextComplex : XmlObjectSerializerWriteContext
{
	protected IDataContractSurrogate dataContractSurrogate; //Field offset: 0x64
	private SerializationMode mode; //Field offset: 0x68
	private SerializationBinder binder; //Field offset: 0x6C
	private ISurrogateSelector surrogateSelector; //Field offset: 0x70
	private StreamingContext streamingContext; //Field offset: 0x74
	private Hashtable surrogateDataContracts; //Field offset: 0x7C

	internal virtual SerializationMode Mode
	{
		internal get { } //Length: 11
	}

	internal XmlObjectSerializerWriteContextComplex(DataContractSerializer serializer, DataContract rootTypeDataContract, DataContractResolver dataContractResolver) { }

	internal XmlObjectSerializerWriteContextComplex(NetDataContractSerializer serializer, Hashtable surrogateDataContracts) { }

	internal XmlObjectSerializerWriteContextComplex(XmlObjectSerializer serializer, int maxItemsInObjectGraph, StreamingContext streamingContext, bool ignoreExtensionDataObject) { }

	internal virtual void CheckIfTypeSerializable(Type memberType, bool isMemberTypeSerializable) { }

	private bool CheckIfTypeSerializableForSharedTypeMode(Type memberType) { }

	internal virtual SerializationMode get_Mode() { }

	internal virtual DataContract GetDataContract(RuntimeTypeHandle typeHandle, Type type) { }

	internal virtual DataContract GetDataContract(int id, RuntimeTypeHandle typeHandle) { }

	internal virtual DataContract GetDataContractSkipValidation(int typeId, RuntimeTypeHandle typeHandle, Type type) { }

	internal virtual Type GetSurrogatedType(Type type) { }

	public virtual void InternalSerialize(XmlWriterDelegator xmlWriter, object obj, bool isDeclaredType, bool writeXsiType, int declaredTypeID, RuntimeTypeHandle declaredTypeHandle) { }

	private void InternalSerializeWithSurrogate(XmlWriterDelegator xmlWriter, object obj, bool isDeclaredType, bool writeXsiType, int declaredTypeID, RuntimeTypeHandle declaredTypeHandle) { }

	internal virtual void OnEndHandleReference(XmlWriterDelegator xmlWriter, object obj, bool canContainCyclicReference) { }

	internal virtual bool OnHandleReference(XmlWriterDelegator xmlWriter, object obj, bool canContainCyclicReference) { }

	public virtual void WriteAnyType(XmlWriterDelegator xmlWriter, object value) { }

	internal virtual void WriteArraySize(XmlWriterDelegator xmlWriter, int size) { }

	public virtual void WriteBase64(XmlWriterDelegator xmlWriter, Byte[] value, XmlDictionaryString name, XmlDictionaryString ns) { }

	public virtual void WriteBase64(XmlWriterDelegator xmlWriter, Byte[] value) { }

	internal virtual bool WriteClrTypeInfo(XmlWriterDelegator xmlWriter, Type dataContractType, SerializationInfo serInfo) { }

	internal virtual bool WriteClrTypeInfo(XmlWriterDelegator xmlWriter, Type dataContractType, string clrTypeName, string clrAssemblyName) { }

	internal virtual bool WriteClrTypeInfo(XmlWriterDelegator xmlWriter, DataContract dataContract) { }

	public virtual void WriteQName(XmlWriterDelegator xmlWriter, XmlQualifiedName value) { }

	public virtual void WriteQName(XmlWriterDelegator xmlWriter, XmlQualifiedName value, XmlDictionaryString name, XmlDictionaryString ns) { }

	public virtual void WriteString(XmlWriterDelegator xmlWriter, string value, XmlDictionaryString name, XmlDictionaryString ns) { }

	public virtual void WriteString(XmlWriterDelegator xmlWriter, string value) { }

	public virtual void WriteUri(XmlWriterDelegator xmlWriter, Uri value, XmlDictionaryString name, XmlDictionaryString ns) { }

	public virtual void WriteUri(XmlWriterDelegator xmlWriter, Uri value) { }

}


namespace System.Runtime.Serialization.Json;

internal class XmlObjectSerializerReadContextComplexJson : XmlObjectSerializerReadContextComplex
{
	private string extensionDataValueType; //Field offset: 0x80
	private DateTimeFormat dateTimeFormat; //Field offset: 0x84
	private bool useSimpleDictionaryFormat; //Field offset: 0x88

	internal IList<Type> SerializerKnownTypeList
	{
		internal get { } //Length: 11
	}

	public bool UseSimpleDictionaryFormat
	{
		 get { } //Length: 14
	}

	public XmlObjectSerializerReadContextComplexJson(DataContractJsonSerializer serializer, DataContract rootTypeDataContract) { }

	internal static XmlObjectSerializerReadContextComplexJson CreateContext(DataContractJsonSerializer serializer, DataContract rootTypeDataContract) { }

	protected virtual XmlReaderDelegator CreateReaderDelegatorForReader(XmlReader xmlReader) { }

	internal IList<Type> get_SerializerKnownTypeList() { }

	public bool get_UseSimpleDictionaryFormat() { }

	internal virtual int GetArraySize() { }

	internal virtual DataContract GetDataContract(RuntimeTypeHandle typeHandle, Type type) { }

	internal virtual DataContract GetDataContract(int id, RuntimeTypeHandle typeHandle) { }

	internal virtual DataContract GetDataContractSkipValidation(int typeId, RuntimeTypeHandle typeHandle, Type type) { }

	public int GetJsonMemberIndex(XmlReaderDelegator xmlReader, XmlDictionaryString[] memberNames, int memberIndex, ExtensionDataObject extensionData) { }

	public static string GetJsonMemberName(XmlReaderDelegator xmlReader) { }

	private static bool IsBitSet(Byte[] bytes, int bitIndex) { }

	protected virtual bool IsReadingClassExtensionData(XmlReaderDelegator xmlReader) { }

	protected virtual bool IsReadingCollectionExtensionData(XmlReaderDelegator xmlReader) { }

	internal virtual void ReadAttributes(XmlReaderDelegator xmlReader) { }

	protected virtual object ReadDataContractValue(DataContract dataContract, XmlReaderDelegator reader) { }

	private IDataNode ReadNumericalPrimitiveExtensionDataValue(XmlReaderDelegator xmlReader) { }

	protected virtual IDataNode ReadPrimitiveExtensionDataValue(XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace) { }

	protected virtual DataContract ResolveDataContractFromRootDataContract(XmlQualifiedName typeQName) { }

	protected virtual void StartReadExtensionDataValue(XmlReaderDelegator xmlReader) { }

	public static void ThrowDuplicateMemberException(object obj, XmlDictionaryString[] memberNames, int memberIndex) { }

	public static void ThrowMissingRequiredMembers(object obj, XmlDictionaryString[] memberNames, Byte[] expectedElements, Byte[] requiredElements) { }

	internal static bool TryGetJsonLocalName(XmlReaderDelegator xmlReader, out string name) { }

}


namespace System.Runtime.Serialization.Json;

internal class JsonFormatReaderInterpreter
{
	private enum KeyParseMode
	{
		Fail = 0,
		AsString = 1,
		UsingParseEnum = 2,
		UsingCustomParse = 3,
	}

	private bool is_get_only_collection; //Field offset: 0x8
	private ClassDataContract classContract; //Field offset: 0xC
	private CollectionDataContract collectionContract; //Field offset: 0x10
	private object objectLocal; //Field offset: 0x14
	private Type objectType; //Field offset: 0x18
	private XmlReaderDelegator xmlReader; //Field offset: 0x1C
	private XmlObjectSerializerReadContextComplexJson context; //Field offset: 0x20
	private XmlDictionaryString[] memberNames; //Field offset: 0x24
	private XmlDictionaryString emptyDictionaryString; //Field offset: 0x28
	private XmlDictionaryString itemName; //Field offset: 0x2C
	private XmlDictionaryString itemNamespace; //Field offset: 0x30

	public JsonFormatReaderInterpreter(ClassDataContract classContract) { }

	public JsonFormatReaderInterpreter(CollectionDataContract collectionContract, bool isGetOnly) { }

	private bool CheckRequiredElements(BitFlagsGenerator expectedElements, Byte[] requiredElements) { }

	private void CreateObject(ClassDataContract classContract) { }

	private void HandleUnexpectedItemInCollection(ref int iterator) { }

	private bool HasFactoryMethod(ClassDataContract classContract) { }

	private object InternalDeserialize(Type type, string name) { }

	private bool InvokeFactoryMethod(ClassDataContract classContract) { }

	private void InvokeOnDeserialized(ClassDataContract classContract) { }

	private void InvokeOnDeserializing(ClassDataContract classContract) { }

	private bool IsEndElement() { }

	private bool IsStartElement(XmlDictionaryString name, XmlDictionaryString ns) { }

	private bool IsStartElement() { }

	private void ReadClass(ClassDataContract classContract) { }

	private void ReadCollection(CollectionDataContract collectionContract) { }

	public object ReadCollectionFromJson(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContextComplexJson context, XmlDictionaryString emptyDictionaryString, XmlDictionaryString itemName, CollectionDataContract collectionContract) { }

	private object ReadCollectionItem(CollectionDataContract collectionContract, Type itemType) { }

	public object ReadFromJson(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContextComplexJson context, XmlDictionaryString emptyDictionaryString, XmlDictionaryString[] memberNames) { }

	private void ReadGetOnlyCollection(CollectionDataContract collectionContract) { }

	public void ReadGetOnlyCollectionFromJson(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContextComplexJson context, XmlDictionaryString emptyDictionaryString, XmlDictionaryString itemName, CollectionDataContract collectionContract) { }

	private void ReadISerializable(ClassDataContract classContract) { }

	private int ReadMembers(int index, ClassDataContract classContract, BitFlagsGenerator expectedElements, ref int memberIndex) { }

	private void ReadMembers(ClassDataContract classContract, ExtensionDataObject extensionData) { }

	private void ReadSimpleDictionary(CollectionDataContract collectionContract, Type keyValueType) { }

	private object ReadValue(Type type, string name) { }

	private void ResetExpectedElements(BitFlagsGenerator expectedElements, int index) { }

	private void SetExpectedElements(BitFlagsGenerator expectedElements, int startIndex) { }

	private int SetRequiredElements(ClassDataContract contract, Byte[] requiredElements) { }

	private void StoreCollectionValue(object collection, Type valueType, object value, CollectionDataContract collectionContract) { }

	private void ThrowSerializationException(string msg, Object[] values) { }

	private void ThrowUnexpectedStateException(XmlNodeType expectedState) { }

	private bool TryReadPrimitiveArray(Type itemType, out bool readResult) { }

	private object WrapNullableObject(Type innerType, object innerValue, Type outerType, int nullables) { }

}


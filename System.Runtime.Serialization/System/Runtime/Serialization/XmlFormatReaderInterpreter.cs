namespace System.Runtime.Serialization;

internal class XmlFormatReaderInterpreter
{
	private bool is_get_only_collection; //Field offset: 0x8
	private ClassDataContract classContract; //Field offset: 0xC
	private CollectionDataContract collectionContract; //Field offset: 0x10
	private object objectLocal; //Field offset: 0x14
	private Type objectType; //Field offset: 0x18
	private XmlReaderDelegator xmlReader; //Field offset: 0x1C
	private XmlObjectSerializerReadContext context; //Field offset: 0x20
	private XmlDictionaryString[] memberNames; //Field offset: 0x24
	private XmlDictionaryString[] memberNamespaces; //Field offset: 0x28
	private XmlDictionaryString itemName; //Field offset: 0x2C
	private XmlDictionaryString itemNamespace; //Field offset: 0x30

	public XmlFormatReaderInterpreter(ClassDataContract classContract) { }

	public XmlFormatReaderInterpreter(CollectionDataContract collectionContract, bool isGetOnly) { }

	private void CreateObject(ClassDataContract classContract) { }

	private int GetRequiredMembers(ClassDataContract contract, Boolean[] requiredMembers) { }

	private Boolean[] GetRequiredMembers(ClassDataContract contract, out int firstRequiredMember) { }

	private void HandleUnexpectedItemInCollection(ref int iterator) { }

	private bool HasFactoryMethod(ClassDataContract classContract) { }

	private object InternalDeserialize(Type type, string name, string ns) { }

	private bool InvokeFactoryMethod(ClassDataContract classContract, string objectId) { }

	private void InvokeOnDeserialized(ClassDataContract classContract) { }

	private void InvokeOnDeserializing(ClassDataContract classContract) { }

	private bool IsEndElement() { }

	private bool IsStartElement() { }

	private bool IsStartElement(XmlDictionaryString name, XmlDictionaryString ns) { }

	private void ReadClass(ClassDataContract classContract) { }

	private void ReadCollection(CollectionDataContract collectionContract) { }

	public object ReadCollectionFromXml(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContext context, XmlDictionaryString itemName, XmlDictionaryString itemNamespace, CollectionDataContract collectionContract) { }

	private object ReadCollectionItem(CollectionDataContract collectionContract, Type itemType, string itemName, string itemNs) { }

	public object ReadFromXml(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContext context, XmlDictionaryString[] memberNames, XmlDictionaryString[] memberNamespaces) { }

	private void ReadGetOnlyCollection(CollectionDataContract collectionContract) { }

	public void ReadGetOnlyCollectionFromXml(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContext context, XmlDictionaryString itemName, XmlDictionaryString itemNamespace, CollectionDataContract collectionContract) { }

	private void ReadISerializable(ClassDataContract classContract) { }

	private void ReadMembers(ClassDataContract classContract, ExtensionDataObject extensionData) { }

	private int ReadMembers(int index, ClassDataContract classContract, Boolean[] requiredMembers, ref int memberIndex, ref int requiredIndex) { }

	private object ReadValue(Type type, string name, string ns) { }

	private void StoreCollectionValue(object collection, Type valueType, object value, CollectionDataContract collectionContract) { }

	private bool TryReadPrimitiveArray(Type type, Type itemType, int size, out bool readResult) { }

	private object WrapNullableObject(Type innerType, object innerValue, Type outerType, int nullables) { }

}


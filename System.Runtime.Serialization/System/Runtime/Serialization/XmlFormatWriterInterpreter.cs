namespace System.Runtime.Serialization;

internal class XmlFormatWriterInterpreter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public object currentValue; //Field offset: 0x8

		public <>c__DisplayClass24_0() { }

		internal object <WriteCollection>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public object memberValue; //Field offset: 0x8

		public <>c__DisplayClass25_0() { }

		internal object <WriteMembers>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public object memberValue; //Field offset: 0x8

		public <>c__DisplayClass33_0() { }

		internal object <WriteValue>b__0() { }

	}

	private ClassDataContract classContract; //Field offset: 0x8
	private CollectionDataContract collectionContract; //Field offset: 0xC
	private XmlWriterDelegator writer; //Field offset: 0x10
	private object obj; //Field offset: 0x14
	private XmlObjectSerializerWriteContext ctx; //Field offset: 0x18
	private DataContract dataContract; //Field offset: 0x1C
	private object objLocal; //Field offset: 0x20
	private XmlDictionaryString[] contractNamespaces; //Field offset: 0x24
	private XmlDictionaryString[] memberNames; //Field offset: 0x28
	private XmlDictionaryString[] childElementNamespaces; //Field offset: 0x2C
	private int typeIndex; //Field offset: 0x30
	private int childElementIndex; //Field offset: 0x34

	private ClassDataContract classDataContract
	{
		private get { } //Length: 68
	}

	private CollectionDataContract collectionDataContract
	{
		private get { } //Length: 68
	}

	public XmlFormatWriterInterpreter(ClassDataContract classContract) { }

	public XmlFormatWriterInterpreter(CollectionDataContract collectionContract) { }

	[CompilerGenerated]
	private object <WriteCollection>b__24_0() { }

	private bool CheckIfConflictingMembersHaveDifferentTypes(DataMember member) { }

	private bool CheckIfMemberHasConflict(DataMember member, ClassDataContract classContract, ClassDataContract derivedMostClassContract) { }

	private ClassDataContract get_classDataContract() { }

	private CollectionDataContract get_collectionDataContract() { }

	internal object GetDefaultValue(Type type) { }

	private void InitArgs(Type objType) { }

	private void InvokeOnSerialized(ClassDataContract classContract, object objSerialized, XmlObjectSerializerWriteContext ctx) { }

	private void InvokeOnSerializing(ClassDataContract classContract, object objSerialized, XmlObjectSerializerWriteContext ctx) { }

	internal bool IsDefaultValue(Type type, object value) { }

	private object LoadMemberValue(DataMember member) { }

	private bool NeedsPrefix(Type type, XmlDictionaryString ns) { }

	private bool TryWritePrimitive(Type type, Func<Object> value, MemberInfo memberInfo, Nullable<Int32> arrayItemIndex, XmlDictionaryString ns, XmlDictionaryString name, int nameIndex) { }

	private bool TryWritePrimitiveArray(Type type, Type itemType, Func<Object> value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	private object UnwrapNullableObject(Func<Object> memberValue, ref Type memberType, out bool isNull) { }

	private void WriteClass(ClassDataContract classContract) { }

	private void WriteCollection(CollectionDataContract collectionContract) { }

	public void WriteCollectionToXml(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContext context, CollectionDataContract collectionContract) { }

	private void WriteEndElement() { }

	private int WriteMembers(ClassDataContract classContract, ExtensionDataObject extensionData, ClassDataContract derivedMostClassContract) { }

	private void WriteStartElement(Type type, XmlDictionaryString ns, XmlDictionaryString namespaceLocal, XmlDictionaryString nameLocal, int nameIndex) { }

	public void WriteToXml(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContext context, ClassDataContract dataContract) { }

	private void WriteValue(Type memberType, object memberValue, bool writeXsiType) { }

}


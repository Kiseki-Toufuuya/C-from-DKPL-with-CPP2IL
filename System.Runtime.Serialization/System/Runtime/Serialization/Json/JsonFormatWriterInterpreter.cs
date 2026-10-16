namespace System.Runtime.Serialization.Json;

internal class JsonFormatWriterInterpreter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public object currentValue; //Field offset: 0x8
		public Func<Object> <>9__1; //Field offset: 0xC

		public <>c__DisplayClass22_0() { }

		internal object <WriteCollection>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public object memberValue; //Field offset: 0x8

		public <>c__DisplayClass23_0() { }

		internal object <WriteMembers>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public object memberValue; //Field offset: 0x8

		public <>c__DisplayClass30_0() { }

		internal object <WriteValue>b__0() { }

		internal object <WriteValue>b__1() { }

		internal object <WriteValue>b__2() { }

	}

	private ClassDataContract classContract; //Field offset: 0x8
	private CollectionDataContract collectionContract; //Field offset: 0xC
	private XmlWriterDelegator writer; //Field offset: 0x10
	private object obj; //Field offset: 0x14
	private XmlObjectSerializerWriteContextComplexJson context; //Field offset: 0x18
	private DataContract dataContract; //Field offset: 0x1C
	private object objLocal; //Field offset: 0x20
	private XmlDictionaryString[] memberNames; //Field offset: 0x24
	private int typeIndex; //Field offset: 0x28
	private int childElementIndex; //Field offset: 0x2C

	private ClassDataContract classDataContract
	{
		private get { } //Length: 68
	}

	private CollectionDataContract collectionDataContract
	{
		private get { } //Length: 68
	}

	public JsonFormatWriterInterpreter(ClassDataContract classContract) { }

	public JsonFormatWriterInterpreter(CollectionDataContract collectionContract) { }

	[CompilerGenerated]
	private object <WriteCollection>b__22_0() { }

	private ClassDataContract get_classDataContract() { }

	private CollectionDataContract get_collectionDataContract() { }

	internal object GetDefaultValue(Type type) { }

	private void InitArgs(Type objType) { }

	private void InternalSerialize(MethodInfo methodInfo, Func<Object> memberValue, Type memberType, bool writeXsiType) { }

	private void InvokeOnSerialized(ClassDataContract classContract, object objSerialized, XmlObjectSerializerWriteContext context) { }

	private void InvokeOnSerializing(ClassDataContract classContract, object objSerialized, XmlObjectSerializerWriteContext context) { }

	internal bool IsDefaultValue(Type type, object value) { }

	private object LoadMemberValue(DataMember member) { }

	private bool TryWritePrimitive(Type type, Func<Object> value, MemberInfo memberInfo, Nullable<Int32> arrayItemIndex, XmlDictionaryString name, int nameIndex) { }

	private bool TryWritePrimitiveArray(Type type, Type itemType, Func<Object> value, XmlDictionaryString itemName) { }

	private object UnwrapNullableObject(Func<Object> memberValue, ref Type memberType, out bool isNull) { }

	private void WriteArrayAttribute() { }

	private void WriteClass(ClassDataContract classContract) { }

	private void WriteCollection(CollectionDataContract collectionContract) { }

	public void WriteCollectionToJson(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContextComplexJson context, CollectionDataContract dataContract) { }

	private void WriteEndElement() { }

	private int WriteMembers(ClassDataContract classContract, ExtensionDataObject extensionData, ClassDataContract derivedMostClassContract) { }

	private void WriteObjectAttribute() { }

	private void WriteStartElement(object nameLocal, int nameIndex) { }

	public void WriteToJson(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContextComplexJson context, ClassDataContract dataContract, XmlDictionaryString[] memberNames) { }

	private void WriteValue(Type memberType, object memberValue) { }

}


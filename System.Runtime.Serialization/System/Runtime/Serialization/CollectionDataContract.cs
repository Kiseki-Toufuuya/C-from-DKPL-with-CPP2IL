namespace System.Runtime.Serialization;

internal sealed class CollectionDataContract : DataContract
{
	private class CollectionDataContractCriticalHelper : DataContractCriticalHelper
	{
		private static Type[] _knownInterfaces; //Field offset: 0x0
		private Type itemType; //Field offset: 0x30
		private bool isItemTypeNullable; //Field offset: 0x34
		private CollectionKind kind; //Field offset: 0x35
		private readonly MethodInfo getEnumeratorMethod; //Field offset: 0x38
		private readonly MethodInfo addMethod; //Field offset: 0x3C
		private readonly ConstructorInfo constructor; //Field offset: 0x40
		private readonly string serializationExceptionMessage; //Field offset: 0x44
		private readonly string deserializationExceptionMessage; //Field offset: 0x48
		private DataContract itemContract; //Field offset: 0x4C
		private DataContract sharedTypeContract; //Field offset: 0x50
		private Dictionary<XmlQualifiedName, DataContract> knownDataContracts; //Field offset: 0x54
		private bool isKnownTypeAttributeChecked; //Field offset: 0x58
		private string itemName; //Field offset: 0x5C
		private bool itemNameSetExplicit; //Field offset: 0x60
		private XmlDictionaryString collectionItemName; //Field offset: 0x64
		private string keyName; //Field offset: 0x68
		private string valueName; //Field offset: 0x6C
		private XmlDictionaryString childElementNamespace; //Field offset: 0x70
		private string invalidCollectionInSharedContractMessage; //Field offset: 0x74
		private XmlFormatCollectionReaderDelegate xmlFormatReaderDelegate; //Field offset: 0x78
		private XmlFormatGetOnlyCollectionReaderDelegate xmlFormatGetOnlyCollectionReaderDelegate; //Field offset: 0x7C
		private XmlFormatCollectionWriterDelegate xmlFormatWriterDelegate; //Field offset: 0x80
		private bool isConstructorCheckRequired; //Field offset: 0x84

		internal MethodInfo AddMethod
		{
			internal get { } //Length: 11
		}

		public XmlDictionaryString ChildElementNamespace
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public XmlDictionaryString CollectionItemName
		{
			 get { } //Length: 11
		}

		internal ConstructorInfo Constructor
		{
			internal get { } //Length: 11
		}

		public string DeserializationExceptionMessage
		{
			 get { } //Length: 11
		}

		internal MethodInfo GetEnumeratorMethod
		{
			internal get { } //Length: 11
		}

		internal string InvalidCollectionInSharedContractMessage
		{
			internal get { } //Length: 11
		}

		internal bool IsConstructorCheckRequired
		{
			internal get { } //Length: 14
			internal set { } //Length: 17
		}

		internal bool IsDictionary
		{
			internal get { } //Length: 15
		}

		internal bool IsItemTypeNullable
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal DataContract ItemContract
		{
			internal get { } //Length: 467
			internal set { } //Length: 27
		}

		internal string ItemName
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal bool ItemNameSetExplicit
		{
			internal get { } //Length: 11
		}

		internal Type ItemType
		{
			internal get { } //Length: 11
		}

		internal string KeyName
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal CollectionKind Kind
		{
			internal get { } //Length: 11
		}

		internal virtual Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
		{
			internal get { } //Length: 299
			internal set { } //Length: 27
		}

		internal static Type[] KnownInterfaces
		{
			internal get { } //Length: 758
		}

		public string SerializationExceptionMessage
		{
			 get { } //Length: 11
		}

		internal DataContract SharedTypeContract
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal string ValueName
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal XmlFormatGetOnlyCollectionReaderDelegate XmlFormatGetOnlyCollectionReaderDelegate
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal XmlFormatCollectionReaderDelegate XmlFormatReaderDelegate
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal XmlFormatCollectionWriterDelegate XmlFormatWriterDelegate
		{
			internal get { } //Length: 14
			internal set { } //Length: 33
		}

		internal CollectionDataContractCriticalHelper(CollectionKind kind) { }

		internal CollectionDataContractCriticalHelper(Type type) { }

		internal CollectionDataContractCriticalHelper(Type type, DataContract itemContract) { }

		internal CollectionDataContractCriticalHelper(Type type, CollectionKind kind, Type itemType, MethodInfo getEnumeratorMethod, string serializationExceptionMessage, string deserializationExceptionMessage) { }

		internal CollectionDataContractCriticalHelper(Type type, CollectionKind kind, Type itemType, MethodInfo getEnumeratorMethod, MethodInfo addMethod, ConstructorInfo constructor) { }

		internal CollectionDataContractCriticalHelper(Type type, CollectionKind kind, Type itemType, MethodInfo getEnumeratorMethod, MethodInfo addMethod, ConstructorInfo constructor, bool isConstructorCheckRequired) { }

		internal CollectionDataContractCriticalHelper(Type type, string invalidCollectionInSharedContractMessage) { }

		internal MethodInfo get_AddMethod() { }

		public XmlDictionaryString get_ChildElementNamespace() { }

		public XmlDictionaryString get_CollectionItemName() { }

		internal ConstructorInfo get_Constructor() { }

		public string get_DeserializationExceptionMessage() { }

		internal MethodInfo get_GetEnumeratorMethod() { }

		internal string get_InvalidCollectionInSharedContractMessage() { }

		internal bool get_IsConstructorCheckRequired() { }

		internal bool get_IsDictionary() { }

		internal bool get_IsItemTypeNullable() { }

		internal DataContract get_ItemContract() { }

		internal string get_ItemName() { }

		internal bool get_ItemNameSetExplicit() { }

		internal Type get_ItemType() { }

		internal string get_KeyName() { }

		internal CollectionKind get_Kind() { }

		internal virtual Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

		internal static Type[] get_KnownInterfaces() { }

		public string get_SerializationExceptionMessage() { }

		internal DataContract get_SharedTypeContract() { }

		internal string get_ValueName() { }

		internal XmlFormatGetOnlyCollectionReaderDelegate get_XmlFormatGetOnlyCollectionReaderDelegate() { }

		internal XmlFormatCollectionReaderDelegate get_XmlFormatReaderDelegate() { }

		internal XmlFormatCollectionWriterDelegate get_XmlFormatWriterDelegate() { }

		private void Init(CollectionKind kind, Type itemType, CollectionDataContractAttribute collectionContractAttribute) { }

		public void set_ChildElementNamespace(XmlDictionaryString value) { }

		internal void set_IsConstructorCheckRequired(bool value) { }

		internal void set_IsItemTypeNullable(bool value) { }

		internal void set_ItemContract(DataContract value) { }

		internal void set_ItemName(string value) { }

		internal void set_KeyName(string value) { }

		internal virtual void set_KnownDataContracts(Dictionary<XmlQualifiedName, DataContract> value) { }

		internal void set_SharedTypeContract(DataContract value) { }

		internal void set_ValueName(string value) { }

		internal void set_XmlFormatGetOnlyCollectionReaderDelegate(XmlFormatGetOnlyCollectionReaderDelegate value) { }

		internal void set_XmlFormatReaderDelegate(XmlFormatCollectionReaderDelegate value) { }

		internal void set_XmlFormatWriterDelegate(XmlFormatCollectionWriterDelegate value) { }

	}

	internal class DictionaryEnumerator : IEnumerator<KeyValue`2<Object, Object>>, IDisposable, IEnumerator
	{
		private IDictionaryEnumerator enumerator; //Field offset: 0x8

		public override KeyValue<Object, Object> Current
		{
			 get { } //Length: 142
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 192
		}

		public DictionaryEnumerator(IDictionaryEnumerator enumerator) { }

		public override void Dispose() { }

		public override KeyValue<Object, Object> get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal class GenericDictionaryEnumerator : IEnumerator<KeyValue`2<K, V>>, IDisposable, IEnumerator
	{
		private IEnumerator<KeyValuePair`2<K, V>> enumerator; //Field offset: 0x0

		public override KeyValue<K, V> Current
		{
			 get { } //Length: 471
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 92
		}

		public GenericDictionaryEnumerator`2(IEnumerator<KeyValuePair`2<K, V>> enumerator) { }

		public override void Dispose() { }

		public override KeyValue<K, V> get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private XmlDictionaryString collectionItemName; //Field offset: 0x14
	private XmlDictionaryString childElementNamespace; //Field offset: 0x18
	private DataContract itemContract; //Field offset: 0x1C
	private CollectionDataContractCriticalHelper helper; //Field offset: 0x20

	internal MethodInfo AddMethod
	{
		internal get { } //Length: 23
	}

	public XmlDictionaryString ChildElementNamespace
	{
		 get { } //Length: 381
	}

	public XmlDictionaryString CollectionItemName
	{
		 get { } //Length: 11
	}

	internal ConstructorInfo Constructor
	{
		internal get { } //Length: 23
	}

	internal string DeserializationExceptionMessage
	{
		internal get { } //Length: 23
	}

	internal MethodInfo GetEnumeratorMethod
	{
		internal get { } //Length: 23
	}

	internal string InvalidCollectionInSharedContractMessage
	{
		internal get { } //Length: 23
	}

	internal bool IsConstructorCheckRequired
	{
		internal get { } //Length: 26
		internal set { } //Length: 29
	}

	internal bool IsDictionary
	{
		internal get { } //Length: 27
	}

	internal bool IsItemTypeNullable
	{
		internal get { } //Length: 23
		internal set { } //Length: 26
	}

	internal bool IsReadOnlyContract
	{
		internal get { } //Length: 27
	}

	public DataContract ItemContract
	{
		 get { } //Length: 43
		 set { } //Length: 59
	}

	internal string ItemName
	{
		internal get { } //Length: 23
		internal set { } //Length: 39
	}

	private bool ItemNameSetExplicit
	{
		private get { } //Length: 23
	}

	internal Type ItemType
	{
		internal get { } //Length: 23
	}

	internal string KeyName
	{
		internal get { } //Length: 23
		internal set { } //Length: 39
	}

	internal CollectionKind Kind
	{
		internal get { } //Length: 23
	}

	internal virtual Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
	{
		internal get { } //Length: 40
		internal set { } //Length: 43
	}

	private static Type[] KnownInterfaces
	{
		private get { } //Length: 11
	}

	internal string SerializationExceptionMessage
	{
		internal get { } //Length: 23
	}

	internal DataContract SharedTypeContract
	{
		internal get { } //Length: 23
	}

	internal string ValueName
	{
		internal get { } //Length: 23
		internal set { } //Length: 39
	}

	internal XmlFormatGetOnlyCollectionReaderDelegate XmlFormatGetOnlyCollectionReaderDelegate
	{
		internal get { } //Length: 675
	}

	internal XmlFormatCollectionReaderDelegate XmlFormatReaderDelegate
	{
		internal get { } //Length: 395
	}

	internal XmlFormatCollectionWriterDelegate XmlFormatWriterDelegate
	{
		internal get { } //Length: 365
	}

	internal CollectionDataContract(CollectionKind kind) { }

	internal CollectionDataContract(Type type) { }

	internal CollectionDataContract(Type type, DataContract itemContract) { }

	private CollectionDataContract(Type type, CollectionKind kind, Type itemType, MethodInfo getEnumeratorMethod, string serializationExceptionMessage, string deserializationExceptionMessage) { }

	private CollectionDataContract(Type type, CollectionKind kind, Type itemType, MethodInfo getEnumeratorMethod, MethodInfo addMethod, ConstructorInfo constructor) { }

	private CollectionDataContract(Type type, CollectionKind kind, Type itemType, MethodInfo getEnumeratorMethod, MethodInfo addMethod, ConstructorInfo constructor, bool isConstructorCheckRequired) { }

	private CollectionDataContract(Type type, string invalidCollectionInSharedContractMessage) { }

	internal virtual DataContract BindGenericParameters(DataContract[] paramContracts, Dictionary<DataContract, DataContract> boundContracts) { }

	private void CheckConstructor() { }

	internal virtual bool Equals(object other, Dictionary<DataContractPairKey, Object> checkedContracts) { }

	private static void FindCollectionMethodsOnInterface(Type type, Type interfaceType, ref MethodInfo addMethod, ref MethodInfo getEnumeratorMethod) { }

	internal MethodInfo get_AddMethod() { }

	public XmlDictionaryString get_ChildElementNamespace() { }

	public XmlDictionaryString get_CollectionItemName() { }

	internal ConstructorInfo get_Constructor() { }

	internal string get_DeserializationExceptionMessage() { }

	internal MethodInfo get_GetEnumeratorMethod() { }

	internal string get_InvalidCollectionInSharedContractMessage() { }

	internal bool get_IsConstructorCheckRequired() { }

	internal bool get_IsDictionary() { }

	internal bool get_IsItemTypeNullable() { }

	internal bool get_IsReadOnlyContract() { }

	public DataContract get_ItemContract() { }

	internal string get_ItemName() { }

	private bool get_ItemNameSetExplicit() { }

	internal Type get_ItemType() { }

	internal string get_KeyName() { }

	internal CollectionKind get_Kind() { }

	internal virtual Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

	private static Type[] get_KnownInterfaces() { }

	internal string get_SerializationExceptionMessage() { }

	internal DataContract get_SharedTypeContract() { }

	internal string get_ValueName() { }

	internal XmlFormatGetOnlyCollectionReaderDelegate get_XmlFormatGetOnlyCollectionReaderDelegate() { }

	internal XmlFormatCollectionReaderDelegate get_XmlFormatReaderDelegate() { }

	internal XmlFormatCollectionWriterDelegate get_XmlFormatWriterDelegate() { }

	private static void GetCollectionMethods(Type type, Type interfaceType, Type[] addMethodTypeArray, bool addMethodOnInterface, out MethodInfo getEnumeratorMethod, out MethodInfo addMethod) { }

	public virtual int GetHashCode() { }

	private static string GetInvalidCollectionMessage(string message, string nestedMessage, string param) { }

	private static void GetReadOnlyCollectionExceptionMessages(Type type, bool hasCollectionDataContract, string message, string param, out string serializationExceptionMessage, out string deserializationExceptionMessage) { }

	private DataContract GetSharedTypeContract(Type type) { }

	internal static MethodInfo GetTargetMethodWithName(string name, Type type, Type interfaceType) { }

	internal virtual DataContract GetValidContract(SerializationMode mode) { }

	internal virtual DataContract GetValidContract() { }

	private static bool HandleIfInvalidCollection(Type type, bool tryCreate, bool hasCollectionDataContract, bool createContractWithException, string message, string param, ref DataContract dataContract) { }

	private void InitCollectionDataContract(DataContract sharedTypeContract) { }

	private void InitSharedTypeContract() { }

	private static bool IsArraySegment(Type t) { }

	internal static bool IsCollection(Type type, out Type itemType) { }

	internal static bool IsCollection(Type type, bool constructorRequired, bool skipIfReadOnlyContract) { }

	internal static bool IsCollection(Type type) { }

	internal static bool IsCollectionDataContract(Type type) { }

	private static bool IsCollectionHelper(Type type, out Type itemType, bool constructorRequired, bool skipIfReadOnlyContract = false) { }

	internal static bool IsCollectionInterface(Type type) { }

	private static bool IsCollectionOrTryCreate(Type type, bool tryCreate, out DataContract dataContract, out Type itemType, bool constructorRequired, bool skipIfReadOnlyContract = false) { }

	private static bool IsKnownInterface(Type type) { }

	internal virtual bool IsValidContract(SerializationMode mode) { }

	public virtual object ReadXmlValue(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContext context) { }

	internal void set_IsConstructorCheckRequired(bool value) { }

	internal void set_IsItemTypeNullable(bool value) { }

	public void set_ItemContract(DataContract value) { }

	internal void set_ItemName(string value) { }

	internal void set_KeyName(string value) { }

	internal virtual void set_KnownDataContracts(Dictionary<XmlQualifiedName, DataContract> value) { }

	internal void set_ValueName(string value) { }

	private void ThrowIfInvalid() { }

	internal static bool TryCreate(Type type, out DataContract dataContract) { }

	internal static bool TryCreateGetOnlyCollectionDataContract(Type type, out DataContract dataContract) { }

	public virtual void WriteXmlValue(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContext context) { }

}


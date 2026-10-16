namespace System.Runtime.Serialization;

internal sealed class ClassDataContract : DataContract
{
	private class ClassDataContractCriticalHelper : DataContractCriticalHelper
	{
		public class DataMemberConflictComparer : IComparer<Member>
		{
			internal static DataMemberConflictComparer Singleton; //Field offset: 0x0

			private static DataMemberConflictComparer() { }

			public DataMemberConflictComparer() { }

			public override int Compare(Member x, Member y) { }

		}

		public struct Member
		{
			internal DataMember member; //Field offset: 0x0
			internal string ns; //Field offset: 0x4
			internal int baseTypeIndex; //Field offset: 0x8

			internal Member(DataMember member, string ns, int baseTypeIndex) { }

		}

		private static Type[] serInfoCtorArgs; //Field offset: 0x0
		private ClassDataContract baseContract; //Field offset: 0x30
		private List<DataMember> members; //Field offset: 0x34
		private MethodInfo onSerializing; //Field offset: 0x38
		private MethodInfo onSerialized; //Field offset: 0x3C
		private MethodInfo onDeserializing; //Field offset: 0x40
		private MethodInfo onDeserialized; //Field offset: 0x44
		private MethodInfo extensionDataSetMethod; //Field offset: 0x48
		private Dictionary<XmlQualifiedName, DataContract> knownDataContracts; //Field offset: 0x4C
		private string serializationExceptionMessage; //Field offset: 0x50
		private bool isISerializable; //Field offset: 0x54
		private bool isKnownTypeAttributeChecked; //Field offset: 0x55
		private bool isMethodChecked; //Field offset: 0x56
		private bool hasExtensionData; //Field offset: 0x57
		private bool isNonAttributedType; //Field offset: 0x58
		private bool hasDataContract; //Field offset: 0x59
		private XmlDictionaryString[] childElementNamespaces; //Field offset: 0x5C
		private XmlFormatClassReaderDelegate xmlFormatReaderDelegate; //Field offset: 0x60
		private XmlFormatClassWriterDelegate xmlFormatWriterDelegate; //Field offset: 0x64
		public XmlDictionaryString[] ContractNamespaces; //Field offset: 0x68
		public XmlDictionaryString[] MemberNames; //Field offset: 0x6C
		public XmlDictionaryString[] MemberNamespaces; //Field offset: 0x70

		internal ClassDataContract BaseContract
		{
			internal get { } //Length: 11
			internal set { } //Length: 351
		}

		public XmlDictionaryString[] ChildElementNamespaces
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		internal string DeserializationExceptionMessage
		{
			internal get { } //Length: 169
		}

		internal MethodInfo ExtensionDataSetMethod
		{
			internal get { } //Length: 24
		}

		internal bool HasDataContract
		{
			internal get { } //Length: 11
		}

		internal bool HasExtensionData
		{
			internal get { } //Length: 11
		}

		internal virtual bool IsISerializable
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal bool IsNonAttributedType
		{
			internal get { } //Length: 11
		}

		internal virtual Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
		{
			internal get { } //Length: 299
			internal set { } //Length: 27
		}

		internal List<DataMember> Members
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal MethodInfo OnDeserialized
		{
			internal get { } //Length: 24
		}

		internal MethodInfo OnDeserializing
		{
			internal get { } //Length: 24
		}

		internal MethodInfo OnSerialized
		{
			internal get { } //Length: 24
		}

		internal MethodInfo OnSerializing
		{
			internal get { } //Length: 24
		}

		internal string SerializationExceptionMessage
		{
			internal get { } //Length: 11
		}

		private static Type[] SerInfoCtorArgs
		{
			private get { } //Length: 329
		}

		internal XmlFormatClassReaderDelegate XmlFormatReaderDelegate
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal XmlFormatClassWriterDelegate XmlFormatWriterDelegate
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal ClassDataContractCriticalHelper() { }

		internal ClassDataContractCriticalHelper(Type type) { }

		internal ClassDataContractCriticalHelper(Type type, XmlDictionaryString ns, String[] memberNames) { }

		private void EnsureIsReferenceImported(Type type) { }

		internal void EnsureMethodsImported() { }

		internal ClassDataContract get_BaseContract() { }

		public XmlDictionaryString[] get_ChildElementNamespaces() { }

		internal string get_DeserializationExceptionMessage() { }

		internal MethodInfo get_ExtensionDataSetMethod() { }

		internal bool get_HasDataContract() { }

		internal bool get_HasExtensionData() { }

		internal virtual bool get_IsISerializable() { }

		internal bool get_IsNonAttributedType() { }

		internal virtual Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

		internal List<DataMember> get_Members() { }

		internal MethodInfo get_OnDeserialized() { }

		internal MethodInfo get_OnDeserializing() { }

		internal MethodInfo get_OnSerialized() { }

		internal MethodInfo get_OnSerializing() { }

		internal string get_SerializationExceptionMessage() { }

		private static Type[] get_SerInfoCtorArgs() { }

		internal XmlFormatClassReaderDelegate get_XmlFormatReaderDelegate() { }

		internal XmlFormatClassWriterDelegate get_XmlFormatWriterDelegate() { }

		internal ConstructorInfo GetISerializableConstructor() { }

		internal ConstructorInfo GetNonAttributedTypeConstructor() { }

		private XmlQualifiedName GetStableNameAndSetHasDataContract(Type type) { }

		private void ImportDataMembers() { }

		private static bool IsMethodOverriding(MethodInfo method) { }

		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

		private bool IsValidExtensionDataSetMethod(MethodInfo method, ParameterInfo[] parameters) { }

		internal void set_BaseContract(ClassDataContract value) { }

		public void set_ChildElementNamespaces(XmlDictionaryString[] value) { }

		internal virtual void set_IsISerializable(bool value) { }

		internal virtual void set_KnownDataContracts(Dictionary<XmlQualifiedName, DataContract> value) { }

		internal void set_Members(List<DataMember> value) { }

		internal void set_XmlFormatReaderDelegate(XmlFormatClassReaderDelegate value) { }

		internal void set_XmlFormatWriterDelegate(XmlFormatClassWriterDelegate value) { }

		private bool SetIfGetOnlyCollection(DataMember memberContract, bool skipIfReadOnlyContract) { }

		private void SetIfMembersHaveConflict(List<DataMember> members) { }

		private void SetIsNonAttributedType(Type type) { }

	}

	public class DataMemberComparer : IComparer<DataMember>
	{
		internal static DataMemberComparer Singleton; //Field offset: 0x0

		private static DataMemberComparer() { }

		public DataMemberComparer() { }

		public override int Compare(DataMember x, DataMember y) { }

	}

	public XmlDictionaryString[] ContractNamespaces; //Field offset: 0x14
	public XmlDictionaryString[] MemberNames; //Field offset: 0x18
	public XmlDictionaryString[] MemberNamespaces; //Field offset: 0x1C
	private XmlDictionaryString[] childElementNamespaces; //Field offset: 0x20
	private ClassDataContractCriticalHelper helper; //Field offset: 0x24

	internal ClassDataContract BaseContract
	{
		internal get { } //Length: 23
		internal set { } //Length: 34
	}

	public XmlDictionaryString[] ChildElementNamespaces
	{
		 get { } //Length: 310
	}

	internal string DeserializationExceptionMessage
	{
		internal get { } //Length: 34
	}

	internal MethodInfo ExtensionDataSetMethod
	{
		internal get { } //Length: 34
	}

	internal bool HasDataContract
	{
		internal get { } //Length: 23
	}

	internal bool HasExtensionData
	{
		internal get { } //Length: 23
	}

	internal virtual bool IsISerializable
	{
		internal get { } //Length: 40
		internal set { } //Length: 43
	}

	internal bool IsNonAttributedType
	{
		internal get { } //Length: 23
	}

	internal bool IsReadOnlyContract
	{
		internal get { } //Length: 36
	}

	internal virtual Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
	{
		internal get { } //Length: 40
		internal set { } //Length: 43
	}

	internal List<DataMember> Members
	{
		internal get { } //Length: 23
		internal set { } //Length: 39
	}

	internal MethodInfo OnDeserialized
	{
		internal get { } //Length: 34
	}

	internal MethodInfo OnDeserializing
	{
		internal get { } //Length: 34
	}

	internal MethodInfo OnSerialized
	{
		internal get { } //Length: 34
	}

	internal MethodInfo OnSerializing
	{
		internal get { } //Length: 34
	}

	internal string SerializationExceptionMessage
	{
		internal get { } //Length: 23
	}

	internal XmlFormatClassReaderDelegate XmlFormatReaderDelegate
	{
		internal get { } //Length: 407
	}

	internal XmlFormatClassWriterDelegate XmlFormatWriterDelegate
	{
		internal get { } //Length: 353
	}

	internal ClassDataContract() { }

	internal ClassDataContract(Type type) { }

	private ClassDataContract(Type type, XmlDictionaryString ns, String[] memberNames) { }

	internal virtual DataContract BindGenericParameters(DataContract[] paramContracts, Dictionary<DataContract, DataContract> boundContracts) { }

	internal static void CheckAndAddMember(List<DataMember> members, DataMember memberContract, Dictionary<String, DataMember> memberNamesTable) { }

	private XmlDictionaryString[] CreateChildElementNamespaces() { }

	internal static ClassDataContract CreateClassDataContractForKeyValue(Type type, XmlDictionaryString ns, String[] memberNames) { }

	private void EnsureMethodsImported() { }

	internal virtual bool Equals(object other, Dictionary<DataContractPairKey, Object> checkedContracts) { }

	internal ClassDataContract get_BaseContract() { }

	public XmlDictionaryString[] get_ChildElementNamespaces() { }

	internal string get_DeserializationExceptionMessage() { }

	internal MethodInfo get_ExtensionDataSetMethod() { }

	internal bool get_HasDataContract() { }

	internal bool get_HasExtensionData() { }

	internal virtual bool get_IsISerializable() { }

	internal bool get_IsNonAttributedType() { }

	internal bool get_IsReadOnlyContract() { }

	internal virtual Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

	internal List<DataMember> get_Members() { }

	internal MethodInfo get_OnDeserialized() { }

	internal MethodInfo get_OnDeserializing() { }

	internal MethodInfo get_OnSerialized() { }

	internal MethodInfo get_OnSerializing() { }

	internal string get_SerializationExceptionMessage() { }

	internal XmlFormatClassReaderDelegate get_XmlFormatReaderDelegate() { }

	internal XmlFormatClassWriterDelegate get_XmlFormatWriterDelegate() { }

	internal static XmlDictionaryString GetChildNamespaceToDeclare(DataContract dataContract, Type childType, XmlDictionary dictionary) { }

	public virtual int GetHashCode() { }

	internal ConstructorInfo GetISerializableConstructor() { }

	internal ConstructorInfo GetNonAttributedTypeConstructor() { }

	private void InitClassDataContract() { }

	private bool IsEveryDataMemberOptional(IEnumerable<DataMember> dataMembers) { }

	internal static bool IsNonAttributedTypeValidForSerialization(Type type) { }

	public virtual object ReadXmlValue(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContext context) { }

	internal void set_BaseContract(ClassDataContract value) { }

	internal virtual void set_IsISerializable(bool value) { }

	internal virtual void set_KnownDataContracts(Dictionary<XmlQualifiedName, DataContract> value) { }

	internal void set_Members(List<DataMember> value) { }

	public virtual void WriteXmlValue(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContext context) { }

}


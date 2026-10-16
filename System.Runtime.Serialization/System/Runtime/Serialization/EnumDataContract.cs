namespace System.Runtime.Serialization;

internal sealed class EnumDataContract : DataContract
{
	private class EnumDataContractCriticalHelper : DataContractCriticalHelper
	{
		private static Dictionary<Type, XmlQualifiedName> typeToName; //Field offset: 0x0
		private static Dictionary<XmlQualifiedName, Type> nameToType; //Field offset: 0x4
		private XmlQualifiedName baseContractName; //Field offset: 0x30
		private List<DataMember> members; //Field offset: 0x34
		private List<Int64> values; //Field offset: 0x38
		private bool isULong; //Field offset: 0x3C
		private bool isFlags; //Field offset: 0x3D
		private bool hasDataContract; //Field offset: 0x3E
		private XmlDictionaryString[] childElementNames; //Field offset: 0x40

		internal XmlQualifiedName BaseContractName
		{
			internal get { } //Length: 11
			internal set { } //Length: 533
		}

		internal XmlDictionaryString[] ChildElementNames
		{
			internal get { } //Length: 11
		}

		internal bool IsFlags
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal bool IsULong
		{
			internal get { } //Length: 11
		}

		internal List<DataMember> Members
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal List<Int64> Values
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		private static EnumDataContractCriticalHelper() { }

		internal EnumDataContractCriticalHelper() { }

		internal EnumDataContractCriticalHelper(Type type) { }

		internal static void Add(Type type, string localName) { }

		internal XmlQualifiedName get_BaseContractName() { }

		internal XmlDictionaryString[] get_ChildElementNames() { }

		internal bool get_IsFlags() { }

		internal bool get_IsULong() { }

		internal List<DataMember> get_Members() { }

		internal List<Int64> get_Values() { }

		internal static XmlQualifiedName GetBaseContractName(Type type) { }

		internal static Type GetBaseType(XmlQualifiedName baseContractName) { }

		private void ImportBaseType(Type baseType) { }

		private void ImportDataMembers() { }

		internal void set_BaseContractName(XmlQualifiedName value) { }

		internal void set_IsFlags(bool value) { }

		internal void set_Members(List<DataMember> value) { }

		internal void set_Values(List<Int64> value) { }

	}

	private EnumDataContractCriticalHelper helper; //Field offset: 0x14

	internal XmlQualifiedName BaseContractName
	{
		internal get { } //Length: 23
		internal set { } //Length: 34
	}

	internal virtual bool CanContainReferences
	{
		internal get { } //Length: 3
	}

	private XmlDictionaryString[] ChildElementNames
	{
		private get { } //Length: 23
	}

	internal bool IsFlags
	{
		internal get { } //Length: 23
		internal set { } //Length: 26
	}

	internal bool IsULong
	{
		internal get { } //Length: 23
	}

	internal List<DataMember> Members
	{
		internal get { } //Length: 23
		internal set { } //Length: 39
	}

	internal List<Int64> Values
	{
		internal get { } //Length: 23
		internal set { } //Length: 39
	}

	internal EnumDataContract() { }

	internal EnumDataContract(Type type) { }

	internal virtual bool Equals(object other, Dictionary<DataContractPairKey, Object> checkedContracts) { }

	internal XmlQualifiedName get_BaseContractName() { }

	internal virtual bool get_CanContainReferences() { }

	private XmlDictionaryString[] get_ChildElementNames() { }

	internal bool get_IsFlags() { }

	internal bool get_IsULong() { }

	internal List<DataMember> get_Members() { }

	internal List<Int64> get_Values() { }

	internal static XmlQualifiedName GetBaseContractName(Type type) { }

	internal static Type GetBaseType(XmlQualifiedName baseContractName) { }

	internal long GetEnumValueFromString(string value) { }

	public virtual int GetHashCode() { }

	internal string GetStringFromEnumValue(long value) { }

	private long ReadEnumValue(string value, int index, int count) { }

	internal object ReadEnumValue(XmlReaderDelegator reader) { }

	public virtual object ReadXmlValue(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContext context) { }

	internal void set_BaseContractName(XmlQualifiedName value) { }

	internal void set_IsFlags(bool value) { }

	internal void set_Members(List<DataMember> value) { }

	internal void set_Values(List<Int64> value) { }

	internal void WriteEnumValue(XmlWriterDelegator writer, object value) { }

	public virtual void WriteXmlValue(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContext context) { }

}


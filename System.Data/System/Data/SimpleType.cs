namespace System.Data;

internal sealed class SimpleType : ISerializable
{
	private string _baseType; //Field offset: 0x8
	private SimpleType _baseSimpleType; //Field offset: 0xC
	private XmlQualifiedName _xmlBaseType; //Field offset: 0x10
	private string _name; //Field offset: 0x14
	private int _length; //Field offset: 0x18
	private int _minLength; //Field offset: 0x1C
	private int _maxLength; //Field offset: 0x20
	private string _pattern; //Field offset: 0x24
	private string _ns; //Field offset: 0x28
	private string _maxExclusive; //Field offset: 0x2C
	private string _maxInclusive; //Field offset: 0x30
	private string _minExclusive; //Field offset: 0x34
	private string _minInclusive; //Field offset: 0x38
	internal string _enumeration; //Field offset: 0x3C

	internal SimpleType BaseSimpleType
	{
		internal get { } //Length: 11
	}

	internal string BaseType
	{
		internal get { } //Length: 11
	}

	internal int Length
	{
		internal get { } //Length: 11
	}

	internal int MaxLength
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal string Name
	{
		internal get { } //Length: 11
	}

	internal string Namespace
	{
		internal get { } //Length: 11
	}

	public string SimpleTypeQualifiedName
	{
		 get { } //Length: 80
	}

	internal XmlQualifiedName XmlBaseType
	{
		internal get { } //Length: 11
	}

	internal SimpleType(string baseType) { }

	internal SimpleType(XmlSchemaSimpleType node) { }

	internal bool CanHaveMaxLength() { }

	internal void ConvertToAnnonymousSimpleType() { }

	internal static SimpleType CreateByteArrayType(string encoding) { }

	internal static SimpleType CreateEnumeratedType(string values) { }

	internal static SimpleType CreateLimitedStringType(int length) { }

	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	internal SimpleType get_BaseSimpleType() { }

	internal string get_BaseType() { }

	internal int get_Length() { }

	internal int get_MaxLength() { }

	internal string get_Name() { }

	internal string get_Namespace() { }

	public string get_SimpleTypeQualifiedName() { }

	internal XmlQualifiedName get_XmlBaseType() { }

	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	internal bool IsPlainString() { }

	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	internal string QualifiedName(string name) { }

	internal void set_MaxLength(int value) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

}


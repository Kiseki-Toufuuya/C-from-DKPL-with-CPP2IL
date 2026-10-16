namespace System.Xml.Schema;

internal abstract class SchemaDeclBase
{
	public enum Use
	{
		Default = 0,
		Required = 1,
		Implied = 2,
		Fixed = 3,
		RequiredFixed = 4,
	}

	protected XmlQualifiedName name; //Field offset: 0x8
	protected string prefix; //Field offset: 0xC
	protected bool isDeclaredInExternal; //Field offset: 0x10
	protected Use presence; //Field offset: 0x14
	protected XmlSchemaType schemaType; //Field offset: 0x18
	protected XmlSchemaDatatype datatype; //Field offset: 0x1C
	protected string defaultValueRaw; //Field offset: 0x20
	protected object defaultValueTyped; //Field offset: 0x24
	protected long maxLength; //Field offset: 0x28
	protected long minLength; //Field offset: 0x30
	protected List<String> values; //Field offset: 0x38

	internal XmlSchemaDatatype Datatype
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal string DefaultValueRaw
	{
		internal get { } //Length: 29
		internal set { } //Length: 27
	}

	internal object DefaultValueTyped
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal bool IsDeclaredInExternal
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal long MaxLength
	{
		internal get { } //Length: 14
		internal set { } //Length: 20
	}

	internal long MinLength
	{
		internal get { } //Length: 14
		internal set { } //Length: 20
	}

	internal XmlQualifiedName Name
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal string Prefix
	{
		internal get { } //Length: 29
		internal set { } //Length: 27
	}

	internal Use Presence
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal XmlSchemaType SchemaType
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal List<String> Values
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	protected SchemaDeclBase(XmlQualifiedName name, string prefix) { }

	protected SchemaDeclBase() { }

	internal void AddValue(string value) { }

	internal bool CheckEnumeration(object pVal) { }

	internal bool CheckValue(object pVal) { }

	internal XmlSchemaDatatype get_Datatype() { }

	internal string get_DefaultValueRaw() { }

	internal object get_DefaultValueTyped() { }

	internal bool get_IsDeclaredInExternal() { }

	internal long get_MaxLength() { }

	internal long get_MinLength() { }

	internal XmlQualifiedName get_Name() { }

	internal string get_Prefix() { }

	internal Use get_Presence() { }

	internal XmlSchemaType get_SchemaType() { }

	internal List<String> get_Values() { }

	internal void set_Datatype(XmlSchemaDatatype value) { }

	internal void set_DefaultValueRaw(string value) { }

	internal void set_DefaultValueTyped(object value) { }

	internal void set_IsDeclaredInExternal(bool value) { }

	internal void set_MaxLength(long value) { }

	internal void set_MinLength(long value) { }

	internal void set_Name(XmlQualifiedName value) { }

	internal void set_Prefix(string value) { }

	internal void set_Presence(Use value) { }

	internal void set_SchemaType(XmlSchemaType value) { }

	internal void set_Values(List<String> value) { }

}


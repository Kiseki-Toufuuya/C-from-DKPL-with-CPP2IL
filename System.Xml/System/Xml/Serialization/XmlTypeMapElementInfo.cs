namespace System.Xml.Serialization;

internal class XmlTypeMapElementInfo
{
	private string _elementName; //Field offset: 0x8
	private string _namespace; //Field offset: 0xC
	private XmlSchemaForm _form; //Field offset: 0x10
	private XmlTypeMapMember _member; //Field offset: 0x14
	private object _choiceValue; //Field offset: 0x18
	private bool _isNullable; //Field offset: 0x1C
	private int _nestingLevel; //Field offset: 0x20
	private XmlTypeMapping _mappedType; //Field offset: 0x24
	private TypeData _type; //Field offset: 0x28
	private bool _wrappedElement; //Field offset: 0x2C
	private int _explicitOrder; //Field offset: 0x30

	public object ChoiceValue
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string DataTypeName
	{
		 get { } //Length: 37
	}

	public string DataTypeNamespace
	{
		 get { } //Length: 70
	}

	public string ElementName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int ExplicitOrder
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public XmlSchemaForm Form
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsNullable
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsTextElement
	{
		 get { } //Length: 56
		 set { } //Length: 152
	}

	public bool IsUnnamedAnyElement
	{
		 get { } //Length: 32
		 set { } //Length: 128
	}

	public XmlTypeMapping MappedType
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlTypeMapMember Member
	{
		 get { } //Length: 11
	}

	public bool MultiReferenceType
	{
		 get { } //Length: 24
	}

	public string Namespace
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int NestingLevel
	{
		 set { } //Length: 14
	}

	public TypeData TypeData
	{
		 get { } //Length: 11
	}

	public bool WrappedElement
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public XmlTypeMapElementInfo(XmlTypeMapMember member, TypeData type) { }

	public virtual bool Equals(object other) { }

	public object get_ChoiceValue() { }

	public string get_DataTypeName() { }

	public string get_DataTypeNamespace() { }

	public string get_ElementName() { }

	public int get_ExplicitOrder() { }

	public XmlSchemaForm get_Form() { }

	public bool get_IsNullable() { }

	public bool get_IsTextElement() { }

	public bool get_IsUnnamedAnyElement() { }

	public XmlTypeMapping get_MappedType() { }

	public XmlTypeMapMember get_Member() { }

	public bool get_MultiReferenceType() { }

	public string get_Namespace() { }

	public TypeData get_TypeData() { }

	public bool get_WrappedElement() { }

	public virtual int GetHashCode() { }

	public void set_ChoiceValue(object value) { }

	public void set_ElementName(string value) { }

	public void set_ExplicitOrder(int value) { }

	public void set_Form(XmlSchemaForm value) { }

	public void set_IsNullable(bool value) { }

	public void set_IsTextElement(bool value) { }

	public void set_IsUnnamedAnyElement(bool value) { }

	public void set_MappedType(XmlTypeMapping value) { }

	public void set_Namespace(string value) { }

	public void set_NestingLevel(int value) { }

	public void set_WrappedElement(bool value) { }

}


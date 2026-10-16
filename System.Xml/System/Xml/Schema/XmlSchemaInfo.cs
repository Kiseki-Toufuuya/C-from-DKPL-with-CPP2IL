namespace System.Xml.Schema;

public class XmlSchemaInfo : IXmlSchemaInfo
{
	private bool isDefault; //Field offset: 0x8
	private bool isNil; //Field offset: 0x9
	private XmlSchemaElement schemaElement; //Field offset: 0xC
	private XmlSchemaAttribute schemaAttribute; //Field offset: 0x10
	private XmlSchemaType schemaType; //Field offset: 0x14
	private XmlSchemaSimpleType memberType; //Field offset: 0x18
	private XmlSchemaValidity validity; //Field offset: 0x1C
	private XmlSchemaContentType contentType; //Field offset: 0x20

	public XmlSchemaContentType ContentType
	{
		 get { } //Length: 11
	}

	internal bool HasDefaultValue
	{
		internal get { } //Length: 43
	}

	public override bool IsDefault
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public override bool IsNil
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	internal bool IsUnionType
	{
		internal get { } //Length: 56
	}

	public override XmlSchemaSimpleType MemberType
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override XmlSchemaAttribute SchemaAttribute
	{
		 get { } //Length: 11
		 set { } //Length: 56
	}

	public override XmlSchemaElement SchemaElement
	{
		 get { } //Length: 11
		 set { } //Length: 56
	}

	public override XmlSchemaType SchemaType
	{
		 get { } //Length: 11
		 set { } //Length: 63
	}

	public override XmlSchemaValidity Validity
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	internal XmlSchemaType XmlType
	{
		internal get { } //Length: 22
	}

	public XmlSchemaInfo() { }

	internal XmlSchemaInfo(XmlSchemaValidity validity) { }

	internal void Clear() { }

	public XmlSchemaContentType get_ContentType() { }

	internal bool get_HasDefaultValue() { }

	public override bool get_IsDefault() { }

	public override bool get_IsNil() { }

	internal bool get_IsUnionType() { }

	public override XmlSchemaSimpleType get_MemberType() { }

	public override XmlSchemaAttribute get_SchemaAttribute() { }

	public override XmlSchemaElement get_SchemaElement() { }

	public override XmlSchemaType get_SchemaType() { }

	public override XmlSchemaValidity get_Validity() { }

	internal XmlSchemaType get_XmlType() { }

	public void set_IsDefault(bool value) { }

	public void set_IsNil(bool value) { }

	public void set_MemberType(XmlSchemaSimpleType value) { }

	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	public void set_SchemaElement(XmlSchemaElement value) { }

	public void set_SchemaType(XmlSchemaType value) { }

	public void set_Validity(XmlSchemaValidity value) { }

}


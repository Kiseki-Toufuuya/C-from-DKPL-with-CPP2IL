namespace System.Xml;

internal sealed class XmlNameEx : XmlName
{
	private byte flags; //Field offset: 0x24
	private XmlSchemaSimpleType memberType; //Field offset: 0x28
	private XmlSchemaType schemaType; //Field offset: 0x2C
	private object decl; //Field offset: 0x30

	public virtual bool IsDefault
	{
		 get { } //Length: 15
	}

	public virtual bool IsNil
	{
		 get { } //Length: 15
	}

	public virtual XmlSchemaSimpleType MemberType
	{
		 get { } //Length: 11
	}

	public virtual XmlSchemaAttribute SchemaAttribute
	{
		 get { } //Length: 112
	}

	public virtual XmlSchemaElement SchemaElement
	{
		 get { } //Length: 112
	}

	public virtual XmlSchemaType SchemaType
	{
		 get { } //Length: 11
	}

	public virtual XmlSchemaValidity Validity
	{
		 get { } //Length: 37
	}

	internal XmlNameEx(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsNil() { }

	public virtual XmlSchemaSimpleType get_MemberType() { }

	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	public virtual XmlSchemaElement get_SchemaElement() { }

	public virtual XmlSchemaType get_SchemaType() { }

	public virtual XmlSchemaValidity get_Validity() { }

	public void SetIsDefault(bool value) { }

	public void SetIsNil(bool value) { }

	public void SetValidity(XmlSchemaValidity value) { }

}


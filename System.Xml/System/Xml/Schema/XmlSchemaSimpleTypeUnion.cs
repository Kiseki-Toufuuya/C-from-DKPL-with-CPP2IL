namespace System.Xml.Schema;

public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
{
	private XmlSchemaObjectCollection baseTypes; //Field offset: 0x2C
	private XmlQualifiedName[] memberTypes; //Field offset: 0x30
	private XmlSchemaSimpleType[] baseMemberTypes; //Field offset: 0x34

	[XmlIgnore]
	public XmlSchemaSimpleType[] BaseMemberTypes
	{
		 get { } //Length: 11
	}

	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection BaseTypes
	{
		 get { } //Length: 11
	}

	[XmlAttribute("memberTypes")]
	public XmlQualifiedName[] MemberTypes
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlSchemaSimpleTypeUnion() { }

	internal virtual XmlSchemaObject Clone() { }

	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	public XmlSchemaObjectCollection get_BaseTypes() { }

	public XmlQualifiedName[] get_MemberTypes() { }

	public void set_MemberTypes(XmlQualifiedName[] value) { }

	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

}


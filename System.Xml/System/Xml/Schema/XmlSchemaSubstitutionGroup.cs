namespace System.Xml.Schema;

internal class XmlSchemaSubstitutionGroup : XmlSchemaObject
{
	private ArrayList membersList; //Field offset: 0x20
	private XmlQualifiedName examplar; //Field offset: 0x24

	[XmlIgnore]
	internal XmlQualifiedName Examplar
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlIgnore]
	internal ArrayList Members
	{
		internal get { } //Length: 11
	}

	public XmlSchemaSubstitutionGroup() { }

	internal XmlQualifiedName get_Examplar() { }

	internal ArrayList get_Members() { }

	internal void set_Examplar(XmlQualifiedName value) { }

}


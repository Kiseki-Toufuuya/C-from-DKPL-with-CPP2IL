namespace System.Xml.Schema;

public class XmlSchemaChoice : XmlSchemaGroupBase
{
	private XmlSchemaObjectCollection items; //Field offset: 0x58

	internal virtual bool IsEmpty
	{
		internal get { } //Length: 16
	}

	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	public virtual XmlSchemaObjectCollection Items
	{
		 get { } //Length: 11
	}

	public XmlSchemaChoice() { }

	internal virtual bool get_IsEmpty() { }

	public virtual XmlSchemaObjectCollection get_Items() { }

	internal virtual void SetItems(XmlSchemaObjectCollection newItems) { }

}


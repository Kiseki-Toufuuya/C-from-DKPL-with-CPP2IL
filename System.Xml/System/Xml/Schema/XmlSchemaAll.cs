namespace System.Xml.Schema;

public class XmlSchemaAll : XmlSchemaGroupBase
{
	private XmlSchemaObjectCollection items; //Field offset: 0x58

	internal virtual bool IsEmpty
	{
		internal get { } //Length: 58
	}

	[XmlElement("element", typeof(XmlSchemaElement))]
	public virtual XmlSchemaObjectCollection Items
	{
		 get { } //Length: 11
	}

	public XmlSchemaAll() { }

	internal virtual bool get_IsEmpty() { }

	public virtual XmlSchemaObjectCollection get_Items() { }

	internal virtual void SetItems(XmlSchemaObjectCollection newItems) { }

}


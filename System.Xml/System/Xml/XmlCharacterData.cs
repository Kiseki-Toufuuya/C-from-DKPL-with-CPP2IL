namespace System.Xml;

public abstract class XmlCharacterData : XmlLinkedNode
{
	private string data; //Field offset: 0x10

	public override string Data
	{
		 get { } //Length: 29
		 set { } //Length: 144
	}

	public virtual string InnerText
	{
		 get { } //Length: 28
		 set { } //Length: 31
	}

	public virtual string Value
	{
		 get { } //Length: 28
		 set { } //Length: 31
	}

	protected private XmlCharacterData(string data, XmlDocument doc) { }

	internal bool CheckOnData(string data) { }

	internal bool DecideXPNodeTypeForTextNodes(XmlNode node, ref XPathNodeType xnt) { }

	public override string get_Data() { }

	public virtual string get_InnerText() { }

	public virtual string get_Value() { }

	public override void set_Data(string value) { }

	public virtual void set_InnerText(string value) { }

	public virtual void set_Value(string value) { }

}


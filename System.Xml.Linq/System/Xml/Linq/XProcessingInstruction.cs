namespace System.Xml.Linq;

public class XProcessingInstruction : XNode
{
	internal string target; //Field offset: 0x14
	internal string data; //Field offset: 0x18

	public string Data
	{
		 get { } //Length: 11
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public string Target
	{
		 get { } //Length: 11
	}

	public XProcessingInstruction(string target, string data) { }

	public XProcessingInstruction(XProcessingInstruction other) { }

	internal virtual XNode CloneNode() { }

	public string get_Data() { }

	public virtual XmlNodeType get_NodeType() { }

	public string get_Target() { }

	private static void ValidateName(string name) { }

	public virtual void WriteTo(XmlWriter writer) { }

}


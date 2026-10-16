namespace System.Xml.Linq;

public class XDocumentType : XNode
{
	private string _name; //Field offset: 0x14
	private string _publicId; //Field offset: 0x18
	private string _systemId; //Field offset: 0x1C
	private string _internalSubset; //Field offset: 0x20

	public string InternalSubset
	{
		 get { } //Length: 11
	}

	public string Name
	{
		 get { } //Length: 11
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public string PublicId
	{
		 get { } //Length: 11
	}

	public string SystemId
	{
		 get { } //Length: 11
	}

	public XDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	public XDocumentType(XDocumentType other) { }

	internal virtual XNode CloneNode() { }

	public string get_InternalSubset() { }

	public string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public string get_PublicId() { }

	public string get_SystemId() { }

	public virtual void WriteTo(XmlWriter writer) { }

}


namespace System.Xml;

internal class ValidatingReaderNodeData
{
	private string localName; //Field offset: 0x8
	private string namespaceUri; //Field offset: 0xC
	private string prefix; //Field offset: 0x10
	private string nameWPrefix; //Field offset: 0x14
	private string rawValue; //Field offset: 0x18
	private string originalStringValue; //Field offset: 0x1C
	private int depth; //Field offset: 0x20
	private AttributePSVIInfo attributePSVIInfo; //Field offset: 0x24
	private XmlNodeType nodeType; //Field offset: 0x28
	private int lineNo; //Field offset: 0x2C
	private int linePos; //Field offset: 0x30

	public AttributePSVIInfo AttInfo
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int Depth
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int LineNumber
	{
		 get { } //Length: 11
	}

	public int LinePosition
	{
		 get { } //Length: 11
	}

	public string LocalName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string Namespace
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlNodeType NodeType
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string OriginalStringValue
	{
		 get { } //Length: 11
	}

	public string Prefix
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string RawValue
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public ValidatingReaderNodeData() { }

	public ValidatingReaderNodeData(XmlNodeType nodeType) { }

	internal void Clear(XmlNodeType nodeType) { }

	public AttributePSVIInfo get_AttInfo() { }

	public int get_Depth() { }

	public int get_LineNumber() { }

	public int get_LinePosition() { }

	public string get_LocalName() { }

	public string get_Namespace() { }

	public XmlNodeType get_NodeType() { }

	public string get_OriginalStringValue() { }

	public string get_Prefix() { }

	public string get_RawValue() { }

	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	public void set_AttInfo(AttributePSVIInfo value) { }

	public void set_Depth(int value) { }

	public void set_LocalName(string value) { }

	public void set_Namespace(string value) { }

	public void set_NodeType(XmlNodeType value) { }

	public void set_Prefix(string value) { }

	public void set_RawValue(string value) { }

	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	internal void SetItemData(string value) { }

	internal void SetItemData(string value, string originalStringValue) { }

	internal void SetLineInfo(int lineNo, int linePos) { }

	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

}


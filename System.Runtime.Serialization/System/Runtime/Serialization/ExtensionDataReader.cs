namespace System.Runtime.Serialization;

[DefaultMember("Item")]
internal class ExtensionDataReader : XmlReader
{
	private enum ExtensionDataNodeType
	{
		None = 0,
		Element = 1,
		EndElement = 2,
		Text = 3,
		Xml = 4,
		ReferencedElement = 5,
		NullElement = 6,
	}

	private static Dictionary<String, String> nsToPrefixTable; //Field offset: 0x0
	private static Dictionary<String, String> prefixToNsTable; //Field offset: 0x4
	private Hashtable cache; //Field offset: 0x8
	private ElementData[] elements; //Field offset: 0xC
	private ElementData element; //Field offset: 0x10
	private ElementData nextElement; //Field offset: 0x14
	private ReadState readState; //Field offset: 0x18
	private ExtensionDataNodeType internalNodeType; //Field offset: 0x1C
	private XmlNodeType nodeType; //Field offset: 0x20
	private int depth; //Field offset: 0x24
	private string localName; //Field offset: 0x28
	private string ns; //Field offset: 0x2C
	private string prefix; //Field offset: 0x30
	private string value; //Field offset: 0x34
	private int attributeCount; //Field offset: 0x38
	private int attributeIndex; //Field offset: 0x3C
	private XmlNodeReader xmlNodeReader; //Field offset: 0x40
	private Queue<IDataNode> deserializedDataNodes; //Field offset: 0x44
	private XmlObjectSerializerReadContext context; //Field offset: 0x48

	public virtual int AttributeCount
	{
		 get { } //Length: 51
	}

	public virtual string BaseURI
	{
		 get { } //Length: 58
	}

	public virtual int Depth
	{
		 get { } //Length: 51
	}

	public virtual bool EOF
	{
		 get { } //Length: 55
	}

	public virtual bool HasValue
	{
		 get { } //Length: 50
	}

	public virtual bool IsDefault
	{
		 get { } //Length: 62
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 50
	}

	private bool IsXmlDataNode
	{
		private get { } //Length: 15
	}

	public virtual string Item
	{
		 get { } //Length: 74
	}

	public virtual string Item
	{
		 get { } //Length: 74
	}

	public virtual string Item
	{
		 get { } //Length: 80
	}

	public virtual string LocalName
	{
		 get { } //Length: 51
	}

	public virtual string Name
	{
		 get { } //Length: 58
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 51
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 50
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 51
	}

	public virtual string Prefix
	{
		 get { } //Length: 51
	}

	public virtual char QuoteChar
	{
		 get { } //Length: 62
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 51
	}

	public virtual string Value
	{
		 get { } //Length: 51
	}

	public virtual string XmlLang
	{
		 get { } //Length: 58
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 62
	}

	private static ExtensionDataReader() { }

	internal ExtensionDataReader(XmlObjectSerializerReadContext context) { }

	private void AddDeserializedDataNode(IDataNode node) { }

	private static void AddPrefix(string prefix, string ns) { }

	private bool CheckIfNodeHandled(IDataNode node) { }

	public virtual void Close() { }

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual int get_Depth() { }

	public virtual bool get_EOF() { }

	public virtual bool get_HasValue() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	private bool get_IsXmlDataNode() { }

	public virtual string get_Item(int i) { }

	public virtual string get_Item(string name, string namespaceURI) { }

	public virtual string get_Item(string name) { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual char get_QuoteChar() { }

	public virtual ReadState get_ReadState() { }

	public virtual string get_Value() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string GetAttribute(int i) { }

	public virtual string GetAttribute(string name) { }

	public virtual string GetAttribute(string name, string namespaceURI) { }

	internal IDataNode GetCurrentNode() { }

	private ElementData GetNextElement() { }

	internal static string GetPrefix(string ns) { }

	private void GrowElementsIfNeeded() { }

	private bool IsElementNode(ExtensionDataNodeType nodeType) { }

	public virtual string LookupNamespace(string prefix) { }

	private void MoveNext(IDataNode dataNode) { }

	private void MoveNextInClass(ClassDataNode dataNode) { }

	private void MoveNextInCollection(CollectionDataNode dataNode) { }

	private void MoveNextInISerializable(ISerializableDataNode dataNode) { }

	private void MoveNextInXml(XmlDataNode dataNode) { }

	public virtual bool MoveToAttribute(string name, string namespaceURI) { }

	public virtual void MoveToAttribute(int index) { }

	public virtual bool MoveToAttribute(string name) { }

	private void MoveToDeserializedObject(IDataNode dataNode) { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	private bool MoveToText(Type type, IDataNode dataNode, bool isTypedNode) { }

	private void PopElement() { }

	private void PushElement() { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	internal void Reset() { }

	public virtual void ResolveEntity() { }

	internal void SetDataNode(IDataNode dataNode, string name, string ns) { }

	internal void SetDeserializedValue(object obj) { }

	private void SetElement() { }

	private void SetNextElement(IDataNode node, string name, string ns, string prefix) { }

	public virtual void Skip() { }

}


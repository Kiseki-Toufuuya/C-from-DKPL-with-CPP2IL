namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XmlNodeWrapper : IXmlNode
{
	[Nullable(1)]
	private readonly XmlNode _node; //Field offset: 0x8
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private List<IXmlNode> _childNodes; //Field offset: 0xC
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private List<IXmlNode> _attributes; //Field offset: 0x10

	[Nullable(1)]
	public override List<IXmlNode> Attributes
	{
		[NullableContext(1)]
		 get { } //Length: 973
	}

	[Nullable(1)]
	public override List<IXmlNode> ChildNodes
	{
		[NullableContext(1)]
		 get { } //Length: 811
	}

	private bool HasAttributes
	{
		private get { } //Length: 197
	}

	public override string LocalName
	{
		 get { } //Length: 40
	}

	public override string NamespaceUri
	{
		 get { } //Length: 40
	}

	public override XmlNodeType NodeType
	{
		 get { } //Length: 40
	}

	public override IXmlNode ParentNode
	{
		 get { } //Length: 174
	}

	public override string Value
	{
		 get { } //Length: 40
		 set { } //Length: 43
	}

	public override object WrappedNode
	{
		 get { } //Length: 11
	}

	[NullableContext(1)]
	public XmlNodeWrapper(XmlNode node) { }

	[NullableContext(1)]
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	[NullableContext(1)]
	public override List<IXmlNode> get_Attributes() { }

	[NullableContext(1)]
	public override List<IXmlNode> get_ChildNodes() { }

	private bool get_HasAttributes() { }

	public override string get_LocalName() { }

	public override string get_NamespaceUri() { }

	public override XmlNodeType get_NodeType() { }

	public override IXmlNode get_ParentNode() { }

	public override string get_Value() { }

	public override object get_WrappedNode() { }

	public override void set_Value(string value) { }

	[NullableContext(1)]
	internal static IXmlNode WrapNode(XmlNode node) { }

}


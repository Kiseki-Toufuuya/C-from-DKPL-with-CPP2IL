namespace MS.Internal.Xml.XPath;

internal class Axis : AstNode
{
	internal enum AxisType
	{
		Ancestor = 0,
		AncestorOrSelf = 1,
		Attribute = 2,
		Child = 3,
		Descendant = 4,
		DescendantOrSelf = 5,
		Following = 6,
		FollowingSibling = 7,
		Namespace = 8,
		Parent = 9,
		Preceding = 10,
		PrecedingSibling = 11,
		Self = 12,
		None = 13,
	}

	private AxisType _axisType; //Field offset: 0x8
	private AstNode _input; //Field offset: 0xC
	private string _prefix; //Field offset: 0x10
	private string _name; //Field offset: 0x14
	private XPathNodeType _nodeType; //Field offset: 0x18
	protected bool abbrAxis; //Field offset: 0x1C
	private string _urn; //Field offset: 0x20

	public bool AbbrAxis
	{
		 get { } //Length: 11
	}

	public AstNode Input
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string Name
	{
		 get { } //Length: 11
	}

	public XPathNodeType NodeType
	{
		 get { } //Length: 11
	}

	public string Prefix
	{
		 get { } //Length: 11
	}

	public virtual XPathResultType ReturnType
	{
		 get { } //Length: 6
	}

	public virtual AstType Type
	{
		 get { } //Length: 3
	}

	public AxisType TypeOfAxis
	{
		 get { } //Length: 11
	}

	public string Urn
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Axis(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	public Axis(AxisType axisType, AstNode input) { }

	public bool get_AbbrAxis() { }

	public AstNode get_Input() { }

	public string get_Name() { }

	public XPathNodeType get_NodeType() { }

	public string get_Prefix() { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

	public AxisType get_TypeOfAxis() { }

	public string get_Urn() { }

	public void set_Input(AstNode value) { }

	public void set_Urn(string value) { }

}


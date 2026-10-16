namespace MS.Internal.Xml.XPath;

internal class Operand : AstNode
{
	private XPathResultType _type; //Field offset: 0x8
	private object _val; //Field offset: 0xC

	public virtual XPathResultType ReturnType
	{
		 get { } //Length: 11
	}

	public virtual AstType Type
	{
		 get { } //Length: 6
	}

	public Operand(string val) { }

	public Operand(double val) { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

}


namespace System.Xml.Schema;

internal abstract class InteriorNode : SyntaxTreeNode
{
	private SyntaxTreeNode leftChild; //Field offset: 0x8
	private SyntaxTreeNode rightChild; //Field offset: 0xC

	public SyntaxTreeNode LeftChild
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public SyntaxTreeNode RightChild
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	protected InteriorNode() { }

	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public SyntaxTreeNode get_LeftChild() { }

	public SyntaxTreeNode get_RightChild() { }

	public void set_LeftChild(SyntaxTreeNode value) { }

	public void set_RightChild(SyntaxTreeNode value) { }

}


namespace System.Xml.Schema;

internal class NamespaceListNode : SyntaxTreeNode
{
	protected NamespaceList namespaceList; //Field offset: 0x8
	protected object particle; //Field offset: 0xC

	public virtual bool IsNullable
	{
		 get { } //Length: 47
	}

	public NamespaceListNode(NamespaceList namespaceList, object particle) { }

	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public virtual bool get_IsNullable() { }

	public override ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

}


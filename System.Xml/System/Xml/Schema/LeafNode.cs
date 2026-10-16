namespace System.Xml.Schema;

internal class LeafNode : SyntaxTreeNode
{
	private int pos; //Field offset: 0x8

	public virtual bool IsNullable
	{
		 get { } //Length: 3
	}

	public int Pos
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public LeafNode(int pos) { }

	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public virtual bool get_IsNullable() { }

	public int get_Pos() { }

	public void set_Pos(int value) { }

}


namespace System.Xml.Schema;

internal sealed class LeafRangeNode : LeafNode
{
	private decimal min; //Field offset: 0x10
	private decimal max; //Field offset: 0x20
	private BitSet nextIteration; //Field offset: 0x30

	public virtual bool IsRangeNode
	{
		 get { } //Length: 3
	}

	public decimal Max
	{
		 get { } //Length: 18
	}

	public decimal Min
	{
		 get { } //Length: 18
	}

	public BitSet NextIteration
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LeafRangeNode(decimal min, decimal max) { }

	public LeafRangeNode(int pos, decimal min, decimal max) { }

	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public virtual bool get_IsRangeNode() { }

	public decimal get_Max() { }

	public decimal get_Min() { }

	public BitSet get_NextIteration() { }

	public void set_NextIteration(BitSet value) { }

}


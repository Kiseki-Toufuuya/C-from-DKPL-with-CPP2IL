namespace System.Text.RegularExpressions;

internal sealed class RegexNode
{
	public int NType; //Field offset: 0x8
	public List<RegexNode> Children; //Field offset: 0xC
	public string Str; //Field offset: 0x10
	public char Ch; //Field offset: 0x14
	public int M; //Field offset: 0x18
	public int N; //Field offset: 0x1C
	public readonly RegexOptions Options; //Field offset: 0x20
	public RegexNode Next; //Field offset: 0x24

	public RegexNode(int type, RegexOptions options) { }

	public RegexNode(int type, RegexOptions options, char ch) { }

	public RegexNode(int type, RegexOptions options, string str) { }

	public RegexNode(int type, RegexOptions options, int m) { }

	public RegexNode(int type, RegexOptions options, int m, int n) { }

	public void AddChild(RegexNode newChild) { }

	public RegexNode Child(int i) { }

	public int ChildCount() { }

	public RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	private void MakeRep(int type, int min, int max) { }

	private RegexNode Reduce() { }

	private RegexNode ReduceAlternation() { }

	private RegexNode ReduceConcatenation() { }

	private RegexNode ReduceGroup() { }

	private RegexNode ReduceRep() { }

	private RegexNode ReduceSet() { }

	public RegexNode ReverseLeft() { }

	private RegexNode StripEnation(int emptyType) { }

	public int Type() { }

	public bool UseOptionR() { }

}


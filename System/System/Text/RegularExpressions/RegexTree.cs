namespace System.Text.RegularExpressions;

internal sealed class RegexTree
{
	public readonly RegexNode Root; //Field offset: 0x8
	public readonly Hashtable Caps; //Field offset: 0xC
	public readonly Int32[] CapNumList; //Field offset: 0x10
	public readonly int CapTop; //Field offset: 0x14
	public readonly Hashtable CapNames; //Field offset: 0x18
	public readonly String[] CapsList; //Field offset: 0x1C
	public readonly RegexOptions Options; //Field offset: 0x20

	internal RegexTree(RegexNode root, Hashtable caps, Int32[] capNumList, int capTop, Hashtable capNames, String[] capsList, RegexOptions options) { }

}


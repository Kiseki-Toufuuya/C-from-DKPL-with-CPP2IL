namespace Ionic.Zlib;

internal sealed class StaticTree
{
	internal static readonly Int16[] lengthAndLiteralsTreeCodes; //Field offset: 0x0
	internal static readonly Int16[] distTreeCodes; //Field offset: 0x4
	internal static readonly StaticTree Literals; //Field offset: 0x8
	internal static readonly StaticTree Distances; //Field offset: 0xC
	internal static readonly StaticTree BitLengths; //Field offset: 0x10
	internal Int16[] treeCodes; //Field offset: 0x8
	internal Int32[] extraBits; //Field offset: 0xC
	internal int extraBase; //Field offset: 0x10
	internal int elems; //Field offset: 0x14
	internal int maxLength; //Field offset: 0x18

	private static StaticTree() { }

	private StaticTree(Int16[] treeCodes, Int32[] extraBits, int extraBase, int elems, int maxLength) { }

}


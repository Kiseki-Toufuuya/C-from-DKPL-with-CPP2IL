namespace Mono.Globalization.Unicode;

internal class Contraction
{
	public int Index; //Field offset: 0x8
	public readonly Char[] Source; //Field offset: 0xC
	public readonly string Replacement; //Field offset: 0x10
	public readonly Byte[] SortKey; //Field offset: 0x14

	public Contraction(int index, Char[] source, string replacement, Byte[] sortkey) { }

}


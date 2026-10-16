namespace Ionic.Zlib;

internal sealed class InflateBlocks
{
	private enum InflateBlockMode
	{
		TYPE = 0,
		LENS = 1,
		STORED = 2,
		TABLE = 3,
		BTREE = 4,
		DTREE = 5,
		CODES = 6,
		DRY = 7,
		DONE = 8,
		BAD = 9,
	}

	internal static readonly Int32[] border; //Field offset: 0x0
	private InflateBlockMode mode; //Field offset: 0x8
	internal int left; //Field offset: 0xC
	internal int table; //Field offset: 0x10
	internal int index; //Field offset: 0x14
	internal Int32[] blens; //Field offset: 0x18
	internal Int32[] bb; //Field offset: 0x1C
	internal Int32[] tb; //Field offset: 0x20
	internal InflateCodes codes; //Field offset: 0x24
	internal int last; //Field offset: 0x28
	internal ZlibCodec _codec; //Field offset: 0x2C
	internal int bitk; //Field offset: 0x30
	internal int bitb; //Field offset: 0x34
	internal Int32[] hufts; //Field offset: 0x38
	internal Byte[] window; //Field offset: 0x3C
	internal int end; //Field offset: 0x40
	internal int readAt; //Field offset: 0x44
	internal int writeAt; //Field offset: 0x48
	internal object checkfn; //Field offset: 0x4C
	internal uint check; //Field offset: 0x50
	internal InfTree inftree; //Field offset: 0x54

	private static InflateBlocks() { }

	internal InflateBlocks(ZlibCodec codec, object checkfn, int w) { }

	internal int Flush(int r) { }

	internal void Free() { }

	internal int Process(int r) { }

	internal uint Reset() { }

}


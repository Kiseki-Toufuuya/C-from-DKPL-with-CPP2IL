namespace Ionic.Zlib;

internal sealed class InflateManager
{
	private enum InflateManagerMode
	{
		METHOD = 0,
		FLAG = 1,
		DICT4 = 2,
		DICT3 = 3,
		DICT2 = 4,
		DICT1 = 5,
		DICT0 = 6,
		BLOCKS = 7,
		CHECK4 = 8,
		CHECK3 = 9,
		CHECK2 = 10,
		CHECK1 = 11,
		DONE = 12,
		BAD = 13,
	}

	private static readonly Byte[] mark; //Field offset: 0x0
	private InflateManagerMode mode; //Field offset: 0x8
	internal ZlibCodec _codec; //Field offset: 0xC
	internal int method; //Field offset: 0x10
	internal uint computedCheck; //Field offset: 0x14
	internal uint expectedCheck; //Field offset: 0x18
	internal int marker; //Field offset: 0x1C
	private bool _handleRfc1950HeaderBytes; //Field offset: 0x20
	internal int wbits; //Field offset: 0x24
	internal InflateBlocks blocks; //Field offset: 0x28

	internal bool HandleRfc1950HeaderBytes
	{
		internal get { } //Length: 11
	}

	private static InflateManager() { }

	public InflateManager(bool expectRfc1950HeaderBytes) { }

	internal int End() { }

	internal bool get_HandleRfc1950HeaderBytes() { }

	internal int Inflate(FlushType flush) { }

	internal int Initialize(ZlibCodec codec, int w) { }

	internal int Reset() { }

}


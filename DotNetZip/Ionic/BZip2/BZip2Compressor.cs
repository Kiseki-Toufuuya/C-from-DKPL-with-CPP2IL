namespace Ionic.BZip2;

internal class BZip2Compressor
{
	private class CompressionState
	{
		public readonly Boolean[] inUse; //Field offset: 0x8
		public readonly Byte[] unseqToSeq; //Field offset: 0xC
		public readonly Int32[] mtfFreq; //Field offset: 0x10
		public readonly Byte[] selector; //Field offset: 0x14
		public readonly Byte[] selectorMtf; //Field offset: 0x18
		public readonly Byte[] generateMTFValues_yy; //Field offset: 0x1C
		public Byte[][] sendMTFValues_len; //Field offset: 0x20
		public Int32[][] sendMTFValues_rfreq; //Field offset: 0x24
		public readonly Int32[] sendMTFValues_fave; //Field offset: 0x28
		public readonly Int16[] sendMTFValues_cost; //Field offset: 0x2C
		public Int32[][] sendMTFValues_code; //Field offset: 0x30
		public readonly Byte[] sendMTFValues2_pos; //Field offset: 0x34
		public readonly Boolean[] sentMTFValues4_inUse16; //Field offset: 0x38
		public readonly Int32[] stack_ll; //Field offset: 0x3C
		public readonly Int32[] stack_hh; //Field offset: 0x40
		public readonly Int32[] stack_dd; //Field offset: 0x44
		public readonly Int32[] mainSort_runningOrder; //Field offset: 0x48
		public readonly Int32[] mainSort_copy; //Field offset: 0x4C
		public readonly Boolean[] mainSort_bigDone; //Field offset: 0x50
		public Int32[] heap; //Field offset: 0x54
		public Int32[] weight; //Field offset: 0x58
		public Int32[] parent; //Field offset: 0x5C
		public readonly Int32[] ftab; //Field offset: 0x60
		public Byte[] block; //Field offset: 0x64
		public Int32[] fmap; //Field offset: 0x68
		public Char[] sfmap; //Field offset: 0x6C
		public Char[] quadrant; //Field offset: 0x70

		public CompressionState(int blockSize100k) { }

	}

	private static readonly int SETMASK; //Field offset: 0x0
	private static readonly int CLEARMASK; //Field offset: 0x4
	private static readonly byte GREATER_ICOST; //Field offset: 0x8
	private static readonly byte LESSER_ICOST; //Field offset: 0x9
	private static readonly int SMALL_THRESH; //Field offset: 0xC
	private static readonly int DEPTH_THRESH; //Field offset: 0x10
	private static readonly int WORK_FACTOR; //Field offset: 0x14
	private static readonly Int32[] increments; //Field offset: 0x18
	private int blockSize100k; //Field offset: 0x8
	private int currentByte; //Field offset: 0xC
	private int runLength; //Field offset: 0x10
	private int last; //Field offset: 0x14
	private int outBlockFillThreshold; //Field offset: 0x18
	private CompressionState cstate; //Field offset: 0x1C
	private readonly CRC32 crc; //Field offset: 0x20
	private BitWriter bw; //Field offset: 0x24
	private int runs; //Field offset: 0x28
	private int workDone; //Field offset: 0x2C
	private int workLimit; //Field offset: 0x30
	private bool firstAttempt; //Field offset: 0x34
	private bool blockRandomised; //Field offset: 0x35
	private int origPtr; //Field offset: 0x38
	private int nInUse; //Field offset: 0x3C
	private int nMTF; //Field offset: 0x40
	[CompilerGenerated]
	private uint <Crc32>k__BackingField; //Field offset: 0x44

	public private uint Crc32
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private static BZip2Compressor() { }

	public BZip2Compressor(BitWriter writer, int blockSize) { }

	private bool AddRunToOutputBlock(bool final) { }

	private void blockSort() { }

	public void CompressAndWrite() { }

	public int Fill(Byte[] buffer, int offset, int count) { }

	private void generateMTFValues() { }

	[CompilerGenerated]
	public uint get_Crc32() { }

	private static void hbAssignCodes(Int32[] code, Byte[] length, int minLen, int maxLen, int alphaSize) { }

	private static void hbMakeCodeLengths(Byte[] len, Int32[] freq, CompressionState state1, int alphaSize, int maxLen) { }

	private void mainQSort3(CompressionState dataShadow, int loSt, int hiSt, int dSt) { }

	private bool mainSimpleSort(CompressionState dataShadow, int lo, int hi, int d) { }

	private void mainSort() { }

	private static byte med3(byte a, byte b, byte c) { }

	private void moveToFrontCodeAndSend() { }

	private void randomiseBlock() { }

	private void Reset() { }

	private void sendMTFValues() { }

	private void sendMTFValues0(int nGroups, int alphaSize) { }

	private int sendMTFValues1(int nGroups, int alphaSize) { }

	private void sendMTFValues2(int nGroups, int nSelectors) { }

	private void sendMTFValues3(int nGroups, int alphaSize) { }

	private void sendMTFValues4() { }

	private void sendMTFValues5(int nGroups, int nSelectors) { }

	private void sendMTFValues6(int nGroups, int alphaSize) { }

	private void sendMTFValues7(int nSelectors) { }

	[CompilerGenerated]
	private void set_Crc32(uint value) { }

	private static void vswap(Int32[] fmap, int p1, int p2, int n) { }

	private int write0(byte b) { }

}


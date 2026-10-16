namespace Ionic.BZip2;

public class BZip2InputStream : Stream
{
	private enum CState
	{
		EOF = 0,
		START_BLOCK = 1,
		RAND_PART_A = 2,
		RAND_PART_B = 3,
		RAND_PART_C = 4,
		NO_RAND_PART_A = 5,
		NO_RAND_PART_B = 6,
		NO_RAND_PART_C = 7,
	}

	private sealed class DecompressionState
	{
		public readonly Boolean[] inUse; //Field offset: 0x8
		public readonly Byte[] seqToUnseq; //Field offset: 0xC
		public readonly Byte[] selector; //Field offset: 0x10
		public readonly Byte[] selectorMtf; //Field offset: 0x14
		public readonly Int32[] unzftab; //Field offset: 0x18
		public readonly Int32[][] gLimit; //Field offset: 0x1C
		public readonly Int32[][] gBase; //Field offset: 0x20
		public readonly Int32[][] gPerm; //Field offset: 0x24
		public readonly Int32[] gMinlen; //Field offset: 0x28
		public readonly Int32[] cftab; //Field offset: 0x2C
		public readonly Byte[] getAndMoveToFrontDecode_yy; //Field offset: 0x30
		public readonly Char[][] temp_charArray2d; //Field offset: 0x34
		public readonly Byte[] recvDecodingTables_pos; //Field offset: 0x38
		public Int32[] tt; //Field offset: 0x3C
		public Byte[] ll8; //Field offset: 0x40

		public DecompressionState(int blockSize100k) { }

		public Int32[] initTT(int length) { }

	}

	private bool _disposed; //Field offset: 0x14
	private bool _leaveOpen; //Field offset: 0x15
	private long totalBytesRead; //Field offset: 0x18
	private int last; //Field offset: 0x20
	private int origPtr; //Field offset: 0x24
	private int blockSize100k; //Field offset: 0x28
	private bool blockRandomised; //Field offset: 0x2C
	private int bsBuff; //Field offset: 0x30
	private int bsLive; //Field offset: 0x34
	private readonly CRC32 crc; //Field offset: 0x38
	private int nInUse; //Field offset: 0x3C
	private Stream input; //Field offset: 0x40
	private int currentChar; //Field offset: 0x44
	private CState currentState; //Field offset: 0x48
	private uint storedBlockCRC; //Field offset: 0x4C
	private uint storedCombinedCRC; //Field offset: 0x50
	private uint computedBlockCRC; //Field offset: 0x54
	private uint computedCombinedCRC; //Field offset: 0x58
	private int su_count; //Field offset: 0x5C
	private int su_ch2; //Field offset: 0x60
	private int su_chPrev; //Field offset: 0x64
	private int su_i2; //Field offset: 0x68
	private int su_j2; //Field offset: 0x6C
	private int su_rNToGo; //Field offset: 0x70
	private int su_rTPos; //Field offset: 0x74
	private int su_tPos; //Field offset: 0x78
	private char su_z; //Field offset: 0x7C
	private DecompressionState data; //Field offset: 0x80

	public virtual bool CanRead
	{
		 get { } //Length: 111
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 111
	}

	public virtual long Length
	{
		 get { } //Length: 47
	}

	public virtual long Position
	{
		 get { } //Length: 14
		 set { } //Length: 47
	}

	public BZip2InputStream(Stream input, bool leaveOpen) { }

	private bool bsGetBit() { }

	private uint bsGetInt() { }

	private char bsGetUByte() { }

	private void CheckMagicChar(char expected, int position) { }

	public virtual void Close() { }

	private void complete() { }

	private void createHuffmanDecodingTables(int alphaSize, int nGroups) { }

	protected virtual void Dispose(bool disposing) { }

	private void EndBlock() { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	private void getAndMoveToFrontDecode() { }

	private int getAndMoveToFrontDecode0(int groupNo) { }

	private int GetBits(int n) { }

	private static void hbCreateDecodeTables(Int32[] limit, Int32[] bbase, Int32[] perm, Char[] length, int minLen, int maxLen, int alphaSize) { }

	private void init() { }

	private void InitBlock() { }

	private void MakeMaps() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual int ReadByte() { }

	private void recvDecodingTables() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	private void SetupBlock() { }

	private void SetupNoRandPartA() { }

	private void SetupNoRandPartB() { }

	private void SetupNoRandPartC() { }

	private void SetupRandPartA() { }

	private void SetupRandPartB() { }

	private void SetupRandPartC() { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}


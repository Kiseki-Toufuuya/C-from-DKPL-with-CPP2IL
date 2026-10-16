namespace Google.Protobuf;

public sealed class CodedInputStream : IDisposable
{
	internal const int BufferSize = 4096; //Field offset: 0x0
	internal const int DefaultRecursionLimit = 100; //Field offset: 0x0
	internal const int DefaultSizeLimit = 2147483647; //Field offset: 0x0
	private readonly bool leaveOpen; //Field offset: 0x8
	private readonly Byte[] buffer; //Field offset: 0xC
	private int bufferSize; //Field offset: 0x10
	private int bufferSizeAfterLimit; //Field offset: 0x14
	private int bufferPos; //Field offset: 0x18
	private readonly Stream input; //Field offset: 0x1C
	private uint lastTag; //Field offset: 0x20
	private uint nextTag; //Field offset: 0x24
	private bool hasNextTag; //Field offset: 0x28
	private int totalBytesRetired; //Field offset: 0x2C
	private int currentLimit; //Field offset: 0x30
	private int recursionDepth; //Field offset: 0x34
	private readonly int recursionLimit; //Field offset: 0x38
	private readonly int sizeLimit; //Field offset: 0x3C
	[CompilerGenerated]
	private bool <DiscardUnknownFields>k__BackingField; //Field offset: 0x40

	internal bool DiscardUnknownFields
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public bool IsAtEnd
	{
		 get { } //Length: 35
	}

	internal uint LastTag
	{
		internal get { } //Length: 11
	}

	public long Position
	{
		 get { } //Length: 70
	}

	internal bool ReachedLimit
	{
		internal get { } //Length: 33
	}

	public int RecursionLimit
	{
		 get { } //Length: 11
	}

	public int SizeLimit
	{
		 get { } //Length: 11
	}

	public CodedInputStream(Byte[] buffer) { }

	public CodedInputStream(Byte[] buffer, int offset, int length) { }

	public CodedInputStream(Stream input) { }

	public CodedInputStream(Stream input, bool leaveOpen) { }

	internal CodedInputStream(Stream input, Byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen) { }

	internal CodedInputStream(Stream input, Byte[] buffer, int bufferPos, int bufferSize, int sizeLimit, int recursionLimit, bool leaveOpen) { }

	internal void CheckReadEndOfStreamTag() { }

	public static CodedInputStream CreateWithLimits(Stream input, int sizeLimit, int recursionLimit) { }

	internal static int DecodeZigZag32(uint n) { }

	internal static long DecodeZigZag64(ulong n) { }

	public override void Dispose() { }

	[CompilerGenerated]
	internal bool get_DiscardUnknownFields() { }

	public bool get_IsAtEnd() { }

	internal uint get_LastTag() { }

	public long get_Position() { }

	internal bool get_ReachedLimit() { }

	public int get_RecursionLimit() { }

	public int get_SizeLimit() { }

	public bool MaybeConsumeTag(uint tag) { }

	public uint PeekTag() { }

	internal void PopLimit(int oldLimit) { }

	internal int PushLimit(int byteLimit) { }

	public bool ReadBool() { }

	public ByteString ReadBytes() { }

	public double ReadDouble() { }

	public int ReadEnum() { }

	public uint ReadFixed32() { }

	public ulong ReadFixed64() { }

	public float ReadFloat() { }

	public void ReadGroup(IMessage builder) { }

	public int ReadInt32() { }

	public long ReadInt64() { }

	public int ReadLength() { }

	public void ReadMessage(IMessage builder) { }

	internal byte ReadRawByte() { }

	internal Byte[] ReadRawBytes(int size) { }

	internal uint ReadRawLittleEndian32() { }

	internal ulong ReadRawLittleEndian64() { }

	internal uint ReadRawVarint32() { }

	internal static uint ReadRawVarint32(Stream input) { }

	internal ulong ReadRawVarint64() { }

	public int ReadSFixed32() { }

	public long ReadSFixed64() { }

	public int ReadSInt32() { }

	public long ReadSInt64() { }

	public string ReadString() { }

	public uint ReadTag() { }

	public uint ReadUInt32() { }

	public ulong ReadUInt64() { }

	private void RecomputeBufferSizeAfterLimit() { }

	private bool RefillBuffer(bool mustSucceed) { }

	[CompilerGenerated]
	internal void set_DiscardUnknownFields(bool value) { }

	internal void SkipGroup(uint startGroupTag) { }

	private void SkipImpl(int amountToSkip) { }

	public void SkipLastField() { }

	private void SkipRawBytes(int size) { }

	private uint SlowReadRawVarint32() { }

}


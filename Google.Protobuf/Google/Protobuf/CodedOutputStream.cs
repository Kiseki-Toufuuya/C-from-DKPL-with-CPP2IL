namespace Google.Protobuf;

public sealed class CodedOutputStream : IDisposable
{
	internal sealed class OutOfSpaceException : IOException
	{

		internal OutOfSpaceException() { }

	}

	private const int LittleEndian64Size = 8; //Field offset: 0x0
	private const int LittleEndian32Size = 4; //Field offset: 0x0
	internal const int DoubleSize = 8; //Field offset: 0x0
	internal const int FloatSize = 4; //Field offset: 0x0
	internal const int BoolSize = 1; //Field offset: 0x0
	internal static readonly Encoding Utf8Encoding; //Field offset: 0x0
	public static readonly int DefaultBufferSize; //Field offset: 0x4
	private readonly bool leaveOpen; //Field offset: 0x8
	private readonly Byte[] buffer; //Field offset: 0xC
	private readonly int limit; //Field offset: 0x10
	private int position; //Field offset: 0x14
	private readonly Stream output; //Field offset: 0x18

	public long Position
	{
		 get { } //Length: 60
	}

	public int SpaceLeft
	{
		 get { } //Length: 85
	}

	private static CodedOutputStream() { }

	public CodedOutputStream(Stream output, int bufferSize, bool leaveOpen) { }

	public CodedOutputStream(Stream output, bool leaveOpen) { }

	public CodedOutputStream(Stream output, int bufferSize) { }

	public CodedOutputStream(Stream output) { }

	private CodedOutputStream(Stream output, Byte[] buffer, bool leaveOpen) { }

	private CodedOutputStream(Byte[] buffer, int offset, int length) { }

	public CodedOutputStream(Byte[] flatArray) { }

	public void CheckNoSpaceLeft() { }

	public static int ComputeBoolSize(bool value) { }

	public static int ComputeBytesSize(ByteString value) { }

	public static int ComputeDoubleSize(double value) { }

	public static int ComputeEnumSize(int value) { }

	public static int ComputeFixed32Size(uint value) { }

	public static int ComputeFixed64Size(ulong value) { }

	public static int ComputeFloatSize(float value) { }

	public static int ComputeGroupSize(IMessage value) { }

	public static int ComputeInt32Size(int value) { }

	public static int ComputeInt64Size(long value) { }

	public static int ComputeLengthSize(int length) { }

	public static int ComputeMessageSize(IMessage value) { }

	public static int ComputeRawVarint32Size(uint value) { }

	public static int ComputeRawVarint64Size(ulong value) { }

	public static int ComputeSFixed32Size(int value) { }

	public static int ComputeSFixed64Size(long value) { }

	public static int ComputeSInt32Size(int value) { }

	public static int ComputeSInt64Size(long value) { }

	public static int ComputeStringSize(string value) { }

	public static int ComputeTagSize(int fieldNumber) { }

	public static int ComputeUInt32Size(uint value) { }

	public static int ComputeUInt64Size(ulong value) { }

	public override void Dispose() { }

	internal static uint EncodeZigZag32(int n) { }

	internal static ulong EncodeZigZag64(long n) { }

	public void Flush() { }

	public long get_Position() { }

	public int get_SpaceLeft() { }

	private void RefreshBuffer() { }

	public void WriteBool(bool value) { }

	public void WriteBytes(ByteString value) { }

	public void WriteDouble(double value) { }

	public void WriteEnum(int value) { }

	public void WriteFixed32(uint value) { }

	public void WriteFixed64(ulong value) { }

	public void WriteFloat(float value) { }

	public void WriteGroup(IMessage value) { }

	public void WriteInt32(int value) { }

	public void WriteInt64(long value) { }

	public void WriteLength(int length) { }

	public void WriteMessage(IMessage value) { }

	internal void WriteRawByte(uint value) { }

	internal void WriteRawByte(byte value) { }

	internal void WriteRawBytes(Byte[] value, int offset, int length) { }

	internal void WriteRawBytes(Byte[] value) { }

	internal void WriteRawLittleEndian32(uint value) { }

	internal void WriteRawLittleEndian64(ulong value) { }

	public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5) { }

	public void WriteRawTag(byte b1, byte b2, byte b3, byte b4) { }

	public void WriteRawTag(byte b1, byte b2, byte b3) { }

	public void WriteRawTag(byte b1, byte b2) { }

	public void WriteRawTag(byte b1) { }

	internal void WriteRawVarint32(uint value) { }

	internal void WriteRawVarint64(ulong value) { }

	public void WriteSFixed32(int value) { }

	public void WriteSFixed64(long value) { }

	public void WriteSInt32(int value) { }

	public void WriteSInt64(long value) { }

	public void WriteString(string value) { }

	public void WriteTag(uint tag) { }

	public void WriteTag(int fieldNumber, WireType type) { }

	public void WriteUInt32(uint value) { }

	public void WriteUInt64(ulong value) { }

}


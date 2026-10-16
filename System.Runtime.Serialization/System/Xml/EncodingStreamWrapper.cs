namespace System.Xml;

internal class EncodingStreamWrapper : Stream
{
	private enum SupportedEncoding
	{
		UTF8 = 0,
		UTF16LE = 1,
		UTF16BE = 2,
		None = 3,
	}

	private static readonly UTF8Encoding SafeUTF8; //Field offset: 0x0
	private const int BufferLength = 128; //Field offset: 0x0
	private static readonly UnicodeEncoding SafeUTF16; //Field offset: 0x4
	private static readonly UnicodeEncoding SafeBEUTF16; //Field offset: 0x8
	private static readonly UTF8Encoding ValidatingUTF8; //Field offset: 0xC
	private static readonly UnicodeEncoding ValidatingUTF16; //Field offset: 0x10
	private static readonly UnicodeEncoding ValidatingBEUTF16; //Field offset: 0x14
	private static readonly Byte[] encodingAttr; //Field offset: 0x18
	private static readonly Byte[] encodingUTF8; //Field offset: 0x1C
	private static readonly Byte[] encodingUnicode; //Field offset: 0x20
	private static readonly Byte[] encodingUnicodeLE; //Field offset: 0x24
	private static readonly Byte[] encodingUnicodeBE; //Field offset: 0x28
	private SupportedEncoding encodingCode; //Field offset: 0x14
	private Encoding encoding; //Field offset: 0x18
	private Encoder enc; //Field offset: 0x1C
	private Decoder dec; //Field offset: 0x20
	private bool isReading; //Field offset: 0x24
	private Stream stream; //Field offset: 0x28
	private Char[] chars; //Field offset: 0x2C
	private Byte[] bytes; //Field offset: 0x30
	private int byteOffset; //Field offset: 0x34
	private int byteCount; //Field offset: 0x38
	private Byte[] byteBuffer; //Field offset: 0x3C

	public virtual bool CanRead
	{
		 get { } //Length: 50
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanTimeout
	{
		 get { } //Length: 40
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 50
	}

	public virtual long Length
	{
		 get { } //Length: 40
	}

	public virtual long Position
	{
		 get { } //Length: 57
		 set { } //Length: 57
	}

	public virtual int ReadTimeout
	{
		 get { } //Length: 40
		 set { } //Length: 43
	}

	public virtual int WriteTimeout
	{
		 get { } //Length: 40
		 set { } //Length: 43
	}

	private static EncodingStreamWrapper() { }

	public EncodingStreamWrapper(Stream stream, Encoding encoding, bool emitBOM) { }

	public EncodingStreamWrapper(Stream stream, Encoding encoding) { }

	private static void CheckUTF8DeclarationEncoding(Byte[] buffer, int offset, int count, SupportedEncoding e, SupportedEncoding expectedEnc) { }

	private void CleanupCharBreak() { }

	public virtual void Close() { }

	private static bool Compare(Byte[] key, Byte[] buffer, int offset) { }

	private static bool CompareCaseInsensitive(Byte[] key, Byte[] buffer, int offset) { }

	private void EnsureBuffers() { }

	private void EnsureByteBuffer() { }

	private void FillBuffer(int count) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanTimeout() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int get_ReadTimeout() { }

	public virtual int get_WriteTimeout() { }

	private static Encoding GetEncoding(SupportedEncoding e) { }

	private static string GetEncodingName(SupportedEncoding enc) { }

	private static Encoding GetSafeEncoding(SupportedEncoding e) { }

	private static SupportedEncoding GetSupportedEncoding(Encoding encoding) { }

	private static bool IsWhitespace(byte ch) { }

	internal static ArraySegment<Byte> ProcessBuffer(Byte[] buffer, int offset, int count, Encoding encoding) { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	private SupportedEncoding ReadBOMEncoding(bool notOutOfBand) { }

	private static SupportedEncoding ReadBOMEncoding(byte b1, byte b2, byte b3, byte b4, bool notOutOfBand, out int preserve) { }

	public virtual int ReadByte() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void set_ReadTimeout(int value) { }

	public virtual void set_WriteTimeout(int value) { }

	public virtual void SetLength(long value) { }

	private void SetReadDocumentEncoding(SupportedEncoding e) { }

	private static void ThrowEncodingMismatch(string declEnc, string docEnc) { }

	private static void ThrowEncodingMismatch(string declEnc, SupportedEncoding enc) { }

	private static void ThrowExpectedEncodingMismatch(SupportedEncoding expEnc, SupportedEncoding actualEnc) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

	public virtual void WriteByte(byte b) { }

}


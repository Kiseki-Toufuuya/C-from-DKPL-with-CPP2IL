namespace System.Text;

public sealed class UTF32Encoding : Encoding
{
	private sealed class UTF32Decoder : DecoderNLS
	{
		internal int iChar; //Field offset: 0x1C
		internal int readByteCount; //Field offset: 0x20

		internal virtual bool HasState
		{
			internal get { } //Length: 15
		}

		public UTF32Decoder(UTF32Encoding encoding) { }

		internal virtual bool get_HasState() { }

		public virtual void Reset() { }

	}

	internal static readonly UTF32Encoding s_default; //Field offset: 0x0
	internal static readonly UTF32Encoding s_bigEndianDefault; //Field offset: 0x4
	private static readonly Byte[] s_bigEndianPreamble; //Field offset: 0x8
	private static readonly Byte[] s_littleEndianPreamble; //Field offset: 0xC
	private bool _emitUTF32ByteOrderMark; //Field offset: 0x1C
	private bool _isThrowException; //Field offset: 0x1D
	private bool _bigEndian; //Field offset: 0x1E

	public virtual ReadOnlySpan<Byte> Preamble
	{
		 get { } //Length: 315
	}

	private static UTF32Encoding() { }

	public UTF32Encoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	public UTF32Encoding() { }

	public UTF32Encoding(bool bigEndian, bool byteOrderMark) { }

	public virtual bool Equals(object value) { }

	public virtual ReadOnlySpan<Byte> get_Preamble() { }

	internal virtual int GetByteCount(Char* chars, int count, EncoderNLS encoder) { }

	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	public virtual int GetByteCount(string s) { }

	[CLSCompliant(False)]
	public virtual int GetByteCount(Char* chars, int count) { }

	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS baseDecoder) { }

	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS baseDecoder) { }

	public virtual Decoder GetDecoder() { }

	public virtual Encoder GetEncoder() { }

	public virtual int GetHashCode() { }

	private char GetHighSurrogate(uint iChar) { }

	private char GetLowSurrogate(uint iChar) { }

	public virtual int GetMaxByteCount(int charCount) { }

	public virtual int GetMaxCharCount(int byteCount) { }

	public virtual Byte[] GetPreamble() { }

	public virtual string GetString(Byte[] bytes, int index, int count) { }

	private uint GetSurrogate(char cHigh, char cLow) { }

	internal virtual void SetDefaultFallbacks() { }

}


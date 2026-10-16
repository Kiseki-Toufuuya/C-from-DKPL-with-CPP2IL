namespace System.Text;

internal class Base64Encoding : Encoding
{
	private static Byte[] char2val; //Field offset: 0x0
	private static string val2char; //Field offset: 0x4
	private static Byte[] val2byte; //Field offset: 0x8

	private static Base64Encoding() { }

	public Base64Encoding() { }

	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	public override int GetBytes(Byte[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	public int GetChars(Byte[] bytes, int byteIndex, int byteCount, Byte[] chars, int charIndex) { }

	public virtual int GetMaxByteCount(int charCount) { }

	public virtual int GetMaxCharCount(int byteCount) { }

	private bool IsValidLeadBytes(int v1, int v2, int v3, int v4) { }

	private bool IsValidTailBytes(int v3, int v4) { }

}


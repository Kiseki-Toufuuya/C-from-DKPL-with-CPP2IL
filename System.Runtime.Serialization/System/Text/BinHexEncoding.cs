namespace System.Text;

internal class BinHexEncoding : Encoding
{
	private static Byte[] char2val; //Field offset: 0x0
	private static string val2char; //Field offset: 0x4

	private static BinHexEncoding() { }

	public BinHexEncoding() { }

	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	public virtual int GetMaxByteCount(int charCount) { }

	public virtual int GetMaxCharCount(int byteCount) { }

}


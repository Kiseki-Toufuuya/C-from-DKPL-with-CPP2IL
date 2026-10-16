namespace System.Xml;

internal class BinHexDecoder : IncrementalReadDecoder
{
	private Byte[] buffer; //Field offset: 0x8
	private int startIndex; //Field offset: 0xC
	private int curIndex; //Field offset: 0x10
	private int endIndex; //Field offset: 0x14
	private bool hasHalfByteCached; //Field offset: 0x18
	private byte cachedHalfByte; //Field offset: 0x19

	internal virtual int DecodedCount
	{
		internal get { } //Length: 14
	}

	internal virtual bool IsFull
	{
		internal get { } //Length: 17
	}

	public BinHexDecoder() { }

	internal virtual int Decode(Char[] chars, int startPos, int len) { }

	internal virtual int Decode(string str, int startPos, int len) { }

	public static Byte[] Decode(Char[] chars, bool allowOddChars) { }

	private static void Decode(Char* pChars, Char* pCharsEndPos, Byte* pBytes, Byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }

	internal virtual int get_DecodedCount() { }

	internal virtual bool get_IsFull() { }

	internal virtual void Reset() { }

	internal virtual void SetNextOutputBuffer(Array buffer, int index, int count) { }

}


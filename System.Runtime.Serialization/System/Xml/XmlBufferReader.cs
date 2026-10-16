namespace System.Xml;

internal class XmlBufferReader
{
	private const int maxBytesPerChar = 3; //Field offset: 0x0
	private static Byte[] emptyByteArray; //Field offset: 0x0
	private static XmlBufferReader empty; //Field offset: 0x4
	private XmlDictionaryReader reader; //Field offset: 0x8
	private Stream stream; //Field offset: 0xC
	private Byte[] streamBuffer; //Field offset: 0x10
	private Byte[] buffer; //Field offset: 0x14
	private int offsetMin; //Field offset: 0x18
	private int offsetMax; //Field offset: 0x1C
	private IXmlDictionary dictionary; //Field offset: 0x20
	private XmlBinaryReaderSession session; //Field offset: 0x24
	private Byte[] guid; //Field offset: 0x28
	private int offset; //Field offset: 0x2C
	private Char[] chars; //Field offset: 0x30
	private int windowOffset; //Field offset: 0x34
	private int windowOffsetMax; //Field offset: 0x38
	private ValueHandle listValue; //Field offset: 0x3C

	public Byte[] Buffer
	{
		 get { } //Length: 11
	}

	public static XmlBufferReader Empty
	{
		 get { } //Length: 61
	}

	public bool EndOfFile
	{
		 get { } //Length: 33
	}

	public bool IsStreamed
	{
		 get { } //Length: 15
	}

	public int Offset
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static XmlBufferReader() { }

	public XmlBufferReader(XmlDictionaryReader reader) { }

	public XmlBufferReader(Byte[] buffer) { }

	public void Advance(int count) { }

	public void Close() { }

	public int Compare(int offset1, int length1, int offset2, int length2) { }

	private void EnsureByte() { }

	private void EnsureBytes(int count) { }

	public bool Equals2(int offset1, int length1, XmlBufferReader bufferReader2, int offset2, int length2) { }

	public bool Equals2(int offset1, int length1, Byte[] buffer2) { }

	public bool Equals2(int offset1, int length1, string s2) { }

	public bool Equals2(int offset1, int length1, int offset2, int length2) { }

	public bool Equals2(int key1, int key2, XmlBufferReader bufferReader2) { }

	public bool Equals2(int key1, XmlDictionaryString xmlString2) { }

	public Byte[] get_Buffer() { }

	public static XmlBufferReader get_Empty() { }

	public bool get_EndOfFile() { }

	public bool get_IsStreamed() { }

	public int get_Offset() { }

	private int GetAmpersandCharEntity(int offset, int length) { }

	private int GetApostropheCharEntity(int offset, int length) { }

	public void GetBase64(int srcOffset, Byte[] buffer, int dstOffset, int count) { }

	public Byte[] GetBuffer(int count, out int offset) { }

	public Byte[] GetBuffer(int count, out int offset, out int offsetMax) { }

	public Byte[] GetBuffer(out int offset, out int offsetMax) { }

	private Byte[] GetBufferHard(int count, out int offset) { }

	public byte GetByte(int offset) { }

	public byte GetByte() { }

	private byte GetByteHard() { }

	private Char[] GetCharBuffer(int count) { }

	public int GetCharEntity(int offset, int length) { }

	private int GetChars(int offset, int length, Char[] chars) { }

	private int GetChars(int offset, int length, Char[] chars, int charOffset) { }

	public decimal GetDecimal(int offset) { }

	private int GetDecimalCharEntity(int offset, int length) { }

	public XmlDictionaryString GetDictionaryString(int key) { }

	public double GetDouble(int offset) { }

	public int GetEscapedChars(int offset, int length, Char[] chars) { }

	public string GetEscapedString(int offset, int length, XmlNameTable nameTable) { }

	public string GetEscapedString(int offset, int length) { }

	private int GetGreaterThanCharEntity(int offset, int length) { }

	public Guid GetGuid(int offset) { }

	private int GetHexCharEntity(int offset, int length) { }

	public int GetInt16(int offset) { }

	public int GetInt32(int offset) { }

	public long GetInt64(int offset) { }

	public int GetInt8(int offset) { }

	private int GetLessThanCharEntity(int offset, int length) { }

	public Object[] GetList(int offset, int count) { }

	public XmlBinaryNodeType GetNodeType() { }

	private int GetQuoteCharEntity(int offset, int length) { }

	public Int32[] GetRows() { }

	public float GetSingle(int offset) { }

	public string GetString(int offset, int length) { }

	public string GetString(int offset, int length, XmlNameTable nameTable) { }

	public ulong GetUInt64(int offset) { }

	public string GetUnicodeString(int offset, int length) { }

	public UniqueId GetUniqueId(int offset) { }

	public void InsertBytes(Byte[] buffer, int offset, int count) { }

	private bool IsAttrChar(int ch) { }

	public bool IsWhitespaceKey(int key) { }

	public bool IsWhitespaceUnicode(int offset, int length) { }

	public bool IsWhitespaceUTF8(int offset, int length) { }

	public int ReadBytes(int count) { }

	public DateTime ReadDateTime() { }

	public decimal ReadDecimal() { }

	public int ReadDictionaryKey() { }

	public double ReadDouble() { }

	public Guid ReadGuid() { }

	public int ReadInt16() { }

	public int ReadInt32() { }

	public long ReadInt64() { }

	public int ReadInt8() { }

	private void ReadList(ValueHandle value) { }

	public int ReadMultiByteUInt31() { }

	public void ReadQName(ValueHandle value) { }

	public float ReadSingle() { }

	public TimeSpan ReadTimeSpan() { }

	public int ReadUInt16() { }

	public int ReadUInt31() { }

	public int ReadUInt8() { }

	private void ReadUnicodeValue(ValueHandle value, int length) { }

	public UniqueId ReadUniqueId() { }

	public string ReadUTF8String(int length) { }

	public void ReadValue(XmlBinaryNodeType nodeType, ValueHandle value) { }

	private void ReadValue(ValueHandle value, ValueHandleType type, int length) { }

	public void set_Offset(int value) { }

	public void SetBuffer(Byte[] buffer, int offset, int count, IXmlDictionary dictionary, XmlBinaryReaderSession session) { }

	public void SetBuffer(Stream stream, IXmlDictionary dictionary, XmlBinaryReaderSession session) { }

	private void SetBuffer(Stream stream, Byte[] buffer, int offset, int count, IXmlDictionary dictionary, XmlBinaryReaderSession session) { }

	public void SetWindow(int windowOffset, int windowLength) { }

	public void SkipByte() { }

	public void SkipNodeType() { }

	private bool TryEnsureByte() { }

	private bool TryEnsureBytes(int count) { }

	private void UnsafeReadArray(Byte* dst, int length) { }

	public void UnsafeReadArray(Byte* dst, Byte* dstMax) { }

}


namespace System.Xml;

internal class ValueHandle
{
	private static Base64Encoding base64Encoding; //Field offset: 0x0
	private static String[] constStrings; //Field offset: 0x4
	private XmlBufferReader bufferReader; //Field offset: 0x8
	private ValueHandleType type; //Field offset: 0xC
	private int offset; //Field offset: 0x10
	private int length; //Field offset: 0x14

	private static Base64Encoding Base64Encoding
	{
		private get { } //Length: 185
	}

	private static ValueHandle() { }

	public ValueHandle(XmlBufferReader bufferReader) { }

	public bool Equals2(string str, bool checkLower) { }

	private static Base64Encoding get_Base64Encoding() { }

	private void GetBase64(Byte[] buffer, int offset, int count) { }

	private int GetChar() { }

	private string GetCharsText() { }

	private string GetCharText() { }

	private decimal GetDecimal() { }

	private XmlDictionaryString GetDictionaryString() { }

	private double GetDouble() { }

	private string GetEscapedCharsText() { }

	private Guid GetGuid() { }

	private int GetInt16() { }

	private int GetInt32() { }

	private long GetInt64() { }

	private int GetInt8() { }

	private string GetQNameDictionaryText() { }

	private float GetSingle() { }

	public string GetString() { }

	private ulong GetUInt64() { }

	private string GetUnicodeCharsText() { }

	private UniqueId GetUniqueId() { }

	public bool IsWhitespace() { }

	public void SetCharValue(int ch) { }

	public void SetConstantValue(ValueHandleConstStringType constStringType) { }

	public void SetDictionaryValue(int key) { }

	public void SetQNameValue(int prefix, int key) { }

	public void SetValue(ValueHandleType type, int offset, int length) { }

	public void SetValue(ValueHandleType type) { }

	public void Sign(XmlSigningNodeWriter writer) { }

	public bool ToBoolean() { }

	public Byte[] ToByteArray() { }

	public DateTime ToDateTime() { }

	public decimal ToDecimal() { }

	public double ToDouble() { }

	public Guid ToGuid() { }

	public int ToInt() { }

	public Object[] ToList() { }

	public long ToLong() { }

	public object ToObject() { }

	public float ToSingle() { }

	public virtual string ToString() { }

	public TimeSpan ToTimeSpan() { }

	public Type ToType() { }

	public ulong ToULong() { }

	public UniqueId ToUniqueId() { }

	public bool TryGetByteArrayLength(out int length) { }

	public bool TryGetDictionaryString(out XmlDictionaryString value) { }

	public bool TryReadBase64(Byte[] buffer, int offset, int count, out int actual) { }

	public bool TryReadChars(Char[] chars, int offset, int count, out int actual) { }

	private bool TryReadUnicodeChars(Char[] chars, int offset, int count, out int actual) { }

}


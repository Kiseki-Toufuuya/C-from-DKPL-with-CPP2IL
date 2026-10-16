namespace System.Xml;

internal class StringHandle
{
	private enum StringHandleType
	{
		Dictionary = 0,
		UTF8 = 1,
		EscapedUTF8 = 2,
		ConstString = 3,
	}

	private static String[] constStrings; //Field offset: 0x0
	private XmlBufferReader bufferReader; //Field offset: 0x8
	private StringHandleType type; //Field offset: 0xC
	private int key; //Field offset: 0x10
	private int offset; //Field offset: 0x14
	private int length; //Field offset: 0x18

	public bool IsEmpty
	{
		 get { } //Length: 44
	}

	public bool IsXmlns
	{
		 get { } //Length: 172
	}

	private static StringHandle() { }

	public StringHandle(XmlBufferReader bufferReader) { }

	public int CompareTo(StringHandle that) { }

	public virtual bool Equals(object obj) { }

	private bool Equals2(XmlDictionaryString xmlString2) { }

	private bool Equals2(StringHandle s2) { }

	private bool Equals2(int offset2, int length2, XmlBufferReader bufferReader2) { }

	private bool Equals2(string s2) { }

	private bool Equals2(int key2, XmlBufferReader bufferReader2) { }

	public bool get_IsEmpty() { }

	public bool get_IsXmlns() { }

	public virtual int GetHashCode() { }

	public string GetString(XmlNameTable nameTable) { }

	public string GetString() { }

	public Byte[] GetString(out int offset, out int length) { }

	public static bool op_Equality(StringHandle s1, StringHandle s2) { }

	public static bool op_Equality(StringHandle s1, string s2) { }

	public static bool op_Equality(StringHandle s1, XmlDictionaryString xmlString2) { }

	public static bool op_Inequality(StringHandle s1, StringHandle s2) { }

	public static bool op_Inequality(StringHandle s1, string s2) { }

	public static bool op_Inequality(StringHandle s1, XmlDictionaryString xmlString2) { }

	public void SetConstantValue(StringHandleConstStringType constStringType) { }

	public void SetValue(int offset, int length) { }

	public void SetValue(int key) { }

	public void SetValue(int offset, int length, bool escaped) { }

	public void SetValue(StringHandle value) { }

	public void ToPrefixHandle(PrefixHandle prefix) { }

	public virtual string ToString() { }

	public bool TryGetDictionaryString(out XmlDictionaryString value) { }

}


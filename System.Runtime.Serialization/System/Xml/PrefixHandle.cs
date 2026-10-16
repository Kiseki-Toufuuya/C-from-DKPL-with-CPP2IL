namespace System.Xml;

internal class PrefixHandle
{
	private static String[] prefixStrings; //Field offset: 0x0
	private static Byte[] prefixBuffer; //Field offset: 0x4
	private XmlBufferReader bufferReader; //Field offset: 0x8
	private PrefixHandleType type; //Field offset: 0xC
	private int offset; //Field offset: 0x10
	private int length; //Field offset: 0x14

	public bool IsEmpty
	{
		 get { } //Length: 15
	}

	public bool IsXml
	{
		 get { } //Length: 94
	}

	public bool IsXmlns
	{
		 get { } //Length: 124
	}

	private static PrefixHandle() { }

	public PrefixHandle(XmlBufferReader bufferReader) { }

	public int CompareTo(PrefixHandle that) { }

	public virtual bool Equals(object obj) { }

	private bool Equals2(XmlDictionaryString prefix2) { }

	private bool Equals2(string prefix2) { }

	private bool Equals2(PrefixHandle prefix2) { }

	public bool get_IsEmpty() { }

	public bool get_IsXml() { }

	public bool get_IsXmlns() { }

	public static PrefixHandleType GetAlphaPrefix(int index) { }

	public virtual int GetHashCode() { }

	public Byte[] GetString(out int offset, out int length) { }

	public string GetString(XmlNameTable nameTable) { }

	public static Byte[] GetString(PrefixHandleType type, out int offset, out int length) { }

	public static string GetString(PrefixHandleType type) { }

	public string GetString() { }

	public static bool op_Equality(PrefixHandle prefix1, string prefix2) { }

	public static bool op_Equality(PrefixHandle prefix1, XmlDictionaryString prefix2) { }

	public static bool op_Equality(PrefixHandle prefix1, PrefixHandle prefix2) { }

	public static bool op_Inequality(PrefixHandle prefix1, string prefix2) { }

	public static bool op_Inequality(PrefixHandle prefix1, XmlDictionaryString prefix2) { }

	public static bool op_Inequality(PrefixHandle prefix1, PrefixHandle prefix2) { }

	public void SetValue(PrefixHandleType type) { }

	public void SetValue(int offset, int length) { }

	public void SetValue(PrefixHandle prefix) { }

	public virtual string ToString() { }

	public bool TryGetShortPrefix(out PrefixHandleType type) { }

}


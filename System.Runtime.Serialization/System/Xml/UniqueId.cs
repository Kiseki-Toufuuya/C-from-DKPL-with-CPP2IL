namespace System.Xml;

public class UniqueId
{
	private const int guidLength = 16; //Field offset: 0x0
	private const int uuidLength = 45; //Field offset: 0x0
	private static Int16[] char2val; //Field offset: 0x0
	private const string val2char = "0123456789abcdef"; //Field offset: 0x0
	private long idLow; //Field offset: 0x8
	private long idHigh; //Field offset: 0x10
	private string s; //Field offset: 0x18

	public int CharArrayLength
	{
		 get { } //Length: 27
	}

	public bool IsGuid
	{
		 get { } //Length: 39
	}

	private static UniqueId() { }

	public UniqueId(Char[] chars, int offset, int count) { }

	public UniqueId(string value) { }

	public UniqueId() { }

	public UniqueId(Byte[] guid) { }

	public UniqueId(Guid guid) { }

	public UniqueId(Byte[] guid, int offset) { }

	public virtual bool Equals(object obj) { }

	public int get_CharArrayLength() { }

	public bool get_IsGuid() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(UniqueId id1, UniqueId id2) { }

	public static bool op_Inequality(UniqueId id1, UniqueId id2) { }

	public int ToCharArray(Char[] chars, int offset) { }

	public virtual string ToString() { }

	public bool TryGetGuid(out Guid guid) { }

	public bool TryGetGuid(Byte[] buffer, int offset) { }

	private int UnsafeDecode(Int16* char2val, char ch1, char ch2) { }

	private void UnsafeEncode(Char* val2char, byte b, Char* pch) { }

	private int UnsafeGetInt32(Byte* pb) { }

	private long UnsafeGetInt64(Byte* pb) { }

	private void UnsafeParse(Char* chars, int charCount) { }

	private void UnsafeSetInt32(int value, Byte* pb) { }

	private void UnsafeSetInt64(long value, Byte* pb) { }

}


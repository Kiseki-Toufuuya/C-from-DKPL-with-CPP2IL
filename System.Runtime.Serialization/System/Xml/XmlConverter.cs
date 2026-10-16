namespace System.Xml;

internal static class XmlConverter
{
	public const int MaxDateTimeChars = 64; //Field offset: 0x0
	public const int MaxInt32Chars = 16; //Field offset: 0x0
	public const int MaxInt64Chars = 32; //Field offset: 0x0
	public const int MaxBoolChars = 5; //Field offset: 0x0
	public const int MaxFloatChars = 16; //Field offset: 0x0
	public const int MaxDoubleChars = 32; //Field offset: 0x0
	public const int MaxDecimalChars = 40; //Field offset: 0x0
	public const int MaxUInt64Chars = 32; //Field offset: 0x0
	public const int MaxPrimitiveChars = 64; //Field offset: 0x0
	private static Char[] whiteSpaceChars; //Field offset: 0x0
	private static UTF8Encoding utf8Encoding; //Field offset: 0x4
	private static UnicodeEncoding unicodeEncoding; //Field offset: 0x8
	private static Base64Encoding base64Encoding; //Field offset: 0xC

	public static Base64Encoding Base64Encoding
	{
		 get { } //Length: 193
	}

	private static UnicodeEncoding UnicodeEncoding
	{
		private get { } //Length: 199
	}

	private static UTF8Encoding UTF8Encoding
	{
		private get { } //Length: 197
	}

	private static XmlConverter() { }

	public static Base64Encoding get_Base64Encoding() { }

	private static UnicodeEncoding get_UnicodeEncoding() { }

	private static UTF8Encoding get_UTF8Encoding() { }

	private static bool IsNegativeZero(float value) { }

	private static bool IsNegativeZero(double value) { }

	public static bool IsWhitespace(string s) { }

	public static bool IsWhitespace(char ch) { }

	public static string StripWhitespace(string s) { }

	private static int ToAsciiChars(string s, Byte[] buffer, int offset) { }

	public static bool ToBoolean(string value) { }

	public static bool ToBoolean(Byte[] buffer, int offset, int count) { }

	public static Byte[] ToBytes(string value) { }

	public static int ToChars(DateTime value, Byte[] chars, int offset) { }

	public static int ToChars(Byte[] buffer, int offset, int count, Char[] chars, int charOffset) { }

	public static int ToChars(float value, Byte[] buffer, int offset) { }

	public static int ToChars(decimal value, Byte[] buffer, int offset) { }

	public static int ToChars(double value, Byte[] buffer, int offset) { }

	public static int ToChars(long value, Byte[] chars, int offset) { }

	public static int ToChars(int value, Byte[] chars, int offset) { }

	public static int ToChars(bool value, Byte[] buffer, int offset) { }

	public static int ToChars(ulong value, Byte[] buffer, int offset) { }

	private static int ToCharsD2(int value, Byte[] chars, int offset) { }

	private static int ToCharsD4(int value, Byte[] chars, int offset) { }

	private static int ToCharsD7(int value, Byte[] chars, int offset) { }

	public static int ToCharsR(int value, Byte[] chars, int offset) { }

	public static int ToCharsR(long value, Byte[] chars, int offset) { }

	public static DateTime ToDateTime(Byte[] buffer, int offset, int count) { }

	public static DateTime ToDateTime(string value) { }

	public static DateTime ToDateTime(long value) { }

	public static decimal ToDecimal(Byte[] buffer, int offset, int count) { }

	public static decimal ToDecimal(string value) { }

	public static double ToDouble(Byte[] buffer, int offset, int count) { }

	public static double ToDouble(string value) { }

	public static Guid ToGuid(Byte[] buffer, int offset, int count) { }

	public static Guid ToGuid(string value) { }

	private static int ToInfinity(bool isNegative, Byte[] buffer, int offset) { }

	public static int ToInt32(string value) { }

	public static int ToInt32(Byte[] buffer, int offset, int count) { }

	private static int ToInt32D2(Byte[] chars, int offset) { }

	private static int ToInt32D4(Byte[] chars, int offset, int count) { }

	private static int ToInt32D7(Byte[] chars, int offset, int count) { }

	public static long ToInt64(Byte[] buffer, int offset, int count) { }

	public static long ToInt64(string value) { }

	public static void ToQualifiedName(string qname, out string prefix, out string localName) { }

	public static float ToSingle(string value) { }

	public static float ToSingle(Byte[] buffer, int offset, int count) { }

	public static string ToString(Guid value) { }

	public static string ToString(float value) { }

	public static string ToString(Byte[] buffer, int offset, int count) { }

	public static string ToString(bool value) { }

	public static string ToString(int value) { }

	public static string ToString(long value) { }

	public static string ToString(double value) { }

	public static string ToString(decimal value) { }

	public static string ToString(TimeSpan value) { }

	public static string ToString(UniqueId value) { }

	public static string ToString(ulong value) { }

	public static string ToString(DateTime value) { }

	private static string ToString(object value) { }

	public static string ToString(Object[] objects) { }

	public static string ToStringUnicode(Byte[] buffer, int offset, int count) { }

	public static TimeSpan ToTimeSpan(Byte[] buffer, int offset, int count) { }

	public static TimeSpan ToTimeSpan(string value) { }

	public static ulong ToUInt64(Byte[] buffer, int offset, int count) { }

	public static ulong ToUInt64(string value) { }

	public static UniqueId ToUniqueId(Byte[] buffer, int offset, int count) { }

	public static UniqueId ToUniqueId(string value) { }

	private static int ToZero(bool isNegative, Byte[] buffer, int offset) { }

	private static string Trim(string s) { }

	private static bool TryParseDateTime(Byte[] chars, int offset, int count, out DateTime result) { }

	private static bool TryParseDouble(Byte[] chars, int offset, int count, out double result) { }

	private static bool TryParseInt32(Byte[] chars, int offset, int count, out int result) { }

	private static bool TryParseInt64(Byte[] chars, int offset, int count, out long result) { }

	private static bool TryParseSingle(Byte[] chars, int offset, int count, out float result) { }

}


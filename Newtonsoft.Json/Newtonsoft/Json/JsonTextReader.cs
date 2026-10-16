namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonTextReader : JsonReader, IJsonLineInfo
{
	private readonly bool _safeAsync; //Field offset: 0x50
	private readonly TextReader _reader; //Field offset: 0x54
	[Nullable(2)]
	private Char[] _chars; //Field offset: 0x58
	private int _charsUsed; //Field offset: 0x5C
	private int _charPos; //Field offset: 0x60
	private int _lineStartPos; //Field offset: 0x64
	private int _lineNumber; //Field offset: 0x68
	private bool _isEndOfFile; //Field offset: 0x6C
	private StringBuffer _stringBuffer; //Field offset: 0x70
	private StringReference _stringReference; //Field offset: 0x78
	[Nullable(2)]
	private IArrayPool<Char> _arrayPool; //Field offset: 0x84
	[CompilerGenerated]
	[Nullable(2)]
	private JsonNameTable <PropertyNameTable>k__BackingField; //Field offset: 0x88

	public override int LineNumber
	{
		 get { } //Length: 57
	}

	public override int LinePosition
	{
		 get { } //Length: 14
	}

	[Nullable(2)]
	public JsonNameTable PropertyNameTable
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 14
		[CompilerGenerated]
		[NullableContext(2)]
		 set { } //Length: 33
	}

	public JsonTextReader(TextReader reader) { }

	private static object BigIntegerParse(string number, CultureInfo culture) { }

	private static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	private void ClearRecentString() { }

	public virtual void Close() { }

	private char ConvertUnicode(bool enoughChars) { }

	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	private void EatWhitespace() { }

	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	private void EnsureBuffer() { }

	private void EnsureBufferNotEmpty() { }

	private bool EnsureChars(int relativePosition, bool append) { }

	[NullableContext(2)]
	private object FinishReadQuotedNumber(ReadType readType) { }

	[NullableContext(2)]
	private object FinishReadQuotedStringValue(ReadType readType) { }

	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public JsonNameTable get_PropertyNameTable() { }

	private void HandleNull() { }

	public override bool HasLineInfo() { }

	private bool IsSeparator(char c) { }

	private bool MatchValue(string value) { }

	private bool MatchValue(bool enoughChars, string value) { }

	private bool MatchValueWithTrailingSeparator(string value) { }

	private void OnNewLine(int pos) { }

	private void ParseComment(bool setToken) { }

	private void ParseConstructor() { }

	private void ParseFalse() { }

	private void ParseNull() { }

	private void ParseNumber(ReadType readType) { }

	private object ParseNumberNaN(ReadType readType) { }

	private object ParseNumberNaN(ReadType readType, bool matched) { }

	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	private object ParseNumberNegativeInfinity(ReadType readType) { }

	private object ParseNumberPositiveInfinity(ReadType readType) { }

	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	private bool ParseObject() { }

	private bool ParsePostValue(bool ignoreComments) { }

	private bool ParseProperty() { }

	private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition) { }

	private void ParseReadString(char quote, ReadType readType) { }

	private void ParseString(char quote, ReadType readType) { }

	private void ParseTrue() { }

	private void ParseUndefined() { }

	private char ParseUnicode() { }

	private void ParseUnquotedProperty() { }

	private bool ParseValue() { }

	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	private void ProcessCarriageReturn(bool append) { }

	private void ProcessLineFeed() { }

	private void ProcessValueComma() { }

	public virtual bool Read() { }

	public virtual Nullable<Boolean> ReadAsBoolean() { }

	[NullableContext(2)]
	public virtual Byte[] ReadAsBytes() { }

	public virtual Nullable<DateTime> ReadAsDateTime() { }

	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	public virtual Nullable<Decimal> ReadAsDecimal() { }

	public virtual Nullable<Double> ReadAsDouble() { }

	public virtual Nullable<Int32> ReadAsInt32() { }

	[NullableContext(2)]
	public virtual string ReadAsString() { }

	private bool ReadChars(int relativePosition, bool append) { }

	private int ReadData(bool append) { }

	private int ReadData(bool append, int charsRequired) { }

	private void ReadFinished() { }

	private bool ReadNullChar() { }

	private bool ReadNumberCharIntoBuffer(char currentChar, int charPos) { }

	private void ReadNumberIntoBuffer() { }

	[NullableContext(2)]
	private object ReadNumberValue(ReadType readType) { }

	private void ReadStringIntoBuffer(char quote) { }

	[NullableContext(2)]
	private object ReadStringValue(ReadType readType) { }

	private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public void set_PropertyNameTable(JsonNameTable value) { }

	private void SetNewLine(bool hasNextChar) { }

	private void ShiftBufferIfNeeded() { }

	private JsonReaderException ThrowReaderError(string message, Exception ex = null) { }

	private bool ValidIdentifierChar(char value) { }

	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

}


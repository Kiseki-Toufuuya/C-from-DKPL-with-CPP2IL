namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonTextWriter : JsonWriter
{
	private readonly bool _safeAsync; //Field offset: 0x40
	private readonly TextWriter _writer; //Field offset: 0x44
	[Nullable(2)]
	private Base64Encoder _base64Encoder; //Field offset: 0x48
	private char _indentChar; //Field offset: 0x4C
	private int _indentation; //Field offset: 0x50
	private char _quoteChar; //Field offset: 0x54
	private bool _quoteName; //Field offset: 0x56
	[Nullable(2)]
	private Boolean[] _charEscapeFlags; //Field offset: 0x58
	[Nullable(2)]
	private Char[] _writeBuffer; //Field offset: 0x5C
	[Nullable(2)]
	private IArrayPool<Char> _arrayPool; //Field offset: 0x60
	[Nullable(2)]
	private Char[] _indentChars; //Field offset: 0x64

	private Base64Encoder Base64Encoder
	{
		private get { } //Length: 93
	}

	public char QuoteChar
	{
		 get { } //Length: 12
	}

	public JsonTextWriter(TextWriter textWriter) { }

	public virtual void Close() { }

	private void CloseBufferAndWriter() { }

	private void EnsureWriteBuffer() { }

	private Base64Encoder get_Base64Encoder() { }

	public char get_QuoteChar() { }

	internal virtual void OnStringEscapeHandlingChanged() { }

	private int SetIndentChars() { }

	private void UpdateCharEscapeFlags() { }

	[NullableContext(2)]
	public virtual void WriteComment(string text) { }

	protected virtual void WriteEnd(JsonToken token) { }

	private void WriteEscapedString(string value, bool quote) { }

	protected virtual void WriteIndent() { }

	protected virtual void WriteIndentSpace() { }

	private void WriteIntegerValue(uint value, bool negative) { }

	private void WriteIntegerValue(long value) { }

	private void WriteIntegerValue(int value) { }

	private void WriteIntegerValue(ulong value, bool negative) { }

	public virtual void WriteNull() { }

	private int WriteNumberToBuffer(ulong value, bool negative) { }

	private int WriteNumberToBuffer(uint value, bool negative) { }

	public virtual void WritePropertyName(string name) { }

	public virtual void WritePropertyName(string name, bool escape) { }

	[NullableContext(2)]
	public virtual void WriteRaw(string json) { }

	public virtual void WriteStartArray() { }

	public virtual void WriteStartConstructor(string name) { }

	public virtual void WriteStartObject() { }

	public virtual void WriteUndefined() { }

	[NullableContext(2)]
	public virtual void WriteValue(Uri value) { }

	public virtual void WriteValue(TimeSpan value) { }

	public virtual void WriteValue(Guid value) { }

	public virtual void WriteValue(DateTimeOffset value) { }

	[NullableContext(2)]
	public virtual void WriteValue(Byte[] value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(decimal value) { }

	public virtual void WriteValue(byte value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(sbyte value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(ushort value) { }

	[NullableContext(2)]
	public virtual void WriteValue(string value) { }

	[NullableContext(2)]
	public virtual void WriteValue(object value) { }

	public virtual void WriteValue(int value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(uint value) { }

	public virtual void WriteValue(long value) { }

	public virtual void WriteValue(char value) { }

	public virtual void WriteValue(float value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(Nullable<Double> value) { }

	public virtual void WriteValue(bool value) { }

	public virtual void WriteValue(short value) { }

	public virtual void WriteValue(Nullable<Single> value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(ulong value) { }

	protected virtual void WriteValueDelimiter() { }

	private void WriteValueInternal(string value, JsonToken token) { }

	private int WriteValueToBuffer(DateTimeOffset value) { }

	private int WriteValueToBuffer(DateTime value) { }

}


namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public abstract class JsonWriter : IDisposable
{
	[NullableContext(0)]
	public enum State
	{
		Start = 0,
		Property = 1,
		ObjectStart = 2,
		Object = 3,
		ArrayStart = 4,
		Array = 5,
		ConstructorStart = 6,
		Constructor = 7,
		Closed = 8,
		Error = 9,
	}

	private static readonly State[][] StateArray; //Field offset: 0x0
	internal static readonly State[][] StateArrayTemplate; //Field offset: 0x4
	[Nullable(2)]
	private List<JsonPosition> _stack; //Field offset: 0x8
	private JsonPosition _currentPosition; //Field offset: 0xC
	private State _currentState; //Field offset: 0x1C
	private Formatting _formatting; //Field offset: 0x20
	[CompilerGenerated]
	private bool <CloseOutput>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private bool <AutoCompleteOnClose>k__BackingField; //Field offset: 0x25
	private DateFormatHandling _dateFormatHandling; //Field offset: 0x28
	private DateTimeZoneHandling _dateTimeZoneHandling; //Field offset: 0x2C
	private StringEscapeHandling _stringEscapeHandling; //Field offset: 0x30
	private FloatFormatHandling _floatFormatHandling; //Field offset: 0x34
	[Nullable(2)]
	private string _dateFormatString; //Field offset: 0x38
	[Nullable(2)]
	private CultureInfo _culture; //Field offset: 0x3C

	public bool AutoCompleteOnClose
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool CloseOutput
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	internal string ContainerPath
	{
		internal get { } //Length: 119
	}

	public CultureInfo Culture
	{
		 get { } //Length: 74
		 set { } //Length: 27
	}

	public DateFormatHandling DateFormatHandling
	{
		 get { } //Length: 11
		 set { } //Length: 84
	}

	[Nullable(2)]
	public string DateFormatString
	{
		[NullableContext(2)]
		 get { } //Length: 11
		[NullableContext(2)]
		 set { } //Length: 27
	}

	public DateTimeZoneHandling DateTimeZoneHandling
	{
		 get { } //Length: 11
		 set { } //Length: 84
	}

	public FloatFormatHandling FloatFormatHandling
	{
		 get { } //Length: 11
		 set { } //Length: 84
	}

	public Formatting Formatting
	{
		 get { } //Length: 11
		 set { } //Length: 84
	}

	public string Path
	{
		 get { } //Length: 211
	}

	public StringEscapeHandling StringEscapeHandling
	{
		 get { } //Length: 11
		 set { } //Length: 104
	}

	protected private int Top
	{
		private get { } //Length: 70
	}

	public WriteState WriteState
	{
		 get { } //Length: 228
	}

	private static JsonWriter() { }

	protected JsonWriter() { }

	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	private void AutoCompleteAll() { }

	private void AutoCompleteClose(JsonContainerType type) { }

	internal static State[][] BuildStateArray() { }

	private int CalculateLevelsToComplete(JsonContainerType type) { }

	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	public override void Close() { }

	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	public bool get_AutoCompleteOnClose() { }

	[CompilerGenerated]
	public bool get_CloseOutput() { }

	internal string get_ContainerPath() { }

	public CultureInfo get_Culture() { }

	public DateFormatHandling get_DateFormatHandling() { }

	[NullableContext(2)]
	public string get_DateFormatString() { }

	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	public FloatFormatHandling get_FloatFormatHandling() { }

	public Formatting get_Formatting() { }

	public string get_Path() { }

	public StringEscapeHandling get_StringEscapeHandling() { }

	protected private int get_Top() { }

	public WriteState get_WriteState() { }

	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	internal void InternalWriteComment() { }

	internal void InternalWriteEnd(JsonContainerType container) { }

	internal void InternalWritePropertyName(string name) { }

	internal void InternalWriteRaw() { }

	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	internal void InternalWriteValue(JsonToken token) { }

	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	internal override void OnStringEscapeHandlingChanged() { }

	private JsonContainerType Peek() { }

	private JsonContainerType Pop() { }

	private void Push(JsonContainerType value) { }

	private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value) { }

	[CompilerGenerated]
	public void set_AutoCompleteOnClose(bool value) { }

	[CompilerGenerated]
	public void set_CloseOutput(bool value) { }

	public void set_Culture(CultureInfo value) { }

	public void set_DateFormatHandling(DateFormatHandling value) { }

	[NullableContext(2)]
	public void set_DateFormatString(string value) { }

	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	public void set_Formatting(Formatting value) { }

	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	protected void SetWriteState(JsonToken token, object value) { }

	private override void System.IDisposable.Dispose() { }

	private void UpdateCurrentState() { }

	internal void UpdateScopeWithFinishedValue() { }

	[NullableContext(2)]
	public override void WriteComment(string text) { }

	private void WriteConstructorDate(JsonReader reader) { }

	public override void WriteEnd() { }

	private void WriteEnd(JsonContainerType type) { }

	protected override void WriteEnd(JsonToken token) { }

	public override void WriteEndArray() { }

	public override void WriteEndConstructor() { }

	public override void WriteEndObject() { }

	protected override void WriteIndent() { }

	protected override void WriteIndentSpace() { }

	public override void WriteNull() { }

	public override void WritePropertyName(string name) { }

	public override void WritePropertyName(string name, bool escape) { }

	[NullableContext(2)]
	public override void WriteRaw(string json) { }

	[NullableContext(2)]
	public override void WriteRawValue(string json) { }

	public override void WriteStartArray() { }

	public override void WriteStartConstructor(string name) { }

	public override void WriteStartObject() { }

	public void WriteToken(JsonReader reader, bool writeChildren) { }

	[NullableContext(2)]
	public void WriteToken(JsonToken token, object value) { }

	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	public void WriteToken(JsonReader reader) { }

	public override void WriteUndefined() { }

	public override void WriteValue(Nullable<Char> value) { }

	public override void WriteValue(Nullable<Byte> value) { }

	[CLSCompliant(False)]
	public override void WriteValue(Nullable<SByte> value) { }

	public override void WriteValue(Nullable<Decimal> value) { }

	public override void WriteValue(Nullable<DateTime> value) { }

	public override void WriteValue(Nullable<DateTimeOffset> value) { }

	public override void WriteValue(Nullable<TimeSpan> value) { }

	[NullableContext(2)]
	public override void WriteValue(Byte[] value) { }

	[NullableContext(2)]
	public override void WriteValue(Uri value) { }

	[NullableContext(2)]
	public override void WriteValue(object value) { }

	[CLSCompliant(False)]
	public override void WriteValue(Nullable<UInt16> value) { }

	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	public override void WriteValue(Nullable<Guid> value) { }

	public override void WriteValue(Nullable<Int16> value) { }

	public override void WriteValue(bool value) { }

	public override void WriteValue(Nullable<Double> value) { }

	[NullableContext(2)]
	public override void WriteValue(string value) { }

	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	public override void WriteValue(uint value) { }

	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	public override void WriteValue(ulong value) { }

	public override void WriteValue(float value) { }

	public override void WriteValue(double value) { }

	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	public override void WriteValue(ushort value) { }

	public override void WriteValue(char value) { }

	public override void WriteValue(Nullable<Boolean> value) { }

	public override void WriteValue(byte value) { }

	public override void WriteValue(decimal value) { }

	public override void WriteValue(DateTime value) { }

	public override void WriteValue(DateTimeOffset value) { }

	public override void WriteValue(Guid value) { }

	public override void WriteValue(TimeSpan value) { }

	public override void WriteValue(Nullable<Int32> value) { }

	[CLSCompliant(False)]
	public override void WriteValue(Nullable<UInt32> value) { }

	public override void WriteValue(Nullable<Int64> value) { }

	[CLSCompliant(False)]
	public override void WriteValue(Nullable<UInt64> value) { }

	public override void WriteValue(Nullable<Single> value) { }

	[CLSCompliant(False)]
	public override void WriteValue(sbyte value) { }

	protected override void WriteValueDelimiter() { }

}


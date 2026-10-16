namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public abstract class JToken : IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
{
	[NullableContext(0)]
	private class LineInfoAnnotation
	{
		internal readonly int LineNumber; //Field offset: 0x8
		internal readonly int LinePosition; //Field offset: 0xC

		public LineInfoAnnotation(int lineNumber, int linePosition) { }

	}

	private static readonly JTokenType[] BooleanTypes; //Field offset: 0x0
	private static readonly JTokenType[] NumberTypes; //Field offset: 0x4
	private static readonly JTokenType[] BigIntegerTypes; //Field offset: 0x8
	private static readonly JTokenType[] StringTypes; //Field offset: 0xC
	private static readonly JTokenType[] GuidTypes; //Field offset: 0x10
	private static readonly JTokenType[] TimeSpanTypes; //Field offset: 0x14
	private static readonly JTokenType[] UriTypes; //Field offset: 0x18
	private static readonly JTokenType[] CharTypes; //Field offset: 0x1C
	private static readonly JTokenType[] DateTimeTypes; //Field offset: 0x20
	private static readonly JTokenType[] BytesTypes; //Field offset: 0x24
	[Nullable(2)]
	private JContainer _parent; //Field offset: 0x8
	[Nullable(2)]
	private JToken _previous; //Field offset: 0xC
	[Nullable(2)]
	private JToken _next; //Field offset: 0x10
	[Nullable(2)]
	private object _annotations; //Field offset: 0x14

	[Nullable(2)]
	public override JToken First
	{
		[NullableContext(2)]
		 get { } //Length: 115
	}

	public abstract bool HasValues
	{
		 get { } //Length: 0
	}

	[Nullable(2)]
	public override JToken Item
	{
		 get { } //Length: 115
		 set { } //Length: 115
	}

	[Nullable(2)]
	public override JToken Last
	{
		[NullableContext(2)]
		 get { } //Length: 115
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LineNumber
	{
		private get { } //Length: 60
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LinePosition
	{
		private get { } //Length: 60
	}

	[Nullable(2)]
	public internal JToken Next
	{
		[NullableContext(2)]
		 get { } //Length: 11
		[NullableContext(2)]
		internal set { } //Length: 27
	}

	[Nullable(2)]
	public internal JContainer Parent
	{
		[DebuggerStepThrough]
		[NullableContext(2)]
		 get { } //Length: 11
		[NullableContext(2)]
		internal set { } //Length: 27
	}

	public string Path
	{
		 get { } //Length: 557
	}

	[Nullable(2)]
	public internal JToken Previous
	{
		[NullableContext(2)]
		 get { } //Length: 11
		[NullableContext(2)]
		internal set { } //Length: 27
	}

	public JToken Root
	{
		 get { } //Length: 31
	}

	public abstract JTokenType Type
	{
		 get { } //Length: 0
	}

	private static JToken() { }

	internal JToken() { }

	public void AddAnnotation(object annotation) { }

	public T Annotation() { }

	public override JEnumerable<JToken> Children() { }

	internal abstract JToken CloneToken(JsonCloneSettings settings) { }

	internal void CopyAnnotations(JToken target, JToken source) { }

	public JsonReader CreateReader() { }

	public JToken DeepClone() { }

	private static JValue EnsureValue(JToken value) { }

	[NullableContext(2)]
	public override JToken get_First() { }

	public abstract bool get_HasValues() { }

	public override JToken get_Item(object key) { }

	[NullableContext(2)]
	public override JToken get_Last() { }

	[NullableContext(2)]
	public JToken get_Next() { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public JContainer get_Parent() { }

	public string get_Path() { }

	[NullableContext(2)]
	public JToken get_Previous() { }

	public JToken get_Root() { }

	public abstract JTokenType get_Type() { }

	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	private static string GetType(JToken token) { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	public static Nullable<SByte> op_Explicit(JToken value) { }

	public static DateTime op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Int64> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Single> op_Explicit(JToken value) { }

	public static decimal op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	public static Nullable<UInt64> op_Explicit(JToken value) { }

	public static double op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	public static ulong op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static string op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	public static uint op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Byte> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Guid> op_Explicit(JToken value) { }

	public static TimeSpan op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Uri op_Explicit(JToken value) { }

	public static float op_Explicit(JToken value) { }

	public static Guid op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	public static Nullable<UInt32> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Int32> op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	public static Nullable<UInt16> op_Explicit(JToken value) { }

	public static bool op_Explicit(JToken value) { }

	public static DateTimeOffset op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Boolean> op_Explicit(JToken value) { }

	public static long op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<DateTime> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Decimal> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Int16> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Char> op_Explicit(JToken value) { }

	public static int op_Explicit(JToken value) { }

	public static short op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	public static char op_Explicit(JToken value) { }

	public static byte op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Double> op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	public static sbyte op_Explicit(JToken value) { }

	public static JToken ReadFrom(JsonReader reader) { }

	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	public void Remove() { }

	public void Replace(JToken value) { }

	public override void set_Item(object key, JToken value) { }

	[NullableContext(2)]
	internal void set_Next(JToken value) { }

	[NullableContext(2)]
	internal void set_Parent(JContainer value) { }

	[NullableContext(2)]
	internal void set_Previous(JToken value) { }

	internal void SetLineInfo(int lineNumber, int linePosition) { }

	[NullableContext(2)]
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	private override object System.ICloneable.Clone() { }

	private static BigInteger ToBigInteger(JToken value) { }

	private static Nullable<BigInteger> ToBigIntegerNullable(JToken value) { }

	public object ToObject(Type objectType) { }

	[NullableContext(2)]
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	public virtual string ToString() { }

	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

}


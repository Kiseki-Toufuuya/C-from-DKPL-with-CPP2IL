namespace Google.Protobuf;

internal sealed class JsonToken : IEquatable<JsonToken>
{
	public enum TokenType
	{
		Null = 0,
		False = 1,
		True = 2,
		StringValue = 3,
		Number = 4,
		Name = 5,
		StartObject = 6,
		EndObject = 7,
		StartArray = 8,
		EndArray = 9,
		EndDocument = 10,
	}

	private static readonly JsonToken _true; //Field offset: 0x0
	private static readonly JsonToken _false; //Field offset: 0x4
	private static readonly JsonToken _null; //Field offset: 0x8
	private static readonly JsonToken startObject; //Field offset: 0xC
	private static readonly JsonToken endObject; //Field offset: 0x10
	private static readonly JsonToken startArray; //Field offset: 0x14
	private static readonly JsonToken endArray; //Field offset: 0x18
	private static readonly JsonToken endDocument; //Field offset: 0x1C
	private readonly TokenType type; //Field offset: 0x8
	private readonly string stringValue; //Field offset: 0xC
	private readonly double numberValue; //Field offset: 0x10

	internal static JsonToken EndArray
	{
		internal get { } //Length: 61
	}

	internal static JsonToken EndDocument
	{
		internal get { } //Length: 61
	}

	internal static JsonToken EndObject
	{
		internal get { } //Length: 61
	}

	internal static JsonToken False
	{
		internal get { } //Length: 61
	}

	internal static JsonToken Null
	{
		internal get { } //Length: 61
	}

	internal double NumberValue
	{
		internal get { } //Length: 11
	}

	internal static JsonToken StartArray
	{
		internal get { } //Length: 61
	}

	internal static JsonToken StartObject
	{
		internal get { } //Length: 61
	}

	internal string StringValue
	{
		internal get { } //Length: 11
	}

	internal static JsonToken True
	{
		internal get { } //Length: 60
	}

	internal TokenType Type
	{
		internal get { } //Length: 11
	}

	private static JsonToken() { }

	private JsonToken(TokenType type, string stringValue = null, double numberValue = 0) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(JsonToken other) { }

	internal static JsonToken get_EndArray() { }

	internal static JsonToken get_EndDocument() { }

	internal static JsonToken get_EndObject() { }

	internal static JsonToken get_False() { }

	internal static JsonToken get_Null() { }

	internal double get_NumberValue() { }

	internal static JsonToken get_StartArray() { }

	internal static JsonToken get_StartObject() { }

	internal string get_StringValue() { }

	internal static JsonToken get_True() { }

	internal TokenType get_Type() { }

	public virtual int GetHashCode() { }

	internal static JsonToken Name(string name) { }

	public virtual string ToString() { }

	internal static JsonToken Value(double value) { }

	internal static JsonToken Value(string value) { }

}


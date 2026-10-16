namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class JsonFormatterConverter : IFormatterConverter
{
	private readonly JsonSerializerInternalReader _reader; //Field offset: 0x8
	private readonly JsonISerializableContract _contract; //Field offset: 0xC
	[Nullable(2)]
	private readonly JsonProperty _member; //Field offset: 0x10

	public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	public override object Convert(object value, Type type) { }

	private T GetTokenValue(object value) { }

	public override bool ToBoolean(object value) { }

	public override int ToInt32(object value) { }

	public override long ToInt64(object value) { }

	public override float ToSingle(object value) { }

	public override string ToString(object value) { }

}


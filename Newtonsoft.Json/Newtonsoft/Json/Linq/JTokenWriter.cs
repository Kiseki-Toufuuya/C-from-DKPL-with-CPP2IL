namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(2)]
public class JTokenWriter : JsonWriter
{
	private JContainer _token; //Field offset: 0x40
	private JContainer _parent; //Field offset: 0x44
	private JValue _value; //Field offset: 0x48
	private JToken _current; //Field offset: 0x4C

	public JToken Token
	{
		 get { } //Length: 22
	}

	public JTokenWriter() { }

	internal void AddJValue(JValue value, JsonToken token) { }

	[NullableContext(1)]
	private void AddParent(JContainer container) { }

	private void AddRawValue(object value, JTokenType type, JsonToken token) { }

	public virtual void Close() { }

	public JToken get_Token() { }

	private void RemoveParent() { }

	public virtual void WriteComment(string text) { }

	protected virtual void WriteEnd(JsonToken token) { }

	public virtual void WriteNull() { }

	[NullableContext(1)]
	public virtual void WritePropertyName(string name) { }

	public virtual void WriteRaw(string json) { }

	public virtual void WriteStartArray() { }

	[NullableContext(1)]
	public virtual void WriteStartConstructor(string name) { }

	public virtual void WriteStartObject() { }

	[NullableContext(1)]
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	public virtual void WriteUndefined() { }

	public virtual void WriteValue(object value) { }

	public virtual void WriteValue(Guid value) { }

	public virtual void WriteValue(TimeSpan value) { }

	public virtual void WriteValue(Byte[] value) { }

	public virtual void WriteValue(DateTimeOffset value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(decimal value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(sbyte value) { }

	public virtual void WriteValue(byte value) { }

	public virtual void WriteValue(char value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(ushort value) { }

	public virtual void WriteValue(bool value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(float value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(ulong value) { }

	public virtual void WriteValue(long value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(uint value) { }

	public virtual void WriteValue(Uri value) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteValue(short value) { }

	public virtual void WriteValue(int value) { }

}


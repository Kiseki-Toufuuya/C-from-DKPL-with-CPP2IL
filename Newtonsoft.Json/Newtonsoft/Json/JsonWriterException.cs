namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonWriterException : JsonException
{
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; //Field offset: 0x48

	public JsonWriterException() { }

	public JsonWriterException(SerializationInfo info, StreamingContext context) { }

	public JsonWriterException(string message, string path, Exception innerException) { }

	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	internal static JsonWriterException Create(string path, string message, Exception ex) { }

}


namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public class JRaw : JValue
{

	internal JRaw(JRaw other, JsonCloneSettings settings) { }

	[NullableContext(2)]
	public JRaw(object rawJson) { }

	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	public static JRaw Create(JsonReader reader) { }

}


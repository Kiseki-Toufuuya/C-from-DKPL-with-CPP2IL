namespace Newtonsoft.Json.Bson;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonWriter : JsonWriter
{
	private BsonToken _root; //Field offset: 0x40
	private BsonToken _parent; //Field offset: 0x44
	private string _propertyName; //Field offset: 0x48

	internal void AddToken(BsonToken token) { }

	private void AddValue(object value, BsonType type) { }

	public void WriteObjectId(Byte[] value) { }

	public void WriteRegex(string pattern, string options) { }

}


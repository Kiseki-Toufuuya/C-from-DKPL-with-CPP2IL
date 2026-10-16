namespace Newtonsoft.Json.Bson;

internal class BsonValue : BsonToken
{
	private readonly object _value; //Field offset: 0xC
	private readonly BsonType _type; //Field offset: 0x10

	public virtual BsonType Type
	{
		 get { } //Length: 11
	}

	public BsonValue(object value, BsonType type) { }

	public virtual BsonType get_Type() { }

}


namespace Newtonsoft.Json.Bson;

internal class BsonArray : BsonToken
{
	private readonly List<BsonToken> _children; //Field offset: 0xC

	public virtual BsonType Type
	{
		 get { } //Length: 3
	}

	public void Add(BsonToken token) { }

	public virtual BsonType get_Type() { }

}


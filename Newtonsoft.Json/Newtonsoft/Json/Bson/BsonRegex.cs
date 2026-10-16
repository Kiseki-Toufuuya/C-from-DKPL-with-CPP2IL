namespace Newtonsoft.Json.Bson;

internal class BsonRegex : BsonToken
{
	[CompilerGenerated]
	private BsonString <Pattern>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private BsonString <Options>k__BackingField; //Field offset: 0x10

	public BsonString Options
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public BsonString Pattern
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public virtual BsonType Type
	{
		 get { } //Length: 3
	}

	public BsonRegex(string pattern, string options) { }

	public virtual BsonType get_Type() { }

	[CompilerGenerated]
	public void set_Options(BsonString value) { }

	[CompilerGenerated]
	public void set_Pattern(BsonString value) { }

}


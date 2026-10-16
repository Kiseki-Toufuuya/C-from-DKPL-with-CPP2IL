namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public class JsonContainerContract : JsonContract
{
	private JsonContract _itemContract; //Field offset: 0x4C
	private JsonContract _finalItemContract; //Field offset: 0x50
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private Nullable<Boolean> <ItemIsReference>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; //Field offset: 0x64

	internal JsonContract FinalItemContract
	{
		internal get { } //Length: 11
	}

	internal JsonContract ItemContract
	{
		internal get { } //Length: 11
		internal set { } //Length: 128
	}

	public JsonConverter ItemConverter
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Nullable<Boolean> ItemIsReference
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Nullable<TypeNameHandling> ItemTypeNameHandling
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	[NullableContext(1)]
	internal JsonContainerContract(Type underlyingType) { }

	internal JsonContract get_FinalItemContract() { }

	internal JsonContract get_ItemContract() { }

	[CompilerGenerated]
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	public Nullable<Boolean> get_ItemIsReference() { }

	[CompilerGenerated]
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	internal void set_ItemContract(JsonContract value) { }

	[CompilerGenerated]
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	public void set_ItemIsReference(Nullable<Boolean> value) { }

	[CompilerGenerated]
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

}


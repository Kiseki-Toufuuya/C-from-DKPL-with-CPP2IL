namespace D4L.TakashoFes.Master;

public sealed class MessageMapEntry : IFlatbuffersDaoEntry<Int64>
{
	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <Label>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Value>k__BackingField; //Field offset: 0x14

	public long ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string Label
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string Value
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public MessageMapEntry() { }

	public static MessageMapEntry Create(MessageMapRawEntry source) { }

	[CompilerGenerated]
	public string get_Value() { }

	[CompilerGenerated]
	public void set_ID(long value) { }

	[CompilerGenerated]
	public void set_Label(string value) { }

	[CompilerGenerated]
	public void set_Value(string value) { }

}


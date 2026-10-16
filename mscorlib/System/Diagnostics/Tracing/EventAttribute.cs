namespace System.Diagnostics.Tracing;

[AttributeUsage(AttributeTargets::Method (64))]
public sealed class EventAttribute : Attribute
{
	[CompilerGenerated]
	private int <EventId>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private EventLevel <Level>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private EventKeywords <Keywords>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0x18

	private int EventId
	{
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public EventKeywords Keywords
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public EventLevel Level
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string Message
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public EventAttribute(int eventId) { }

	[CompilerGenerated]
	private void set_EventId(int value) { }

	[CompilerGenerated]
	public void set_Keywords(EventKeywords value) { }

	[CompilerGenerated]
	public void set_Level(EventLevel value) { }

	[CompilerGenerated]
	public void set_Message(string value) { }

}


namespace D4L.TakashoFes.Storage;

public sealed class InventoryHistoryEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override InventoryHistoryEntry Parse(Byte[] source) { }

		public InventoryHistoryEntry Parse(InventoryHistoryProto source) { }

		public override Byte[] ToBytes(InventoryHistoryEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Value>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private long <ReceiveDate>k__BackingField; //Field offset: 0x18

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string Message
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public long ReceiveDate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string Value
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public InventoryHistoryEntry() { }

	[Preserve]
	public override InventoryHistoryEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public string get_Message() { }

	[CompilerGenerated]
	public long get_ReceiveDate() { }

	[CompilerGenerated]
	public string get_Value() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_Message(string value) { }

	[CompilerGenerated]
	public void set_ReceiveDate(long value) { }

	[CompilerGenerated]
	public void set_Value(string value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


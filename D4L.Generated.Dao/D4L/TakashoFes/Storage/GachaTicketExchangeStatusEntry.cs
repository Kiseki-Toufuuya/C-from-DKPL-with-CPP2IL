namespace D4L.TakashoFes.Storage;

public sealed class GachaTicketExchangeStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override GachaTicketExchangeStatusEntry Parse(Byte[] source) { }

		public GachaTicketExchangeStatusEntry Parse(GachaTicketExchangeStatusProto source) { }

		public override Byte[] ToBytes(GachaTicketExchangeStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <GachaTikectID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardInt <Delta>k__BackingField; //Field offset: 0x18

	public GuardInt Delta
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt GachaTikectID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GachaTicketExchangeStatusEntry() { }

	[Preserve]
	public override GachaTicketExchangeStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardInt get_Delta() { }

	[CompilerGenerated]
	public GuardInt get_GachaTikectID() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public void set_Delta(GuardInt value) { }

	[CompilerGenerated]
	public void set_GachaTikectID(GuardInt value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


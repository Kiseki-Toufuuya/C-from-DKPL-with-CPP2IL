namespace D4L.TakashoFes.Storage;

public sealed class SpotRepairStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override SpotRepairStatusEntry Parse(Byte[] source) { }

		public SpotRepairStatusEntry Parse(SpotRepairStatusProto source) { }

		public override Byte[] ToBytes(SpotRepairStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <RepairStatus>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <CreateDate>k__BackingField; //Field offset: 0x18

	public long CreateDate
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

	public GuardInt RepairStatus
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public SpotRepairStatusEntry() { }

	[Preserve]
	public override SpotRepairStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_CreateDate() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardInt get_RepairStatus() { }

	[CompilerGenerated]
	public void set_CreateDate(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_RepairStatus(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


namespace D4L.TakashoFes.Storage;

public sealed class SpotRepairTutorialStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override SpotRepairTutorialStatusEntry Parse(Byte[] source) { }

		public SpotRepairTutorialStatusEntry Parse(SpotRepairTutorialStatusProto source) { }

		public override Byte[] ToBytes(SpotRepairTutorialStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <RepairTutorialProgress>k__BackingField; //Field offset: 0x10

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt RepairTutorialProgress
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public SpotRepairTutorialStatusEntry() { }

	[Preserve]
	public override SpotRepairTutorialStatusEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardInt get_RepairTutorialProgress() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_RepairTutorialProgress(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


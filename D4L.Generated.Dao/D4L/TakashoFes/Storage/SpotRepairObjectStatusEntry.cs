namespace D4L.TakashoFes.Storage;

public sealed class SpotRepairObjectStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override SpotRepairObjectStatusEntry Parse(Byte[] source) { }

		public SpotRepairObjectStatusEntry Parse(SpotRepairObjectStatusProto source) { }

		public override Byte[] ToBytes(SpotRepairObjectStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <SpotObjectID>k__BackingField; //Field offset: 0x10

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt SpotObjectID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public SpotRepairObjectStatusEntry() { }

	[Preserve]
	public override SpotRepairObjectStatusEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardInt get_SpotObjectID() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_SpotObjectID(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


namespace D4L.TakashoFes.Storage;

public sealed class SpotVisitStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override SpotVisitStatusEntry Parse(Byte[] source) { }

		public SpotVisitStatusEntry Parse(SpotVisitStatusProto source) { }

		public override Byte[] ToBytes(SpotVisitStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <SpotVisitID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardInt <FlVistWeight>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x28

	public long CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt FlVistWeight
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

	public long LastUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt SpotVisitID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public SpotVisitStatusEntry() { }

	[Preserve]
	public override SpotVisitStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public GuardInt get_FlVistWeight() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public GuardInt get_SpotVisitID() { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public void set_FlVistWeight(GuardInt value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_SpotVisitID(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


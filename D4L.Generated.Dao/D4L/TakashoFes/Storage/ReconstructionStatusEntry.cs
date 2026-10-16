namespace D4L.TakashoFes.Storage;

public sealed class ReconstructionStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override ReconstructionStatusEntry Parse(Byte[] source) { }

		public ReconstructionStatusEntry Parse(ReconstructionStatusProto source) { }

		public override Byte[] ToBytes(ReconstructionStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <SpotObjectID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardLong <CompleteTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x30

	public GuardLong CompleteTime
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public long CreatedAt
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

	public GuardInt SpotObjectID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public ReconstructionStatusEntry() { }

	[Preserve]
	public override ReconstructionStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardLong get_CompleteTime() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public GuardInt get_SpotObjectID() { }

	[CompilerGenerated]
	public void set_CompleteTime(GuardLong value) { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_SpotObjectID(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


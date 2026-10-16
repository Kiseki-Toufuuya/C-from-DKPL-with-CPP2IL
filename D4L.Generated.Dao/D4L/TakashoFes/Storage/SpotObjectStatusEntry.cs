namespace D4L.TakashoFes.Storage;

public sealed class SpotObjectStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override SpotObjectStatusEntry Parse(Byte[] source) { }

		public SpotObjectStatusEntry Parse(SpotObjectStatusProto source) { }

		public override Byte[] ToBytes(SpotObjectStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <SpotObjectID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardLong <RewordGetTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GuardInt <SpotObjectRewardID>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private GuardInt <SpotObjectItemID>k__BackingField; //Field offset: 0x40

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

	public GuardLong RewordGetTime
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardInt SpotObjectID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt SpotObjectItemID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt SpotObjectRewardID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public SpotObjectStatusEntry() { }

	[Preserve]
	public override SpotObjectStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public GuardLong get_RewordGetTime() { }

	[CompilerGenerated]
	public GuardInt get_SpotObjectID() { }

	[CompilerGenerated]
	public GuardInt get_SpotObjectItemID() { }

	[CompilerGenerated]
	public GuardInt get_SpotObjectRewardID() { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_RewordGetTime(GuardLong value) { }

	[CompilerGenerated]
	public void set_SpotObjectID(GuardInt value) { }

	[CompilerGenerated]
	public void set_SpotObjectItemID(GuardInt value) { }

	[CompilerGenerated]
	public void set_SpotObjectRewardID(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


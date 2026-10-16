namespace D4L.TakashoFes.Storage;

public sealed class PartyExecStatusEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int64> <>9__37_0; //Field offset: 0x4
		public static Func<Int32, Int64> <>9__37_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal long <ToDict>b__37_0(int ____) { }

		internal long <ToDict>b__37_1(int ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override PartyExecStatusEntry Parse(Byte[] source) { }

		public PartyExecStatusEntry Parse(PartyExecStatusProto source) { }

		public override Byte[] ToBytes(PartyExecStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Int32[] <PartyMemberID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Int32[] <PartyRewardID>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private GuardLong <StartTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GuardLong <EndTime>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x40

	public long CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong EndTime
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
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

	public Int32[] PartyMemberID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Int32[] PartyRewardID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public GuardLong StartTime
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public PartyExecStatusEntry() { }

	[Preserve]
	public override PartyExecStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public GuardLong get_EndTime() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public Int32[] get_PartyMemberID() { }

	[CompilerGenerated]
	public Int32[] get_PartyRewardID() { }

	[CompilerGenerated]
	public GuardLong get_StartTime() { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public void set_EndTime(GuardLong value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_PartyMemberID(Int32[] value) { }

	[CompilerGenerated]
	public void set_PartyRewardID(Int32[] value) { }

	[CompilerGenerated]
	public void set_StartTime(GuardLong value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


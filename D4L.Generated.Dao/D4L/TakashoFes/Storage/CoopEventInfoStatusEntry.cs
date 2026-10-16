namespace D4L.TakashoFes.Storage;

public sealed class CoopEventInfoStatusEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int64> <>9__33_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal long <ToDict>b__33_0(int ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override CoopEventInfoStatusEntry Parse(Byte[] source) { }

		public CoopEventInfoStatusEntry Parse(CoopEventInfoStatusProto source) { }

		public override Byte[] ToBytes(CoopEventInfoStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Int32[] <PhaseUnlockedProgress>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Show>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private GuardLong <LastUpdate>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GuardLong <TweetLastReadTime>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuardLong <TotalTicketCount>k__BackingField; //Field offset: 0x38

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong LastUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public Int32[] PhaseUnlockedProgress
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int Show
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardLong TotalTicketCount
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong TweetLastReadTime
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public CoopEventInfoStatusEntry() { }

	[Preserve]
	public override CoopEventInfoStatusEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardLong get_LastUpdate() { }

	[CompilerGenerated]
	public Int32[] get_PhaseUnlockedProgress() { }

	[CompilerGenerated]
	public int get_Show() { }

	[CompilerGenerated]
	public GuardLong get_TotalTicketCount() { }

	[CompilerGenerated]
	public GuardLong get_TweetLastReadTime() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(GuardLong value) { }

	[CompilerGenerated]
	public void set_PhaseUnlockedProgress(Int32[] value) { }

	[CompilerGenerated]
	public void set_Show(int value) { }

	[CompilerGenerated]
	public void set_TotalTicketCount(GuardLong value) { }

	[CompilerGenerated]
	public void set_TweetLastReadTime(GuardLong value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


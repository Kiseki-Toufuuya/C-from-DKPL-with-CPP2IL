namespace D4L.TakashoFes.Storage;

public sealed class DanmakuPassSeasonStatusEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int64, Int64> <>9__29_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal long <ToDict>b__29_0(long ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override DanmakuPassSeasonStatusEntry Parse(Byte[] source) { }

		public DanmakuPassSeasonStatusEntry Parse(DanmakuPassSeasonStatusProto source) { }

		public override Byte[] ToBytes(DanmakuPassSeasonStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Int64[] <Received>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GuardLong <TierExp>k__BackingField; //Field offset: 0x28

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

	public Int64[] Received
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public GuardLong TierExp
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public DanmakuPassSeasonStatusEntry() { }

	[Preserve]
	public override DanmakuPassSeasonStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public Int64[] get_Received() { }

	[CompilerGenerated]
	public GuardLong get_TierExp() { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_Received(Int64[] value) { }

	[CompilerGenerated]
	public void set_TierExp(GuardLong value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


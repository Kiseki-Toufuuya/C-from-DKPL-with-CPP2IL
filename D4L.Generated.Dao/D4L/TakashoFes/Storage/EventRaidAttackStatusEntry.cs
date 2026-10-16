namespace D4L.TakashoFes.Storage;

public sealed class EventRaidAttackStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override EventRaidAttackStatusEntry Parse(Byte[] source) { }

		public EventRaidAttackStatusEntry Parse(EventRaidAttackStatusProto source) { }

		public override Byte[] ToBytes(EventRaidAttackStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardLong <DailyAttackBf>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardLong <DailyAttackAf>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GuardLong <EventAttackBf>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GuardLong <EventAttackAf>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private GuardLong <TotalAttackBf>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private GuardLong <TotalAttackAf>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private GuardString <RaidBossInstanceID>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private GuardLong <LastAttackAt>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private GuardInt <EventID>k__BackingField; //Field offset: 0x88

	public GuardLong DailyAttackAf
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong DailyAttackBf
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong EventAttackAf
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong EventAttackBf
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardInt EventID
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong LastAttackAt
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardString RaidBossInstanceID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 34
	}

	public GuardLong TotalAttackAf
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong TotalAttackBf
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public EventRaidAttackStatusEntry() { }

	[Preserve]
	public override EventRaidAttackStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardLong get_DailyAttackAf() { }

	[CompilerGenerated]
	public GuardLong get_DailyAttackBf() { }

	[CompilerGenerated]
	public GuardLong get_EventAttackAf() { }

	[CompilerGenerated]
	public GuardLong get_EventAttackBf() { }

	[CompilerGenerated]
	public GuardInt get_EventID() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardLong get_LastAttackAt() { }

	[CompilerGenerated]
	public GuardString get_RaidBossInstanceID() { }

	[CompilerGenerated]
	public GuardLong get_TotalAttackAf() { }

	[CompilerGenerated]
	public GuardLong get_TotalAttackBf() { }

	[CompilerGenerated]
	public void set_DailyAttackAf(GuardLong value) { }

	[CompilerGenerated]
	public void set_DailyAttackBf(GuardLong value) { }

	[CompilerGenerated]
	public void set_EventAttackAf(GuardLong value) { }

	[CompilerGenerated]
	public void set_EventAttackBf(GuardLong value) { }

	[CompilerGenerated]
	public void set_EventID(GuardInt value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastAttackAt(GuardLong value) { }

	[CompilerGenerated]
	public void set_RaidBossInstanceID(GuardString value) { }

	[CompilerGenerated]
	public void set_TotalAttackAf(GuardLong value) { }

	[CompilerGenerated]
	public void set_TotalAttackBf(GuardLong value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


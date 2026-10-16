namespace D4L.TakashoFes.Storage;

public sealed class AdMobMovieStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override AdMobMovieStatusEntry Parse(Byte[] source) { }

		public AdMobMovieStatusEntry Parse(AdMobMovieStatusProto source) { }

		public override Byte[] ToBytes(AdMobMovieStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardLong <ExpeditionLastShowDate>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardLong <ExpeditionTodayShowCount>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GuardLong <ExpeditionTotalShowCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GuardLong <HomeLastShowDate>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private GuardLong <HomeTodayShowCount>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private GuardLong <HomeShowCount>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private GuardLong <HomeTotalShowCount>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private GuardLong <SpecialChanceEndAt>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private GuardInt <SpecialChanceStep>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private GuardInt <SpecialChanceEnable>k__BackingField; //Field offset: 0x98

	public GuardLong ExpeditionLastShowDate
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong ExpeditionTodayShowCount
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong ExpeditionTotalShowCount
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong HomeLastShowDate
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong HomeShowCount
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong HomeTodayShowCount
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong HomeTotalShowCount
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

	public GuardInt SpecialChanceEnable
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public GuardLong SpecialChanceEndAt
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public GuardInt SpecialChanceStep
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public AdMobMovieStatusEntry() { }

	[Preserve]
	public override AdMobMovieStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardLong get_ExpeditionLastShowDate() { }

	[CompilerGenerated]
	public GuardLong get_ExpeditionTodayShowCount() { }

	[CompilerGenerated]
	public GuardLong get_ExpeditionTotalShowCount() { }

	[CompilerGenerated]
	public GuardLong get_HomeLastShowDate() { }

	[CompilerGenerated]
	public GuardLong get_HomeShowCount() { }

	[CompilerGenerated]
	public GuardLong get_HomeTodayShowCount() { }

	[CompilerGenerated]
	public GuardLong get_HomeTotalShowCount() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardInt get_SpecialChanceEnable() { }

	[CompilerGenerated]
	public GuardLong get_SpecialChanceEndAt() { }

	[CompilerGenerated]
	public GuardInt get_SpecialChanceStep() { }

	[CompilerGenerated]
	public void set_ExpeditionLastShowDate(GuardLong value) { }

	[CompilerGenerated]
	public void set_ExpeditionTodayShowCount(GuardLong value) { }

	[CompilerGenerated]
	public void set_ExpeditionTotalShowCount(GuardLong value) { }

	[CompilerGenerated]
	public void set_HomeLastShowDate(GuardLong value) { }

	[CompilerGenerated]
	public void set_HomeShowCount(GuardLong value) { }

	[CompilerGenerated]
	public void set_HomeTodayShowCount(GuardLong value) { }

	[CompilerGenerated]
	public void set_HomeTotalShowCount(GuardLong value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_SpecialChanceEnable(GuardInt value) { }

	[CompilerGenerated]
	public void set_SpecialChanceEndAt(GuardLong value) { }

	[CompilerGenerated]
	public void set_SpecialChanceStep(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


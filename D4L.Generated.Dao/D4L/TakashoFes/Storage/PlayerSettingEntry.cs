namespace D4L.TakashoFes.Storage;

public sealed class PlayerSettingEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int64> <>9__105_0; //Field offset: 0x4
		public static Func<Boolean, Boolean> <>9__105_1; //Field offset: 0x8
		public static Func<Boolean, Boolean> <>9__105_2; //Field offset: 0xC
		public static Func<Int64, Int64> <>9__105_3; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal long <ToDict>b__105_0(int ____) { }

		internal bool <ToDict>b__105_1(bool ____) { }

		internal bool <ToDict>b__105_2(bool ____) { }

		internal long <ToDict>b__105_3(long ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override PlayerSettingEntry Parse(Byte[] source) { }

		public PlayerSettingEntry Parse(PlayerSettingProto source) { }

		public override Byte[] ToBytes(PlayerSettingEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsPostAchievementSSRDraw>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsPostAchievementMaxStrengthen>k__BackingField; //Field offset: 0x21
	[CompilerGenerated]
	private bool <IsPostAchievementMaxAwake>k__BackingField; //Field offset: 0x22
	[CompilerGenerated]
	private bool <IsPostAchievementMaxLimitBreak>k__BackingField; //Field offset: 0x23
	[CompilerGenerated]
	private Int32[] <HomeCardIDs>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private bool <IsHomeDisplayMySpot>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Boolean[] <AwakeDisps>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private Boolean[] <PremiumDisps>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <BoxExchangeCount>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private long <LastGachaViewTime>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private long <LastGachaOpenTime>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Int64[] <GachaCheck>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private long <LastActiveEventViewTime>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private long <LastNewMusicAnnouncementViewTime>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private int <MessaggeFilter>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private long <StartDashGachaBaseTime>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private long <LastReviewDate>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private int <ReviewVersion>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private long <ContineLoginCounter>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private long <LastLoginDate>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private int <PlayerExpRev>k__BackingField; //Field offset: 0x90

	public Boolean[] AwakeDisps
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int BoxExchangeCount
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public long ContineLoginCounter
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public long CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Int64[] GachaCheck
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Int32[] HomeCardIDs
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public bool IsHomeDisplayMySpot
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsPostAchievementMaxAwake
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsPostAchievementMaxLimitBreak
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsPostAchievementMaxStrengthen
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsPostAchievementSSRDraw
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public long LastActiveEventViewTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long LastGachaOpenTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long LastGachaViewTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long LastLoginDate
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public long LastNewMusicAnnouncementViewTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long LastReviewDate
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

	public int MessaggeFilter
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int PlayerExpRev
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public Boolean[] PremiumDisps
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int ReviewVersion
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public long StartDashGachaBaseTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public PlayerSettingEntry() { }

	[Preserve]
	public override PlayerSettingEntry Clone() { }

	[CompilerGenerated]
	public Boolean[] get_AwakeDisps() { }

	[CompilerGenerated]
	public int get_BoxExchangeCount() { }

	[CompilerGenerated]
	public long get_ContineLoginCounter() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public Int64[] get_GachaCheck() { }

	[CompilerGenerated]
	public Int32[] get_HomeCardIDs() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public bool get_IsHomeDisplayMySpot() { }

	[CompilerGenerated]
	public bool get_IsPostAchievementMaxAwake() { }

	[CompilerGenerated]
	public bool get_IsPostAchievementMaxLimitBreak() { }

	[CompilerGenerated]
	public bool get_IsPostAchievementMaxStrengthen() { }

	[CompilerGenerated]
	public bool get_IsPostAchievementSSRDraw() { }

	[CompilerGenerated]
	public long get_LastActiveEventViewTime() { }

	[CompilerGenerated]
	public long get_LastGachaOpenTime() { }

	[CompilerGenerated]
	public long get_LastGachaViewTime() { }

	[CompilerGenerated]
	public long get_LastLoginDate() { }

	[CompilerGenerated]
	public long get_LastNewMusicAnnouncementViewTime() { }

	[CompilerGenerated]
	public long get_LastReviewDate() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public int get_MessaggeFilter() { }

	[CompilerGenerated]
	public int get_PlayerExpRev() { }

	[CompilerGenerated]
	public Boolean[] get_PremiumDisps() { }

	[CompilerGenerated]
	public int get_ReviewVersion() { }

	[CompilerGenerated]
	public long get_StartDashGachaBaseTime() { }

	[CompilerGenerated]
	public void set_AwakeDisps(Boolean[] value) { }

	[CompilerGenerated]
	public void set_BoxExchangeCount(int value) { }

	[CompilerGenerated]
	public void set_ContineLoginCounter(long value) { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public void set_GachaCheck(Int64[] value) { }

	[CompilerGenerated]
	public void set_HomeCardIDs(Int32[] value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_IsHomeDisplayMySpot(bool value) { }

	[CompilerGenerated]
	public void set_IsPostAchievementMaxAwake(bool value) { }

	[CompilerGenerated]
	public void set_IsPostAchievementMaxLimitBreak(bool value) { }

	[CompilerGenerated]
	public void set_IsPostAchievementMaxStrengthen(bool value) { }

	[CompilerGenerated]
	public void set_IsPostAchievementSSRDraw(bool value) { }

	[CompilerGenerated]
	public void set_LastActiveEventViewTime(long value) { }

	[CompilerGenerated]
	public void set_LastGachaOpenTime(long value) { }

	[CompilerGenerated]
	public void set_LastGachaViewTime(long value) { }

	[CompilerGenerated]
	public void set_LastLoginDate(long value) { }

	[CompilerGenerated]
	public void set_LastNewMusicAnnouncementViewTime(long value) { }

	[CompilerGenerated]
	public void set_LastReviewDate(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_MessaggeFilter(int value) { }

	[CompilerGenerated]
	public void set_PlayerExpRev(int value) { }

	[CompilerGenerated]
	public void set_PremiumDisps(Boolean[] value) { }

	[CompilerGenerated]
	public void set_ReviewVersion(int value) { }

	[CompilerGenerated]
	public void set_StartDashGachaBaseTime(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


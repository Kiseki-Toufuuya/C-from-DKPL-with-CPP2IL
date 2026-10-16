namespace D4L.TakashoFes.Storage;

public sealed class PlayMusicRecordEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MusicLevelRecord, Dictionary`2<String, Object>> <>9__69_0; //Field offset: 0x4
		public static Func<Int64, Int64> <>9__69_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__69_0(MusicLevelRecord ____) { }

		internal long <ToDict>b__69_1(long ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override PlayMusicRecordEntry Parse(Byte[] source) { }

		public PlayMusicRecordEntry Parse(PlayMusicRecordProto source) { }

		public override Byte[] ToBytes(PlayMusicRecordEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GuardInt <ReceiveRewardScore>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GuardInt <ReceiveRewardCombo>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuardInt <ReceiveRewardBossGauge>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <Favorite>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private MusicLevelRecord[] <Levels>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private int <New>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private GuardBool <IsLunaticRelease>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private GuardLong <RegularRankingScore0>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private GuardLong <RegularRankingScore1>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private GuardInt <RegularRankingSeriesID0>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private GuardInt <RegularRankingSeriesID1>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private Int64[] <MusicIDs>k__BackingField; //Field offset: 0x80

	public long CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int Favorite
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardBool IsLunaticRelease
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

	public MusicLevelRecord[] Levels
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Int64[] MusicIDs
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public int New
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardInt ReceiveRewardBossGauge
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ReceiveRewardCombo
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ReceiveRewardScore
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong RegularRankingScore0
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong RegularRankingScore1
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardInt RegularRankingSeriesID0
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt RegularRankingSeriesID1
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public PlayMusicRecordEntry() { }

	[Preserve]
	public override PlayMusicRecordEntry Clone() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public int get_Favorite() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardBool get_IsLunaticRelease() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public MusicLevelRecord[] get_Levels() { }

	[CompilerGenerated]
	public Int64[] get_MusicIDs() { }

	[CompilerGenerated]
	public int get_New() { }

	[CompilerGenerated]
	public GuardInt get_ReceiveRewardBossGauge() { }

	[CompilerGenerated]
	public GuardInt get_ReceiveRewardCombo() { }

	[CompilerGenerated]
	public GuardInt get_ReceiveRewardScore() { }

	[CompilerGenerated]
	public GuardLong get_RegularRankingScore0() { }

	[CompilerGenerated]
	public GuardLong get_RegularRankingScore1() { }

	[CompilerGenerated]
	public GuardInt get_RegularRankingSeriesID0() { }

	[CompilerGenerated]
	public GuardInt get_RegularRankingSeriesID1() { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public void set_Favorite(int value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_IsLunaticRelease(GuardBool value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_Levels(MusicLevelRecord[] value) { }

	[CompilerGenerated]
	public void set_MusicIDs(Int64[] value) { }

	[CompilerGenerated]
	public void set_New(int value) { }

	[CompilerGenerated]
	public void set_ReceiveRewardBossGauge(GuardInt value) { }

	[CompilerGenerated]
	public void set_ReceiveRewardCombo(GuardInt value) { }

	[CompilerGenerated]
	public void set_ReceiveRewardScore(GuardInt value) { }

	[CompilerGenerated]
	public void set_RegularRankingScore0(GuardLong value) { }

	[CompilerGenerated]
	public void set_RegularRankingScore1(GuardLong value) { }

	[CompilerGenerated]
	public void set_RegularRankingSeriesID0(GuardInt value) { }

	[CompilerGenerated]
	public void set_RegularRankingSeriesID1(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


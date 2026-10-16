namespace D4L.TakashoFes.Storage;

public sealed class PlayerBaseEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override PlayerBaseEntry Parse(Byte[] source) { }

		public PlayerBaseEntry Parse(PlayerBaseProto source) { }

		public override Byte[] ToBytes(PlayerBaseEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private long <CreateDate>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <PlayerName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Apeal>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private GuardInt <Emblem1ID>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GuardInt <Emblem2ID>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuardInt <FavorateHeroineID>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GuardLong <FavorateHeroineStatusID>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private GuardInt <FavorateCardID>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private GuardLong <FavorateCardStatusID>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private GuardInt <LaunchCount>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private long <LastLoggedInAt>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private GuardInt <FavorateMusicID>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private GuardInt <FavorateIconType>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private GuardInt <FirstTutorialProgress>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private GuardInt <RiverPatternNo>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private GuardInt <IsOpenMySpace>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private GuardInt <Emblem1IntVal>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private GuardInt <Emblem2IntVal>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private GuardInt <IsOpenNakasyoshi>k__BackingField; //Field offset: 0xA8

	public string Apeal
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public long CreateDate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt Emblem1ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt Emblem1IntVal
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public GuardInt Emblem2ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt Emblem2IntVal
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public GuardInt FavorateCardID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong FavorateCardStatusID
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardInt FavorateHeroineID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong FavorateHeroineStatusID
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardInt FavorateIconType
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt FavorateMusicID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt FirstTutorialProgress
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

	public GuardInt IsOpenMySpace
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public GuardInt IsOpenNakasyoshi
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public long LastLoggedInAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt LaunchCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string PlayerName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public GuardInt RiverPatternNo
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public PlayerBaseEntry() { }

	[Preserve]
	public override PlayerBaseEntry Clone() { }

	[CompilerGenerated]
	public string get_Apeal() { }

	[CompilerGenerated]
	public long get_CreateDate() { }

	[CompilerGenerated]
	public GuardInt get_Emblem1ID() { }

	[CompilerGenerated]
	public GuardInt get_Emblem1IntVal() { }

	[CompilerGenerated]
	public GuardInt get_Emblem2ID() { }

	[CompilerGenerated]
	public GuardInt get_Emblem2IntVal() { }

	[CompilerGenerated]
	public GuardInt get_FavorateCardID() { }

	[CompilerGenerated]
	public GuardLong get_FavorateCardStatusID() { }

	[CompilerGenerated]
	public GuardInt get_FavorateHeroineID() { }

	[CompilerGenerated]
	public GuardLong get_FavorateHeroineStatusID() { }

	[CompilerGenerated]
	public GuardInt get_FavorateIconType() { }

	[CompilerGenerated]
	public GuardInt get_FavorateMusicID() { }

	[CompilerGenerated]
	public GuardInt get_FirstTutorialProgress() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardInt get_IsOpenMySpace() { }

	[CompilerGenerated]
	public GuardInt get_IsOpenNakasyoshi() { }

	[CompilerGenerated]
	public long get_LastLoggedInAt() { }

	[CompilerGenerated]
	public GuardInt get_LaunchCount() { }

	[CompilerGenerated]
	public string get_PlayerName() { }

	[CompilerGenerated]
	public GuardInt get_RiverPatternNo() { }

	[CompilerGenerated]
	public void set_Apeal(string value) { }

	[CompilerGenerated]
	public void set_CreateDate(long value) { }

	[CompilerGenerated]
	public void set_Emblem1ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_Emblem1IntVal(GuardInt value) { }

	[CompilerGenerated]
	public void set_Emblem2ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_Emblem2IntVal(GuardInt value) { }

	[CompilerGenerated]
	public void set_FavorateCardID(GuardInt value) { }

	[CompilerGenerated]
	public void set_FavorateCardStatusID(GuardLong value) { }

	[CompilerGenerated]
	public void set_FavorateHeroineID(GuardInt value) { }

	[CompilerGenerated]
	public void set_FavorateHeroineStatusID(GuardLong value) { }

	[CompilerGenerated]
	public void set_FavorateIconType(GuardInt value) { }

	[CompilerGenerated]
	public void set_FavorateMusicID(GuardInt value) { }

	[CompilerGenerated]
	public void set_FirstTutorialProgress(GuardInt value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_IsOpenMySpace(GuardInt value) { }

	[CompilerGenerated]
	public void set_IsOpenNakasyoshi(GuardInt value) { }

	[CompilerGenerated]
	public void set_LastLoggedInAt(long value) { }

	[CompilerGenerated]
	public void set_LaunchCount(GuardInt value) { }

	[CompilerGenerated]
	public void set_PlayerName(string value) { }

	[CompilerGenerated]
	public void set_RiverPatternNo(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


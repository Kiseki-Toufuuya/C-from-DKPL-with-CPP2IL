namespace D4L.TakashoFes.Storage;

public sealed class PlayerStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override PlayerStatusEntry Parse(Byte[] source) { }

		public PlayerStatusEntry Parse(PlayerStatusProto source) { }

		public override Byte[] ToBytes(PlayerStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GuardLong <Exp>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GuardInt <StaminaValue>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GuardLong <StaminaDate>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private GuardInt <CardMaxAdd>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private GuardInt <HeroineMaxAdd>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private GuardInt <HaveCoin>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private GuardInt <TotalTemp>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private GuardInt <ClubMaxAdd>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private GuardInt <LevelTemp>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private GuardInt <LastPlayMusicID>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private GuardInt <LastPlayMusicDifficutyID>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private GuardInt <TodayBoostHealNum>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private GuardLong <LastBoostHealTime>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private int <LastSelectParty>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private int <LastPartyStageID>k__BackingField; //Field offset: 0xA4

	public GuardInt CardMaxAdd
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ClubMaxAdd
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong Exp
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardInt HaveCoin
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt HeroineMaxAdd
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

	public GuardLong LastBoostHealTime
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public int LastPartyStageID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public GuardInt LastPlayMusicDifficutyID
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public GuardInt LastPlayMusicID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int LastSelectParty
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public long LastUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt LevelTemp
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong StaminaDate
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardInt StaminaValue
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt TodayBoostHealNum
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public GuardInt TotalTemp
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public PlayerStatusEntry() { }

	[Preserve]
	public override PlayerStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardInt get_CardMaxAdd() { }

	[CompilerGenerated]
	public GuardInt get_ClubMaxAdd() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public GuardLong get_Exp() { }

	[CompilerGenerated]
	public GuardInt get_HaveCoin() { }

	[CompilerGenerated]
	public GuardInt get_HeroineMaxAdd() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardLong get_LastBoostHealTime() { }

	[CompilerGenerated]
	public int get_LastPartyStageID() { }

	[CompilerGenerated]
	public GuardInt get_LastPlayMusicDifficutyID() { }

	[CompilerGenerated]
	public GuardInt get_LastPlayMusicID() { }

	[CompilerGenerated]
	public int get_LastSelectParty() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public GuardInt get_LevelTemp() { }

	[CompilerGenerated]
	public GuardLong get_StaminaDate() { }

	[CompilerGenerated]
	public GuardInt get_StaminaValue() { }

	[CompilerGenerated]
	public GuardInt get_TodayBoostHealNum() { }

	[CompilerGenerated]
	public GuardInt get_TotalTemp() { }

	[CompilerGenerated]
	public void set_CardMaxAdd(GuardInt value) { }

	[CompilerGenerated]
	public void set_ClubMaxAdd(GuardInt value) { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public void set_Exp(GuardLong value) { }

	[CompilerGenerated]
	public void set_HaveCoin(GuardInt value) { }

	[CompilerGenerated]
	public void set_HeroineMaxAdd(GuardInt value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastBoostHealTime(GuardLong value) { }

	[CompilerGenerated]
	public void set_LastPartyStageID(int value) { }

	[CompilerGenerated]
	public void set_LastPlayMusicDifficutyID(GuardInt value) { }

	[CompilerGenerated]
	public void set_LastPlayMusicID(GuardInt value) { }

	[CompilerGenerated]
	public void set_LastSelectParty(int value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_LevelTemp(GuardInt value) { }

	[CompilerGenerated]
	public void set_StaminaDate(GuardLong value) { }

	[CompilerGenerated]
	public void set_StaminaValue(GuardInt value) { }

	[CompilerGenerated]
	public void set_TodayBoostHealNum(GuardInt value) { }

	[CompilerGenerated]
	public void set_TotalTemp(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


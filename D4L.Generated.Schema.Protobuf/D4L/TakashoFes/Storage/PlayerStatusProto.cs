namespace D4L.TakashoFes.Storage;

public sealed class PlayerStatusProto : IMessage<PlayerStatusProto>, IMessage, IEquatable<PlayerStatusProto>, IDeepCloneable<PlayerStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PlayerStatusProto <.cctor>b__110_0() { }

	}

	private static readonly MessageParser<PlayerStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long createdAt_; //Field offset: 0x18
	private long lastUpdate_; //Field offset: 0x20
	private long exp_; //Field offset: 0x28
	private int staminaValue_; //Field offset: 0x30
	private long staminaDate_; //Field offset: 0x38
	private int cardMaxAdd_; //Field offset: 0x40
	private int heroineMaxAdd_; //Field offset: 0x44
	private int haveCoin_; //Field offset: 0x48
	private int totalTemp_; //Field offset: 0x4C
	private int clubMaxAdd_; //Field offset: 0x50
	private int levelTemp_; //Field offset: 0x54
	private int lastPlayMusicID_; //Field offset: 0x58
	private int lastPlayMusicDifficutyID_; //Field offset: 0x5C
	private int todayBoostHealNum_; //Field offset: 0x60
	private long lastBoostHealTime_; //Field offset: 0x68
	private int lastSelectParty_; //Field offset: 0x70
	private int lastPartyStageID_; //Field offset: 0x74

	[DebuggerNonUserCode]
	public int CardMaxAdd
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int ClubMaxAdd
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long CreatedAt
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public long Exp
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int HaveCoin
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int HeroineMaxAdd
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long LastBoostHealTime
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int LastPartyStageID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int LastPlayMusicDifficutyID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int LastPlayMusicID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int LastSelectParty
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int LevelTemp
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<PlayerStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public long StaminaDate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int StaminaValue
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int TodayBoostHealNum
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int TotalTemp
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static PlayerStatusProto() { }

	[DebuggerNonUserCode]
	public PlayerStatusProto() { }

	[DebuggerNonUserCode]
	public PlayerStatusProto(PlayerStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override PlayerStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(PlayerStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_CardMaxAdd() { }

	public int get_ClubMaxAdd() { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_Exp() { }

	public int get_HaveCoin() { }

	public int get_HeroineMaxAdd() { }

	public long get_ID() { }

	public long get_LastBoostHealTime() { }

	public int get_LastPartyStageID() { }

	public int get_LastPlayMusicDifficutyID() { }

	public int get_LastPlayMusicID() { }

	public int get_LastSelectParty() { }

	public long get_LastUpdate() { }

	public int get_LevelTemp() { }

	public static MessageParser<PlayerStatusProto> get_Parser() { }

	public long get_StaminaDate() { }

	public int get_StaminaValue() { }

	public int get_TodayBoostHealNum() { }

	public int get_TotalTemp() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(PlayerStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CardMaxAdd(int value) { }

	public void set_ClubMaxAdd(int value) { }

	public void set_CreatedAt(long value) { }

	public void set_Exp(long value) { }

	public void set_HaveCoin(int value) { }

	public void set_HeroineMaxAdd(int value) { }

	public void set_ID(long value) { }

	public void set_LastBoostHealTime(long value) { }

	public void set_LastPartyStageID(int value) { }

	public void set_LastPlayMusicDifficutyID(int value) { }

	public void set_LastPlayMusicID(int value) { }

	public void set_LastSelectParty(int value) { }

	public void set_LastUpdate(long value) { }

	public void set_LevelTemp(int value) { }

	public void set_StaminaDate(long value) { }

	public void set_StaminaValue(int value) { }

	public void set_TodayBoostHealNum(int value) { }

	public void set_TotalTemp(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


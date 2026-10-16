namespace D4L.TakashoFes.Storage;

public sealed class PlayerSettingProto : IMessage<PlayerSettingProto>, IMessage, IEquatable<PlayerSettingProto>, IDeepCloneable<PlayerSettingProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PlayerSettingProto <.cctor>b__140_0() { }

	}

	private static readonly MessageParser<PlayerSettingProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int32> _repeated_homeCardIDs_codec; //Field offset: 0x4
	private static readonly FieldCodec<Boolean> _repeated_awakeDisps_codec; //Field offset: 0x8
	private static readonly FieldCodec<Boolean> _repeated_premiumDisps_codec; //Field offset: 0xC
	private static readonly FieldCodec<Int64> _repeated_gachaCheck_codec; //Field offset: 0x10
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long createdAt_; //Field offset: 0x18
	private long lastUpdate_; //Field offset: 0x20
	private bool isPostAchievementSSRDraw_; //Field offset: 0x28
	private bool isPostAchievementMaxStrengthen_; //Field offset: 0x29
	private bool isPostAchievementMaxAwake_; //Field offset: 0x2A
	private bool isPostAchievementMaxLimitBreak_; //Field offset: 0x2B
	private readonly RepeatedField<Int32> homeCardIDs_; //Field offset: 0x2C
	private bool isHomeDisplayMySpot_; //Field offset: 0x30
	private readonly RepeatedField<Boolean> awakeDisps_; //Field offset: 0x34
	private readonly RepeatedField<Boolean> premiumDisps_; //Field offset: 0x38
	private int boxExchangeCount_; //Field offset: 0x3C
	private long lastGachaViewTime_; //Field offset: 0x40
	private long lastGachaOpenTime_; //Field offset: 0x48
	private readonly RepeatedField<Int64> gachaCheck_; //Field offset: 0x50
	private long lastActiveEventViewTime_; //Field offset: 0x58
	private long lastNewMusicAnnouncementViewTime_; //Field offset: 0x60
	private int messaggeFilter_; //Field offset: 0x68
	private long startDashGachaBaseTime_; //Field offset: 0x70
	private long lastReviewDate_; //Field offset: 0x78
	private int reviewVersion_; //Field offset: 0x80
	private long contineLoginCounter_; //Field offset: 0x88
	private long lastLoginDate_; //Field offset: 0x90
	private int playerExpRev_; //Field offset: 0x98

	[DebuggerNonUserCode]
	public RepeatedField<Boolean> AwakeDisps
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public int BoxExchangeCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long ContineLoginCounter
	{
		 get { } //Length: 20
		 set { } //Length: 26
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
	public RepeatedField<Int64> GachaCheck
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> HomeCardIDs
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public bool IsHomeDisplayMySpot
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public bool IsPostAchievementMaxAwake
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public bool IsPostAchievementMaxLimitBreak
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public bool IsPostAchievementMaxStrengthen
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public bool IsPostAchievementSSRDraw
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long LastActiveEventViewTime
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long LastGachaOpenTime
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long LastGachaViewTime
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long LastLoginDate
	{
		 get { } //Length: 20
		 set { } //Length: 26
	}

	[DebuggerNonUserCode]
	public long LastNewMusicAnnouncementViewTime
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long LastReviewDate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int MessaggeFilter
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<PlayerSettingProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int PlayerExpRev
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	[DebuggerNonUserCode]
	public RepeatedField<Boolean> PremiumDisps
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public int ReviewVersion
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	[DebuggerNonUserCode]
	public long StartDashGachaBaseTime
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static PlayerSettingProto() { }

	[DebuggerNonUserCode]
	public PlayerSettingProto() { }

	[DebuggerNonUserCode]
	public PlayerSettingProto(PlayerSettingProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override PlayerSettingProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(PlayerSettingProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public RepeatedField<Boolean> get_AwakeDisps() { }

	public int get_BoxExchangeCount() { }

	public long get_ContineLoginCounter() { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<Int64> get_GachaCheck() { }

	public RepeatedField<Int32> get_HomeCardIDs() { }

	public long get_ID() { }

	public bool get_IsHomeDisplayMySpot() { }

	public bool get_IsPostAchievementMaxAwake() { }

	public bool get_IsPostAchievementMaxLimitBreak() { }

	public bool get_IsPostAchievementMaxStrengthen() { }

	public bool get_IsPostAchievementSSRDraw() { }

	public long get_LastActiveEventViewTime() { }

	public long get_LastGachaOpenTime() { }

	public long get_LastGachaViewTime() { }

	public long get_LastLoginDate() { }

	public long get_LastNewMusicAnnouncementViewTime() { }

	public long get_LastReviewDate() { }

	public long get_LastUpdate() { }

	public int get_MessaggeFilter() { }

	public static MessageParser<PlayerSettingProto> get_Parser() { }

	public int get_PlayerExpRev() { }

	public RepeatedField<Boolean> get_PremiumDisps() { }

	public int get_ReviewVersion() { }

	public long get_StartDashGachaBaseTime() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(PlayerSettingProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_BoxExchangeCount(int value) { }

	public void set_ContineLoginCounter(long value) { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_IsHomeDisplayMySpot(bool value) { }

	public void set_IsPostAchievementMaxAwake(bool value) { }

	public void set_IsPostAchievementMaxLimitBreak(bool value) { }

	public void set_IsPostAchievementMaxStrengthen(bool value) { }

	public void set_IsPostAchievementSSRDraw(bool value) { }

	public void set_LastActiveEventViewTime(long value) { }

	public void set_LastGachaOpenTime(long value) { }

	public void set_LastGachaViewTime(long value) { }

	public void set_LastLoginDate(long value) { }

	public void set_LastNewMusicAnnouncementViewTime(long value) { }

	public void set_LastReviewDate(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_MessaggeFilter(int value) { }

	public void set_PlayerExpRev(int value) { }

	public void set_ReviewVersion(int value) { }

	public void set_StartDashGachaBaseTime(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


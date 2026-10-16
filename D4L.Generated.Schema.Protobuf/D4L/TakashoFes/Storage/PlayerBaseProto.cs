namespace D4L.TakashoFes.Storage;

public sealed class PlayerBaseProto : IMessage<PlayerBaseProto>, IMessage, IEquatable<PlayerBaseProto>, IDeepCloneable<PlayerBaseProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PlayerBaseProto <.cctor>b__120_0() { }

	}

	private static readonly MessageParser<PlayerBaseProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long createDate_; //Field offset: 0x18
	private string playerName_; //Field offset: 0x20
	private string apeal_; //Field offset: 0x24
	private int emblem1ID_; //Field offset: 0x28
	private int emblem2ID_; //Field offset: 0x2C
	private int favorateHeroineID_; //Field offset: 0x30
	private long favorateHeroineStatusID_; //Field offset: 0x38
	private int favorateCardID_; //Field offset: 0x40
	private long favorateCardStatusID_; //Field offset: 0x48
	private int launchCount_; //Field offset: 0x50
	private long lastLoggedInAt_; //Field offset: 0x58
	private int favorateMusicID_; //Field offset: 0x60
	private int favorateIconType_; //Field offset: 0x64
	private int firstTutorialProgress_; //Field offset: 0x68
	private int riverPatternNo_; //Field offset: 0x6C
	private int isOpenMySpace_; //Field offset: 0x70
	private int emblem1IntVal_; //Field offset: 0x74
	private int emblem2IntVal_; //Field offset: 0x78
	private int isOpenNakasyoshi_; //Field offset: 0x7C

	[DebuggerNonUserCode]
	public string Apeal
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public long CreateDate
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
	public int Emblem1ID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int Emblem1IntVal
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int Emblem2ID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int Emblem2IntVal
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int FavorateCardID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long FavorateCardStatusID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int FavorateHeroineID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long FavorateHeroineStatusID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int FavorateIconType
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int FavorateMusicID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int FirstTutorialProgress
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
	public int IsOpenMySpace
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int IsOpenNakasyoshi
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long LastLoggedInAt
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int LaunchCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<PlayerBaseProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string PlayerName
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public int RiverPatternNo
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static PlayerBaseProto() { }

	[DebuggerNonUserCode]
	public PlayerBaseProto() { }

	[DebuggerNonUserCode]
	public PlayerBaseProto(PlayerBaseProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override PlayerBaseProto Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(PlayerBaseProto other) { }

	public string get_Apeal() { }

	public long get_CreateDate() { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_Emblem1ID() { }

	public int get_Emblem1IntVal() { }

	public int get_Emblem2ID() { }

	public int get_Emblem2IntVal() { }

	public int get_FavorateCardID() { }

	public long get_FavorateCardStatusID() { }

	public int get_FavorateHeroineID() { }

	public long get_FavorateHeroineStatusID() { }

	public int get_FavorateIconType() { }

	public int get_FavorateMusicID() { }

	public int get_FirstTutorialProgress() { }

	public long get_ID() { }

	public int get_IsOpenMySpace() { }

	public int get_IsOpenNakasyoshi() { }

	public long get_LastLoggedInAt() { }

	public int get_LaunchCount() { }

	public static MessageParser<PlayerBaseProto> get_Parser() { }

	public string get_PlayerName() { }

	public int get_RiverPatternNo() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(PlayerBaseProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Apeal(string value) { }

	public void set_CreateDate(long value) { }

	public void set_Emblem1ID(int value) { }

	public void set_Emblem1IntVal(int value) { }

	public void set_Emblem2ID(int value) { }

	public void set_Emblem2IntVal(int value) { }

	public void set_FavorateCardID(int value) { }

	public void set_FavorateCardStatusID(long value) { }

	public void set_FavorateHeroineID(int value) { }

	public void set_FavorateHeroineStatusID(long value) { }

	public void set_FavorateIconType(int value) { }

	public void set_FavorateMusicID(int value) { }

	public void set_FirstTutorialProgress(int value) { }

	public void set_ID(long value) { }

	public void set_IsOpenMySpace(int value) { }

	public void set_IsOpenNakasyoshi(int value) { }

	public void set_LastLoggedInAt(long value) { }

	public void set_LaunchCount(int value) { }

	public void set_PlayerName(string value) { }

	public void set_RiverPatternNo(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


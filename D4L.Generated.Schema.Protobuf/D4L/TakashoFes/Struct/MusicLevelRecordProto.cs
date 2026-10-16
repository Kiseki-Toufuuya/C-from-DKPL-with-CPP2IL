namespace D4L.TakashoFes.Struct;

public sealed class MusicLevelRecordProto : IMessage<MusicLevelRecordProto>, IMessage, IEquatable<MusicLevelRecordProto>, IDeepCloneable<MusicLevelRecordProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal MusicLevelRecordProto <.cctor>b__85_0() { }

	}

	private static readonly MessageParser<MusicLevelRecordProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long playCount_; //Field offset: 0x18
	private long clearCount_; //Field offset: 0x20
	private long maxScore_; //Field offset: 0x28
	private long maxCombo_; //Field offset: 0x30
	private long clearTime_; //Field offset: 0x38
	private int bossGauge_; //Field offset: 0x40
	private bool isSpellBreak_; //Field offset: 0x44
	private int bossDamage_; //Field offset: 0x48
	private int maxBrilliant_; //Field offset: 0x4C
	private bool isNoDamageClear_; //Field offset: 0x50
	private bool isFullCombo_; //Field offset: 0x51
	private bool isAllBrilliant_; //Field offset: 0x52

	[DebuggerNonUserCode]
	public int BossDamage
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int BossGauge
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long ClearCount
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long ClearTime
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
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public bool IsAllBrilliant
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public bool IsFullCombo
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public bool IsNoDamageClear
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public bool IsSpellBreak
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int MaxBrilliant
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long MaxCombo
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long MaxScore
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<MusicLevelRecordProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public long PlayCount
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static MusicLevelRecordProto() { }

	[DebuggerNonUserCode]
	public MusicLevelRecordProto() { }

	[DebuggerNonUserCode]
	public MusicLevelRecordProto(MusicLevelRecordProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override MusicLevelRecordProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MusicLevelRecordProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_BossDamage() { }

	public int get_BossGauge() { }

	public long get_ClearCount() { }

	public long get_ClearTime() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public bool get_IsAllBrilliant() { }

	public bool get_IsFullCombo() { }

	public bool get_IsNoDamageClear() { }

	public bool get_IsSpellBreak() { }

	public int get_MaxBrilliant() { }

	public long get_MaxCombo() { }

	public long get_MaxScore() { }

	public static MessageParser<MusicLevelRecordProto> get_Parser() { }

	public long get_PlayCount() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MusicLevelRecordProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_BossDamage(int value) { }

	public void set_BossGauge(int value) { }

	public void set_ClearCount(long value) { }

	public void set_ClearTime(long value) { }

	public void set_ID(long value) { }

	public void set_IsAllBrilliant(bool value) { }

	public void set_IsFullCombo(bool value) { }

	public void set_IsNoDamageClear(bool value) { }

	public void set_IsSpellBreak(bool value) { }

	public void set_MaxBrilliant(int value) { }

	public void set_MaxCombo(long value) { }

	public void set_MaxScore(long value) { }

	public void set_PlayCount(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


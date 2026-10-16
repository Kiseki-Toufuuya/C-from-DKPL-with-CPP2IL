namespace D4L.TakashoFes.Storage;

public sealed class PlayMusicRecordProto : IMessage<PlayMusicRecordProto>, IMessage, IEquatable<PlayMusicRecordProto>, IDeepCloneable<PlayMusicRecordProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PlayMusicRecordProto <.cctor>b__95_0() { }

	}

	private static readonly MessageParser<PlayMusicRecordProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<MusicLevelRecordProto> _repeated_levels_codec; //Field offset: 0x4
	private static readonly FieldCodec<Int64> _repeated_musicIDs_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long createdAt_; //Field offset: 0x18
	private long lastUpdate_; //Field offset: 0x20
	private int receiveRewardScore_; //Field offset: 0x28
	private int receiveRewardCombo_; //Field offset: 0x2C
	private int receiveRewardBossGauge_; //Field offset: 0x30
	private int favorite_; //Field offset: 0x34
	private readonly RepeatedField<MusicLevelRecordProto> levels_; //Field offset: 0x38
	private int new_; //Field offset: 0x3C
	private bool isLunaticRelease_; //Field offset: 0x40
	private long regularRankingScore0_; //Field offset: 0x48
	private long regularRankingScore1_; //Field offset: 0x50
	private int regularRankingSeriesID0_; //Field offset: 0x58
	private int regularRankingSeriesID1_; //Field offset: 0x5C
	private readonly RepeatedField<Int64> musicIDs_; //Field offset: 0x60

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
	public int Favorite
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
	public bool IsLunaticRelease
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
	public RepeatedField<MusicLevelRecordProto> Levels
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int64> MusicIDs
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public int New
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<PlayMusicRecordProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int ReceiveRewardBossGauge
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int ReceiveRewardCombo
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int ReceiveRewardScore
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long RegularRankingScore0
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long RegularRankingScore1
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int RegularRankingSeriesID0
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int RegularRankingSeriesID1
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static PlayMusicRecordProto() { }

	[DebuggerNonUserCode]
	public PlayMusicRecordProto() { }

	[DebuggerNonUserCode]
	public PlayMusicRecordProto(PlayMusicRecordProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override PlayMusicRecordProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(PlayMusicRecordProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_Favorite() { }

	public long get_ID() { }

	public bool get_IsLunaticRelease() { }

	public long get_LastUpdate() { }

	public RepeatedField<MusicLevelRecordProto> get_Levels() { }

	public RepeatedField<Int64> get_MusicIDs() { }

	public int get_New() { }

	public static MessageParser<PlayMusicRecordProto> get_Parser() { }

	public int get_ReceiveRewardBossGauge() { }

	public int get_ReceiveRewardCombo() { }

	public int get_ReceiveRewardScore() { }

	public long get_RegularRankingScore0() { }

	public long get_RegularRankingScore1() { }

	public int get_RegularRankingSeriesID0() { }

	public int get_RegularRankingSeriesID1() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(PlayMusicRecordProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_Favorite(int value) { }

	public void set_ID(long value) { }

	public void set_IsLunaticRelease(bool value) { }

	public void set_LastUpdate(long value) { }

	public void set_New(int value) { }

	public void set_ReceiveRewardBossGauge(int value) { }

	public void set_ReceiveRewardCombo(int value) { }

	public void set_ReceiveRewardScore(int value) { }

	public void set_RegularRankingScore0(long value) { }

	public void set_RegularRankingScore1(long value) { }

	public void set_RegularRankingSeriesID0(int value) { }

	public void set_RegularRankingSeriesID1(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


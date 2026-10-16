namespace D4L.TakashoFes.Storage;

public sealed class PlayerPublicStatusProto : IMessage<PlayerPublicStatusProto>, IMessage, IEquatable<PlayerPublicStatusProto>, IDeepCloneable<PlayerPublicStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PlayerPublicStatusProto <.cctor>b__130_0() { }

	}

	private static readonly MessageParser<PlayerPublicStatusProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int32> _repeated_clearMusicCount_codec; //Field offset: 0x4
	private static readonly FieldCodec<Int32> _repeated_clearFullComboCount_codec; //Field offset: 0x8
	private static readonly FieldCodec<CardEntityStatusProto> _repeated_favCard_codec; //Field offset: 0xC
	private static readonly FieldCodec<HeroineEntityStatusProto> _repeated_favHeroine_codec; //Field offset: 0x10
	private static readonly FieldCodec<CharacterEntityStatusProto> _repeated_favCharacter_codec; //Field offset: 0x14
	private static readonly FieldCodec<Int32> _repeated_clearAllBrilliantCount_codec; //Field offset: 0x18
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<Int32> clearMusicCount_; //Field offset: 0x18
	private readonly RepeatedField<Int32> clearFullComboCount_; //Field offset: 0x1C
	private int totalMusicPlayCount_; //Field offset: 0x20
	private int totalSpellBreakMusicCount_; //Field offset: 0x24
	private int totalBossBreakMusicCount_; //Field offset: 0x28
	private int danmakuRate_; //Field offset: 0x2C
	private int totalUnlockEpisodeCount_; //Field offset: 0x30
	private int mainEpisodeReadCount_; //Field offset: 0x34
	private int charaEpisodeReadCount_; //Field offset: 0x38
	private int reconstructSymbolCount_; //Field offset: 0x3C
	private int getObjectCount_; //Field offset: 0x40
	private long totalCardUnlockCount_; //Field offset: 0x48
	private long totalCardLevel_; //Field offset: 0x50
	private long totalCardAwakeLevel_; //Field offset: 0x58
	private long totalCharacterLevel_; //Field offset: 0x60
	private readonly RepeatedField<CardEntityStatusProto> favCard_; //Field offset: 0x68
	private readonly RepeatedField<HeroineEntityStatusProto> favHeroine_; //Field offset: 0x6C
	private readonly RepeatedField<CharacterEntityStatusProto> favCharacter_; //Field offset: 0x70
	private int totalSpellBreakMusicCountV2_; //Field offset: 0x74
	private int charaEpisodeReadCountV2_; //Field offset: 0x78
	private readonly RepeatedField<Int32> clearAllBrilliantCount_; //Field offset: 0x7C

	[DebuggerNonUserCode]
	public int CharaEpisodeReadCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int CharaEpisodeReadCountV2
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> ClearAllBrilliantCount
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> ClearFullComboCount
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> ClearMusicCount
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public int DanmakuRate
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public RepeatedField<CardEntityStatusProto> FavCard
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<CharacterEntityStatusProto> FavCharacter
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<HeroineEntityStatusProto> FavHeroine
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public int GetObjectCount
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
	public int MainEpisodeReadCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<PlayerPublicStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int ReconstructSymbolCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int TotalBossBreakMusicCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long TotalCardAwakeLevel
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long TotalCardLevel
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long TotalCardUnlockCount
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long TotalCharacterLevel
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int TotalMusicPlayCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int TotalSpellBreakMusicCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int TotalSpellBreakMusicCountV2
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int TotalUnlockEpisodeCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static PlayerPublicStatusProto() { }

	[DebuggerNonUserCode]
	public PlayerPublicStatusProto() { }

	[DebuggerNonUserCode]
	public PlayerPublicStatusProto(PlayerPublicStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override PlayerPublicStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(PlayerPublicStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_CharaEpisodeReadCount() { }

	public int get_CharaEpisodeReadCountV2() { }

	public RepeatedField<Int32> get_ClearAllBrilliantCount() { }

	public RepeatedField<Int32> get_ClearFullComboCount() { }

	public RepeatedField<Int32> get_ClearMusicCount() { }

	public int get_DanmakuRate() { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<CardEntityStatusProto> get_FavCard() { }

	public RepeatedField<CharacterEntityStatusProto> get_FavCharacter() { }

	public RepeatedField<HeroineEntityStatusProto> get_FavHeroine() { }

	public int get_GetObjectCount() { }

	public long get_ID() { }

	public int get_MainEpisodeReadCount() { }

	public static MessageParser<PlayerPublicStatusProto> get_Parser() { }

	public int get_ReconstructSymbolCount() { }

	public int get_TotalBossBreakMusicCount() { }

	public long get_TotalCardAwakeLevel() { }

	public long get_TotalCardLevel() { }

	public long get_TotalCardUnlockCount() { }

	public long get_TotalCharacterLevel() { }

	public int get_TotalMusicPlayCount() { }

	public int get_TotalSpellBreakMusicCount() { }

	public int get_TotalSpellBreakMusicCountV2() { }

	public int get_TotalUnlockEpisodeCount() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(PlayerPublicStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CharaEpisodeReadCount(int value) { }

	public void set_CharaEpisodeReadCountV2(int value) { }

	public void set_DanmakuRate(int value) { }

	public void set_GetObjectCount(int value) { }

	public void set_ID(long value) { }

	public void set_MainEpisodeReadCount(int value) { }

	public void set_ReconstructSymbolCount(int value) { }

	public void set_TotalBossBreakMusicCount(int value) { }

	public void set_TotalCardAwakeLevel(long value) { }

	public void set_TotalCardLevel(long value) { }

	public void set_TotalCardUnlockCount(long value) { }

	public void set_TotalCharacterLevel(long value) { }

	public void set_TotalMusicPlayCount(int value) { }

	public void set_TotalSpellBreakMusicCount(int value) { }

	public void set_TotalSpellBreakMusicCountV2(int value) { }

	public void set_TotalUnlockEpisodeCount(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


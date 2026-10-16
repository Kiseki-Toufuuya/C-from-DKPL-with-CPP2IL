namespace D4L.TakashoFes.Storage;

public sealed class PlayerPublicStatusEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int64> <>9__97_0; //Field offset: 0x4
		public static Func<Int32, Int64> <>9__97_1; //Field offset: 0x8
		public static Func<CardEntityStatus, Dictionary`2<String, Object>> <>9__97_2; //Field offset: 0xC
		public static Func<HeroineEntityStatus, Dictionary`2<String, Object>> <>9__97_3; //Field offset: 0x10
		public static Func<CharacterEntityStatus, Dictionary`2<String, Object>> <>9__97_4; //Field offset: 0x14
		public static Func<Int32, Int64> <>9__97_5; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal long <ToDict>b__97_0(int ____) { }

		internal long <ToDict>b__97_1(int ____) { }

		internal Dictionary<String, Object> <ToDict>b__97_2(CardEntityStatus ____) { }

		internal Dictionary<String, Object> <ToDict>b__97_3(HeroineEntityStatus ____) { }

		internal Dictionary<String, Object> <ToDict>b__97_4(CharacterEntityStatus ____) { }

		internal long <ToDict>b__97_5(int ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override PlayerPublicStatusEntry Parse(Byte[] source) { }

		public PlayerPublicStatusEntry Parse(PlayerPublicStatusProto source) { }

		public override Byte[] ToBytes(PlayerPublicStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Int32[] <ClearMusicCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Int32[] <ClearFullComboCount>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private GuardInt <TotalMusicPlayCount>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GuardInt <TotalSpellBreakMusicCount>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GuardInt <TotalBossBreakMusicCount>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuardInt <DanmakuRate>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GuardInt <TotalUnlockEpisodeCount>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private GuardInt <MainEpisodeReadCount>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private GuardInt <CharaEpisodeReadCount>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private GuardInt <ReconstructSymbolCount>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private GuardInt <GetObjectCount>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private GuardLong <TotalCardUnlockCount>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private GuardLong <TotalCardLevel>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private GuardLong <TotalCardAwakeLevel>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private GuardLong <TotalCharacterLevel>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private CardEntityStatus[] <FavCard>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private HeroineEntityStatus[] <FavHeroine>k__BackingField; //Field offset: 0xA4
	[CompilerGenerated]
	private CharacterEntityStatus[] <FavCharacter>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private GuardInt <TotalSpellBreakMusicCountV2>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	private GuardInt <CharaEpisodeReadCountV2>k__BackingField; //Field offset: 0xB4
	[CompilerGenerated]
	private Int32[] <ClearAllBrilliantCount>k__BackingField; //Field offset: 0xBC

	public GuardInt CharaEpisodeReadCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt CharaEpisodeReadCountV2
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public Int32[] ClearAllBrilliantCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Int32[] ClearFullComboCount
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Int32[] ClearMusicCount
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public GuardInt DanmakuRate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public CardEntityStatus[] FavCard
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public CharacterEntityStatus[] FavCharacter
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public HeroineEntityStatus[] FavHeroine
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public GuardInt GetObjectCount
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

	public GuardInt MainEpisodeReadCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ReconstructSymbolCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt TotalBossBreakMusicCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong TotalCardAwakeLevel
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public GuardLong TotalCardLevel
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong TotalCardUnlockCount
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong TotalCharacterLevel
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public GuardInt TotalMusicPlayCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt TotalSpellBreakMusicCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt TotalSpellBreakMusicCountV2
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public GuardInt TotalUnlockEpisodeCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public PlayerPublicStatusEntry() { }

	[Preserve]
	public override PlayerPublicStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardInt get_CharaEpisodeReadCount() { }

	[CompilerGenerated]
	public GuardInt get_CharaEpisodeReadCountV2() { }

	[CompilerGenerated]
	public Int32[] get_ClearAllBrilliantCount() { }

	[CompilerGenerated]
	public Int32[] get_ClearFullComboCount() { }

	[CompilerGenerated]
	public Int32[] get_ClearMusicCount() { }

	[CompilerGenerated]
	public GuardInt get_DanmakuRate() { }

	[CompilerGenerated]
	public CardEntityStatus[] get_FavCard() { }

	[CompilerGenerated]
	public CharacterEntityStatus[] get_FavCharacter() { }

	[CompilerGenerated]
	public HeroineEntityStatus[] get_FavHeroine() { }

	[CompilerGenerated]
	public GuardInt get_GetObjectCount() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardInt get_MainEpisodeReadCount() { }

	[CompilerGenerated]
	public GuardInt get_ReconstructSymbolCount() { }

	[CompilerGenerated]
	public GuardInt get_TotalBossBreakMusicCount() { }

	[CompilerGenerated]
	public GuardLong get_TotalCardAwakeLevel() { }

	[CompilerGenerated]
	public GuardLong get_TotalCardLevel() { }

	[CompilerGenerated]
	public GuardLong get_TotalCardUnlockCount() { }

	[CompilerGenerated]
	public GuardLong get_TotalCharacterLevel() { }

	[CompilerGenerated]
	public GuardInt get_TotalMusicPlayCount() { }

	[CompilerGenerated]
	public GuardInt get_TotalSpellBreakMusicCount() { }

	[CompilerGenerated]
	public GuardInt get_TotalSpellBreakMusicCountV2() { }

	[CompilerGenerated]
	public GuardInt get_TotalUnlockEpisodeCount() { }

	[CompilerGenerated]
	public void set_CharaEpisodeReadCount(GuardInt value) { }

	[CompilerGenerated]
	public void set_CharaEpisodeReadCountV2(GuardInt value) { }

	[CompilerGenerated]
	public void set_ClearAllBrilliantCount(Int32[] value) { }

	[CompilerGenerated]
	public void set_ClearFullComboCount(Int32[] value) { }

	[CompilerGenerated]
	public void set_ClearMusicCount(Int32[] value) { }

	[CompilerGenerated]
	public void set_DanmakuRate(GuardInt value) { }

	[CompilerGenerated]
	public void set_FavCard(CardEntityStatus[] value) { }

	[CompilerGenerated]
	public void set_FavCharacter(CharacterEntityStatus[] value) { }

	[CompilerGenerated]
	public void set_FavHeroine(HeroineEntityStatus[] value) { }

	[CompilerGenerated]
	public void set_GetObjectCount(GuardInt value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_MainEpisodeReadCount(GuardInt value) { }

	[CompilerGenerated]
	public void set_ReconstructSymbolCount(GuardInt value) { }

	[CompilerGenerated]
	public void set_TotalBossBreakMusicCount(GuardInt value) { }

	[CompilerGenerated]
	public void set_TotalCardAwakeLevel(GuardLong value) { }

	[CompilerGenerated]
	public void set_TotalCardLevel(GuardLong value) { }

	[CompilerGenerated]
	public void set_TotalCardUnlockCount(GuardLong value) { }

	[CompilerGenerated]
	public void set_TotalCharacterLevel(GuardLong value) { }

	[CompilerGenerated]
	public void set_TotalMusicPlayCount(GuardInt value) { }

	[CompilerGenerated]
	public void set_TotalSpellBreakMusicCount(GuardInt value) { }

	[CompilerGenerated]
	public void set_TotalSpellBreakMusicCountV2(GuardInt value) { }

	[CompilerGenerated]
	public void set_TotalUnlockEpisodeCount(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}


namespace D4L.TakashoFes.Master;

public sealed class MusicEntry : IFlatbuffersDaoEntry<GuardInt>
{
	[CompilerGenerated]
	private GuardInt <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <Enable>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <DataVersion>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private GuardInt <WavID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <ScoreBaseID>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <MusicType>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <NotShowBossSpellName>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <CoverID>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private int <BackgroundID>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <MusicDateFileID>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private GuardInt <CharaType>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private GuardInt <BossID>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private GuardInt <BossID2>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private GuardInt <BossID3>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private int <BossHp>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private int <RankMaxScore>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private int <RankSScore>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private int <RankAScore>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private int <RankBScore>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private int <RankCScore>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private int <RankDScore>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private int <RankMaxTotal>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private int <RankSTotal>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private int <RankATotal>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	private int <RankBTotal>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private int <RankCTotal>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private int <RankDTotal>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private GuardInt <MusicStartTime>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private GuardInt <SpellCardID>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	private GuardInt <SpellCard2ID>k__BackingField; //Field offset: 0x9C
	[CompilerGenerated]
	private GuardInt <SpellCard3ID>k__BackingField; //Field offset: 0xA4
	[CompilerGenerated]
	private GuardInt <SpellCardMissionID>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	private int <GroupeID>k__BackingField; //Field offset: 0xB4
	[CompilerGenerated]
	private string <IllustratorName>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private int <CreaterNo>k__BackingField; //Field offset: 0xBC
	[CompilerGenerated]
	private int <MusicAttr>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private string <Circle>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private string <Title>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private string <TitleYomi>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	private string <OriginalName>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private string <Vocal>k__BackingField; //Field offset: 0xD4
	[CompilerGenerated]
	private string <Part1>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private string <Part2>k__BackingField; //Field offset: 0xDC
	[CompilerGenerated]
	private string <Part3>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private string <Part4>k__BackingField; //Field offset: 0xE4
	[CompilerGenerated]
	private string <Part5>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private string <Part6>k__BackingField; //Field offset: 0xEC
	[CompilerGenerated]
	private string <Part7>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private string <Part8>k__BackingField; //Field offset: 0xF4
	[CompilerGenerated]
	private string <Part9>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private string <Part10>k__BackingField; //Field offset: 0xFC
	[CompilerGenerated]
	private string <Part11>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private GuardInt <DisplayOrder>k__BackingField; //Field offset: 0x104
	[CompilerGenerated]
	private GuardInt <DanmakuRate>k__BackingField; //Field offset: 0x10C
	[CompilerGenerated]
	private GuardInt <ScoreRewardID>k__BackingField; //Field offset: 0x114
	[CompilerGenerated]
	private GuardInt <ComboRewardID>k__BackingField; //Field offset: 0x11C
	[CompilerGenerated]
	private GuardInt <BossGaugeRewardID>k__BackingField; //Field offset: 0x124
	[CompilerGenerated]
	private Int32[] <ConsumeStamina>k__BackingField; //Field offset: 0x12C
	[CompilerGenerated]
	private Int32[] <GetExp>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private Int32[] <GetNakayosiPt>k__BackingField; //Field offset: 0x134
	[CompilerGenerated]
	private Int32[] <GetCardPt>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private Int32[] <GetPartyPt>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private int <BaseBPM>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private bool <IsShowStageSelect>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private int <LunaticNoDamageClearEmblemID>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private string <DetailURL>k__BackingField; //Field offset: 0x14C

	public int BackgroundID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int BaseBPM
	{
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public GuardInt BossGaugeRewardID
	{
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public int BossHp
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardInt BossID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt BossID2
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt BossID3
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt CharaType
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string Circle
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public GuardInt ComboRewardID
	{
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public Int32[] ConsumeStamina
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public int CoverID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int CreaterNo
	{
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public GuardInt DanmakuRate
	{
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public int DataVersion
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string DetailURL
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public GuardInt DisplayOrder
	{
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public int Enable
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Int32[] GetCardPt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Int32[] GetExp
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Int32[] GetNakayosiPt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Int32[] GetPartyPt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public int GroupeID
	{
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public GuardInt ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string IllustratorName
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public bool IsShowStageSelect
	{
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int LunaticNoDamageClearEmblemID
	{
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int MusicAttr
	{
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int MusicDateFileID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardInt MusicStartTime
	{
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public int MusicType
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int NotShowBossSpellName
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string OriginalName
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string Part1
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string Part10
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string Part11
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string Part2
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string Part3
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string Part4
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string Part5
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string Part6
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string Part7
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string Part8
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string Part9
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public int RankAScore
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int RankATotal
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int RankBScore
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int RankBTotal
	{
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int RankCScore
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int RankCTotal
	{
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int RankDScore
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int RankDTotal
	{
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int RankMaxScore
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int RankMaxTotal
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int RankSScore
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int RankSTotal
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int ScoreBaseID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardInt ScoreRewardID
	{
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public GuardInt SpellCard2ID
	{
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public GuardInt SpellCard3ID
	{
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public GuardInt SpellCardID
	{
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public GuardInt SpellCardMissionID
	{
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public string Title
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string TitleYomi
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public string Vocal
	{
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public GuardInt WavID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public MusicEntry() { }

	public static MusicEntry Create(MusicRawEntry source) { }

	[CompilerGenerated]
	public Int32[] get_ConsumeStamina() { }

	[CompilerGenerated]
	public Int32[] get_GetCardPt() { }

	[CompilerGenerated]
	public Int32[] get_GetExp() { }

	[CompilerGenerated]
	public Int32[] get_GetNakayosiPt() { }

	[CompilerGenerated]
	public Int32[] get_GetPartyPt() { }

	[CompilerGenerated]
	public void set_BackgroundID(int value) { }

	[CompilerGenerated]
	public void set_BaseBPM(int value) { }

	[CompilerGenerated]
	public void set_BossGaugeRewardID(GuardInt value) { }

	[CompilerGenerated]
	public void set_BossHp(int value) { }

	[CompilerGenerated]
	public void set_BossID(GuardInt value) { }

	[CompilerGenerated]
	public void set_BossID2(GuardInt value) { }

	[CompilerGenerated]
	public void set_BossID3(GuardInt value) { }

	[CompilerGenerated]
	public void set_CharaType(GuardInt value) { }

	[CompilerGenerated]
	public void set_Circle(string value) { }

	[CompilerGenerated]
	public void set_ComboRewardID(GuardInt value) { }

	[CompilerGenerated]
	public void set_ConsumeStamina(Int32[] value) { }

	[CompilerGenerated]
	public void set_CoverID(int value) { }

	[CompilerGenerated]
	public void set_CreaterNo(int value) { }

	[CompilerGenerated]
	public void set_DanmakuRate(GuardInt value) { }

	[CompilerGenerated]
	public void set_DataVersion(int value) { }

	[CompilerGenerated]
	public void set_DetailURL(string value) { }

	[CompilerGenerated]
	public void set_DisplayOrder(GuardInt value) { }

	[CompilerGenerated]
	public void set_Enable(int value) { }

	[CompilerGenerated]
	public void set_GetCardPt(Int32[] value) { }

	[CompilerGenerated]
	public void set_GetExp(Int32[] value) { }

	[CompilerGenerated]
	public void set_GetNakayosiPt(Int32[] value) { }

	[CompilerGenerated]
	public void set_GetPartyPt(Int32[] value) { }

	[CompilerGenerated]
	public void set_GroupeID(int value) { }

	[CompilerGenerated]
	public void set_ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_IllustratorName(string value) { }

	[CompilerGenerated]
	public void set_IsShowStageSelect(bool value) { }

	[CompilerGenerated]
	public void set_LunaticNoDamageClearEmblemID(int value) { }

	[CompilerGenerated]
	public void set_MusicAttr(int value) { }

	[CompilerGenerated]
	public void set_MusicDateFileID(int value) { }

	[CompilerGenerated]
	public void set_MusicStartTime(GuardInt value) { }

	[CompilerGenerated]
	public void set_MusicType(int value) { }

	[CompilerGenerated]
	public void set_NotShowBossSpellName(int value) { }

	[CompilerGenerated]
	public void set_OriginalName(string value) { }

	[CompilerGenerated]
	public void set_Part1(string value) { }

	[CompilerGenerated]
	public void set_Part10(string value) { }

	[CompilerGenerated]
	public void set_Part11(string value) { }

	[CompilerGenerated]
	public void set_Part2(string value) { }

	[CompilerGenerated]
	public void set_Part3(string value) { }

	[CompilerGenerated]
	public void set_Part4(string value) { }

	[CompilerGenerated]
	public void set_Part5(string value) { }

	[CompilerGenerated]
	public void set_Part6(string value) { }

	[CompilerGenerated]
	public void set_Part7(string value) { }

	[CompilerGenerated]
	public void set_Part8(string value) { }

	[CompilerGenerated]
	public void set_Part9(string value) { }

	[CompilerGenerated]
	public void set_RankAScore(int value) { }

	[CompilerGenerated]
	public void set_RankATotal(int value) { }

	[CompilerGenerated]
	public void set_RankBScore(int value) { }

	[CompilerGenerated]
	public void set_RankBTotal(int value) { }

	[CompilerGenerated]
	public void set_RankCScore(int value) { }

	[CompilerGenerated]
	public void set_RankCTotal(int value) { }

	[CompilerGenerated]
	public void set_RankDScore(int value) { }

	[CompilerGenerated]
	public void set_RankDTotal(int value) { }

	[CompilerGenerated]
	public void set_RankMaxScore(int value) { }

	[CompilerGenerated]
	public void set_RankMaxTotal(int value) { }

	[CompilerGenerated]
	public void set_RankSScore(int value) { }

	[CompilerGenerated]
	public void set_RankSTotal(int value) { }

	[CompilerGenerated]
	public void set_ScoreBaseID(int value) { }

	[CompilerGenerated]
	public void set_ScoreRewardID(GuardInt value) { }

	[CompilerGenerated]
	public void set_SpellCard2ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_SpellCard3ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_SpellCardID(GuardInt value) { }

	[CompilerGenerated]
	public void set_SpellCardMissionID(GuardInt value) { }

	[CompilerGenerated]
	public void set_Title(string value) { }

	[CompilerGenerated]
	public void set_TitleYomi(string value) { }

	[CompilerGenerated]
	public void set_Vocal(string value) { }

	[CompilerGenerated]
	public void set_WavID(GuardInt value) { }

}


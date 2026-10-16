namespace Heqet;

public class HeqetMusicModel : EntityBase<HeqetMusicModel, Int32>
{
	internal enum CategoryType
	{
		None = -1,
		Original = 0,
		DankaguOriginal = 1,
		OpenCallSilver = 2,
		OpenCallGold = 3,
		Movie = 4,
		Max = 5,
	}

	internal enum CircleDispTypes
	{
		Circle = 0,
		Artist = 1,
		Remixer = 2,
		Max = 3,
	}

	public int ID; //Field offset: 0xC
	public int DlcID; //Field offset: 0x10
	public string Title; //Field offset: 0x14
	public int WavID; //Field offset: 0x18
	public int NotShowBossSpellName; //Field offset: 0x1C
	public int BackgroundID; //Field offset: 0x20
	public int CharaType; //Field offset: 0x24
	public int BossID; //Field offset: 0x28
	public int BossID2; //Field offset: 0x2C
	public int BossID3; //Field offset: 0x30
	public int BossHp; //Field offset: 0x34
	public int MusicStartTime; //Field offset: 0x38
	public int SpellCardID; //Field offset: 0x3C
	public int SpellCard2ID; //Field offset: 0x40
	public int SpellCard3ID; //Field offset: 0x44
	public string IllustratorName; //Field offset: 0x48
	public int CreaterNo; //Field offset: 0x4C
	public string Circle; //Field offset: 0x50
	public string CircleYomi; //Field offset: 0x54
	public string TitleYomi; //Field offset: 0x58
	public string Vocal; //Field offset: 0x5C
	public string Part1; //Field offset: 0x60
	public string Part2; //Field offset: 0x64
	public string Part3; //Field offset: 0x68
	public string Part4; //Field offset: 0x6C
	public string Part5; //Field offset: 0x70
	public string Part6; //Field offset: 0x74
	public string Part7; //Field offset: 0x78
	public string Part8; //Field offset: 0x7C
	public string Part9; //Field offset: 0x80
	public string Part10; //Field offset: 0x84
	public string Part11; //Field offset: 0x88
	public float BaseBPM; //Field offset: 0x8C
	public string DispBPM; //Field offset: 0x90
	public int CircleDispType; //Field offset: 0x94
	public int CategoryBitFlags; //Field offset: 0x98
	public Int32[] OriginalSongsSeriesArray; //Field offset: 0x9C
	public int Enable; //Field offset: 0xA0
	public string CreaterName; //Field offset: 0xA4
	public int MusicType; //Field offset: 0xA8
	public int MusicAttr; //Field offset: 0xAC
	public bool IsShowStageSelect; //Field offset: 0xB0
	public string DetailURL; //Field offset: 0xB4
	public int RankMaxScore; //Field offset: 0xB8
	public int RankSScore; //Field offset: 0xBC
	public int RankAScore; //Field offset: 0xC0
	public int RankBScore; //Field offset: 0xC4
	public int RankCScore; //Field offset: 0xC8
	public int RankDScore; //Field offset: 0xCC
	public int RankSTotal; //Field offset: 0xD0
	public int RankATotal; //Field offset: 0xD4
	public int RankBTotal; //Field offset: 0xD8
	public int RankCTotal; //Field offset: 0xDC
	public int RankDTotal; //Field offset: 0xE0
	public int RankMaxTotal; //Field offset: 0xE4
	public int LunaticNoDamageClearEmblemID; //Field offset: 0xE8

	public int CoverID
	{
		 get { } //Length: 11
	}

	public int MusicDateFileID
	{
		 get { } //Length: 11
	}

	public int ScoreBaseID
	{
		 get { } //Length: 11
	}

	public HeqetMusicModel() { }

	public HeqetMusicModel(HeqetMusicModel _model) { }

	public int get_CoverID() { }

	public int get_MusicDateFileID() { }

	public int get_ScoreBaseID() { }

	public CategoryType GetBadgeCategoryType() { }

	public float GetMusicLevelFloat(int difficulty, LaneMode laneMode) { }

	public float GetMusicLevelForRating(int difficulty, LaneMode laneMode) { }

	public int GetMusicLevelInteger(int difficulty, LaneMode laneMode) { }

	public string GetMusicLevelStr(int difficulty, LaneMode laneMode) { }

	public bool IsDankaguOriginal() { }

	public bool IsMusicAnother() { }

	public bool IsMusicPlanA() { }

	public bool IsMusicPlanX() { }

	public bool IsOpenCall() { }

	public bool IsOriginalSong() { }

	public bool IsUnlockLunatic() { }

	public bool IsUnlockLunaticEnable() { }

	public ScoreRankID ScoreToRank(int score) { }

}


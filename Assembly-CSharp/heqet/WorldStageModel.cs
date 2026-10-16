namespace Heqet;

public class WorldStageModel : EntityBase<WorldStageModel, Int32>
{
	internal enum AqcuisitionConditions
	{
		StageClear = 0,
		MissionClear = 1,
		DropItem = 2,
	}

	internal enum Area
	{
		Start = 0,
		Area1 = 1,
		Area2 = 2,
		Area3 = 3,
	}

	internal enum Attribute
	{
		Em = 0,
		Co = 1,
		Ro = 2,
		All = 3,
	}

	internal enum ItemType
	{
		Card = 0,
		Emblem = 1,
		Heroine = 2,
		RewardMoney = 3,
	}

	internal enum RythmGameType
	{
		Kagura = 0,
		Danmaku = 1,
	}

	internal struct StageReward
	{
		public int ItemType; //Field offset: 0x0
		public int ItemID; //Field offset: 0x4

		public bool IsEmpty() { }

		public bool IsHave() { }

	}

	internal enum StageType
	{
		Mission = 0,
		TreasureBox = 1,
		Shop = 2,
		Episord = 3,
	}

	public int ID; //Field offset: 0xC
	public int DlcID; //Field offset: 0x10
	public int SpotID; //Field offset: 0x14
	public int SortNo; //Field offset: 0x18
	public string Name; //Field offset: 0x1C
	public string NameYomi; //Field offset: 0x20
	public int OpenConditionsID; //Field offset: 0x24
	public bool IsHidden; //Field offset: 0x28
	public StageType StageTypeID; //Field offset: 0x2C
	public Attribute AttributeID; //Field offset: 0x30
	public RythmGameType RythmGameTypeID; //Field offset: 0x34
	public int StageLevel; //Field offset: 0x38
	public int BackgroundID; //Field offset: 0x3C
	public int MusicDataFileID; //Field offset: 0x40
	public HeqetMusicModel MusicModel; //Field offset: 0x44
	public int BossID; //Field offset: 0x48
	public HeqetHeroineModel BossHeroineModel; //Field offset: 0x4C
	public int BossDefeatBonus; //Field offset: 0x50
	public StageReward[] StageRewardArray; //Field offset: 0x54
	public int RenaissanceValue; //Field offset: 0x58
	public int DisplayOrder; //Field offset: 0x5C
	public int AcquirableMoney; //Field offset: 0x60
	public int AcquirableExp; //Field offset: 0x64
	public Int32[] ClearConditionsTypeIDArray; //Field offset: 0x68
	public Int32[] StageGimmickTypeiDArray; //Field offset: 0x6C
	public int ArrivalEpisodeID; //Field offset: 0x70
	public Int32[] MusicDifficultyIDArray; //Field offset: 0x74
	public int HelpGroupID; //Field offset: 0x78
	public int FailedHelpGroupID; //Field offset: 0x7C
	public RecommendCardModel RecommendCardModel; //Field offset: 0x80
	public int RecommendCardID; //Field offset: 0x84

	public WorldStageModel() { }

	public bool IsEnableDifficulty(int difficulty) { }

}


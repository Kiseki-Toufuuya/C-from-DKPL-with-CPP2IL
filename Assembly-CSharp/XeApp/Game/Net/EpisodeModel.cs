namespace XeApp.Game.Net;

public class EpisodeModel : EntityBase<EpisodeModel, Int32>
{
	public int ID; //Field offset: 0xC
	public int Enable; //Field offset: 0x10
	public int DataVersion; //Field offset: 0x14
	public int Category; //Field offset: 0x18
	public int SortNo; //Field offset: 0x1C
	public int MainIndex; //Field offset: 0x20
	public int SubIndex; //Field offset: 0x24
	public int SubSubIndex; //Field offset: 0x28
	public bool ListDisplay; //Field offset: 0x2C
	public int EpisodeRewardID; //Field offset: 0x30
	public string Title; //Field offset: 0x34
	public string AssetName; //Field offset: 0x38
	public int Character1ID; //Field offset: 0x3C
	public int Character2ID; //Field offset: 0x40
	public int Character3ID; //Field offset: 0x44
	public int BackgroundID; //Field offset: 0x48
	public int ThumbnailBackgroundID; //Field offset: 0x4C
	public int Character1Thumbnail; //Field offset: 0x50
	public int Character2Thumbnail; //Field offset: 0x54
	public int Character3Thumbnail; //Field offset: 0x58
	public int ThumbnailDispOrder; //Field offset: 0x5C
	public int ReadUnlockEpisodeID; //Field offset: 0x60
	public GuardInt AfterEpisodeID; //Field offset: 0x64
	public string UnlockConditionMessage; //Field offset: 0x6C
	public bool IsVoice; //Field offset: 0x70
	public int UnlockMusicID; //Field offset: 0x74
	public Int32[] UnlockMusicIDs; //Field offset: 0x78
	public HeqetMusicModel UnlockMusic; //Field offset: 0x7C
	public HeqetMusicModel[] UnlockMusics; //Field offset: 0x80
	public Int32[] UnlocMenuHeroineIDs; //Field offset: 0x84
	public int LogOptionType; //Field offset: 0x88
	public int LogOptionValue; //Field offset: 0x8C
	public sbyte EventEpisodeType; //Field offset: 0x90

	public int SubIndex2
	{
		 get { } //Length: 11
	}

	public EpisodeModel() { }

	public int get_SubIndex2() { }

	public int GetCardID() { }

	public int GetEventID() { }

	public int GetSpotID() { }

	public bool IsCardEpisode() { }

	public bool IsCharaEpisode() { }

	public bool IsEventEpisode() { }

	public bool IsEventSDEpisode() { }

	public bool IsGrandEpisode() { }

	public bool IsSpotEpisode() { }

}


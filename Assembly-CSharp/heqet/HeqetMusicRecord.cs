namespace Heqet;

public class HeqetMusicRecord
{
	private HeqetMusicModel m_MusicModel; //Field offset: 0x8
	private HeqetMusicSelectionModel m_MusicSelectModel; //Field offset: 0xC
	private MusicPlayRecord m_MusicRecord; //Field offset: 0x10
	private MusicSettingData m_SettingData; //Field offset: 0x14
	private bool m_Favorite; //Field offset: 0x18

	public int ID
	{
		 get { } //Length: 23
	}

	public HeqetMusicModel MusicModel
	{
		 get { } //Length: 11
	}

	public MusicPlayRecord MusicRecord
	{
		 get { } //Length: 11
	}

	public HeqetMusicRecord() { }

	public void Create(HeqetMusicSelectionModel _model, HeqetMusicModel _heqetMusic) { }

	protected virtual void Finalize() { }

	public int get_ID() { }

	public HeqetMusicModel get_MusicModel() { }

	public MusicPlayRecord get_MusicRecord() { }

	public bool GetAllBrilliant(MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public int GetBackGroundId() { }

	public string GetBPM() { }

	public int GetDlcId() { }

	public bool GetFavaret() { }

	public int GetFirstSeriesId() { }

	public bool GetFramePerfect(MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public bool GetFullCombo(MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public int GetHightCombo(MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public int GetHiScore(MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public int GetJacketId() { }

	public int GetLevel(MusicDifficulty _difficulty, LaneMode laneMode) { }

	public float GetLevelForRating(MusicDifficulty _difficulty, LaneMode laneMode) { }

	public float GetLevelForSorting(MusicDifficulty _difficulty, LaneMode laneMode) { }

	public string GetLevelText(MusicDifficulty _difficulty, LaneMode laneMode) { }

	public string GetMusicCircle() { }

	public string GetMusicCircleJp() { }

	public string GetMusicCircleYomi() { }

	public int GetMusicId(int _index) { }

	public int GetMusicScoreCount(MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public string GetMusicTitle() { }

	public string GetMusicTitleJp() { }

	public string GetMusicTitleYomi() { }

	public string GetMusicTitleYomiJp() { }

	public bool GetMusicTypeNormal() { }

	public string GetMusicVocal() { }

	public string GetMusicVocalJp() { }

	public float GetPerfectRate(MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public int GetPlayCount(MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public int GetScoreRank(MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public Int32[] GetSeriesList() { }

	public bool GetStageClear(MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public bool IsDifficultyLevel(MusicDifficulty _difficulty) { }

	public bool IsNewRelease() { }

	public bool IsOriginalSong() { }

	public void LoadMusicRecord() { }

	public void LoadMusicSetting() { }

	public void SetFavaret(bool _value) { }

}


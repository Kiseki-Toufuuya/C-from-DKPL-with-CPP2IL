namespace Heqet;

public class RatingInfo
{
	private TextMeshProUGUI m_Rating; //Field offset: 0x8
	private TextMeshProUGUI m_TotalNotes; //Field offset: 0xC
	private TextMeshProUGUI m_PlayCount; //Field offset: 0x10
	private TextMeshProUGUI m_TapRate; //Field offset: 0x14
	private TextMeshProUGUI m_MaxCombo; //Field offset: 0x18

	public RatingInfo() { }

	public void Setup(Transform rootTransform) { }

	public void UpdateDisp(HeqetMusicModel musicModel, MusicPlayRecord musicRecord, int difficulty, LaneMode laneMode) { }

	public void UpdateDisp(float rating, int titalNotes, int playCount, float tapRate, int maxCombo) { }

}


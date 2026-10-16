namespace Heqet.Danmaku;

public class UIController : UIControllerBase
{
	[SerializeField]
	private LaneController laneController; //Field offset: 0x24
	private bool isDone; //Field offset: 0x28
	private RhythmGame rhythmGame; //Field offset: 0x2C
	private MusicManager musicManager; //Field offset: 0x30
	private DanmakuLayer layer; //Field offset: 0x34

	public UIController() { }

	private void Awake() { }

	public void Clear() { }

	protected virtual GameObject GetJudgeMessagePintOfLowerBlind() { }

	protected virtual GameObject GetJudgeMessagePintOfUpperBlind() { }

	public void Initialize(RhythmGame rhythmGame, MusicManager musicManager) { }

	public bool IsDone() { }

	private void OnJudge(NoteData noteData, int judge) { }

	private void OnJudgeTimeLag(NoteData noteData, int judge, float timeLag) { }

	public virtual void SetGameParam(LayerBase layerBase, HeqetMusicModel musicModel, SettingData musicSettingData) { }

	public void Terminate() { }

}


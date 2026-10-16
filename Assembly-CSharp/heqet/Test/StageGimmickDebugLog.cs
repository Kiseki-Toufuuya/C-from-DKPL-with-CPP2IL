namespace Heqet.Test;

public class StageGimmickDebugLog : MonoBehaviour
{
	private readonly string CANVAS_NAME; //Field offset: 0x10
	private Image m_LogBG; //Field offset: 0x14
	private Text m_LogText; //Field offset: 0x18
	private StageGimmickCalculator m_GimmickData; //Field offset: 0x1C
	private string m_GiveDamageMsg; //Field offset: 0x20
	private string m_TakeDamageMsg; //Field offset: 0x24
	private string m_ScoreMsg; //Field offset: 0x28
	private string m_PLevelMsg; //Field offset: 0x2C
	private string m_PsychicForceMsg; //Field offset: 0x30
	private string m_LifeMsg; //Field offset: 0x34
	private string m_NotesJudgeMsg; //Field offset: 0x38
	private string m_UniqueConditionMsg; //Field offset: 0x3C
	private string m_BossAndEnemiesMsg; //Field offset: 0x40
	private Action m_MsgUpdateAction; //Field offset: 0x44

	public StageGimmickDebugLog() { }

	private void BossAndEnemiesMsg() { }

	private string GetCategoryMsg(string category) { }

	private string GetItemMsg(string itemName, string itemData) { }

	private void GiveDamageMsg() { }

	public void Init(StageGimmickCalculator stageGimmick) { }

	private void LifeMsg() { }

	private void NotesJudgeMsg() { }

	private void PLevelMsg() { }

	private void PsychicForceMsg() { }

	private void ScoreMsg() { }

	private void SetBossAndEnemiesMsg(bool show) { }

	private void SetGiveDamageMsg(bool show) { }

	private void SetLifeMsg(bool show) { }

	private void SetNotesJudgeMsg(bool show) { }

	private void SetPLevelMsg(bool show) { }

	private void SetPsychicForceMsg(bool show) { }

	private void SetScoreMsg(bool show) { }

	private void SetTakeDamageMsg(bool show) { }

	private void SetUniqueConditionMsg(bool show) { }

	public void ShowGimmickMsg(GimmickDebugLogType type, bool show) { }

	private void TakeDamageMsg() { }

	private void UniqueConditionMsg() { }

	private void Update() { }

}


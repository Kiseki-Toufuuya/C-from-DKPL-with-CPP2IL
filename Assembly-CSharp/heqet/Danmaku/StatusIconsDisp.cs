namespace Heqet.Danmaku;

public class StatusIconsDisp : DispBase
{
	private enum StateType
	{
		None = 0,
		Invincible = 1,
		Poisoned = 2,
		Sandstorm = 3,
		RedNight = 4,
		GiveDamageUp = 5,
		GiveDamageDown = 6,
		TakeDamageUp = 7,
		TakeDamageDown = 8,
		NoLifeRecovery = 9,
		TakeMoneyUp = 10,
		TakeMoneyDown = 11,
		PLevelFactorUp = 12,
		PLevelFactorDown = 13,
		TakeScoreUp = 14,
		TakeScoreDown = 15,
		GrooveGaugeUp = 16,
		TakeExpUp = 17,
		NotesJudgeTimeLoosely = 18,
	}

	private const string ITEMS = "icons"; //Field offset: 0x0
	private readonly String[] STATE_ICONS; //Field offset: 0x114
	private DanmakuLayer m_DanmakuLayer; //Field offset: 0x118
	private UniqueState m_StateData; //Field offset: 0x11C
	private List<AtlasImage> m_IconImages; //Field offset: 0x120
	private Dictionary<StateType, String> m_StateDic; //Field offset: 0x124

	public StatusIconsDisp() { }

	private void CheckState(bool state, StateType type) { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	protected virtual void UpdateDispMain() { }

}


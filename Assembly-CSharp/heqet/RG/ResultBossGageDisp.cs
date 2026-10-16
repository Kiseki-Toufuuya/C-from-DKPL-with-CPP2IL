namespace Heqet.RG;

public class ResultBossGageDisp : DispBase
{
	private enum eLayerId
	{
		BOSS_GAUGE = 0,
		BOSS_STOCK_1 = 1,
		BOSS_STOCK_2 = 2,
		BOSS_STOCK_3 = 3,
	}

	internal enum UiState
	{
		Wait = 0,
		Open = 1,
		OpenWait = 2,
		CloseWait = 3,
		Close = 4,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private RythmGameRootLayer m_Layer; //Field offset: 0x114
	private Animator RootAnimator; //Field offset: 0x118
	private UiState WindowState; //Field offset: 0x11C
	private ShearProgressBarSprite m_bossHpGauge; //Field offset: 0x120

	private static ResultBossGageDisp() { }

	public ResultBossGageDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetBossHpRate(float _rate) { }

	public void SetBossStock(int num) { }

	public void StartCloseAnimation() { }

	public void StartOpenAnimation(float time = 0) { }

	protected virtual void UpdateDispMain() { }

}


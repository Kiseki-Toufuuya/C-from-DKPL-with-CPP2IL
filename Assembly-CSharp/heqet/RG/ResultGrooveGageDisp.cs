namespace Heqet.RG;

public class ResultGrooveGageDisp : DispBase
{
	private enum eLayerId
	{
		GROOVE_GAUGE_A = 0,
		GROOVE_GAUGE_B = 1,
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
	private Animator RootAnimator; //Field offset: 0x114
	private UiState WindowState; //Field offset: 0x118
	private ShearProgressBarSprite m_GaugeAtlusA; //Field offset: 0x11C
	private ShearProgressBarSprite m_GaugeAtlusB; //Field offset: 0x120

	private static ResultGrooveGageDisp() { }

	public ResultGrooveGageDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetGrooveRate(float _rate) { }

	public void StartCloseAnimation() { }

	public void StartOpenAnimation(float time = 0) { }

	protected virtual void UpdateDispMain() { }

}


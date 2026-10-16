namespace Heqet.RG;

public class ResultCharacterStateDisp : DispBase
{
	private enum eLayerId
	{
		BOMB_1 = 0,
		BOMB_2 = 1,
		BOMB_3 = 2,
		BOMB_4 = 3,
		BOMB_5 = 4,
		LIFE_GAUGE = 5,
	}

	private enum eTxtLayerId
	{
		TEXT_LIFE = 0,
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
	private String[] TxtLayerList; //Field offset: 0x114
	private Animator RootAnimator; //Field offset: 0x118
	private UiState WindowState; //Field offset: 0x11C
	private ShearProgressBarSprite m_LifeGaugeAtlas; //Field offset: 0x120

	private static ResultCharacterStateDisp() { }

	public ResultCharacterStateDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetBombCount(int _value) { }

	public void SetLifeGaugeRate(float _value) { }

	public void SetLifeStock(int _value) { }

	public void StartCloseAnimation() { }

	public void StartOpenAnimation(float time = 0) { }

	protected virtual void UpdateDispMain() { }

}


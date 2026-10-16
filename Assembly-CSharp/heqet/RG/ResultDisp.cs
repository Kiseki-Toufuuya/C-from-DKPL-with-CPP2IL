namespace Heqet.RG;

public class ResultDisp : DispBase
{
	private enum eLayerId
	{
		ICON_CLEAR = 0,
		ICON_GAMEOVER = 1,
		ROOT_FREE_MONEY_ANCHOR = 2,
		ICON_MODE_EXPERT = 3,
		ICON_MODE_RANDOM = 4,
		ICON_MODE_RANDOM_OUTER = 5,
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
	private UiState WindowState; //Field offset: 0x114
	private Animator RootAnimator; //Field offset: 0x118

	public Transform RootFreeMoneyAnchor
	{
		 get { } //Length: 32
	}

	private static ResultDisp() { }

	public ResultDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void DispGameClear() { }

	public void DispGameOver() { }

	public Transform get_RootFreeMoneyAnchor() { }

	protected virtual void InitUguiOther() { }

	public virtual bool IsPlaying() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetPlayMode(int playMode) { }

	public void StartCloseAnimation() { }

	public void StartOpenAnimation() { }

	protected virtual void UpdateDispMain() { }

}


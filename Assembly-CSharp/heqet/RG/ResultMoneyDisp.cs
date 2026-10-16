namespace Heqet.RG;

public class ResultMoneyDisp : DispBase
{
	private enum eLayerId
	{
	}

	private enum eTextId
	{
		TEXT_STAGE_REWARD = 0,
		MONEY_TEXT = 1,
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
	private static readonly String[] m_TextIdList; //Field offset: 0x4
	private Animator RootAnimator; //Field offset: 0x114
	private UiState WindowState; //Field offset: 0x118

	private static ResultMoneyDisp() { }

	public ResultMoneyDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	public virtual bool IsPlaying() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetMoneyCount(int cnt) { }

	public void StartCloseAnimation() { }

	public void StartOpenAnimation(float time = 0) { }

	protected virtual void UpdateDispMain() { }

}


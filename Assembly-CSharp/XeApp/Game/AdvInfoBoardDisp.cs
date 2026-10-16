namespace XeApp.Game;

public class AdvInfoBoardDisp : DispBase
{
	internal enum AnimeType
	{
		In = 0,
		Out = 1,
	}

	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_MESSAGE = 0,
		TEXT_NUM = 1,
	}

	internal enum UiState
	{
		Wait = 0,
		MenuOpen = 1,
		MenuClose = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private AdvInfoBoardLayer m_Layer; //Field offset: 0x114
	private UiState State; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C

	private static AdvInfoBoardDisp() { }

	public AdvInfoBoardDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetMessage(string message) { }

	public void StartAnime(AnimeType type) { }

	protected virtual void UpdateDispMain() { }

}


namespace XeApp.Game;

public class AdvCardNextUiDisp : DispBase
{
	internal enum AnimeType
	{
		In = 0,
		Out = 1,
	}

	private enum eLayerId
	{
		BASE_ROOT = 0,
		BASE_ARROW = 1,
		BASE_ARROW_AUTO = 2,
		BASE_NUM = 3,
		TEXT_NUM = 3,
	}

	internal enum UiState
	{
		Wait = 0,
		MenuOpen = 1,
		MenuClose = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private AdvCardNextUiLayer m_Layer; //Field offset: 0x114
	private UiState State; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private bool isNextDispFlag; //Field offset: 0x120
	private bool isAutoDispFlag; //Field offset: 0x121
	private Animator NextArrowAnimator; //Field offset: 0x124
	private Animator AutoArrowAnimator; //Field offset: 0x128

	private static AdvCardNextUiDisp() { }

	public AdvCardNextUiDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetAllArrowEnable(bool enable) { }

	public void SetAutoArrow(bool enable) { }

	private void SetEnableArrow(bool enable) { }

	private void SetEnableAutoArrow(bool enable) { }

	public void SetNextArrow(bool enable) { }

	public void StartAnime(AnimeType type) { }

	protected virtual void UpdateDispMain() { }

}


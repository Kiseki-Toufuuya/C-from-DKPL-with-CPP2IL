namespace XeApp.Game;

public class AdvCardMessageDisp : DispBase
{
	internal enum AnimeType
	{
		In = 0,
		Out = 1,
	}

	private enum eLayerId
	{
		BASE_SCROLL = 0,
		BASE_NUM = 1,
		TEXT_NUM = 1,
	}

	internal enum UiState
	{
		Wait = 0,
		MenuOpen = 1,
		MenuClose = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private AdvCardMessageLayer m_Layer; //Field offset: 0x114
	private UiState State; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private Color m_backupColor; //Field offset: 0x120
	public eCanvas canvas; //Field offset: 0x130

	private static AdvCardMessageDisp() { }

	public AdvCardMessageDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	public void StartAnime(AnimeType type) { }

	protected virtual void UpdateDispMain() { }

}


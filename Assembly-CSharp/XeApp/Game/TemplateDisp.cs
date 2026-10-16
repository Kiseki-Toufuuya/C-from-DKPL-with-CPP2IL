namespace XeApp.Game;

public class TemplateDisp : DispBase
{
	private enum eButtonId
	{
		OK = 0,
		NUM = 1,
	}

	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_NAME = 0,
		TEXT_MESSAGE = 1,
		TEXT_NUM = 2,
	}

	internal enum MessageBoxAnimeType
	{
		In = 0,
		Out = 1,
	}

	internal enum MessageBoxUiState
	{
		Wait = 0,
		MenuOpen = 1,
		MenuClose = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private static readonly String[] m_ButtonDataList; //Field offset: 0x4
	private TemplateLayer m_Layer; //Field offset: 0x114
	private MessageBoxUiState State; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private Animator ArrowAnimator; //Field offset: 0x120

	private static TemplateDisp() { }

	public TemplateDisp() { }

	public void CallbackButton(int id) { }

	private void CallbackInitLayout() { }

	public bool CallbackInputEnable(int id) { }

	public void CallbackLongTapComp(int id, float sec) { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetMessage(string message) { }

	public void SetTalkName(string name) { }

	public void StartMessageBoxAnime(MessageBoxAnimeType type) { }

	protected virtual void UpdateDispMain() { }

}


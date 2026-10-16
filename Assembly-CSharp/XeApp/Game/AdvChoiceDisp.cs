namespace XeApp.Game;

public class AdvChoiceDisp : DispBase
{
	internal enum ChoiceUiAnimeType
	{
		In = 0,
		Out = 1,
	}

	internal enum ChoiceUiState
	{
		Wait = 0,
		MenuOpen = 1,
		MenuClose = 2,
	}

	private enum eButtonId
	{
		BTN = 0,
		NUM = 1,
	}

	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_MESSAGE = 0,
		TEXT_NUM = 1,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private String[] m_ButtonDataList; //Field offset: 0x114
	private AdvChoiceLayer m_Layer; //Field offset: 0x118
	private ChoiceUiState State; //Field offset: 0x11C
	private Animator RootAnimator; //Field offset: 0x120
	public eCanvas m_Canvas; //Field offset: 0x124
	private AtlasImage m_BtnImage; //Field offset: 0x128
	public bool m_SelectReq; //Field offset: 0x12C

	private static AdvChoiceDisp() { }

	public AdvChoiceDisp() { }

	public void CallbackButton(int id) { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	public bool IsClose() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetMessage(string message) { }

	public void StartAnime(ChoiceUiAnimeType type) { }

	protected virtual void UpdateDispMain() { }

}


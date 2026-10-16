namespace XeApp.Game;

public class AdvMenuUiDisp : DispBase
{
	private enum eButtonId
	{
		Next = 0,
		Auto = 1,
		Skip = 2,
		Log = 3,
		Hide = 4,
		NUM = 5,
	}

	private enum eLayerId
	{
		TEXT_NUM = 0,
	}

	internal enum MenuUiAnimeType
	{
		In = 0,
		Out = 1,
	}

	internal enum MenuUiState
	{
		Wait = 0,
		MenuOpen = 1,
		MenuClose = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private String[2] m_ButtonDataList; //Field offset: 0x114
	private AdvMenuUiLayer m_Layer; //Field offset: 0x118
	public bool NextReq; //Field offset: 0x11C
	public bool SkipReq; //Field offset: 0x11D
	public bool AutoReq; //Field offset: 0x11E
	public bool LogReq; //Field offset: 0x11F
	public bool UiOffReq; //Field offset: 0x120
	private Animator HelpBarAnimator; //Field offset: 0x124
	private bool bButtonUsed; //Field offset: 0x128
	private Dictionary<Int32, InputActionTouchSimulator> m_ButtonInputActionMap; //Field offset: 0x12C

	private static AdvMenuUiDisp() { }

	public AdvMenuUiDisp() { }

	public void CallbackButton(int id) { }

	private void CallbackInitLayout() { }

	public bool CheckToggleInputAction(bool isBaseUiDispFg) { }

	public virtual void Create(LayerBase parent_layer) { }

	private bool GetEpisodeSaveDataAutoEnable() { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingAnime() { }

	private bool isReleaseButton(int button_id) { }

	public bool IsUsedButton() { }

	protected virtual void LateUpdate() { }

	public void SetupNoVoiceEpisodeMenu() { }

	public void SetUsedButton(bool is_used) { }

	public void StartHelpBarAnime(MenuUiAnimeType type) { }

	protected virtual void UpdateDispMain() { }

}


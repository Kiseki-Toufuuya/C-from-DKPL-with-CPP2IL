namespace XeApp.Game;

public class AdvCardMenuUiDisp : DispBase
{
	internal enum AnimeType
	{
		In = 0,
		Out = 1,
	}

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

	internal enum UiState
	{
		Wait = 0,
		MenuOpen = 1,
		MenuClose = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private String[] m_ButtonDataList; //Field offset: 0x114
	private readonly string spriteNameBtnOn; //Field offset: 0x118
	private readonly string spriteNameBtnOff; //Field offset: 0x11C
	private AdvCardMenuUiLayer m_Layer; //Field offset: 0x120
	public bool NextReq; //Field offset: 0x124
	public bool SkipReq; //Field offset: 0x125
	public bool AutoReq; //Field offset: 0x126
	public bool LogReq; //Field offset: 0x127
	public bool UiOffReq; //Field offset: 0x128
	private UiState State; //Field offset: 0x12C
	private Animator HelpBarAnimator; //Field offset: 0x130
	private AtlasImage SkipImage; //Field offset: 0x134
	private AtlasImage AutoImage; //Field offset: 0x138
	private AtlasImage LogImage; //Field offset: 0x13C
	private bool bSkipUsed; //Field offset: 0x140
	private bool bSkipEnable; //Field offset: 0x141
	private bool bAutoUsed; //Field offset: 0x142
	private bool bAutoEnable; //Field offset: 0x143
	private bool bLogUsed; //Field offset: 0x144
	private bool bLogEnable; //Field offset: 0x145
	private bool bUiOffUsed; //Field offset: 0x146
	private bool bButtonUsed; //Field offset: 0x147
	private Dictionary<Int32, InputActionTouchSimulator> m_ButtonInputActionMap; //Field offset: 0x148

	private static AdvCardMenuUiDisp() { }

	public AdvCardMenuUiDisp() { }

	public void CallbackButton(int id) { }

	private void CallbackInitLayout() { }

	protected void ChangeAutoBtnTextrue(bool is_on, bool enable) { }

	protected void ChangeLogBtnTextrue(bool is_on, bool enable) { }

	protected void ChangeSkipBtnTextrue(bool is_on, bool enable) { }

	public bool CheckToggleInputAction() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingAnime() { }

	private bool isReleaseButton(int button_id) { }

	public bool IsUsedAuto() { }

	public bool IsUsedButton() { }

	public bool IsUsedLog() { }

	public bool IsUsedSkip() { }

	public bool IsUsedUiOff() { }

	protected virtual void LateUpdate() { }

	public void SetAutoButton(bool is_used) { }

	public void SetAutoEnable(bool enable) { }

	public void SetLogButton(bool is_used) { }

	public void SetLogEnable(bool enable) { }

	public void SetSkipButton(bool is_used) { }

	public void SetSkipEnable(bool enable) { }

	public void SetUiOff(bool is_off) { }

	public void SetUsedButton(bool is_used) { }

	public void StartHelpBarAnime(AnimeType type) { }

	protected virtual void UpdateDispMain() { }

}


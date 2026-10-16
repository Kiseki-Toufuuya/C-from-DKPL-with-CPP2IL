namespace XeApp.Game;

public class HelpDialogDisp : DispBase
{
	internal enum AnimeType
	{
		In = 0,
		Out = 1,
	}

	private enum eButtonId
	{
		BUTTON_NEXT = 0,
		BUTTON_LEFT_ARROW = 1,
		BUTTON_RIGHT_ARROW = 2,
		BUTTON_CLOSE = 3,
		BUTTON_NUM = 4,
	}

	private enum eLayerId
	{
		BASE_NUM = 0,
		COMMON_BASE = 0,
		COMMON_PAGE_ROOT = 0,
		COMMON_NUM = 1,
		IMG_BASE = 1,
		IMG_INFO = 1,
		IMG_NUM = 2,
		TEXT_BASE = 2,
		TEXT_PAGE = 2,
		TEXT_CLOSE = 3,
		TEXT_TITLE = 4,
		TEXT_MESSAGE = 5,
		TEXT_NUM = 6,
	}

	private enum STATE
	{
		NONE = 0,
		WAIT = 1,
		L_SLIDE = 2,
		L_SLIDE_IMG_CHG = 3,
		L_SLIDE_END = 4,
		R_SLIDE = 5,
		R_SLIDE_IMG_CHG = 6,
		R_SLIDE_END = 7,
		OPEN = 8,
		CLOSE = 9,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private const string AdjustMsg1 = "{0}<size=18>/{1}</size>"; //Field offset: 0x0
	private static readonly String[] m_ButtonIdList; //Field offset: 0x4
	private static readonly int s_animHash_anim_c_win_1; //Field offset: 0x8
	private static readonly int s_animHash_anim_c_win_2; //Field offset: 0xC
	private static readonly int s_animHash_anim_c_win_3; //Field offset: 0x10
	private static readonly int s_animHash_anim_c_win_3b; //Field offset: 0x14
	private static readonly int s_animHash_anim_c_win_img_1; //Field offset: 0x18
	private static readonly int s_animHash_anim_c_win_img_1b; //Field offset: 0x1C
	private static readonly int s_animHash_anim_c_win_img_2; //Field offset: 0x20
	private static readonly int s_animHash_anim_c_win_img_3; //Field offset: 0x24
	private static readonly int s_animHash_anim_c_win_img_3b; //Field offset: 0x28
	private STATE MainState; //Field offset: 0x114
	private STATE MainStateReq; //Field offset: 0x118
	private HelpDialogLayer m_ParentLayer; //Field offset: 0x11C
	private Animator m_RootAnimator; //Field offset: 0x120
	private Animator m_SlideAnimator; //Field offset: 0x124
	public bool CloseReq; //Field offset: 0x128
	private string m_DefaultBtnMsg; //Field offset: 0x12C
	private HelpDialogArg m_Arg; //Field offset: 0x130
	private List<HeqetHelpPageModel> m_Pages; //Field offset: 0x134
	private int m_PageIndex; //Field offset: 0x138
	private int m_PageMax; //Field offset: 0x13C
	private bool m_ImgChangeFlg; //Field offset: 0x140
	private AtlasImage m_BtnImage; //Field offset: 0x144
	private int m_waitCount; //Field offset: 0x148

	private static HelpDialogDisp() { }

	public HelpDialogDisp() { }

	private void CallbackButton(int id) { }

	private bool CallbackEnableButton(int id) { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent) { }

	protected virtual void InitUguiOther() { }

	public bool IsClose() { }

	public bool IsOpen() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	private void SetMessage(int index) { }

	public void SetPageInfo(int pageIndex) { }

	public void StartAnime(AnimeType type) { }

	protected virtual void UpdateDispMain() { }

}


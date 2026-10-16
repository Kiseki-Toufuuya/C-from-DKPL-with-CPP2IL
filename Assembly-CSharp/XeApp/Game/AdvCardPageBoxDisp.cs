namespace XeApp.Game;

public class AdvCardPageBoxDisp : DispBase
{
	internal enum AnimeType
	{
		In = 0,
		Out = 1,
	}

	private enum eButtonId
	{
		Prev = 0,
		Next = 1,
		NUM = 2,
	}

	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_PAGE = 0,
		TEXT_NUM = 1,
	}

	internal enum UiState
	{
		Wait = 0,
		MenuOpen = 1,
		MenuClose = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private String[2] m_ButtonDataList; //Field offset: 0x114
	private readonly int PAGE_NUM_MIN; //Field offset: 0x118
	private AdvCardPageBoxLayer m_Layer; //Field offset: 0x11C
	public bool PrevReq; //Field offset: 0x120
	public bool NextReq; //Field offset: 0x121
	private UiState State; //Field offset: 0x124
	private Animator RootAnimator; //Field offset: 0x128
	private List<UIWrapperButton> BtnList; //Field offset: 0x12C
	private int m_nPageNumMax; //Field offset: 0x130
	private int m_nNowPageNum; //Field offset: 0x134
	private int m_nReadPageNum; //Field offset: 0x138
	private bool m_bBtnEnable; //Field offset: 0x13C
	private bool m_bLogDispEnable; //Field offset: 0x13D

	private static AdvCardPageBoxDisp() { }

	public AdvCardPageBoxDisp() { }

	private void ArrowButtonEnable() { }

	public void CallbackButton(int id) { }

	private void CallbackInitLayout() { }

	public void ChangeLogDisp() { }

	public void ChangeReadDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	public bool IsLogDisp() { }

	public bool IsPageReaded(int page) { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	private void SetArrowButtonEnable(bool enable) { }

	public void SetNowPageNum(int now) { }

	protected void SetPageNum() { }

	public void SetPageNumMax(int mas) { }

	public void SetReadPageNum(int read) { }

	public void StartAnime(AnimeType type) { }

	protected virtual void UpdateDispMain() { }

}


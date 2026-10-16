namespace XeApp.Game;

public class AdvLogWindowDisp : UIDispBase
{
	internal enum AdvLogAnimeType
	{
		In = 0,
		Out = 1,
	}

	internal enum AdvLogUiState
	{
		Wait = 0,
		MenuOpen = 1,
		MenuClose = 2,
	}

	private enum eButtonId
	{
		Src = 0,
		BTN_04 = 1,
		NUM = 2,
	}

	private enum eLayerId
	{
		BASE_SCROLL = 0,
		BASE_NUM = 1,
		TITLE_TEXT = 1,
		BTN_04_TEXT = 2,
		TEXT_NUM = 3,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private static readonly String[] m_ButtonDataList; //Field offset: 0x4
	private AdvLogWindowLayer m_Layer; //Field offset: 0x134
	private AdvLogUiState State; //Field offset: 0x138
	private Animator RootAnimator; //Field offset: 0x13C
	private Button ScrButton; //Field offset: 0x140
	private bool m_CloseReq; //Field offset: 0x144
	[CompilerGenerated]
	private readonly string <StateNameOpen>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private readonly string <StateNameClose>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private readonly string <AnimatorObjectName>k__BackingField; //Field offset: 0x150

	protected virtual string AnimatorObjectName
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public bool CloseReq
	{
		 get { } //Length: 14
	}

	protected virtual string StateNameClose
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	protected virtual string StateNameOpen
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	private static AdvLogWindowDisp() { }

	public AdvLogWindowDisp() { }

	public void CallbackButton(int id) { }

	public bool CallBackEnable(int id) { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	protected virtual string get_AnimatorObjectName() { }

	public bool get_CloseReq() { }

	[CompilerGenerated]
	protected virtual string get_StateNameClose() { }

	[CompilerGenerated]
	protected virtual string get_StateNameOpen() { }

	public UIWrapperButton GetCloseButton() { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void StartAnime(AdvLogAnimeType type) { }

	protected virtual void UpdateDispMain() { }

}


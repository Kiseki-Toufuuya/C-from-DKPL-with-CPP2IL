namespace XeApp.Game;

public class DialogLayout : UIDispBase
{
	internal enum DialogUiAnimeType
	{
		In = 0,
		Out = 1,
	}

	internal enum DialogUiState
	{
		Wait = 0,
		MenuOpen = 1,
		MenuClose = 2,
	}

	internal enum eLayerId
	{
		Root_Layer = 0,
		Fuki_Btn_2 = 1,
		BASE_NUM = 2,
		Text_Title = 2,
		Text_Context = 3,
		Text_Btn_1 = 4,
		Text_2_Btn_1 = 5,
		Text_Btn_2 = 6,
		Text_2_Btn_2 = 7,
		Text_Btn_3 = 8,
		Text_2_Btn_3 = 9,
		Text_Btn_4 = 10,
		Text_2_Btn_4 = 11,
		Text_Btn_5 = 12,
		Text_2_Btn_5 = 13,
		TEXT_NUM = 14,
	}

	private static readonly String[] m_BaseLayer; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private String[2] m_ButtonDataList; //Field offset: 0x134
	private DialogLayer m_Layer; //Field offset: 0x138
	private DialogUiState State; //Field offset: 0x13C
	private sDialogArg DialogArgData; //Field offset: 0x140
	private Animator DialogAnimator; //Field offset: 0x144
	private bool BackGroundMask; //Field offset: 0x148
	private Sprite EmpButtonImage; //Field offset: 0x14C
	private Sprite NmlButtonImage; //Field offset: 0x150
	private GameObject[] ButtonObj; //Field offset: 0x154
	private UIWrapperButton[] ButtonUi; //Field offset: 0x158
	private String[] DialogButtonText; //Field offset: 0x15C
	public ButtonType TapButtonType; //Field offset: 0x160
	public bool CloseReq; //Field offset: 0x164
	private eDialogType DialogType; //Field offset: 0x168
	private eDialogSize DialogSize; //Field offset: 0x16C
	private GameObject m_scrollView; //Field offset: 0x170
	[CompilerGenerated]
	private readonly string <StateNameOpen>k__BackingField; //Field offset: 0x174
	[CompilerGenerated]
	private readonly string <StateNameClose>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private readonly string <AnimatorObjectName>k__BackingField; //Field offset: 0x17C

	protected virtual string AnimatorObjectName
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public Action InAnimationFunc
	{
		 get { } //Length: 26
	}

	public Action OutAnimationFunc
	{
		 get { } //Length: 26
	}

	public GameObject ScrollView
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

	private static DialogLayout() { }

	public DialogLayout() { }

	public void CallbackButton(int id) { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	protected virtual string get_AnimatorObjectName() { }

	public Action get_InAnimationFunc() { }

	public Action get_OutAnimationFunc() { }

	public GameObject get_ScrollView() { }

	[CompilerGenerated]
	protected virtual string get_StateNameClose() { }

	[CompilerGenerated]
	protected virtual string get_StateNameOpen() { }

	public Transform GetButton02FukidashiTransform() { }

	protected virtual void InitUguiOther() { }

	public bool IsClose() { }

	public bool IsOpen() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetButtonEnable(ButtonType btnType, bool isEnable) { }

	public void SetChildLayout(DispBase disp) { }

	public void SetChildLayoutForScrollView(DispBase disp) { }

	public void StartAnime(DialogUiAnimeType type) { }

	protected virtual void UpdateDispMain() { }

}


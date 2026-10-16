namespace XeSys.uGUI;

public abstract class uGUILayoutBase : IUpdateable, IInitializable
{
	internal enum ButtonAnimType
	{
		View = 0,
		Tween = 1,
		Animator = 2,
	}

	protected IEnumerator m_RuntimeInitializeEnumrator; //Field offset: 0x8
	protected bool m_IsNextRuntimeInitialize; //Field offset: 0xC
	private bool m_IsDisp; //Field offset: 0xD
	protected bool m_IsButtonObjectNameTableInit; //Field offset: 0xE
	protected String[] m_ButtonHitObjectNameTable; //Field offset: 0x10
	protected String[] m_ButtonObjectNameTable; //Field offset: 0x14
	protected String[] m_ButtonViewNameTable; //Field offset: 0x18
	protected ButtonAnimType[] m_ButtonTypeTable; //Field offset: 0x1C
	protected GameObject[] m_ButtonHitObjectTable; //Field offset: 0x20
	protected GameObject[] m_ButtonObjectTable; //Field offset: 0x24
	protected ViewBase[] m_ButtonViewTable; //Field offset: 0x28
	protected LayoutuGUITweenAnimBehaviour[] m_ButtonTweenTable; //Field offset: 0x2C
	protected IChgImageSlice[] m_ButtonChgImageTable; //Field offset: 0x30
	protected Animator m_Animator; //Field offset: 0x34
	protected Action[] m_onButtonTable; //Field offset: 0x38
	protected Boolean[] m_IsWaitClickAnimTable; //Field offset: 0x3C
	protected Action<TouchInfo>[] m_onTouchTable; //Field offset: 0x40
	protected Boolean[] m_IsDragTable; //Field offset: 0x44
	protected List<IuGUIButton> m_LayoutButtonArray; //Field offset: 0x48
	protected GameObject m_RootObject; //Field offset: 0x4C
	protected LayoutUGUIRuntime m_RootUGUIRuntime; //Field offset: 0x50
	protected Layout m_RootLayout; //Field offset: 0x54
	protected List<TexUVListManager> m_TexUVListManagersList; //Field offset: 0x58
	private bool m_IsRegister; //Field offset: 0x5C
	private bool m_IsRegisterButton; //Field offset: 0x5D
	private UGUIAnimControllWrapper m_AnimController; //Field offset: 0x60
	private List<LayoutAnimControllData> m_LayoutAnimCtrlDataList; //Field offset: 0x64
	private List<TweenAnimControllData> m_TweenAnimCtrlDataList; //Field offset: 0x68
	private List<AnimatorControllData> m_AnimatorCtrlDataList; //Field offset: 0x6C
	private bool m_IsReady; //Field offset: 0x70
	protected bool m_IsAnim; //Field offset: 0x71
	private Action m_PostInit; //Field offset: 0x74
	private bool m_SupportSafeAreaFlg; //Field offset: 0x78
	protected Action m_onAnimEnd; //Field offset: 0x7C
	protected Dictionary<Int32, Action> m_onAnimEndDic; //Field offset: 0x80
	protected List<Int32> m_RemoveOnAnimEndDicList; //Field offset: 0x84

	protected List<AnimatorControllData> AnimatorCtrlDataList
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	protected UGUIAnimControllWrapper AnimController
	{
		 get { } //Length: 11
	}

	public bool IsDisp
	{
		 get { } //Length: 11
	}

	public override bool IsReady
	{
		 get { } //Length: 11
	}

	protected List<LayoutAnimControllData> LayoutAnimCtrlDataList
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	protected override int StateNo
	{
		 get { } //Length: 23
		 set { } //Length: 26
	}

	public bool SupportSafeAreaFlg
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public List<TexUVListManager> TexUVListManagersList
	{
		 get { } //Length: 11
	}

	protected List<TweenAnimControllData> TweenAnimCtrlDataList
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	protected uGUILayoutBase() { }

	public override void AddCanvas(Transform trans) { }

	public override void AddCanvas(Canvas canvas, bool isSafeArea = true) { }

	public void AdjustSafeArea() { }

	protected override void ButtonNameTableInit() { }

	protected override void ButtonTableInit() { }

	public void DeleteTexture() { }

	public override void Deregister() { }

	public override void DeregisterButton() { }

	public override void DeregisterUpdater() { }

	public GameObject FindObj(Transform parent, string name, string parentName = null) { }

	protected ViewBase FindViewByExId(string id) { }

	protected ViewBase FindViewById(string id) { }

	protected List<AnimatorControllData> get_AnimatorCtrlDataList() { }

	protected UGUIAnimControllWrapper get_AnimController() { }

	public bool get_IsDisp() { }

	public override bool get_IsReady() { }

	protected List<LayoutAnimControllData> get_LayoutAnimCtrlDataList() { }

	protected override int get_StateNo() { }

	public bool get_SupportSafeAreaFlg() { }

	public List<TexUVListManager> get_TexUVListManagersList() { }

	protected List<TweenAnimControllData> get_TweenAnimCtrlDataList() { }

	public GameObject GetRootObject() { }

	public LayoutUGUIRuntime GetUGUIRuntime() { }

	public override void Init(GameObject rootObject, List<TexUVFilePack> texUVFilePackList, List<Font> font = null, Action postInit = null) { }

	public override void Init(GameObject rootObject, List<Font> font = null, Action postInit = null) { }

	protected override void InitAnimCtrlDataList() { }

	protected override void InitLayoutButton() { }

	public void InitScript(GameObject rootObject, List<TexUVFilePack> texUVFilePackList, Font[] font = null, Action postInit = null) { }

	public void InitTexture(List<TexUVFilePack> texUVFilePackList) { }

	protected override void InitUI() { }

	public override bool IsPlaying() { }

	protected override void onButtonTableInit() { }

	protected override void onEndAnim() { }

	protected override void onInitEnd() { }

	protected override void onPostState(int stateNo) { }

	protected override void onUpdate() { }

	public override void Register() { }

	public override void Register(bool flg) { }

	protected override uGUIAnimatorButton RegisterAnimatorButton(int idx, bool isWaitClickAnim, Action<TouchInfo> onTouch, bool isDrag) { }

	public override void RegisterButton() { }

	public override void RegisterButton(bool flg) { }

	protected override uGUITweenButton RegisterTweenButton(int idx, bool isWaitClickAnim, Action<TouchInfo> onTouch, bool isDrag) { }

	public override void RegisterUpdater() { }

	public override void RegisterUpdater(bool flg) { }

	protected override uGUILayoutButton RegisterViewButtons(int idx, bool isWaitClickAnim, Action<TouchInfo> onTouch, bool isDrag) { }

	public override void RemoveCanvas(Transform parent = null) { }

	protected void set_AnimatorCtrlDataList(List<AnimatorControllData> value) { }

	protected void set_LayoutAnimCtrlDataList(List<LayoutAnimControllData> value) { }

	protected override void set_StateNo(int value) { }

	public void set_SupportSafeAreaFlg(bool value) { }

	protected void set_TweenAnimCtrlDataList(List<TweenAnimControllData> value) { }

	public override void SetButtonHit(bool flg) { }

	protected override void SetButtonHitComponent() { }

	public override void SetDisp(bool flg) { }

	public override void SetDispRegister(bool flg) { }

	protected void SetHitComponent(GameObject gameObject, bool target) { }

	protected void SetRaycastTarget(GameObject gameObject, bool target) { }

	public override void SetStateAnimEnd(int stateNo) { }

	public override void SetStateEnd(int stateNo) { }

	protected override void SetSuportSafeAreaFlg() { }

	public void SetText(string text, TextView textView, bool always) { }

	protected override void SettingAnimController() { }

	public override void StartState(int stateNo, Action onAnimEnd = null) { }

	public override void StartStateAnim(int stateNo, Action onAnimEnd = null) { }

	public override bool uGUIInitialize() { }

	public override void uGUIUpdate() { }

}


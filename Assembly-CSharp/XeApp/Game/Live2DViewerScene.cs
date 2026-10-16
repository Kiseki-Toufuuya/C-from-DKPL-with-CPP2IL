namespace XeApp.Game;

public class Live2DViewerScene : MainSceneBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LoadContext> <>9__165_1; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <ReadLive2DList>b__165_1(LoadContext context) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass174_0
	{
		public Live2DViewerScene <>4__this; //Field offset: 0x8
		public int id; //Field offset: 0xC
		public string modelPath; //Field offset: 0x10

		public <>c__DisplayClass174_0() { }

		internal void <LoadInteractAnimation>b__0(AssetBundleLoadAssetOperation op) { }

	}

	internal enum eLive2DType
	{
		ST = 0,
		SD = 1,
		BS = 2,
		BD = 3,
	}

	internal enum eStepMain
	{
		INIT_ALL = 0,
		LOAD_PARAM = 1,
		INIT_START = 2,
		QUICK_START = 3,
		CONT_MAIN = 4,
		LOAD_LIVE2D = 5,
		WAIT_LOAD_LIVE2D = 6,
		END = 7,
		NUM = 8,
	}

	private const string LOAD_LIVE2D_ROOT_PATH = "Live2d/"; //Field offset: 0x0
	private const string SEARCH_LIVE2D_NAME_ST = "st_"; //Field offset: 0x0
	private const string SEARCH_LIVE2D_NAME_SD = "sd_"; //Field offset: 0x0
	private const string SEARCH_LIVE2D_NAME_BS = "bs_"; //Field offset: 0x0
	private const string SEARCH_LIVE2D_NAME_BD = "bd_"; //Field offset: 0x0
	private readonly Vector3 LIVE2D_INIT_POS; //Field offset: 0x14
	private readonly float INIT_EYE_HORIZON; //Field offset: 0x20
	private readonly float INIT_EYE_VERTICAL; //Field offset: 0x24
	private List<String> STFileName; //Field offset: 0x28
	private List<String> SDFileName; //Field offset: 0x2C
	private List<String> BSFileName; //Field offset: 0x30
	private List<String> BDFileName; //Field offset: 0x34
	private Int32[] BgId; //Field offset: 0x38
	private Color[] BgColorPresets; //Field offset: 0x3C
	[SerializeField]
	private Canvas MenuCanvas; //Field offset: 0x40
	[SerializeField]
	private Dropdown Live2DTypeDropDown; //Field offset: 0x44
	[SerializeField]
	private Dropdown Live2DCharaDropDown; //Field offset: 0x48
	[SerializeField]
	private Text Live2DDataText; //Field offset: 0x4C
	[SerializeField]
	private Text Live2DMotionText; //Field offset: 0x50
	[SerializeField]
	private Text Live2DFaceMotionText; //Field offset: 0x54
	[SerializeField]
	private Text Live2DOptionMotionText; //Field offset: 0x58
	[SerializeField]
	private Text Live2DEarMotionText; //Field offset: 0x5C
	[SerializeField]
	private Text Live2DTailMotionText; //Field offset: 0x60
	[SerializeField]
	private Text Live2DWingMotionText; //Field offset: 0x64
	[SerializeField]
	private Text BgText; //Field offset: 0x68
	[SerializeField]
	private Button MotionPrevBtn; //Field offset: 0x6C
	[SerializeField]
	private Button MotionNextBtn; //Field offset: 0x70
	[SerializeField]
	private Button FacePrevBtn; //Field offset: 0x74
	[SerializeField]
	private Button FaceNextBtn; //Field offset: 0x78
	[SerializeField]
	private Button OptionPrevBtn; //Field offset: 0x7C
	[SerializeField]
	private Button OptionNextBtn; //Field offset: 0x80
	[SerializeField]
	private Button EarPrevBtn; //Field offset: 0x84
	[SerializeField]
	private Button EarNextBtn; //Field offset: 0x88
	[SerializeField]
	private Button TailPrevBtn; //Field offset: 0x8C
	[SerializeField]
	private Button TailNextBtn; //Field offset: 0x90
	[SerializeField]
	private Button WingPrevBtn; //Field offset: 0x94
	[SerializeField]
	private Button WingNextBtn; //Field offset: 0x98
	[SerializeField]
	private Button ReturnButton; //Field offset: 0x9C
	[SerializeField]
	private Button MotionButton; //Field offset: 0xA0
	[SerializeField]
	private Button WindowOnButton; //Field offset: 0xA4
	[SerializeField]
	private Toggle EyeToggle; //Field offset: 0xA8
	[SerializeField]
	private Toggle MouthToggle; //Field offset: 0xAC
	[SerializeField]
	private Toggle BreathToggle; //Field offset: 0xB0
	[SerializeField]
	private Toggle EffectToggle; //Field offset: 0xB4
	[SerializeField]
	private Toggle StartTypeToggle; //Field offset: 0xB8
	[SerializeField]
	private Button BgPrevBtn; //Field offset: 0xBC
	[SerializeField]
	private Button BgNextBtn; //Field offset: 0xC0
	[SerializeField]
	private Button FadeInButton; //Field offset: 0xC4
	[SerializeField]
	private Button FadeOutButton; //Field offset: 0xC8
	[SerializeField]
	private Dropdown ReqListNoDropDown; //Field offset: 0xCC
	[SerializeField]
	private InputField ReqDurationInput; //Field offset: 0xD0
	[SerializeField]
	private InputField ReqDelayInput; //Field offset: 0xD4
	[SerializeField]
	private Button ReqUpdateButton; //Field offset: 0xD8
	[SerializeField]
	private Button ReqAddButton; //Field offset: 0xDC
	[SerializeField]
	private Button ReqDelButton; //Field offset: 0xE0
	[SerializeField]
	private Button EditButton; //Field offset: 0xE4
	[SerializeField]
	private Text MotionListText; //Field offset: 0xE8
	[SerializeField]
	private Button BustUpButton; //Field offset: 0xEC
	[SerializeField]
	private Button ReversButton; //Field offset: 0xF0
	[SerializeField]
	private Slider RedColorSlider; //Field offset: 0xF4
	[SerializeField]
	private Text RedColorText; //Field offset: 0xF8
	[SerializeField]
	private Slider GreenColorSlider; //Field offset: 0xFC
	[SerializeField]
	private Text GreenColorText; //Field offset: 0x100
	[SerializeField]
	private Slider BlueColorSlider; //Field offset: 0x104
	[SerializeField]
	private Text BlueColorText; //Field offset: 0x108
	[SerializeField]
	private Slider EyeHorizonSlider; //Field offset: 0x10C
	[SerializeField]
	private Slider EyeVerticalSlider; //Field offset: 0x110
	[SerializeField]
	private Button EyeResetHorizonButton; //Field offset: 0x114
	[SerializeField]
	private Button EyeResetVerticalButton; //Field offset: 0x118
	[SerializeField]
	private Text BlackBallText; //Field offset: 0x11C
	[SerializeField]
	private Button BlackBallBtn; //Field offset: 0x120
	[SerializeField]
	private Button FadeBtn; //Field offset: 0x124
	[SerializeField]
	private Button BgColorBtn; //Field offset: 0x128
	[SerializeField]
	private Button HideUIBtn; //Field offset: 0x12C
	[SerializeField]
	private Button ShowUIBtn; //Field offset: 0x130
	[SerializeField]
	private InputField InteractObjectIDInput; //Field offset: 0x134
	[SerializeField]
	private Button InteractObjectApllyBtn; //Field offset: 0x138
	[SerializeField]
	private Text InteractObjectLoadingText; //Field offset: 0x13C
	private eStepMain m_StepMain; //Field offset: 0x140
	private eLive2DType Live2DType; //Field offset: 0x144
	private List<String> DataFolders; //Field offset: 0x148
	private List<String> MotionStates; //Field offset: 0x14C
	private List<String> FaceStates; //Field offset: 0x150
	private List<String> OptionStates; //Field offset: 0x154
	private List<String> EarStates; //Field offset: 0x158
	private List<String> TailStates; //Field offset: 0x15C
	private List<String> WingStates; //Field offset: 0x160
	private List<Int32> BgIdList; //Field offset: 0x164
	private List<Int32> MotionReqList; //Field offset: 0x168
	private List<Int32> FaceReqList; //Field offset: 0x16C
	private List<Int32> OptionReqList; //Field offset: 0x170
	private List<Int32> EarReqList; //Field offset: 0x174
	private List<Int32> TailReqList; //Field offset: 0x178
	private List<Single> DurationList; //Field offset: 0x17C
	private List<Single> DelayList; //Field offset: 0x180
	private int DataIndex; //Field offset: 0x184
	private int MotionIndex; //Field offset: 0x188
	private int FaceIndex; //Field offset: 0x18C
	private int OptionIndex; //Field offset: 0x190
	private int EarIndex; //Field offset: 0x194
	private int TailIndex; //Field offset: 0x198
	private int WingIndex; //Field offset: 0x19C
	private int BgIndex; //Field offset: 0x1A0
	private bool EyeEnable; //Field offset: 0x1A4
	private bool MouthEnable; //Field offset: 0x1A5
	private bool BreathEnable; //Field offset: 0x1A6
	private bool EffectEnable; //Field offset: 0x1A7
	private bool MStartTypeEnable; //Field offset: 0x1A8
	private AdvLive2DModel Live2DModel; //Field offset: 0x1AC
	private AdvMessageBoxLayer MessageBoxLayer; //Field offset: 0x1B0
	private AdvBgUiLayer BgUiLayer; //Field offset: 0x1B4
	private bool MessageUiOn; //Field offset: 0x1B8
	private bool EditMode; //Field offset: 0x1B9
	private bool BustUpMode; //Field offset: 0x1BA
	private int EditNowListIndex; //Field offset: 0x1BC
	private GameObject EyeHomePosition; //Field offset: 0x1C0
	private GameObject EyePosition; //Field offset: 0x1C4
	private float CharacterNum; //Field offset: 0x1C8
	private int BgColorPresetIndex; //Field offset: 0x1CC
	private Dictionary<Int32, AnimatorOverrideController> interactAnimationOverrideDic; //Field offset: 0x1D0
	private int interactItemId; //Field offset: 0x1D4

	public Live2DViewerScene() { }

	[CompilerGenerated]
	private void <DoStart>b__122_0(int value) { }

	[CompilerGenerated]
	private void <DoStart>b__122_1() { }

	[CompilerGenerated]
	private void <DoStart>b__122_10() { }

	[CompilerGenerated]
	private void <DoStart>b__122_11() { }

	[CompilerGenerated]
	private void <DoStart>b__122_12() { }

	[CompilerGenerated]
	private void <DoStart>b__122_13() { }

	[CompilerGenerated]
	private void <DoStart>b__122_14() { }

	[CompilerGenerated]
	private void <DoStart>b__122_15() { }

	[CompilerGenerated]
	private void <DoStart>b__122_16() { }

	[CompilerGenerated]
	private void <DoStart>b__122_17() { }

	[CompilerGenerated]
	private void <DoStart>b__122_18(float value) { }

	[CompilerGenerated]
	private void <DoStart>b__122_19(float value) { }

	[CompilerGenerated]
	private void <DoStart>b__122_2() { }

	[CompilerGenerated]
	private void <DoStart>b__122_20(float value) { }

	[CompilerGenerated]
	private void <DoStart>b__122_21(float value) { }

	[CompilerGenerated]
	private void <DoStart>b__122_22(float value) { }

	[CompilerGenerated]
	private void <DoStart>b__122_23() { }

	[CompilerGenerated]
	private void <DoStart>b__122_24() { }

	[CompilerGenerated]
	private void <DoStart>b__122_3() { }

	[CompilerGenerated]
	private void <DoStart>b__122_4() { }

	[CompilerGenerated]
	private void <DoStart>b__122_5() { }

	[CompilerGenerated]
	private void <DoStart>b__122_6() { }

	[CompilerGenerated]
	private void <DoStart>b__122_7() { }

	[CompilerGenerated]
	private void <DoStart>b__122_8() { }

	[CompilerGenerated]
	private void <DoStart>b__122_9() { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__123_0() { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__123_1(int value) { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__123_2(int value) { }

	[CompilerGenerated]
	private void <onBgNextPrevBtn>b__146_0(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <ReadLive2DList>b__165_0(LoadContext context) { }

	private void ChangeBustUp() { }

	private void ComLive2d() { }

	private void ContMain() { }

	protected virtual void DoAwake() { }

	protected virtual void DoStart() { }

	protected virtual void DoUpdateMain() { }

	private void InitCanvas() { }

	private void InitLive2D() { }

	private bool IsLoadLive2d() { }

	private void Live2DFade() { }

	private void LoadInteractAnimation() { }

	private void onAddMotion() { }

	private void onBgNextPrevBtn(int addIndex) { }

	private void onBlackBall() { }

	private void onBustUp() { }

	private void OnChangeBgColor() { }

	private void OnChangeEnableBreath(bool on) { }

	private void OnChangeEnableEffect(bool on) { }

	private void OnChangeEnableEye(bool on) { }

	private void OnChangeEnableMouth(bool on) { }

	private void OnChangeEnableStartType(bool on) { }

	private void onChangeTextrueColor(float value) { }

	private void onCharaNextPrevBtn(int addIndex) { }

	private void onDeleteMotion() { }

	private void OnDestroy() { }

	private void onEarNextPrevBtn(int addIndex) { }

	private void onEditMode(bool on) { }

	private void onFaceNextPrevBtn(int addIndex) { }

	private void onFade(bool fadeIn) { }

	private void OnHideUI() { }

	private void OnInteractAnimation() { }

	private void onMotionBtn() { }

	private void onMotionNextPrevBtn(int addIndex) { }

	private void onOptionNextPrevBtn(int addIndex) { }

	private void onReturnBtn() { }

	private void onRevers() { }

	private void OnShowUI() { }

	private void onTailNextPrevBtn(int addIndex) { }

	private void onUpdateMotion() { }

	private void onWindowBtn() { }

	private void onWingNextPrevBtn(int addIndex) { }

	private void ReadLive2DList() { }

	private void SearchLive2DList(eLive2DType type) { }

	private void SetBgText(string fileName) { }

	private void SetBlackBallText() { }

	private void SetDataText(string fileName) { }

	private void SetEarText(string stateName) { }

	private void SetFaceText(string stateName) { }

	private void SetMotionText(string stateName) { }

	private void SetOptionText(string stateName) { }

	private void SetTailText(string stateName) { }

	private void SetWingText(string stateName) { }

	private void UnloadInteractAnimation() { }

	private void UpDateMotionListText() { }

}


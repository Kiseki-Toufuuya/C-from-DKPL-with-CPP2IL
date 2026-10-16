namespace XeApp.Game;

public class GameEventScriptMain
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass101_0
	{
		public int depth; //Field offset: 0x8
		public int event_id; //Field offset: 0xC
		public GameEventScriptMain <>4__this; //Field offset: 0x10
		public bool voicePlay; //Field offset: 0x14
		public Action onFinish; //Field offset: 0x18
		public Action onError; //Field offset: 0x1C

		public <>c__DisplayClass101_0() { }

		internal void <ReadEpisode>b__0(EpisodeViewModel model) { }

		internal void <ReadEpisode>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass102_0
	{
		public bool is_FocesVoice; //Field offset: 0x8
		public GameEventScriptMain <>4__this; //Field offset: 0xC
		public Action finishAction; //Field offset: 0x10
		public EpisodeCategory adv_category; //Field offset: 0x14

		public <>c__DisplayClass102_0() { }

		internal void <SetEventStartReq>b__0() { }

		internal void <SetEventStartReq>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass120_0
	{
		public bool isForce; //Field offset: 0x8
		public GameEventScriptMain <>4__this; //Field offset: 0xC

		public <>c__DisplayClass120_0() { }

		internal void <OpenEpisodeDialog>b__0(ButtonType btn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass121_0
	{
		public bool isForce; //Field offset: 0x8
		public GameEventScriptMain <>4__this; //Field offset: 0xC

		public <>c__DisplayClass121_0() { }

		internal void <OpenEventSDEpisodeDialog>b__0(ButtonType btn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass123_0
	{
		public Action cancelAction; //Field offset: 0x8
		public Action finishAction; //Field offset: 0xC

		public <>c__DisplayClass123_0() { }

		internal void <SetEventCardOpenReq>b__0(ButtonType btn) { }

	}

	internal class AfterEpisodeReward
	{
		public int m_EventId; //Field offset: 0x8
		public List<ReceivedItem> m_ReceivedItems; //Field offset: 0xC

		public AfterEpisodeReward(int eventId, ItemReceiver itemReceiver) { }

	}

	internal enum eBeforeAutoMode
	{
		None = 0,
		AutoModeOn = 1,
		AutoModeOff = 2,
	}

	internal enum eContStep
	{
		NONE = 0,
		DONW_LOAD_LIST_WAIT = 1,
		DOWNLOAD_CHECK_DIALOG = 2,
		INIT_START = 3,
		CONT_LOAD_WAIT = 4,
		CONT_SCRIPT_MAIN = 5,
		CONT_FINISH = 6,
		CONT_GO_RGAME = 7,
		CONT_END = 8,
		DB_DATA_LOAD = 9,
		CONT_UI_WAIT = 10,
		NUM = 11,
	}

	internal enum eDialogType
	{
		None = 0,
		DownloadOnly = 1,
		MainStory = 2,
		EventPrologue = 3,
		CharaEpidode = 4,
		EventEpisode = 5,
		SpotEpisode = 6,
		MainEpisodeList = 7,
		SpotEpisodeList = 8,
		CharaEpisodeList = 9,
		EventEpisodeList = 10,
		EventSDEpisode = 11,
	}

	internal enum EpisodeCategory
	{
		Default = 0,
		Grand = 1,
		Spot = 2,
		Chara = 3,
		Event = 4,
		Card = 5,
		EventSD = 6,
		TEST = 10,
	}

	public const int EVENT_USE_FILE_NAME = -2; //Field offset: 0x0
	private static GameEventScriptMain m_Instance; //Field offset: 0x0
	private eDialogType m_DialogType; //Field offset: 0x8
	private GameEventScriptPlay m_Play; //Field offset: 0xC
	private EpisodeModel m_NowEpisodeModel; //Field offset: 0x10
	private string m_EventFileName; //Field offset: 0x14
	private int m_CntContStep; //Field offset: 0x18
	private int m_EventId; //Field offset: 0x1C
	private bool m_EventPlayFg; //Field offset: 0x20
	private bool m_EventStartReq; //Field offset: 0x21
	private bool m_PreInit; //Field offset: 0x22
	private bool m_Enable_STOP_BGM; //Field offset: 0x23
	private eLayoutType m_LayoutType; //Field offset: 0x24
	private eContStep m_ContStep; //Field offset: 0x28
	private eContStep m_ContStepReq; //Field offset: 0x2C
	private AdventureLayerRoot m_Layer; //Field offset: 0x30
	private AdvMenuUiLayer m_AdvMenuLayer; //Field offset: 0x34
	private AdvMessageBoxLayer m_AdvMesLayer; //Field offset: 0x38
	private AdvScrBtnLayer m_AdvScrBtnLayer; //Field offset: 0x3C
	private AdvBgUiLayer m_AdvBgLayer; //Field offset: 0x40
	private AdvInfoBoardLayer m_AdvInfoLayer; //Field offset: 0x44
	private AdvEffectLayer m_AdvEffectLayer; //Field offset: 0x48
	private AdvChoiceLayer m_AdvChoiceLayer; //Field offset: 0x4C
	private AdvTalkPopupUILayer m_AdvTalkPopupUILayer; //Field offset: 0x50
	private AdvCardMessageLayer m_AdvCardMesLayer; //Field offset: 0x54
	private AdvCardMessageOutlineLayer m_AdvCardMesOutlineLayer; //Field offset: 0x58
	private AdvCardPageBoxLayer m_AdvCardPageLayer; //Field offset: 0x5C
	private AdvCardMenuUiLayer m_AdvCardMenuLayer; //Field offset: 0x60
	private AdvCardNextUiLayer m_AdvCardNextLayer; //Field offset: 0x64
	private bool EndWaitFlg; //Field offset: 0x68
	public Action m_FinishAction; //Field offset: 0x6C
	public Action m_ErrorAction; //Field offset: 0x70
	private ItemReceiver m_AdvReward; //Field offset: 0x74
	private bool m_AdvVoiceEnable; //Field offset: 0x78
	public EpisodeCategory m_AdvEpisodeCategoryId; //Field offset: 0x7C
	private int m_AdvCardUseAwkMode; //Field offset: 0x80
	private bool m_AdvCardUsePremiumMode; //Field offset: 0x84
	private int m_AdvRythmGamePresetNo; //Field offset: 0x88
	private bool m_AdvEpisodeListMode; //Field offset: 0x8C
	private bool m_IsTutorial; //Field offset: 0x8D
	private bool m_IsCreateDitherTexture; //Field offset: 0x8E
	private bool m_Isforce; //Field offset: 0x8F
	private Action m_CallBackFinishAction; //Field offset: 0x90
	private Action m_CallBackCancelAction; //Field offset: 0x94
	[CompilerGenerated]
	private bool <IsGallary>k__BackingField; //Field offset: 0x98
	private List<AfterEpisodeReward> m_AfterEpisodeReward; //Field offset: 0x9C
	[CompilerGenerated]
	private eBeforeAutoMode <BeforeAutoMode>k__BackingField; //Field offset: 0xA0

	public bool AdvEpisodeListMode
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool AdvVoiceEnable
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public eBeforeAutoMode BeforeAutoMode
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public bool EventPlayFg
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Action FinishCallBack
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public static GameEventScriptMain Instance
	{
		 get { } //Length: 40
	}

	private bool IsCardEpisode
	{
		private get { } //Length: 15
	}

	internal bool IsCharaEpisode
	{
		internal get { } //Length: 15
	}

	internal bool IsEventEpisode
	{
		internal get { } //Length: 15
	}

	public private bool IsGallary
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	internal bool IsSpotEpisode
	{
		internal get { } //Length: 15
	}

	internal bool IsStoryEpisode
	{
		internal get { } //Length: 15
	}

	public bool IsTutorial
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public GameEventScriptPlay Play
	{
		 get { } //Length: 11
	}

	public int RythmGamePresetNo
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public eContStep Step
	{
		 get { } //Length: 11
	}

	public eContStep StepReq
	{
		 get { } //Length: 11
	}

	public GameEventScriptMain() { }

	[CompilerGenerated]
	private bool <ContUpdate>b__100_0() { }

	[CompilerGenerated]
	private void <OpenDownLoadDialog>b__111_0(ButtonType btn) { }

	private static bool CheckDataVersion() { }

	private bool CheckVoiceDownloaded(int event_id) { }

	public void ContUpdate() { }

	public static void Create() { }

	public void EventStartReq() { }

	public void ForceStop() { }

	public bool get_AdvEpisodeListMode() { }

	public bool get_AdvVoiceEnable() { }

	[CompilerGenerated]
	public eBeforeAutoMode get_BeforeAutoMode() { }

	public bool get_EventPlayFg() { }

	public Action get_FinishCallBack() { }

	public static GameEventScriptMain get_Instance() { }

	private bool get_IsCardEpisode() { }

	internal bool get_IsCharaEpisode() { }

	internal bool get_IsEventEpisode() { }

	[CompilerGenerated]
	private bool get_IsGallary() { }

	internal bool get_IsSpotEpisode() { }

	internal bool get_IsStoryEpisode() { }

	public bool get_IsTutorial() { }

	public GameEventScriptPlay get_Play() { }

	public int get_RythmGamePresetNo() { }

	public eContStep get_Step() { }

	public eContStep get_StepReq() { }

	public int GetSelectPoint() { }

	public void InitAll() { }

	public static EpisodeCategory IntToEpisodeCategory(int a_id) { }

	public bool IsEndAdventure() { }

	public bool IsPreInit() { }

	private void OpenCharaEpisodeDialog() { }

	private void OpenDownLoadDialog() { }

	private void OpenEpisodeDialog(string title, eSeType seType, bool isForce) { }

	private void OpenEventEpisodeDialog() { }

	private void OpenEventPrologueDialog() { }

	private void OpenEventSDEpisodeDialog(string title, eSeType seType, bool isForce) { }

	private void OpenListEpisodeDialog(string main_text) { }

	private void OpenListEventSDEpisodeDialog(string main_text) { }

	private void OpenMainStoryDialog() { }

	private void OpenSpotEpisodeDialog() { }

	private void ReadEpisode(int event_id, bool voicePlay, bool continuePlay, Action onFinish = null, Action onError = null, int depth = 0) { }

	private void SaveAutoMode() { }

	public void set_AdvEpisodeListMode(bool value) { }

	public void set_AdvVoiceEnable(bool value) { }

	[CompilerGenerated]
	public void set_BeforeAutoMode(eBeforeAutoMode value) { }

	public void set_EventPlayFg(bool value) { }

	public void set_FinishCallBack(Action value) { }

	[CompilerGenerated]
	public void set_IsGallary(bool value) { }

	public void set_IsTutorial(bool value) { }

	public void set_RythmGamePresetNo(int value) { }

	public void SetContStepReq(eContStep step) { }

	public void SetEventCardOpenReq(int unlock1, int unlock2, Action finishAction = null, Action cancelAction = null, bool is_read = false) { }

	public void SetEventCardStartReq(int event_id, int use_awk, bool is_premium, Action finishAction = null, Action onError = null) { }

	public void SetEventStartReq(string file_name, bool pre_init = false, eLayoutType lay_type = 0, bool stop_bgm = true, Action finishAction = null, EpisodeCategory adv_category = 1) { }

	public void SetEventStartReq(int event_id, Action finishAction = null, EpisodeCategory adv_category = 0, bool is_FocesVoice = false, Action onError = null) { }

	public void SetEventStartRewardReq(Action finishAction = null) { }

	public void SetEventStartVoiceDownLoadReq(int event_id, eDialogType dialogType, Action finishAction = null, Action cancelAction = null, bool is_force = false) { }

}


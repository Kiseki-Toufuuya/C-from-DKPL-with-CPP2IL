namespace XeApp.Game;

public class GameEventScriptPlay
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LoadContext> <>9__110_1; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <ContLoadScript>b__110_1(LoadContext context) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass134_0
	{
		public int wk1; //Field offset: 0x8
		public Func<Int32, Boolean> <>9__0; //Field offset: 0xC

		public <>c__DisplayClass134_0() { }

		internal bool <SetNewCommand>b__0(int dat) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass135_0
	{
		public int wk1; //Field offset: 0x8

		public <>c__DisplayClass135_0() { }

		internal bool <SetModelCharaFunc>b__0(int dat) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass136_0
	{
		public int full_id; //Field offset: 0x8

		public <>c__DisplayClass136_0() { }

		internal bool <SetSDModelCharaFunc>b__0(int dat) { }

	}

	private enum eLoadStep
	{
		INIT_START = 0,
		LOAD_LAYOUT = 1,
		LOAD_SCRIPT = 2,
		LOAD_EFFECT = 3,
		LOAD_TEX_BG = 4,
		LOAD_TEX_BG_STILL = 5,
		LOAD_TEX_CHARA = 6,
		LOAD_SHADER = 7,
		LOAD_TEX_ITEM = 8,
		LOAD_VOICE = 9,
		LOAD_BGM = 10,
		LOAD_SE = 11,
		FINISH = 12,
		LOAD_ERROR_OPEN = 13,
		LOAD_ERROR_WAIT = 14,
		LOAD_SCRIPT_DL_CHECK = 15,
		CHECK_DATA = 16,
		CHECK_END = 17,
		NUM = 18,
	}

	private enum eLogStep
	{
		WAIT = 0,
		OPEN_INIT = 1,
		OPEN_ANIM = 2,
		UPDATE = 3,
		CLOSE_WAIT = 4,
		END = 5,
		NUM = 6,
	}

	private enum eWaitType
	{
		NONE = -1,
		TOUCH = 0,
		TIME = 1,
		TEXT = 2,
		TEXT_AUTO = 3,
		SELECT = 4,
		CUT_SCENE_LOAD = 5,
		CUT_SCENE_START = 6,
		CUT_SCENE_END = 7,
		ACCESS_TUTORIAL = 8,
		DATA_LOAD = 9,
		APPEAR = 10,
		TITLE = 11,
		UI_IN = 12,
		UI_OUT = 13,
		CHARA = 14,
		INFO_IN = 15,
		INFO_OUT = 16,
		CARD_TEXT = 17,
		CARD_TOUCH = 18,
		TALK_SD = 19,
		NUM = 20,
	}

	private static Regex scirptRx; //Field offset: 0x0
	private GameEventScriptMain m_GameEventScriptMain; //Field offset: 0x8
	private GameUiEventScriptMain m_UiMain; //Field offset: 0xC
	private GameEventScriptCommandList m_CommandList; //Field offset: 0x10
	private AdvVoicePlayer m_AdvVoice; //Field offset: 0x14
	private AdvBgmPlayer m_AdvBgm; //Field offset: 0x18
	private AdvSePlayer m_AdvSe; //Field offset: 0x1C
	private List<Int32> m_AssetBundleLoadRequestIdList; //Field offset: 0x20
	private List<Int32> m_AssetBundleLoadReqItemIdList; //Field offset: 0x24
	private List<Int32> m_AssetBundleLoadRequestStillIdList; //Field offset: 0x28
	private StringDownloadFile m_StringFile; //Field offset: 0x2C
	private string m_ScriptFileName; //Field offset: 0x30
	private bool m_IsTryInstallPlatform; //Field offset: 0x34
	private float m_WaitSec; //Field offset: 0x38
	private int m_CntLoadStep; //Field offset: 0x3C
	private int m_CommandStep; //Field offset: 0x40
	private int m_CntCommandStep; //Field offset: 0x44
	private float m_CntAutoWait; //Field offset: 0x48
	private float m_CntAutoWaitMax; //Field offset: 0x4C
	private int m_SelectId; //Field offset: 0x50
	private int m_Point; //Field offset: 0x54
	private List<Int32> m_HighlightCharaIdList; //Field offset: 0x58
	private bool m_FinishReq; //Field offset: 0x5C
	private bool m_NextReq; //Field offset: 0x5D
	private bool m_AutoFg; //Field offset: 0x5E
	private bool m_SkipProhibitFg; //Field offset: 0x5F
	private bool m_SkipFg; //Field offset: 0x60
	private bool m_LogModeFg; //Field offset: 0x61
	private bool m_SkipConfirmFg; //Field offset: 0x62
	private eLoadStep m_LoadStep; //Field offset: 0x64
	private eLoadStep m_LoadStepReq; //Field offset: 0x68
	private eWaitType m_WaitType; //Field offset: 0x6C
	private eLogStep m_LogStep; //Field offset: 0x70
	private bool m_UpdateSpineLoadWait; //Field offset: 0x74
	private bool m_SetActionCharaWait; //Field offset: 0x75
	private bool m_SetTitleWait; //Field offset: 0x76
	private bool m_SetCutSceneWait; //Field offset: 0x77
	private bool m_InsertLoadWait; //Field offset: 0x78
	private GameEventScriptCommandData m_StackCommandData; //Field offset: 0x7C
	private List<GameEventScriptSe> m_PlaySeList; //Field offset: 0x80
	private bool m_FirstFadeIn; //Field offset: 0x84
	private bool m_SkipPosArrival; //Field offset: 0x85
	private bool m_PreInit; //Field offset: 0x86
	private bool m_IsPreInit; //Field offset: 0x87
	private bool m_SkipOn; //Field offset: 0x88
	private bool m_Enable_STOP_BGM; //Field offset: 0x89
	private bool m_Enable_VOICE; //Field offset: 0x8A
	private eLayoutType m_LayoutType; //Field offset: 0x8C
	private int m_LastSetBgNo; //Field offset: 0x90
	private Action m_InitStartFunc; //Field offset: 0x94
	private long m_byteSize; //Field offset: 0x98
	private long m_byteSizeWithVoice; //Field offset: 0xA0
	private bool m_SuccessFg; //Field offset: 0xA8
	private bool m_IsPlayingMouth; //Field offset: 0xA9
	private bool m_IsCheckVolumeLevel; //Field offset: 0xAA
	private int m_VolumeCheckWaitFrame; //Field offset: 0xAC
	private int m_WaitFrame; //Field offset: 0xB0
	private bool m_TalkOutFg; //Field offset: 0xB4
	private EpisodeCategory m_AdvEpisodeCategoryId; //Field offset: 0xB8
	private int m_CardBgAwkMode; //Field offset: 0xBC
	private bool m_CardBgPremiumMode; //Field offset: 0xC0
	private bool m_CardSkipFg; //Field offset: 0xC1
	private float m_CardTextWait; //Field offset: 0xC4
	private float m_CardTextWaitMax; //Field offset: 0xC8
	private List<EffectObjectBase> EpisodeEffect; //Field offset: 0xCC
	private bool NowVoicePlayingFlag; //Field offset: 0xD0
	private bool m_ForceFinish; //Field offset: 0xD1

	public AdventureDisp AdvDisp
	{
		 set { } //Length: 39
	}

	public bool AutoFg
	{
		 get { } //Length: 11
	}

	public long byteSize
	{
		 get { } //Length: 20
	}

	public long byteSizeWithVoice
	{
		 get { } //Length: 20
	}

	public int CardBgAwkMode
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool CardBgPremiumMode
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool CardEpisode
	{
		 get { } //Length: 18
	}

	public List<Int32> HighlightCharaIdList
	{
		 get { } //Length: 11
	}

	public bool IsNoVoiceEpisode
	{
		 get { } //Length: 18
	}

	public bool LogModeFg
	{
		 get { } //Length: 11
	}

	public GameEventScriptResInfo[] ResArray
	{
		 set { } //Length: 45
	}

	public GameUiEventScriptMain ScriptMain
	{
		 get { } //Length: 11
	}

	public int SelectPoint
	{
		 get { } //Length: 11
	}

	public bool SkipOn
	{
		 get { } //Length: 14
	}

	public bool SkipProhibitFg
	{
		 get { } //Length: 11
	}

	public bool TalkOut
	{
		 get { } //Length: 14
	}

	private static GameEventScriptPlay() { }

	public GameEventScriptPlay(GameEventScriptMain parent) { }

	[CompilerGenerated]
	private void <ContLoadScript>b__110_0(LoadContext context) { }

	private bool CallbackBackButton() { }

	private bool CheckData() { }

	private bool CheckNextSameTalker() { }

	private bool ChkAutoVoiceWaitFinish() { }

	private void ContCommandMain() { }

	public void ContFinish() { }

	public bool ContLoadBgm() { }

	public bool ContLoadEffect(int count) { }

	public int ContLoadMain() { }

	public int ContLoadScript() { }

	public bool ContLoadSe() { }

	public bool ContLoadShader() { }

	public bool ContLoadTexBgAssetBundle() { }

	public bool ContLoadTexBgStillAssetBundle() { }

	public bool ContLoadTexChara(int count) { }

	public bool ContLoadTexItem() { }

	public bool ContLoadVoice() { }

	public bool ContUpdate() { }

	private void FirstFadeInOnly() { }

	public bool ForceFinish() { }

	public bool get_AutoFg() { }

	public long get_byteSize() { }

	public long get_byteSizeWithVoice() { }

	public int get_CardBgAwkMode() { }

	public bool get_CardBgPremiumMode() { }

	public bool get_CardEpisode() { }

	public List<Int32> get_HighlightCharaIdList() { }

	public bool get_IsNoVoiceEpisode() { }

	public bool get_LogModeFg() { }

	public GameUiEventScriptMain get_ScriptMain() { }

	public int get_SelectPoint() { }

	public bool get_SkipOn() { }

	public bool get_SkipProhibitFg() { }

	public bool get_TalkOut() { }

	public List<GameEventScriptLogInfo> GetLogList() { }

	public void InitAll() { }

	public void InitBgScroll(GameEventScriptCommandData data) { }

	private void InitStart() { }

	private bool IsActiveFadeFunction() { }

	public bool IsCheckDownLoad() { }

	public bool IsCreatedEffectDisp() { }

	public bool IsLoadChara() { }

	public bool IsLoadEffect() { }

	public bool IsOpenSkipConfirm() { }

	public bool IsOpenSkipConfirmOrLogWindow() { }

	private bool IsPlayingVoice() { }

	public bool IsPreInit() { }

	public bool IsUseSDChara() { }

	public void LoadBtlTalkVoice(string fname) { }

	private void LogmodeUpdate() { }

	public bool PlayCutScene() { }

	private void PlayVoice(string cue) { }

	public void PreInitStart() { }

	public void ReqScriptLoadCheck(string filename, bool IsTryInstallPlatform, EpisodeCategory Category, bool isVoice) { }

	private void ResetHighlightCharaMotion() { }

	public void set_AdvDisp(AdventureDisp value) { }

	public void set_CardBgAwkMode(int value) { }

	public void set_CardBgPremiumMode(bool value) { }

	public void set_ResArray(GameEventScriptResInfo[] value) { }

	private bool SetActionCharaFunc(GameEventScriptCommandData data) { }

	private bool SetAnimSDCharaFunc(GameEventScriptCommandData data) { }

	public void SetAutoFg(bool fg1) { }

	public void SetCardLogFg(bool enable) { }

	private bool SetCutSceneFunc(GameEventScriptCommandData data) { }

	public void SetFinishReq(bool force = false) { }

	private void SetInsertFunc() { }

	public void SetLogFg() { }

	private bool SetModelCharaFunc(GameEventScriptCommandData data) { }

	private void SetNewCommand() { }

	public void SetNextCommandReq() { }

	public void SetPlayReq(int event_id, bool pre_init, eLayoutType lay_type, bool stop_bgm, bool enable_voice) { }

	public void SetPlayReq(string file_name, bool pre_init, eLayoutType lay_type, bool stop_bgm, bool enable_voice) { }

	private bool SetSDModelCharaFunc(GameEventScriptCommandData data) { }

	public void SetSkipConfirmFg(bool enable) { }

	public void SetSkipFg() { }

	private bool SetTitleFunc(GameEventScriptCommandData data) { }

	public void SetUiDisp(AdventureDisp disp) { }

	private bool StartAllMouth() { }

	private bool StopAllMouth() { }

	private void StopVoice() { }

	private void TalkOptionCommand(string opt) { }

	public void VoiceReelase() { }

	private void WorkInit() { }

}


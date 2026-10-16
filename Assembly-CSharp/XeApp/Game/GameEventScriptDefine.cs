namespace XeApp.Game;

public class GameEventScriptDefine
{
	internal enum eBgAnimType
	{
		DISP_OFF = 0,
		DISP_ON = 1,
		FADE_IN = 2,
		FADE_OUT = 3,
		SHAKE = 4,
		NUM = 5,
	}

	internal enum eBgShutter
	{
		ENABLE = 0,
		NUM = 1,
	}

	internal enum eCharaAction
	{
		CHARA_DATA_NO = 0,
		CHARA_DATA_NO2 = 1,
		CHARA_DATA_NO3 = 2,
		MOTION = 3,
		FACE = 4,
		DURATION = 5,
		OPTION = 6,
		DELAY = 7,
		EAR = 8,
		TAIL = 9,
		NUM = 10,
	}

	internal enum eCharaAnimType
	{
		DISP_OFF = 0,
		DISP_ON = 1,
		DISP_DARK = 2,
		DISP_BLACK = 3,
		DISP_FADE_IN = 4,
		DISP_FADE_OUT = 5,
		DISP_FADE_IN_LEFT = 6,
		DISP_FADE_OUT_LEFT = 7,
		DISP_FADE_IN_RIGHT = 8,
		DISP_FADE_OUT_RIGHT = 9,
		DISP_FADE_IN_LOWER = 10,
		DISP_FADE_OUT_LOWER = 11,
		DISP_FADE_IN_UPPER = 12,
		DISP_FADE_OUT_UPPER = 13,
		SHAKE = 14,
		SHAKE_V = 15,
		SHAKE_H = 16,
		NUM = 17,
	}

	internal enum eChoineUi
	{
		MESSAGE = 0,
	}

	internal enum eColorMode
	{
		TYPE = 0,
		CHARA_DATA_NO = 1,
		NUM = 2,
	}

	internal enum eColorShader
	{
		NON = 0,
		MONOCHRO = 1,
		SEPIA = 2,
		BLACK = 3,
		NUM = 4,
	}

	internal enum eComBattleBossName
	{
		CHARA_DATA_NO = 0,
		NUM = 1,
	}

	internal enum eComBgInsertChange
	{
		BG_DATA_NO = 0,
		NUM = 1,
	}

	internal enum eComBgInsertIn
	{
		BG_DATA_NO = 0,
		NUM = 1,
	}

	internal enum eComBgInsertMask
	{
		STATE = 0,
		NUM = 1,
	}

	internal enum eComBgInsertShake
	{
		ID = 0,
		TARGET = 1,
		TYPE = 2,
		SPEED = 3,
		POWER = 4,
		DERAY_TIME = 5,
		TIME = 6,
		NUM = 7,
	}

	internal enum eComBgInsertShakeTarget
	{
		MSG = 0,
		CHAR = 1,
		BG = 2,
		ALL = 3,
	}

	internal enum eComBgInsertShakeType
	{
		BIKU = 0,
		PYON = 1,
		GATA = 2,
	}

	internal enum eComCamera
	{
		START = 0,
		END = 1,
		SPEED_RATIO = 2,
		DERAY = 3,
		NUM = 4,
	}

	internal enum eComCenterMes
	{
		TEXT_SPEED = 0,
		LINE = 1,
		NUM = 2,
	}

	internal enum eComChangeBgColor
	{
		R_VALUE = 0,
		G_VALUE = 1,
		B_VALUE = 2,
		NUM = 3,
	}

	internal enum eComChangeCharaColor
	{
		CHARA_DATA_NO = 0,
		R_VALUE = 1,
		G_VALUE = 2,
		B_VALUE = 3,
		NUM = 4,
	}

	internal enum eComCharaCommonMotionActive
	{
		CHARA_DATA_NO = 0,
		ACTIVE = 1,
		NUM = 2,
	}

	internal enum eComCharacterAppear
	{
		CHARA_DATA_NO = 0,
		NUM = 1,
	}

	internal enum eComCharaOptionPriority
	{
		CHARA_DATA_NO = 0,
		NUM = 1,
	}

	internal enum eComClearLookChara
	{
		CHARA_DATA_NO = 0,
		NUM = 1,
	}

	internal enum eComClearLookDelay
	{
		CHARA_DATA_NO = 0,
		NUM = 1,
	}

	internal enum eComEasingMoveCharaPos
	{
		CHARA_DATA_NO = 0,
		TYPE = 1,
		TARGET = 2,
		COUNT = 3,
		OPCITY = 4,
		NUM = 5,
	}

	internal enum eComEraseEffect
	{
		TYPE = 0,
		NUM = 1,
	}

	internal enum eComEraseTexChara
	{
		CHARA_DATA_NO = 0,
		FADE_OUT_TIME = 1,
		NUM = 2,
	}

	internal enum eComEraseTexItem
	{
		TIME = 0,
		NUM = 1,
	}

	internal enum eComFadeIn
	{
		SEC = 0,
		COLOR_TYPE = 1,
		NUM = 2,
	}

	internal enum eComFadeOut
	{
		SEC = 0,
		COLOR_TYPE = 1,
		NUM = 2,
	}

	internal enum eComForcedJump
	{
		ID = 0,
		NUM = 1,
	}

	internal enum eComForcedJumpPlace
	{
		ID = 0,
		NUM = 1,
	}

	internal enum eComInfoBoard
	{
		NUM = 0,
	}

	internal enum eComJumpSelect
	{
		ID = 0,
		SELECT_ID = 1,
		NUM = 2,
	}

	internal enum eComLookChara
	{
		CHARA_DATA_NO = 0,
		TARGET_CHARA_DATA_NO = 1,
		DELAY = 2,
		NUM = 3,
	}

	internal enum eComLookDelay
	{
		CHARA_DATA_NO = 0,
		DELAY = 1,
		NUM = 2,
	}

	internal enum eComMainUiOff
	{
		MENU_LEAVE = 0,
		NUM = 1,
	}

	internal enum eCommand
	{
		NONE = -1,
		START = 0,
		END = 1,
		FADE_IN = 2,
		FADE_OUT = 3,
		WAIT_SEC = 4,
		WAIT_TOUCH = 5,
		SET_BGM = 6,
		STOP_BGM = 7,
		STOP_BGM_FADEOUT = 8,
		SET_SE_SYSTEM = 9,
		SET_SE_OTHER = 10,
		SET_SE_AMB = 11,
		STOP_SE = 12,
		SET_VOICE = 13,
		SET_TEX_BG = 14,
		SET_ANIM_BG = 15,
		SET_TEX_CHARA = 16,
		SET_ANIM_CHARA = 17,
		ERASE_TEX_CHARA = 18,
		TALK = 19,
		MESSAGE = 20,
		MES_CLEAR = 21,
		CENTER_MES = 22,
		CENTER_MES_CLEAR = 23,
		SKIP_NO_ALL = 24,
		SKIP_NO_FIRST = 25,
		SKIP_POS = 26,
		MAIN_UI_OFF = 27,
		MAIN_UI_ON = 28,
		BATTLE_BOSS_NAME = 29,
		CHARACTER_APPEAR = 30,
		ALL_COLOR_MODE = 31,
		WHITE_IN = 32,
		WHITE_OUT = 33,
		FLASH_SCREEN = 34,
		CHARA_COLOR_MODE = 35,
		ONE_CHARA_COLOR_MODE = 36,
		BG_COLOR_MODE = 37,
		SET_TEX_ITEM = 38,
		ERASE_TEX_ITEM = 39,
		SET_EFFECT = 40,
		ERASE_EFFECT = 41,
		SET_SELECT = 42,
		JUMP_SELECT = 43,
		FORCED_JUMP = 44,
		FORCED_JUMP_PLACE = 45,
		START_ALL_SHAKE = 46,
		STOP_ALL_SHAKE = 47,
		END_SELECT = 48,
		CAMERA = 49,
		SET_MODEL_CHARA = 50,
		OUT_MODEL_CHARA = 51,
		BG_SHUTTER = 52,
		SET_ACTION_CHARA = 53,
		SET_TITLE = 54,
		SET_CUT_SCENE = 55,
		SET_LAYER_PRIORITY = 56,
		MOVE_CHARA_POS = 57,
		START_MES_SHAKE = 58,
		STOP_MES_SHAKE = 59,
		TALK_L = 60,
		TALK_R = 61,
		LOAD_BTL_VOICE = 62,
		SECRETLY_DOWNLOAD = 63,
		SET_CHARA_PRIORITY = 64,
		SET_BG_PARAMETER = 65,
		SET_BG_ZOOM = 66,
		SET_INSERT_IN = 67,
		SET_INSERT_OUT = 68,
		SET_INSERT_CHANGE = 69,
		SET_INSERT_SHAKE = 70,
		SET_INSERT_SHAKE_STOP = 71,
		SET_INSERT_MASK = 72,
		WAIT_CHARA = 73,
		SET_LOOK_CHARA = 74,
		CLEAR_LOOK_CHARA = 75,
		SET_LOOK_DELAY = 76,
		CLEAR_LOOK_DELAY = 77,
		SET_EYE_MOTION = 78,
		SET_BREATH_MOTION = 79,
		SET_EFFECT_MOTION = 80,
		CHANGE_CHARA_COLOR = 81,
		CLEAR_CHARA_COLOR = 82,
		ON_CHARA_OPTION_PRIORITY = 83,
		OFF_CHARA_OPTION_PRIORITY = 84,
		SET_WING_MOTION = 85,
		INFO_BOARD = 86,
		TALK_OUT = 87,
		CHANGE_BG_COLOR = 88,
		CLEAR_BG_COLOR = 89,
		SET_MONO = 90,
		CLEAR_MONO = 91,
		SET_SE_COMMON = 92,
		SET_SE_EPISODE = 93,
		STOP_SE_EPISODE = 94,
		STOP_SE_EPISODE_ALL = 95,
		STOP_SE_EPISODE_FADEOUT = 96,
		SET_CARD_BG_IN = 97,
		SET_CARD_BG_OUT = 98,
		SET_CARD_TEXT = 99,
		SET_RYTHMGAME_PRESET_NO = 100,
		EASING_MOVE_CHARA_POS = 101,
		SET_SEPIA = 102,
		CLEAR_SEPIA = 103,
		ENABLE_TOUCH = 104,
		DISABLE_TOUCH = 105,
		SET_DISTORTION = 106,
		STOP_DISTORTION = 107,
		SET_LOOK_POS = 108,
		SET_EFFECT_POS = 109,
		CHOICE_MESSAGE = 110,
		WAIT_CHOICE = 111,
		ENABLE_EFFECT_MODEL = 112,
		DISABLE_EFFECT_MODEL = 113,
		SET_DOWN_CHARA_POS = 114,
		SET_UP_CHARA_POS = 115,
		SET_START_VOICE_BUS_VOLUME = 116,
		SET_END_VOICE_BUS_VOLUME = 117,
		SET_SD_MODEL_CHARA = 118,
		OUT_SD_MODEL_CHARA = 119,
		MOVE_SD_CHARA_POS = 120,
		SET_ANIM_SD_CHARA = 121,
		TALK_SD = 122,
		OUT_TALK_SD = 123,
		SET_TALK_POPUP = 124,
		OUT_TALK_POPUP = 125,
		SET_SD_CHARA_SCALE = 126,
		SET_ENV_EFFECT = 127,
		STOP_ENV_EFFECT = 128,
		SET_CARD_BG_IN_ANIM_OFF = 129,
		SET_TEX_BG_STILL = 130,
		STOP_EFFECT_POS = 131,
		NUM = 132,
	}

	internal enum eComMessage
	{
		TEXT_SPEED = 0,
		LINE = 1,
		NUM = 2,
	}

	internal enum eComMoveCharaPos
	{
		CHARA_DATA_NO = 0,
		TARGET = 1,
		COUNT = 2,
		OPCITY = 3,
		NUM = 4,
	}

	internal enum eComScaleCharaSD
	{
		CHARA_DATA_NO = 0,
		SCALE = 1,
	}

	internal enum eComScreenFlash
	{
		SEC = 0,
		SPEED = 1,
		NUM = 2,
	}

	internal enum eComSetAnimBg
	{
		WORK_NO = 0,
		ANIM = 1,
		SPEED = 2,
		NUM = 3,
	}

	internal enum eComSetAnimChara
	{
		CHARA_DATA_NO = 0,
		ANIME = 1,
		SCALE = 2,
		NUM = 3,
	}

	internal enum eComSetBgm
	{
		DATA_NO = 0,
		NUM = 1,
	}

	internal enum eComSetBgParameter
	{
		WORK_NO = 0,
		SCALE = 1,
		POS_X = 2,
		POS_Y = 3,
		NUM = 4,
	}

	internal enum eComSetBgZoom
	{
		WORK_NO = 0,
		SCALE = 1,
		POS_X = 2,
		POS_Y = 3,
		SPEED = 4,
		NUM = 5,
	}

	internal enum eComSetCardBgIn
	{
		CARD_ID = 0,
		NUM = 1,
	}

	internal enum eComSetCardBgInAnimOff
	{
		CARD_ID = 0,
		NUM = 1,
	}

	internal enum eComSetCardText
	{
		TEXT_SPEED = 0,
		NUM = 1,
	}

	internal enum eComSetCharaPriority
	{
		CHARA_DATA_NO = 0,
		PRIORITY = 1,
		NUM = 2,
	}

	internal enum eComSetCutScene
	{
		ID = 0,
		NUM = 1,
	}

	internal enum eComSetDownCharaPos
	{
		CHARA_DATA_NO = 0,
		COUNT = 1,
		NUM = 2,
	}

	internal enum eComSetEffect
	{
		TYPE = 0,
		DEPTH = 1,
		POS_X = 2,
		POS_Y = 3,
		NUM = 4,
	}

	internal enum eComSetEffectPos
	{
		EFFECT_NO = 0,
		CHARA_DATA_NO = 1,
		POS_Y = 2,
		LAYER = 3,
		DELAY = 4,
	}

	internal enum eComSetEnvEffect
	{
		EFFECT_NO = 0,
	}

	internal enum eComSetLayerPropaty
	{
		VALUE = 0,
		NUM = 1,
	}

	internal enum eComSetLookPos
	{
		CHARA_DATA_NO = 0,
		POS_X = 1,
		POS_Y = 2,
		TIME = 3,
		DELAY = 4,
	}

	internal enum eComSetMono
	{
		R_VALUE = 0,
		G_VALUE = 1,
		B_VALUE = 2,
		NUM = 3,
	}

	internal enum eComSetRythmGamePresetNo
	{
		PRESET_NO = 0,
		NUM = 1,
	}

	internal enum eComSetSDChara
	{
		CHARA_CODE_NO = 0,
		CHARA_DATA_NO = 1,
		CHARA_FULL_NO = 2,
		DISP_POS = 3,
		FADE_IN = 4,
		OPACITY = 5,
		IN_DIRECTION = 6,
		IN_FACE = 7,
		IN_ANIME = 8,
		IN_EMOTION = 9,
		IN_OPTION = 10,
	}

	internal enum eComSetSe
	{
		DATA_NO = 0,
		NUM = 1,
	}

	internal enum eComSetSeCommon
	{
		NUM = 0,
	}

	internal enum eComSetSeEpisode
	{
		NUM = 0,
	}

	internal enum eComSetSelect
	{
		ID = 0,
		TIME = 1,
		LINE = 2,
		NUM = 3,
	}

	internal enum eComSetSepia
	{
		R_VALUE = 0,
		G_VALUE = 1,
		B_VALUE = 2,
		NUM = 3,
	}

	internal enum eComSetSpineChara
	{
		CHARA_CODE_NO = 0,
		CHARA_DATA_NO = 1,
		CHARA_FULL_NO = 2,
		DISP_POS = 3,
		FADE_IN = 4,
		OPACITY = 5,
		IN_ANIME = 6,
		IN_FACE = 7,
		IN_OPTION = 8,
		IN_EAR = 9,
		IN_TAIL = 10,
		NUM = 11,
	}

	internal enum eComSetTexBg
	{
		BG_DATA_NO = 0,
		SIZE = 1,
		NUM = 2,
	}

	internal enum eComSetTexBgStill
	{
		BG_DATA_NO = 0,
		NUM = 1,
	}

	internal enum eComSetTexItem
	{
		ITEM_DATA_NO = 0,
		POS_X_ID = 1,
		TIME = 2,
		NUM = 3,
	}

	internal enum eComSetTitle
	{
		ID = 0,
		NUM = 1,
	}

	internal enum eComSetUpCharaPos
	{
		CHARA_DATA_NO = 0,
		COUNT = 1,
		NUM = 2,
	}

	internal enum eComSetVoice
	{
		CHARA_NO = 0,
		VOICE_NO = 1,
		NUM = 2,
	}

	internal enum eComStartAllShake
	{
		SPEED = 0,
		COUNT = 1,
		NUM = 2,
	}

	internal enum eComStartMesShake
	{
		SPEED = 0,
		COUNT = 1,
		DELAY = 2,
		NUM = 3,
	}

	internal enum eComStopAllShake
	{
		NUM = 0,
	}

	internal enum eComStopBgmFadeout
	{
		SEC = 0,
		NUM = 1,
	}

	internal enum eComStopSe
	{
		NUM = 0,
	}

	internal enum eComStopSeEpisode
	{
		NUM = 0,
	}

	internal enum eComStopSeEpisodeFadeout
	{
		SEC = 0,
		NUM = 1,
	}

	internal enum eComTalk
	{
		PERSON_ID = 0,
		TEXT_SPEED = 1,
		CHARA_DATA_NO_1 = 2,
		CHARA_DATA_NO_2 = 3,
		CHARA_DATA_NO_3 = 4,
		CHARA_1_ID = 5,
		CHARA_2_ID = 6,
		CHARA_3_ID = 7,
		CHARA_1_SKIN = 8,
		CHARA_2_SKIN = 9,
		CHARA_3_SKIN = 10,
		ANIME = 11,
		DURATION = 12,
		FACE = 13,
		OPTION = 14,
		DELAY = 15,
		EAR = 16,
		TAIL = 17,
		LINE = 18,
		NUM = 19,
	}

	internal enum eComTalkOut
	{
		NUM = 0,
	}

	internal enum eComTalkPopup
	{
		PERSON_ID = 0,
		MSG_TYPE = 1,
		CHARA_DATA_NO_1 = 2,
		CHARA_1_ID = 3,
		CHARA_1_SKIN = 4,
		DIRECTION = 5,
		POS_X = 6,
		POS_Y = 7,
		LINE = 8,
	}

	internal enum eComTalkSD
	{
		PERSON_ID = 0,
		MSG_TYPE = 1,
		CHARA_DATA_NO_1 = 2,
		CHARA_1_ID = 3,
		CHARA_1_SKIN = 4,
		DIRECTION = 5,
		FACE = 6,
		ANIME = 7,
		EMOTION = 8,
		DELAY = 9,
		LINE = 10,
	}

	internal enum eComWaitChara
	{
		CHARA_DATA_NO = 0,
		NUM = 1,
	}

	internal enum eComWaitSec
	{
		SEC = 0,
		NUM = 1,
	}

	internal enum eComWingMotion
	{
		CHARA_DATA_NO = 0,
		WING_MOTION_NO = 1,
		NUM = 2,
	}

	internal enum eLayoutType
	{
		NORMAL = 0,
		BATTLE = 1,
		NUM = 2,
	}

	internal enum eSDCharaAction
	{
		CHARA_DATA_NO1 = 0,
		CHARA_DATA_NO2 = 1,
		CHARA_DATA_NO3 = 2,
		CHARA_DATA_NO4 = 3,
		CHARA_DATA_NO5 = 4,
		DIRECTION = 5,
		FACE = 6,
		MOTION = 7,
		EMOTION = 8,
		DELAY = 9,
		OPTION = 10,
		NUM = 11,
	}

	internal enum eVoiceBusVolume
	{
		Volume = 0,
		NUM = 1,
	}

	public const string ITEM_TEX_TYPE = "PACK"; //Field offset: 0x0
	public static String[][] m_EffectAnimName; //Field offset: 0x0
	public const float CARD_TEXT__WAIT = 0.8; //Field offset: 0x0
	public const float SPINE_X_INTERVAL = 1.25; //Field offset: 0x0
	public const float BTL_TYPE_BGM_DUCKING = 0.4; //Field offset: 0x0
	public const float APPEAR_WAIT_COUNT = 6.2; //Field offset: 0x0
	public const int APPEAR_SE_NO = 39; //Field offset: 0x0
	public const float SPINE_FADE_RATIO = 8; //Field offset: 0x0
	public const float BG_EFFECT_OFFSET_Y = 45.5; //Field offset: 0x0
	public const float TITLE_JINGLE_DELAY = 2; //Field offset: 0x0
	public const int SPINE_DIRECT_REF_CODE = 10000; //Field offset: 0x0
	public const float FAST_FOWARD_TEXT = 2; //Field offset: 0x0
	public const float FAST_FOWARD_RATIO = 2; //Field offset: 0x0
	public const float SPINE_SCALE_OFFSET = 1; //Field offset: 0x0
	public const float SPINE_Z_OFFSET_4x3 = 2; //Field offset: 0x0
	public const float BG_EFFECT_OFFSET_X = -84; //Field offset: 0x0
	public const float SPINE_Y_OFFSET = 0; //Field offset: 0x0
	public const float SPINE_Z_OFFSET_16x9 = 0; //Field offset: 0x0
	public const int ITEM_TEX_MAX = 5; //Field offset: 0x0
	public const float AUTO_MESSAGE_WAIT = 3; //Field offset: 0x0
	public const float AUTO_VOICE_WAIT = 0.5; //Field offset: 0x0
	public const float BATTLE_BOSS_NAME_WAIT = 3.5; //Field offset: 0x0
	public const float CHARACTER_APPEAR_WAIT = 3; //Field offset: 0x0
	public const int LARGE_SIZE_BG_CODE = 10000000; //Field offset: 0x0
	public const int CHARA_TEX_MAX = 25; //Field offset: 0x0
	public const float HARUKA_Y_OFFSET = -8; //Field offset: 0x0
	public const float SPINE_CAMERA_X = 0; //Field offset: 0x0
	public const float SPINE_CAMERA_Y = 0; //Field offset: 0x0
	public const float SPINE_CAMERA_Z = -5; //Field offset: 0x0
	public const float SPINE_X_OFFSET = 0; //Field offset: 0x0
	public const float ZAKO_Y_OFFSET = -13; //Field offset: 0x0
	public static String[] m_CommandList; //Field offset: 0x4
	public static String[] m_SetSeSystemItem; //Field offset: 0x8
	public static String[] m_BgAnimType; //Field offset: 0xC
	public static String[] m_CharaAnimType; //Field offset: 0x10
	public static String[] m_EffectAnimType; //Field offset: 0x14
	public static String[] m_VariableType; //Field offset: 0x18
	public static String[] m_CharaFaceType; //Field offset: 0x1C
	public static String[] m_CharaActionType; //Field offset: 0x20
	public static String[] m_SdCharaActionType; //Field offset: 0x24
	public static String[] m_FaceActionType; //Field offset: 0x28
	public static String[] m_OptionActionType; //Field offset: 0x2C
	public static String[] m_EarActionType; //Field offset: 0x30
	public static String[] m_TailActionType; //Field offset: 0x34
	public static String[] m_WingActionType; //Field offset: 0x38

	private static GameEventScriptDefine() { }

	public GameEventScriptDefine() { }

}


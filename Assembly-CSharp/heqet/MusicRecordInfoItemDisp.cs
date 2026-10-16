namespace Heqet;

public class MusicRecordInfoItemDisp : UiScrollListPanelBase
{
	private enum eClearIcon
	{
		NoBomb = 0,
		NoItem = 1,
		BossBreak = 2,
		NoDamage = 3,
		Max = 4,
	}

	private enum eCommonLayerId
	{
		NoBombTitle = 0,
		NoBombIcons = 1,
		NoItemTitle = 2,
		NoItemIcons = 3,
		BossBreakTitle = 4,
		BossBreakIcons = 5,
		NoDamageTitle = 6,
		NoDamageIcons = 7,
		DlcTitle = 8,
		StoryOnly = 9,
		Max = 10,
	}

	internal enum eGameType
	{
		Kagura = 0,
		Danmaku = 1,
	}

	private enum eImageId
	{
		NoBombEasyMark = 0,
		NoBombNormalMark = 1,
		NoBombHardMark = 2,
		NoBombLunaticMark = 3,
		NoItemEasyMark = 4,
		NoItemNormalMark = 5,
		NoItemHardMark = 6,
		NoItemLunaticMark = 7,
		BossBreakEasyMark = 8,
		BossBreakNormalMark = 9,
		BossBreakHardMark = 10,
		BossBreakLunaticMark = 11,
		NoDamageEasyMark = 12,
		NoDamageNormalMark = 13,
		NoDamageHardMark = 14,
		NoDamageLunaticMark = 15,
		Max = 16,
	}

	internal enum eModeType
	{
		StoryMode = 0,
		FreeMode = 1,
	}

	private enum eTextId
	{
		CircleName = 0,
		Part01 = 1,
		Part02 = 2,
		Part03 = 3,
		Part04 = 4,
		Part05 = 5,
		Part06 = 6,
		Part07 = 7,
		Part08 = 8,
		Part09 = 9,
		Part10 = 10,
		Part11 = 11,
		IllustratorName = 12,
		PlayCount = 13,
		TotalNotesCount = 14,
		TapRate = 15,
		MaxCombo = 16,
		DlcTitle = 17,
		Max = 18,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private const string CLEAR_ON_ICON_SPRITE_NAME = "rw_mark_on"; //Field offset: 0x0
	private const string CLEAR_OFF_ICON_SPRITE_NAME = "rw_mark_off"; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private String[] m_TextList; //Field offset: 0x130
	private AtlasImage[2] m_ClearIcons; //Field offset: 0x134
	[CompilerGenerated]
	private eModeType <ModeType>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private eGameType <GameType>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private int <MusicId>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private int <StageId>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private int <Difficulty>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private LaneMode <LaneMode>k__BackingField; //Field offset: 0x14C

	public private int Difficulty
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public eGameType GameType
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public private LaneMode LaneMode
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public eModeType ModeType
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int MusicId
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int StageId
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	private static MusicRecordInfoItemDisp() { }

	public MusicRecordInfoItemDisp() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public int get_Difficulty() { }

	[CompilerGenerated]
	public eGameType get_GameType() { }

	[CompilerGenerated]
	public LaneMode get_LaneMode() { }

	[CompilerGenerated]
	public eModeType get_ModeType() { }

	[CompilerGenerated]
	public int get_MusicId() { }

	[CompilerGenerated]
	public int get_StageId() { }

	public virtual Vector2 GetPanelSize() { }

	protected virtual void InitUguiOther() { }

	[CompilerGenerated]
	private void set_Difficulty(int value) { }

	[CompilerGenerated]
	public void set_GameType(eGameType value) { }

	[CompilerGenerated]
	private void set_LaneMode(LaneMode value) { }

	[CompilerGenerated]
	public void set_ModeType(eModeType value) { }

	[CompilerGenerated]
	public void set_MusicId(int value) { }

	[CompilerGenerated]
	public void set_StageId(int value) { }

	private void SetClearIcon(GameObject _obj, bool _enable) { }

	private void SetDanmakuText(GameObject _obj) { }

	public void SetDifficulty(int difficulty, LaneMode laneMode) { }

	private void SetPartText(eTextId id, string text) { }

	public void UpdateDisp() { }

}


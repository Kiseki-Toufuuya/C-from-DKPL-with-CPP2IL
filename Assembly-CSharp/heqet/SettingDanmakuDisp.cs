namespace Heqet;

public class SettingDanmakuDisp : SettingDispBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, String> <>9__43_0; //Field offset: 0x4
		public static Action<Int32, BaseEventData> <>9__45_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <InitUguiOther>b__45_0(int _id, BaseEventData _data) { }

		internal string <SetupLabel>b__43_0(string _label) { }

	}

	internal enum eButtonId
	{
		Tab1 = 0,
		Tab2 = 1,
		Tab3 = 2,
		DeleteAllMusicUnitSettings = 3,
		TapTimingAutoButton = 4,
		SpeedSub = 5,
		SpeedSubDec = 6,
		SpeedSubDec2 = 7,
		SpeedAddDec2 = 8,
		SpeedAddDec = 9,
		SpeedAdd = 10,
		SpeedAutoSub100 = 11,
		SpeedAutoSub10 = 12,
		SpeedAutoSub = 13,
		SpeedAutoAdd = 14,
		SpeedAutoAdd10 = 15,
		SpeedAutoAdd100 = 16,
		SpeedEasySubTen = 17,
		SpeedEasySub = 18,
		SpeedEasyAdd = 19,
		SpeedEasyAddTen = 20,
		SuddenSub = 21,
		SuddenSubDec = 22,
		SuddenAddDec = 23,
		SuddenAdd = 24,
		HiddenSub = 25,
		HiddenSubDec = 26,
		HiddenAddDec = 27,
		HiddenAdd = 28,
		MusicTimingSub100 = 29,
		MusicTimingSub10 = 30,
		MusicTimingSub = 31,
		MusicTimingAdd = 32,
		MusicTimingAdd10 = 33,
		MusicTimingAdd100 = 34,
		TimingSub100 = 35,
		TimingSub10 = 36,
		TimingSub = 37,
		TimingAdd = 38,
		TimingAdd10 = 39,
		TimingAdd100 = 40,
		PlayerBulletOpacitySub = 41,
		PlayerBulletOpacitySubDec = 42,
		PlayerBulletOpacityAddDec = 43,
		PlayerBulletOpacityAdd = 44,
		Sudden1 = 45,
		Sudden2 = 46,
		Hidden1 = 47,
		Hidden2 = 48,
		Rhythmbeat1 = 49,
		Rhythmbeat2 = 50,
		PlayGuide1 = 51,
		PlayGuide2 = 52,
		Collision1 = 53,
		Collision2 = 54,
		Highaccuracy1 = 55,
		Highaccuracy2 = 56,
		Tapaccuracy1 = 57,
		Tapaccuracy2 = 58,
		Expert1 = 59,
		Expert2 = 60,
		MusicSync1 = 61,
		MusicSync2 = 62,
	}

	internal enum eColumnId
	{
		Speed = 0,
		Sudden = 1,
		Hidden = 2,
		NoteSound = 3,
		Rhythmbeat = 4,
		MusicTiming = 5,
		TapTiming = 6,
		PlayGuide = 7,
		Collision = 8,
		PlayerBulletOpacity = 9,
		Highaccuracy = 10,
		Tapaccuracy = 11,
		Expert = 12,
		MusicSync = 13,
		NoteSkin = 14,
	}

	internal enum eDropdownId
	{
		SpeedType = 0,
		NoteSound = 1,
		NoteSkin = 2,
	}

	internal enum eImageId
	{
		NotesIcon_n1 = 0,
		NotesIcon_n2 = 1,
		NotesIcon_a1 = 2,
		NotesIcon_a2 = 3,
	}

	internal enum eLayerId
	{
		Selectable1 = 0,
		Selectable2 = 1,
		Selectable3 = 2,
		Tab1Body = 3,
		Tab2Body = 4,
		Tab3Body = 5,
		Tab1BodyActive = 6,
		Tab2BodyActive = 7,
		Tab3BodyActive = 8,
		RootSpeed = 9,
		ROOT_PREVIEW = 10,
		ROOT_SPEED_MANUAL = 11,
		ROOT_SPEED_EASY = 12,
		ROOT_SPEED_AUTO = 13,
		ROOT_SPEED_MANUAL_LOCK = 14,
		ROOT_MUSIC_SYNC = 15,
		LockSudden = 16,
		LockHidden = 17,
		RootTab2Scroll = 18,
	}

	internal enum eRadioButtonId
	{
		Sudden = 0,
		Hidden = 1,
		Rhythmbeat = 2,
		PlayGuide = 3,
		Collision = 4,
		Highaccuracy = 5,
		Tapaccuracy = 6,
		Expert = 7,
		MusicSync = 8,
	}

	internal enum eSelectedId
	{
		Selectable1 = 0,
		Selectable2 = 1,
		Selectable3 = 2,
	}

	internal enum eSliderId
	{
		SpeedManual = 0,
		SpeedEasy = 1,
		SpeedAuto = 2,
		Sudden = 3,
		Hidden = 4,
		MusicTiming = 5,
		TapTiming = 6,
		PlayerBulletOpacity = 7,
	}

	internal enum eTabId
	{
		Tab1 = 0,
		Tab2 = 1,
		Tab3 = 2,
	}

	private enum eTextId
	{
		Tab1Label = 0,
		Tab2Label = 1,
		Tab3Label = 2,
		SpeedLabel = 3,
		SuddenLabel = 4,
		HiddenLabel = 5,
		NoteSoundLabel = 6,
		RhythmbeatLabel = 7,
		MusicTimingLabel = 8,
		TapTimingLabel = 9,
		TapTimingAutoLabel = 10,
		PlayGuideLabel = 11,
		CollisionLabel = 12,
		PlayerBulletOpacityLabel = 13,
		HighaccuracyLabel = 14,
		TapaccuracyLabel = 15,
		ExpertLabel = 16,
		MusicSyncLabel = 17,
		NoteSkinLabel = 18,
		HelpText = 19,
		TEXT_BPM = 20,
		TEXT_RATIO = 21,
		TEXT_SPEED = 22,
	}

	internal class SetupParam
	{
		public float player_bnullet_opacity; //Field offset: 0x8
		public float speed; //Field offset: 0xC
		public int speed_level_easy; //Field offset: 0x10
		public int speed_auto; //Field offset: 0x14
		public int speed_type; //Field offset: 0x18
		public float sudden; //Field offset: 0x1C
		public float hidden; //Field offset: 0x20
		public float music_timing; //Field offset: 0x24
		public float tap_timing; //Field offset: 0x28
		public float leneBrightness; //Field offset: 0x2C
		public int noteSound; //Field offset: 0x30
		public int noteSkin; //Field offset: 0x34
		public bool collision; //Field offset: 0x38
		public bool rhythmGuide; //Field offset: 0x39
		public bool playGuide; //Field offset: 0x3A
		public bool enable_sudden; //Field offset: 0x3B
		public bool enable_hidden; //Field offset: 0x3C
		public bool enable_rhythmbeat; //Field offset: 0x3D
		public bool enable_highaccuracy; //Field offset: 0x3E
		public bool enable_tapaccuracy; //Field offset: 0x3F
		public bool enable_expert; //Field offset: 0x40
		public bool enable_music_sync; //Field offset: 0x41

		public SetupParam() { }

		public SetupParam(SetupParam _param) { }

		public bool IsChange(SetupParam _param) { }

	}

	private static readonly String[] m_LayerList; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x4
	private static readonly String[] m_ImageList; //Field offset: 0x8
	private static readonly String[] m_SliderList; //Field offset: 0xC
	private static readonly String[] m_SliderTextList; //Field offset: 0x10
	private static readonly String[] m_DropdownList; //Field offset: 0x14
	private static readonly String[] m_RadioButtonList; //Field offset: 0x18
	private static readonly String[] m_RadioButtonImgList; //Field offset: 0x1C
	private readonly String[] m_ButtonDataList; //Field offset: 0x170
	private int m_SliderIdIndex; //Field offset: 0x174
	private int m_SliderTextIdIndex; //Field offset: 0x178
	private int m_DropdownIdIndex; //Field offset: 0x17C
	private int m_RadioButtonIdIndex; //Field offset: 0x180
	private int m_RadioButtonImgIdIndex; //Field offset: 0x184
	private Action<eTabId> OnClickTab; //Field offset: 0x188
	private Dictionary<Int32, UIWrapperButton> m_ButtonDic; //Field offset: 0x18C
	private RectTransform m_SpeedLayoutRect; //Field offset: 0x190
	private VerticalLayoutGroup m_ColumnLayoutGroup; //Field offset: 0x194
	private float m_SpeedManualBuf; //Field offset: 0x198
	private Dictionary<String, AtlasImage> m_NotePreviewIcons; //Field offset: 0x19C
	private ScrollRect m_ScrollRect; //Field offset: 0x1A0

	public Action<eTabId> OnClickTabCallback
	{
		 set { } //Length: 33
	}

	public GameObject RootPreview
	{
		 get { } //Length: 32
	}

	public int TabCount
	{
		 get { } //Length: 123
	}

	public GameObject TapTimingButton
	{
		 get { } //Length: 76
	}

	private static SettingDanmakuDisp() { }

	public SettingDanmakuDisp() { }

	[CompilerGenerated]
	private void <Setup>b__42_0(int _id, int _value) { }

	public void CallbackInitLayout() { }

	public virtual void CallbackSelect(int button_id, BaseEventData _data) { }

	public virtual void Create(LayerBase parent_layer) { }

	public float CulcSpeedForLevel(int _level) { }

	public float CulcSpeedRate(float _speed) { }

	public GameObject get_RootPreview() { }

	public int get_TabCount() { }

	public GameObject get_TapTimingButton() { }

	public virtual void ImmediateOpen(bool visible) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	protected virtual void OnChangeDropdownValue(int _id, int _value) { }

	protected virtual void OnChangeSliderValue(int _id, float _value, int _decimal) { }

	protected virtual void OnClickButton(int _id) { }

	private void OnClickTabButton(eTabId _id) { }

	protected virtual void OnSelected(BaseEventData _data) { }

	public virtual void ReleaseAll() { }

	public List<GameObject> SelectedList() { }

	public void set_OnClickTabCallback(Action<eTabId> value) { }

	public void SetTapTiming(float _value) { }

	public void Setup(SetupParam _param) { }

	private void SetupeColumnId(GameObject _obj, eButtonId _id) { }

	private void SetupLabel() { }

	public void UpdateDisp(WorldStageModel stageModel) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateNoteSkinDropdownValue(int _value) { }

	public void UpdateNoteSkinPreview(int _id) { }

	private void UpdateRectSpeedType(int _type) { }

	private void UpdateScrollPos(bool top = true) { }

	private void UpdateSerectedSpeedType(int _type) { }

	public void UpdateSpeedDropdownValue(int _value) { }

	public void UpdateSpeedText(float _speed) { }

	public void UpdateSpeedText(float _rate, int _speed) { }

	public void UpdateSpeedTextLevel(int _level) { }

}


namespace Heqet;

public class SettingKaguraDisp : SettingDispBase
{
	[CompilerGenerated]
	private struct <<UpdateRectSpeedType>b__70_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingKaguraDisp <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int32, BaseEventData> <>9__43_0; //Field offset: 0x4
		public static Func<String, String> <>9__47_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <InitUguiOther>b__43_0(int _id, BaseEventData _data) { }

		internal string <SetupLabel>b__47_0(string _label) { }

	}

	internal enum eButtonId
	{
		Tab1 = 0,
		Tab2 = 1,
		Tab3 = 2,
		Tab4 = 3,
		DeleteAllMusicUnitSettings = 4,
		TapTimingAutoButton = 5,
		SpeedSub = 6,
		SpeedSubDec = 7,
		SpeedSubDec2 = 8,
		SpeedAddDec2 = 9,
		SpeedAddDec = 10,
		SpeedAdd = 11,
		SpeedAutoSub100 = 12,
		SpeedAutoSub10 = 13,
		SpeedAutoSub = 14,
		SpeedAutoAdd = 15,
		SpeedAutoAdd10 = 16,
		SpeedAutoAdd100 = 17,
		SpeedEasySubTen = 18,
		SpeedEasySub = 19,
		SpeedEasyAdd = 20,
		SpeedEasyAddTen = 21,
		SuddenSub = 22,
		SuddenSubDec = 23,
		SuddenAddDec = 24,
		SuddenAdd = 25,
		HiddenSub = 26,
		HiddenSubDec = 27,
		HiddenAddDec = 28,
		HiddenAdd = 29,
		MusicTimingSub100 = 30,
		MusicTimingSub10 = 31,
		MusicTimingSub = 32,
		MusicTimingAdd = 33,
		MusicTimingAdd10 = 34,
		MusicTimingAdd100 = 35,
		TimingSub100 = 36,
		TimingSub10 = 37,
		TimingSub = 38,
		TimingAdd = 39,
		TimingAdd10 = 40,
		TimingAdd100 = 41,
		LaneBrightSub10 = 42,
		LaneBrightSub = 43,
		LaneBrightAdd = 44,
		LaneBrightAdd10 = 45,
		JudgeMessagePositionYSub100 = 46,
		JudgeMessagePositionYSub10 = 47,
		JudgeMessagePositionYSub = 48,
		JudgeMessagePositionYAdd = 49,
		JudgeMessagePositionYAdd10 = 50,
		JudgeMessagePositionYAdd100 = 51,
		ComboMessagePositionYSub100 = 52,
		ComboMessagePositionYSub10 = 53,
		ComboMessagePositionYSub = 54,
		ComboMessagePositionYAdd = 55,
		ComboMessagePositionYAdd10 = 56,
		ComboMessagePositionYAdd100 = 57,
		Sudden1 = 58,
		Sudden2 = 59,
		Hidden1 = 60,
		Hidden2 = 61,
		RandomMirror1 = 62,
		RandomMirror2 = 63,
		RandomLine1 = 64,
		RandomLine2 = 65,
		RandomOuter1 = 66,
		RandomOuter2 = 67,
		SeparateLine1 = 68,
		SeparateLine2 = 69,
		Rhythmbeat1 = 70,
		Rhythmbeat2 = 71,
		NotesConnection1 = 72,
		NotesConnection2 = 73,
		Animation1 = 74,
		Animation2 = 75,
		PlayGuide1 = 76,
		PlayGuide2 = 77,
		Highaccuracy1 = 78,
		Highaccuracy2 = 79,
		Tapaccuracy1 = 80,
		Tapaccuracy2 = 81,
		Expert1 = 82,
		Expert2 = 83,
		MusicSync1 = 84,
		MusicSync2 = 85,
		BackgroundMovie1 = 86,
		BackgroundMovie2 = 87,
	}

	internal enum eColumnId
	{
		Speed = 0,
		Sudden = 1,
		Hidden = 2,
		RandomMirror = 3,
		RandomLine = 4,
		RandomOuter = 5,
		Layout = 6,
		NotesSound = 7,
		SeparateLine = 8,
		Rhythmbeat = 9,
		NotesConnection = 10,
		MusicTiming = 11,
		TapTiming = 12,
		Animation = 13,
		PlayGuaid = 14,
		Highaccuracy = 15,
		Tapaccuracy = 16,
		Expert = 17,
		MusicSync = 18,
		NotesSkin = 19,
		LaneBright = 20,
		BackgroundMovie = 21,
		JudgeMessagePosition = 22,
		ComboMessagePosition = 23,
		FastSlowMessagePosition = 24,
	}

	internal enum eComboDisplayType
	{
		Default = 0,
		Upper = 1,
		Center = 2,
		Lower = 3,
		Hide = 4,
		SpecifiedPosition = 5,
	}

	internal enum eDropdownId
	{
		SpeedType = 0,
		Layout = 1,
		NoteSound = 2,
		NoteSkin = 3,
		JudgeMessageDisplayType = 4,
		ComboMessageDisplayType = 5,
		FastSlowMessageDisplayType = 6,
	}

	internal enum eImageId
	{
		NotesIcon_n1 = 0,
		NotesIcon_n2 = 1,
		NotesIcon_a1 = 2,
		NotesIcon_a2 = 3,
	}

	internal enum eJudgeMessageDisplayType
	{
		Default = 0,
		UpperBlind = 1,
		LowerBlind = 2,
		Upper = 3,
		Center = 4,
		Lower = 5,
		SpecifiedPosition = 6,
		Hide = 7,
	}

	internal enum eLayerId
	{
		Selected1 = 0,
		Selected2 = 1,
		Selected3 = 2,
		Selected4 = 3,
		Tab1Body = 4,
		Tab2Body = 5,
		Tab3Body = 6,
		Tab4Body = 7,
		Tab1BodyActive = 8,
		Tab2BodyActive = 9,
		Tab3BodyActive = 10,
		Tab4BodyActive = 11,
		RootSeed = 12,
		ROOT_PREVIEW = 13,
		ROOT_SPEED_MANUAL = 14,
		ROOT_SPEED_EASY = 15,
		ROOT_SPEED_AUTO = 16,
		ROOT_SPEED_MANUAL_LOCK = 17,
		ROOT_MUSIC_SYNC = 18,
		RootJudgeMessagePositionY = 19,
		RootComboMessagePositionY = 20,
		RootTab1Scroll = 21,
		RootTab2Scroll = 22,
		LockSudden = 23,
		LockHidden = 24,
	}

	internal enum eRadioButtonId
	{
		Sudden = 0,
		Hidden = 1,
		RandomMirror = 2,
		RandomLine = 3,
		RandomOuter = 4,
		SeparateLine = 5,
		Rhythmbeat = 6,
		NotesConnection = 7,
		Animation = 8,
		PlayGuide = 9,
		Highaccuracy = 10,
		Tapaccuracy = 11,
		Expert = 12,
		MusicSync = 13,
		BackgroundMovie = 14,
	}

	internal enum eSelectedId
	{
		Tab1 = 0,
		Tab2 = 1,
		Tab3 = 2,
		Tab4 = 3,
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
		LaneBright = 7,
		JudgeMessagePositionY = 8,
		ComboMessagePositionY = 9,
	}

	internal enum eTabId
	{
		Tab1 = 0,
		Tab2 = 1,
		Tab3 = 2,
		Tab4 = 3,
	}

	private enum eTextId
	{
		Tab1Label = 0,
		Tab2Label = 1,
		Tab3Label = 2,
		Tab4Label = 3,
		SpeedLabel = 4,
		SuddenLabel = 5,
		HiddenLabel = 6,
		RandomMirrorLabel = 7,
		RandomLineLabel = 8,
		RandomOuterLabel = 9,
		LayoutLabel = 10,
		NotesTapLabel = 11,
		SeparateLineLabel = 12,
		RhythmbeatLabel = 13,
		NotesConnectionLabel = 14,
		MusicTimingLabel = 15,
		TapTimingLabel = 16,
		TapTimingAutoLabel = 17,
		AnimationLabel = 18,
		PlayGuaideLabel = 19,
		HighaccuracyLabel = 20,
		TapaccuracyLabel = 21,
		ExpertLabel = 22,
		MusicSyncLabel = 23,
		NoteSkinLabel = 24,
		LaneBrightLabel = 25,
		BackgroundMovieLabel = 26,
		JudgeMessagePositionLabel = 27,
		JudgeMessagePositionYLabel = 28,
		ComboMessagePositionLabel = 29,
		ComboMessagePositionYLabel = 30,
		FastSlowMessagePositionLabel = 31,
		HelpText = 32,
		TEXT_BPM = 33,
		TEXT_RATIO = 34,
		TEXT_SPEED = 35,
	}

	internal class SetupParam
	{
		public float speed; //Field offset: 0x8
		public int speed_level_easy; //Field offset: 0xC
		public int speed_auto; //Field offset: 0x10
		public int speed_type; //Field offset: 0x14
		public float sudden; //Field offset: 0x18
		public float hidden; //Field offset: 0x1C
		public float music_timing; //Field offset: 0x20
		public float tap_timing; //Field offset: 0x24
		public int noteSound; //Field offset: 0x28
		public int noteSkin; //Field offset: 0x2C
		public int laneBright; //Field offset: 0x30
		public bool rhythmGuide; //Field offset: 0x34
		public bool characterAnimation; //Field offset: 0x35
		public bool playGuide; //Field offset: 0x36
		public bool separateLine; //Field offset: 0x37
		public bool enable_mirror; //Field offset: 0x38
		public bool enable_random; //Field offset: 0x39
		public bool enable_outer_random; //Field offset: 0x3A
		public int judge_message_display_type; //Field offset: 0x3C
		public int judge_message_position_y; //Field offset: 0x40
		public int combo_message_display_type; //Field offset: 0x44
		public int combo_message_position_y; //Field offset: 0x48
		public int fast_slow_message_display_type; //Field offset: 0x4C
		public int layoutType; //Field offset: 0x50
		public bool enable_sudden; //Field offset: 0x54
		public bool enable_hidden; //Field offset: 0x55
		public bool enable_rhythmbeat; //Field offset: 0x56
		public bool enable_notes_connection; //Field offset: 0x57
		public bool enable_highaccuracy; //Field offset: 0x58
		public bool enable_tapaccuracy; //Field offset: 0x59
		public bool enable_expert; //Field offset: 0x5A
		public bool enable_music_sync; //Field offset: 0x5B
		public bool enable_background_movie; //Field offset: 0x5C

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
	private Dictionary<Int32, UIWrapperButton> m_ButtonDic; //Field offset: 0x188
	private RectTransform m_SpeedLayoutRect; //Field offset: 0x18C
	private VerticalLayoutGroup m_ColumnLayoutGroup; //Field offset: 0x190
	private float m_SpeedManualBuf; //Field offset: 0x194
	private Dictionary<String, AtlasImage> m_NotePreviewIcons; //Field offset: 0x198
	private ScrollRect m_ScrollRect; //Field offset: 0x19C

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

	private static SettingKaguraDisp() { }

	public SettingKaguraDisp() { }

	[CompilerGenerated]
	private void <Setup>b__41_0(int _id, int _value) { }

	[AsyncStateMachine(typeof(<<UpdateRectSpeedType>b__70_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <UpdateRectSpeedType>b__70_0() { }

	public void CallbackInitLayout() { }

	public virtual void CallbackSelect(int button_id, BaseEventData _data) { }

	public virtual void Create(LayerBase parent_layer) { }

	public float CulcSpeedForLevel(int _level) { }

	public float CulcSpeedRate(float _speed) { }

	public GameObject get_RootPreview() { }

	public int get_TabCount() { }

	public GameObject get_TapTimingButton() { }

	private List<String> GetComboMessageDisplayTypeOptions() { }

	private List<String> GetFastSlowMessageDisplayTypeOptions() { }

	private List<String> GetJudgeMessageDisplayTypeOptions() { }

	public virtual void ImmediateOpen(bool visible) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	protected virtual void OnChangeDropdownValue(int _id, int _value) { }

	protected virtual void OnChangeSliderValue(int _id, float _value, int _decimal) { }

	protected virtual void OnClickButton(int _id) { }

	protected virtual void OnSelected(BaseEventData _data) { }

	public virtual void ReleaseAll() { }

	public List<GameObject> SelectedList() { }

	private void SetLayoutOptions() { }

	public void SetTapTiming(float _value) { }

	public void Setup(SetupParam _param) { }

	private void SetupeColumnId(GameObject _obj, eButtonId _id) { }

	private void SetupLabel() { }

	public void UpdateComboMessageDisplayTypeDropdownValue(int _value) { }

	public void UpdateDisp(WorldStageModel stageModel) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateJudgeMessageDisplayTypeDropdownValue(int _value) { }

	public void UpdateNoteSkinDropdownValue(int _value) { }

	public void UpdateNoteSkinPreview(int _id) { }

	private void UpdateRectSpeedType(int _type) { }

	private void UpdateScrollPos(bool top = true) { }

	private void UpdateSelectedComboMessageType(int _type) { }

	private void UpdateSelectedJudgeMessageType(int _type) { }

	private void UpdateSelectedSpeedType(int _type) { }

	public void UpdateSpeedDropdownValue(int _value) { }

	public void UpdateSpeedText(float _speed) { }

	public void UpdateSpeedText(float _rate, int _speed) { }

	public void UpdateSpeedTextLevel(int _level) { }

}


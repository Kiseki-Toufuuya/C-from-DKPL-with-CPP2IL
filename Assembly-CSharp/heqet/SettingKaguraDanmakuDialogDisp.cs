namespace Heqet;

public class SettingKaguraDanmakuDialogDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, String> <>9__59_0; //Field offset: 0x4
		public static Func<Selectable, Selectable> <>9__108_0; //Field offset: 0x8
		public static Func<Selectable, Selectable> <>9__108_1; //Field offset: 0xC
		public static Func<Selectable, Selectable> <>9__108_2; //Field offset: 0x10
		public static Func<Selectable, Selectable> <>9__108_3; //Field offset: 0x14
		public static Func<Selectable, GameObject, Boolean> <>9__109_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal string <InitUguiOther>b__59_0(string _label) { }

		internal bool <ResolveNavigationTarget>b__109_0(Selectable selectable, GameObject root) { }

		internal Selectable <UpdateNavigation>b__108_0(Selectable s) { }

		internal Selectable <UpdateNavigation>b__108_1(Selectable s) { }

		internal Selectable <UpdateNavigation>b__108_2(Selectable s) { }

		internal Selectable <UpdateNavigation>b__108_3(Selectable s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass83_0
	{
		public SettingKaguraDanmakuDialogDisp <>4__this; //Field offset: 0x8
		public int _id; //Field offset: 0xC

		public <>c__DisplayClass83_0() { }

		internal void <AddSalider>b__0(float _value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass86_0
	{
		public SettingKaguraDanmakuDialogDisp <>4__this; //Field offset: 0x8
		public int _id; //Field offset: 0xC

		public <>c__DisplayClass86_0() { }

		internal void <AddDropdown>b__0(int _value) { }

		internal void <AddDropdown>b__1(BaseEventData _data) { }

		internal void <AddDropdown>b__2(BaseEventData _data) { }

	}

	[CompilerGenerated]
	private sealed class <DropDownClose>d__68 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SettingKaguraDanmakuDialogDisp <>4__this; //Field offset: 0x10

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <DropDownClose>d__68(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <Open>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public SettingKaguraDanmakuDialogDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		SUBMIT = 0,
		CANCEL = 1,
		RESET = 2,
		TIMING_AUTO = 3,
		SPEED_SUB = 4,
		SPEED_SUB_DEC = 5,
		SPEED_SUB_DEC2 = 6,
		SPEED_ADD_DEC2 = 7,
		SPEED_ADD_DEC = 8,
		SPEED_ADD = 9,
		SUDDEN_SUB = 10,
		SUDDEN_SUB_DEC = 11,
		SUDDEN_ADD_DEC = 12,
		SUDDEN_ADD = 13,
		HIDDEN_SUB = 14,
		HIDDEN_SUB_DEC = 15,
		HIDDEN_ADD_DEC = 16,
		HIDDEN_ADD = 17,
		SPEED_EASY_SUB_TEN = 18,
		SPEED_EASY_SUB = 19,
		SPEED_EASY_ADD = 20,
		SPEED_EASY_ADD_TEN = 21,
		SPEED_AUTO_SUB_100 = 22,
		SPEED_AUTO_SUB_10 = 23,
		SPEED_AUTO_SUB = 24,
		SPEED_AUTO_ADD = 25,
		SPEED_AUTO_ADD_10 = 26,
		SPEED_AUTO_ADD_100 = 27,
		MUSIC_TIMING_SUB_100 = 28,
		MUSIC_TIMING_SUB_10 = 29,
		MUSIC_TIMING_SUB = 30,
		MUSIC_TIMING_ADD = 31,
		MUSIC_TIMING_ADD_10 = 32,
		MUSIC_TIMING_ADD_100 = 33,
		TAP_TIMING_SUB_100 = 34,
		TAP_TIMING_SUB_10 = 35,
		TAP_TIMING_SUB = 36,
		TAP_TIMING_ADD = 37,
		TAP_TIMING_ADD_10 = 38,
		TAP_TIMING_ADD_100 = 39,
		LANE_BRIGHT_SUB_10 = 40,
		LANE_BRIGHT_SUB = 41,
		LANE_BRIGHT_ADD = 42,
		LANE_BRIGHT_ADD_10 = 43,
		BACKGROUND_MOVIE_ON = 44,
		BACKGROUND_MOVIE_OFF = 45,
		RANDOM_MIRROR_ON = 46,
		RANDOM_MIRROR_OFF = 47,
		RANDOM_LINE_ON = 48,
		RANDOM_LINE_OFF = 49,
		RANDOM_OUTER_ON = 50,
		RANDOM_OUTER_OFF = 51,
		SUDDEN_RADIO_ON = 52,
		SUDDEN_RADIO_OFF = 53,
		HIDDEN_RADIO_ON = 54,
		HIDDEN_RADIO_OFF = 55,
		NOTES_CONNECTION_ON = 56,
		NOTES_CONNECTION_OFF = 57,
		MUSIC_SYNC_ON = 58,
		MUSIC_SYNC_OFF = 59,
		INDIVIDUAL_RESET = 60,
		RESET_NOTESPEED = 61,
		RESET_SUDDEN = 62,
		RESET_HIDDEN = 63,
		RESET_MUSICTIMING = 64,
		RESET_TAPTIMING = 65,
		RESET_LANEBRIGHT = 66,
		RESET_TAPSE = 67,
		RESET_NOTESCONNECTION = 68,
		RESET_MUSICSYNC = 69,
		RESET_BACKGROUND_MOVIE = 70,
	}

	internal enum eDropdownId
	{
		SPEED_TYPE = 0,
		NOTES_TAP = 1,
		LAYOUT = 2,
		AUTO_PLAY = 3,
	}

	internal enum eImageId
	{
		RANDOM_MIRROR_ON = 0,
		RANDOM_MIRROR_OFF = 1,
		RANDOM_LINE_ON = 2,
		RANDOM_LINE_OFF = 3,
		RANDOM_OUTER_ON = 4,
		RANDOM_OUTER_OFF = 5,
		SUDDEN_RADIO_ON = 6,
		SUDDEN_RADIO_OFF = 7,
		HIDDEN_RADIO_ON = 8,
		HIDDEN_RADIO_OFF = 9,
		NOTES_CONNECTION_RADIO_ON = 10,
		NOTES_CONNECTION_RADIO_OFF = 11,
		MUSIC_SYNC_RADIO_ON = 12,
		MUSIC_SYNC_RADIO_OFF = 13,
		BACKGROUND_MOVIE_ON = 14,
		BACKGROUND_MOVIE_OFF = 15,
	}

	internal enum eLayerId
	{
		ROOT_AUTOPLAY = 0,
		ROOT_LAYOUT = 1,
		DROPDOWN_SPEED_TYPE = 2,
		DROPDOWN_NOTES_TAP = 3,
		DROPDOWN_LAYOUT = 4,
		DROPDOWN_AUTO_PLAY = 5,
		SLIDER_SPEED_MANUAL = 6,
		SLIDER_SPEED_EASY = 7,
		SLIDER_SPEED_AUTO = 8,
		SLIDER_SUDDEN = 9,
		SLIDER_HIDDEN = 10,
		SLIDER_MUSIC_TIMING = 11,
		SLIDER_TAP_TIMING = 12,
		SLIDER_LANE_BRIGHT = 13,
		LOCK_SPEED = 14,
		LOCK_SUDDEN = 15,
		LOCK_HIDDEN = 16,
		ROOT_PREVIEW = 17,
		ROOT_SLIDER_SPEED_MANUAL = 18,
		ROOT_SLIDER_SPEED_EASY = 19,
		ROOT_SLIDER_SPEED_AUTO = 20,
		ROOT_SLIDER_SPEED_MANUAL_LOCK = 21,
		ROOT_SPEED = 22,
		ROOT_SCROLL = 23,
		RANDOM_MIRROR_RADIO = 24,
		RANDOM_LINE_RADIO = 25,
		RANDOM_OUTER_RADIO = 26,
		SUDDEN_RADIO = 27,
		HIDDEN_RADIO = 28,
		ROOT_NOTES_CONNECTION_RADIO = 29,
		ROOT_MUSIC_SYNC_RADIO = 30,
		ROOT_BACKGROUND_MOVIE_RADIO = 31,
		ROOT_RADOM_OUTER_LOCK = 32,
		ROOT_NOTES_CONNECTION = 33,
		ROOT_MUSIC_SYNC = 34,
		ROOT_BACKGROUND_MOVIE = 35,
		ROOT_MUSIC_TIMING_BG = 36,
		ROOT_TAP_TIMING_BG = 37,
		ROOT_MUSIC_SYNC_BG = 38,
		ROOT_LANE_BRIGHT_BG = 39,
		ROOT_BACKGROUND_MOVIE_BG = 40,
		ROOT_NOTE_TAP_BG = 41,
		ROOT_LAYOUT_BG = 42,
		ROOT_NOTES_CONNECTION_BG = 43,
	}

	internal enum eRadioButtonId
	{
		RandomMirror = 0,
		RandomLine = 1,
		RandomOuter = 2,
		SUDDEN = 3,
		HIDDEN = 4,
		NOTES_CONNECTION = 5,
		MUSIC_SYNC = 6,
		BACKGROUND_MOVIE = 7,
	}

	internal enum eSliderId
	{
		SPEED_MANUAL = 0,
		SPEED_EASY = 1,
		SPEED_AUTO = 2,
		SUDDEN = 3,
		HIDDEN = 4,
		MUSIC_TIMING = 5,
		TAP_TIMING = 6,
		LANE_BRIGHT = 7,
	}

	private enum eTextId
	{
		TXT_TITLE = 0,
		TXT_BUTTON_SUBMIT = 1,
		TXT_BUTTON_CANCEL = 2,
		TXT_BUTTON_RESET = 3,
		TXT_LABEL_SPEED = 4,
		TXT_LABEL_SUDDEN = 5,
		TXT_LABEL_HIDDEN = 6,
		TXT_LABEL_NOTES_TAP = 7,
		TXT_LABEL_NOTES_SKIN = 8,
		TXT_LABEL_AUTOPLAY = 9,
		TXT_LABEL_MUSIC_TIMING = 10,
		TXT_LABEL_TAP_TIMING = 11,
		TXT_LABEL_TAP_AUTO_SETTING = 12,
		TXT_LABEL_LANE_BRIGHT = 13,
		TXT_LABEL_BACKGROUND_MOIVE = 14,
		TXT_LABEL_LAYOUT = 15,
		TXT_LABEL_NOTES_CONNECTION = 16,
		TXT_LABEL_MUSIC_SYNC = 17,
		SLIDER_COUNT_SPEED_MANUAL = 18,
		SLIDER_COUNT_SPEED_EASY = 19,
		SLIDER_COUNT_SPEED_AUTO = 20,
		SLIDER_COUNT_SUDDEN = 21,
		SLIDER_COUNT_HIDDEN = 22,
		SLIDER_COUNT_MUSIC_TIMING = 23,
		SLIDER_COUNT_TAP_TIMING = 24,
		SLIDER_COUNT_LANE_BRIGHT = 25,
		TEXT_BPM = 26,
		TEXT_RATIO = 27,
		TEXT_SPEED = 28,
		TXT_LABEL_RANDOM_MIRROR = 29,
		TXT_LABEL_RANDOM_LINE = 30,
		TXT_LABEL_RANDOM_OUTER = 31,
		TXT_HELP = 32,
	}

	internal class Param
	{
		public int musicId; //Field offset: 0x8
		public int speed_type; //Field offset: 0xC
		public float speed; //Field offset: 0x10
		public int speed_level; //Field offset: 0x14
		public int speed_auto; //Field offset: 0x18
		public float sudden; //Field offset: 0x1C
		public float hidden; //Field offset: 0x20
		public int notestap; //Field offset: 0x24
		public bool auteplay; //Field offset: 0x28
		public float gimmickSpeed; //Field offset: 0x2C
		public float currentSpeed; //Field offset: 0x30
		public int notes_skin_id; //Field offset: 0x34
		public bool enable_random_mirror; //Field offset: 0x38
		public bool enable_random_line; //Field offset: 0x39
		public bool enable_random_outer; //Field offset: 0x3A
		public bool enable_sudden; //Field offset: 0x3B
		public bool enable_hidden; //Field offset: 0x3C
		public int layout; //Field offset: 0x40
		public int music_timing; //Field offset: 0x44
		public int notes_tap_timing; //Field offset: 0x48
		public int lane_bright; //Field offset: 0x4C
		public bool enable_notes_connection; //Field offset: 0x50
		public bool enable_music_sync; //Field offset: 0x51
		public bool enable_background_movie; //Field offset: 0x52

		public Param() { }

		public Param(Param _param) { }

	}

	internal class RadioButomWork
	{
		[CompilerGenerated]
		private Sprite <TextureOn>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Sprite <TextureOff>k__BackingField; //Field offset: 0xC
		public List<AtlasImage> Images; //Field offset: 0x10

		public private Sprite TextureOff
		{
			[CompilerGenerated]
			private get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public private Sprite TextureOn
		{
			[CompilerGenerated]
			private get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public RadioButomWork() { }

		[CompilerGenerated]
		private Sprite get_TextureOff() { }

		[CompilerGenerated]
		private Sprite get_TextureOn() { }

		[CompilerGenerated]
		public void set_TextureOff(Sprite value) { }

		[CompilerGenerated]
		public void set_TextureOn(Sprite value) { }

		public void UpdateParam(int _index) { }

	}

	internal class ResetButton
	{
		public Transform on; //Field offset: 0x8
		public Transform off; //Field offset: 0xC

		public ResetButton(Transform buttonRoot) { }

		public void SetEdited(bool isEdited) { }

	}

	private static readonly String[] m_LayerList; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x4
	private static readonly String[] m_ImageList; //Field offset: 0x8
	private static readonly ValueTuple<Int32, eResetCategory>[] ButtonCategoryPair; //Field offset: 0xC
	private Dictionary<Int32, ResetButton> m_resetButtons; //Field offset: 0x114
	private readonly String[] m_ButtonDataList; //Field offset: 0x118
	[CompilerGenerated]
	private Action<Int32> <OnClickButtonCallback>k__BackingField; //Field offset: 0x11C
	[CompilerGenerated]
	private Action<Int32, Single> <OnChangeSliderValueCallback>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private Action<Int32, Int32> <OnChangeDropdownValueCallback>k__BackingField; //Field offset: 0x124
	private bool m_isChangeValue; //Field offset: 0x128
	public Action OnChangeValue; //Field offset: 0x12C
	private Animator m_RootAnimator; //Field offset: 0x130
	private CriAtomExPlayback m_SliderSeHandle; //Field offset: 0x134
	private IEnumerator m_DropdownCloseHandle; //Field offset: 0x138
	private RectTransform m_SpeedLayoutRect; //Field offset: 0x13C
	private VerticalLayoutGroup m_ColumnLayoutGroup; //Field offset: 0x140
	protected Dictionary<Int32, RadioButomWork> m_RadioButtonDic; //Field offset: 0x144
	protected Dictionary<Int32, Slider> m_SliderDic; //Field offset: 0x148
	protected Dictionary<Int32, UIWrapperTextMeshPro> m_SliderTextDic; //Field offset: 0x14C
	protected Dictionary<Int32, TMP_Dropdown> m_DropdownDic; //Field offset: 0x150
	protected Dictionary<Int32, UIWrapperButton> m_ButtonDic; //Field offset: 0x154
	private Dictionary<GameObject, String> m_Selectables; //Field offset: 0x158
	private ScrollRect m_ScrollRect; //Field offset: 0x15C
	private List<Single> m_Bpms; //Field offset: 0x160
	private float m_baseBpm; //Field offset: 0x164
	private string m_dispBpm; //Field offset: 0x168
	private bool m_HideBmp; //Field offset: 0x16C
	private Param m_Param; //Field offset: 0x170

	public float GetBpm
	{
		 get { } //Length: 14
	}

	public Action<Int32, Int32> OnChangeDropdownValueCallback
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Action<Int32, Single> OnChangeSliderValueCallback
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action<Int32> OnClickButtonCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public GameObject RootPreview
	{
		 get { } //Length: 32
	}

	public GameObject SelectedGameObject
	{
		 get { } //Length: 76
	}

	public Param SettingParam
	{
		 get { } //Length: 14
	}

	private static SettingKaguraDanmakuDialogDisp() { }

	public SettingKaguraDanmakuDialogDisp() { }

	[CompilerGenerated]
	private bool <Open>b__69_0() { }

	[CompilerGenerated]
	private bool <SetupHiddenButton>b__96_0(GameObject gameObject) { }

	[CompilerGenerated]
	private void <SetupParam>b__74_0(int _id, int _value) { }

	[CompilerGenerated]
	private bool <SetupSuddenButton>b__95_0(GameObject gameObject) { }

	protected void AddDropdown(int _id, int _dropdownId) { }

	protected void AddSalider(int _id, int _sliderId, int _textId) { }

	private void AddSliderValue(eSliderId _id, float _value) { }

	public void CallbackButton(int _id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public float CulcSpeedRate(float _speed) { }

	public float CulcSpeedRateForLevel(int _level) { }

	public void DisableBackgroundMovieColumn() { }

	public void DispAutoPlayColumn(bool _value) { }

	[IteratorStateMachine(typeof(<DropDownClose>d__68))]
	private IEnumerator DropDownClose() { }

	public float get_GetBpm() { }

	[CompilerGenerated]
	protected Action<Int32, Int32> get_OnChangeDropdownValueCallback() { }

	[CompilerGenerated]
	protected Action<Int32, Single> get_OnChangeSliderValueCallback() { }

	[CompilerGenerated]
	private Action<Int32> get_OnClickButtonCallback() { }

	public GameObject get_RootPreview() { }

	public GameObject get_SelectedGameObject() { }

	public Param get_SettingParam() { }

	private eResetCategory GetButtonIdToCategory(int buttonId) { }

	private int GetCategoryToButton(eResetCategory category) { }

	public eResetCategory GetResetCategory(GameObject targetGameObject) { }

	private string GetSpeedString() { }

	private string GetSpeedStringEasy() { }

	private string GetSpeedStringRate(float _speed) { }

	protected virtual void InitUguiOther() { }

	public void InitUpdateBefore() { }

	protected virtual void LateUpdate() { }

	private void OnCangeSliderValue(int _id, float _value) { }

	private void OnChangeDropdownValue(int _id, int _value) { }

	private void OnSelected(BaseEventData _data) { }

	private void OnSelectedDropdown(BaseEventData _data) { }

	[AsyncStateMachine(typeof(<Open>d__69))]
	public UniTask Open(bool visible) { }

	protected void RegistRadioButton(int _id, int _radioButtonId, int _imageId) { }

	public virtual void ReleaseAll() { }

	private static Selectable ResolveNavigationTarget(Selectable candidate, Func<Selectable, Selectable> nextSelector, GameObject root) { }

	private void ScrollToSelected(GameObject selected, float scrollStep = 0.1) { }

	[CompilerGenerated]
	public void set_OnChangeDropdownValueCallback(Action<Int32, Int32> value) { }

	[CompilerGenerated]
	public void set_OnChangeSliderValueCallback(Action<Int32, Single> value) { }

	[CompilerGenerated]
	public void set_OnClickButtonCallback(Action<Int32> value) { }

	public void SetHideBpm(bool _enable) { }

	private float SetSliderValueWithoutNotify(int _id, float _value, int _dec) { }

	public void SetTapTiming(float _value) { }

	protected void SetupAutoplayOptions() { }

	private void SetupHiddenButton(GameObject targetObject) { }

	protected void SetupLayoutOptions() { }

	protected void SetupNotesTapOptions() { }

	public void SetupParam(Param _param) { }

	protected void SetupSpeedTypeOptions() { }

	private void SetupSuddenButton(GameObject targetObject) { }

	public void UpdateDanmakuRowBg() { }

	protected virtual void UpdateDispMain() { }

	private void UpdateDropdownValue(int _id, int _value) { }

	private void UpdateHelpText(GameObject selected = null) { }

	public void UpdateIndividualButton(eResetCategory category, bool isEdited) { }

	public Navigation UpdateNavigation(Navigation navigation) { }

	public void UpdateRadioButtonValue(int _id, int _index) { }

	public void UpdateRandomOuterLock() { }

	private void UpdateRectSpeedType(int _type) { }

	private void UpdateScrollPos(float value = 1) { }

	private void UpdateSelectedSpeedType(int _type) { }

	private void UpdateSliderValue(int _id, float _value) { }

	private void UpdateSliderValueWithoutNotify(int _id, float _value, int _dec) { }

	private void UpdateSpeedType(int _value) { }

	public void UpdateTitleLabel(ref string _label) { }

	public void UpdateUnableLayoutAndNoetsConnection() { }

	public void UpdateUnableRandom() { }

}


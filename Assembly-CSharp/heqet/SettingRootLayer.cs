namespace Heqet;

public class SettingRootLayer : LayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__48_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingRootLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__48_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingRootLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__48_2>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingRootLayer <>4__this; //Field offset: 0x8
		private GameObject <selectedObj>5__2; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10
		private Awaiter <>u__2; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__48_3>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingRootLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__48_4>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingRootLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<DispBase> <>9__40_0; //Field offset: 0x4
		public static Action<LayerBase> <>9__54_0; //Field offset: 0x8
		public static Action <>9__68_2; //Field offset: 0xC
		public static Action <>9__68_3; //Field offset: 0x10
		public static Action <>9__69_2; //Field offset: 0x14
		public static Action <>9__69_3; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <InitAll>b__40_0(DispBase _disp) { }

		internal void <OnClickHelpButton>b__54_0(LayerBase _layer) { }

		internal void <OpenCheckCancelDialog>b__68_2() { }

		internal void <OpenCheckCancelDialog>b__68_3() { }

		internal void <OpenResetDialog>b__69_2() { }

		internal void <OpenResetDialog>b__69_3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public string tag; //Field offset: 0x8
		public GameObject selectedObj; //Field offset: 0xC
		public eMainStep next; //Field offset: 0x10
		public Action<ButtonType> <>9__1; //Field offset: 0x14

		public <>c__DisplayClass68_0() { }

		internal void <OpenCheckCancelDialog>b__0() { }

		internal void <OpenCheckCancelDialog>b__1(ButtonType btnId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public SettingRootLayer <>4__this; //Field offset: 0x8
		public GameObject selectedObj; //Field offset: 0xC
		public Action<ButtonType> <>9__1; //Field offset: 0x10

		public <>c__DisplayClass69_0() { }

		internal void <OpenResetDialog>b__0() { }

		internal void <OpenResetDialog>b__1(ButtonType btnId) { }

	}

	[CompilerGenerated]
	private struct <OpenCheckCancelDialog>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingRootLayer <>4__this; //Field offset: 0xC
		private <>c__DisplayClass68_0 <>8__1; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenResetDialog>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingRootLayer <>4__this; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TaskChangeDisp>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingRootLayer <>4__this; //Field offset: 0x8
		public eCategoryType nextType; //Field offset: 0xC
		private GameObject <currentObject>5__2; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eCategoryType
	{
		kagura = 0,
		Danmaku = 1,
		Sound = 2,
		Other = 3,
		Keyconfig = 4,
	}

	private enum eContStep
	{
		MAIN = 0,
		PREVIEW = 1,
		NONE = 2,
	}

	private enum eMainStep
	{
		ENTRY = 0,
		OPEN = 1,
		OPENING = 2,
		MAIN = 3,
		CLOSE = 4,
		CLOSEING = 5,
		START_CHANGE_DISP = 6,
		CHECK_CANCEL_DIALOG = 7,
		WAIT_CANCEL_DIALOG = 8,
		CHECK_SAVE_DIALOG = 9,
		WAIT_SAVE_DIALOG = 10,
		SAVING = 11,
		WAIT_SYSTEM_ERROR_DIALOG = 12,
		HELP_DIALOG = 13,
		OPEN_DROPDOWN = 14,
		CLOSE_DROPDOWN = 15,
		CHECK_RESET_DIALOG = 16,
		WAIT_RESET_DIALOG = 17,
		NONE = 18,
	}

	private SettingBase m_Current; //Field offset: 0x58
	private SettingBase m_Prev; //Field offset: 0x5C
	private SettingHeaderDisp m_headerDisp; //Field offset: 0x60
	private SettingHelpBarDisp m_helpbarDisp; //Field offset: 0x64
	private SettingPreviewDisp m_SettingPreviewDisp; //Field offset: 0x68
	private SettingAutoTimingDisp m_SettingAutoTimingDisp; //Field offset: 0x6C
	private SettingKeyconfigPreviewDisp m_KeyconfigPreviewDisp; //Field offset: 0x70
	private LicenseUIDisp m_LicenseUIDisp; //Field offset: 0x74
	private SettingKaguraDisp m_kaguraDisp; //Field offset: 0x78
	private SettingDanmakuDisp m_danmakuDisp; //Field offset: 0x7C
	private SettingSoundDisp m_soundDisp; //Field offset: 0x80
	private SettingOtherDisp m_otherDisp; //Field offset: 0x84
	private SettingKeyConfigDisp m_keyconfigDisp; //Field offset: 0x88
	private SettingKagura m_SettingKagura; //Field offset: 0x8C
	private SettingDanmaku m_SettingDanmaku; //Field offset: 0x90
	private SettingSound m_SettingSound; //Field offset: 0x94
	private SettingOther m_SettingOther; //Field offset: 0x98
	private SettingKeyconfig m_SettingKeyconfig; //Field offset: 0x9C
	private readonly string SAVE_DIALOG_TAG; //Field offset: 0xA0
	private readonly string RESET_DIALOG_TAG; //Field offset: 0xA4
	private bool IsOpenDropDown; //Field offset: 0xA8
	private bool IsCloseDropDown; //Field offset: 0xA9
	private bool IsOpenAutoTimingWindow; //Field offset: 0xAA
	private eMainStep m_MainStep; //Field offset: 0xAC
	private eContStep m_ContStep; //Field offset: 0xB0
	private eCategoryType m_currentCategoryType; //Field offset: 0xB4
	private InputActionReference m_inputActionTabLeft; //Field offset: 0xB8
	private InputActionReference m_inputActionTabRight; //Field offset: 0xBC

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public SettingRootLayer() { }

	[CompilerGenerated]
	private void <InitAll>b__40_1(int button_id) { }

	[CompilerGenerated]
	private void <InitAll>b__40_2(int button_id) { }

	[AsyncStateMachine(typeof(<<Update>b__48_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__48_0() { }

	[AsyncStateMachine(typeof(<<Update>b__48_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__48_1() { }

	[AsyncStateMachine(typeof(<<Update>b__48_2>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__48_2() { }

	[AsyncStateMachine(typeof(<<Update>b__48_3>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__48_3() { }

	[AsyncStateMachine(typeof(<<Update>b__48_4>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__48_4() { }

	public void ChangeCategory(eCategoryType nextType) { }

	private void ChangeSelectCategory(eCategoryType _category) { }

	private void ContMain() { }

	public void CreateInit(GalleryTopLayer topLayer) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	private List<String> GetNoteSkinOptions() { }

	private List<String> GetNoteSoundOptions() { }

	private List<String> GetSpeedTypeOptions() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	private bool IsChangeData() { }

	protected virtual void LateUpdate(bool is_active) { }

	private void OnChangeValueDanmakuMusicTiming(float _value) { }

	private void OnChangeValueDanmakuTapTiming(float _value) { }

	private void OnChangeValueKaguraLaneBright(float _value) { }

	private void OnChangeValueKaguraMusicTiming(float _value) { }

	private void OnChangeValueKaguraTapTiming(float _value) { }

	private void OnClickCancelButton() { }

	private void OnClickDecideButton() { }

	private void OnClickHelpButton() { }

	private void OnClickResetButton() { }

	private void OnDispKeyconfigPreview(bool _enable) { }

	private void OnDispLisenceWindow(bool _enable) { }

	private void OnDispTapTimingAutoWindow(bool _enable) { }

	private void OnKeyBind(bool _enable) { }

	private void OnPointerClickDropdown() { }

	private void OnSelectedDropdown() { }

	private void OnUpdateResolution(int _mode, int _width, int _height) { }

	[AsyncStateMachine(typeof(<OpenCheckCancelDialog>d__68))]
	public UniTask OpenCheckCancelDialog() { }

	[AsyncStateMachine(typeof(<OpenResetDialog>d__69))]
	public UniTask OpenResetDialog() { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	private void ResetParam() { }

	private void ResetParamAll() { }

	[AsyncStateMachine(typeof(<TaskChangeDisp>d__52))]
	private UniTaskVoid TaskChangeDisp(eCategoryType nextType) { }

	protected virtual void Update(bool is_active) { }

	private void UpdateInputActionTab() { }

}


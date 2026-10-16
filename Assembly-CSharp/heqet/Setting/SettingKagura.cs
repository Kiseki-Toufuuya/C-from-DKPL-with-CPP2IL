namespace Heqet.Setting;

public class SettingKagura : SettingBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__82_1; //Field offset: 0x4
		public static Action <>9__82_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ExcuteStateDeleteAllMusicUnitSetting>b__82_1() { }

		internal void <ExcuteStateDeleteAllMusicUnitSetting>b__82_2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public ButtonType resultButton; //Field offset: 0x8

		public <>c__DisplayClass82_0() { }

		internal void <ExcuteStateDeleteAllMusicUnitSetting>b__0(ButtonType btnId) { }

	}

	[CompilerGenerated]
	private sealed class <ExcuteStateDeleteAllMusicUnitSetting>d__82 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		private <>c__DisplayClass82_0 <>8__1; //Field offset: 0x10
		public SettingKagura <>4__this; //Field offset: 0x14
		private GameObject <nowSelected>5__2; //Field offset: 0x18

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
		public <ExcuteStateDeleteAllMusicUnitSetting>d__82(int <>1__state) { }

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
	private sealed class <ExcuteStateTimingAuto>d__80 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SettingKagura <>4__this; //Field offset: 0x10

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
		public <ExcuteStateTimingAuto>d__80(int <>1__state) { }

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

	private enum eState
	{
		None = 0,
		TimingAuto = 1,
		DeleteAllMusicUntilSetting = 2,
	}

	private class SaveData
	{
		public SetupParam param; //Field offset: 0x8
		public SetupParam paramBuf; //Field offset: 0xC

		public SaveData() { }

		public bool IsChange() { }

	}

	internal class Setup
	{
		public SettingKaguraDisp SettingKaguraDisp; //Field offset: 0x8
		public SettingHeaderDisp SettingHeaderDisp; //Field offset: 0xC
		public SettingPreviewDisp SettingPreviewDisp; //Field offset: 0x10
		public SettingAutoTimingDisp SettingAutoTimingDisp; //Field offset: 0x14

		public Setup() { }

	}

	private const string ROOT_HEARDER_KAGURA = "root/header/btn_kagura"; //Field offset: 0x0
	private SettingKaguraDisp m_Disp; //Field offset: 0x20
	private SettingHeaderDisp m_HeaderDisp; //Field offset: 0x24
	private SettingPreviewDisp m_SettingPreviewDisp; //Field offset: 0x28
	private SettingAutoTimingDisp m_SettingAutoTimingDisp; //Field offset: 0x2C
	private float m_PositionRateX; //Field offset: 0x30
	private float m_PositionRateY; //Field offset: 0x34
	private float m_SuddenBuf; //Field offset: 0x38
	private float m_HiddenBuf; //Field offset: 0x3C
	private ExcuteStateCooutine<eState> m_StateLoop; //Field offset: 0x40
	[CompilerGenerated]
	private Action<Boolean> <OnDispTapTimingAutoCallback>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private Action<Single> <OnChangeTimingValueCallback>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Action<Single> <OnChangeMusicTimingValueCallback>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private Action<Single> <OnChangeLaneBrightValueCallback>k__BackingField; //Field offset: 0x50
	private SaveData m_SaveData; //Field offset: 0x54

	public private Action<Single> OnChangeLaneBrightValueCallback
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private Action<Single> OnChangeMusicTimingValueCallback
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private Action<Single> OnChangeTimingValueCallback
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private Action<Boolean> OnDispTapTimingAutoCallback
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public SettingKagura(Setup _param) { }

	private void ComboMessageDisplayTypeValueChange(int _value) { }

	[IteratorStateMachine(typeof(<ExcuteStateDeleteAllMusicUnitSetting>d__82))]
	private IEnumerator ExcuteStateDeleteAllMusicUnitSetting() { }

	[IteratorStateMachine(typeof(<ExcuteStateTimingAuto>d__80))]
	private IEnumerator ExcuteStateTimingAuto() { }

	private void FastSlowMessageDisplayTypeValueChange(int _value) { }

	[CompilerGenerated]
	private Action<Single> get_OnChangeLaneBrightValueCallback() { }

	[CompilerGenerated]
	private Action<Single> get_OnChangeMusicTimingValueCallback() { }

	[CompilerGenerated]
	private Action<Single> get_OnChangeTimingValueCallback() { }

	[CompilerGenerated]
	private Action<Boolean> get_OnDispTapTimingAutoCallback() { }

	public virtual int GetTabCount() { }

	public void InitPreview() { }

	public void InitUpdateBefore() { }

	public bool IsChageData() { }

	private void JudgeMessageDisplayTypeValueChange(int _value) { }

	private void LayoutValueChange(int _value) { }

	private void NoteSkinValueChange(int _value) { }

	private void NoteSoundValueChange(int _value) { }

	private void OnChangeDropdownValue(int _id, int _value) { }

	private void OnChangeSliderValue(int _id, float _value) { }

	private void OnPressBackgroundMovie(bool _value) { }

	private void OnPressButton(int _id) { }

	private void OnPressCenterLine(bool _value) { }

	private void OnPressCharacterAnimation(bool _value) { }

	private void OnPressedDeleteAllMusicUnitSettingsButton() { }

	private void OnPressedTapTimingAuto() { }

	private void OnPressExpert(bool _value) { }

	private void OnPressHidden(bool _value) { }

	private void OnPressHighaccuracy(bool _value) { }

	private void OnPressMusicSync(bool _value) { }

	private void OnPressNotesConnection(bool _value) { }

	private void OnPressPlayGuide(bool _value) { }

	private void OnPressRandomLine(bool _value) { }

	private void OnPressRandomMirror(bool _value) { }

	private void OnPressRandomOuter(bool _value) { }

	private void OnPressRhythmbeat(bool _value) { }

	private void OnPressSudden(bool _value) { }

	private void OnPressTapaccuracy(bool _value) { }

	private void OpenCallback(bool _visible) { }

	public virtual void Reset(int _tab) { }

	public void Save() { }

	[CompilerGenerated]
	public void set_OnChangeLaneBrightValueCallback(Action<Single> value) { }

	[CompilerGenerated]
	public void set_OnChangeMusicTimingValueCallback(Action<Single> value) { }

	[CompilerGenerated]
	public void set_OnChangeTimingValueCallback(Action<Single> value) { }

	[CompilerGenerated]
	public void set_OnDispTapTimingAutoCallback(Action<Boolean> value) { }

	private void SetTimingAutoValue(float _value) { }

	public virtual void SetupDisp() { }

	private void SliderComboMessagePositionYValueChange(int _value) { }

	private void SliderHiddenValueChange(float _value) { }

	private void SliderJudgeMessagePositionYValueChange(int _value) { }

	private void SliderLaneBrightValueChange(int _value) { }

	private void SliderMusicTimingValueChange(float _value) { }

	private void SliderSpeedAutoValueChange(int _value) { }

	private void SliderSpeedEasyValueChange(int _value) { }

	private void SliderSpeedManualValueChange(float _value) { }

	private void SliderSuddenValueChange(float _value) { }

	private void SliderTimingValueChange(float _value) { }

	private void SpeedTypeValueChange(int _value) { }

	public virtual void Update() { }

	public void UpdateLaneBrightValue(int _value) { }

	public void UpdateMusicTimingValue(float _value) { }

	private void UpdateTab(int _id) { }

	public void UpdateTapTimingValue(float _value) { }

}


namespace Heqet.Setting;

public class SettingDanmaku : SettingBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__63_1; //Field offset: 0x4
		public static Action <>9__63_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ExcuteStateDeleteAllMusicUnitSetting>b__63_1() { }

		internal void <ExcuteStateDeleteAllMusicUnitSetting>b__63_2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public ButtonType resultButton; //Field offset: 0x8

		public <>c__DisplayClass63_0() { }

		internal void <ExcuteStateDeleteAllMusicUnitSetting>b__0(ButtonType btnId) { }

	}

	[CompilerGenerated]
	private sealed class <ExcuteStateDeleteAllMusicUnitSetting>d__63 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		private <>c__DisplayClass63_0 <>8__1; //Field offset: 0x10
		public SettingDanmaku <>4__this; //Field offset: 0x14
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
		public <ExcuteStateDeleteAllMusicUnitSetting>d__63(int <>1__state) { }

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
	private sealed class <ExcuteStateTimingAuto>d__65 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SettingDanmaku <>4__this; //Field offset: 0x10

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
		public <ExcuteStateTimingAuto>d__65(int <>1__state) { }

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
		public SettingDanmakuDisp SettingDanmakuDisp; //Field offset: 0x8
		public SettingHeaderDisp SettingHeaderDisp; //Field offset: 0xC
		public SettingPreviewDisp SettingPreviewDisp; //Field offset: 0x10
		public SettingAutoTimingDisp SettingAutoTimingDisp; //Field offset: 0x14

		public Setup() { }

	}

	private const string ROOT_HEARDER_DANMAKU = "root/header/btn_danmaku"; //Field offset: 0x0
	private ExcuteStateCooutine<eState> m_StateLoop; //Field offset: 0x20
	private SettingDanmakuDisp m_Disp; //Field offset: 0x24
	private SettingHeaderDisp m_HeaderDisp; //Field offset: 0x28
	private SettingPreviewDisp m_SettingPreviewDisp; //Field offset: 0x2C
	private SettingAutoTimingDisp m_SettingAutoTimingDisp; //Field offset: 0x30
	private float m_SuddenBuf; //Field offset: 0x34
	private float m_HiddenBuf; //Field offset: 0x38
	[CompilerGenerated]
	private Action<Boolean> <OnDispTapTimingAutoCallback>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private Action<Single> <OnChangeTapTimingValueCallback>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Action<Single> <OnChangeMusicTimingValueCallback>k__BackingField; //Field offset: 0x44
	private SaveData m_SaveData; //Field offset: 0x48

	public private Action<Single> OnChangeMusicTimingValueCallback
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private Action<Single> OnChangeTapTimingValueCallback
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

	public SettingDanmaku(Setup _param) { }

	[IteratorStateMachine(typeof(<ExcuteStateDeleteAllMusicUnitSetting>d__63))]
	private IEnumerator ExcuteStateDeleteAllMusicUnitSetting() { }

	[IteratorStateMachine(typeof(<ExcuteStateTimingAuto>d__65))]
	private IEnumerator ExcuteStateTimingAuto() { }

	[CompilerGenerated]
	private Action<Single> get_OnChangeMusicTimingValueCallback() { }

	[CompilerGenerated]
	private Action<Single> get_OnChangeTapTimingValueCallback() { }

	[CompilerGenerated]
	private Action<Boolean> get_OnDispTapTimingAutoCallback() { }

	public virtual int GetTabCount() { }

	private void HiddenValueChange(float _value) { }

	public virtual void ImmediateOpen() { }

	public void InitPreview() { }

	public void InitUpdateBefore() { }

	public bool IsChageData() { }

	private void MusicTimingValueChange(float _value) { }

	private void NoteSkinValueChange(int _value) { }

	private void NoteSoundValueChange(int _value) { }

	private void OnChangeDropdownValue(int _id, int _value) { }

	private void OnChangeSliderValue(int _id, float _value) { }

	private void OnClickTab(eTabId _id) { }

	private void OnPressButton(int _id) { }

	private void OnPressDisplayCollision(bool _value) { }

	private void OnPressedDeleteAllMusicUnitSettingsButton() { }

	private void OnPressedTapTimingAuto() { }

	private void OnPressExpert(bool _value) { }

	private void OnPressHidden(bool _value) { }

	private void OnPressHighaccuracy(bool _value) { }

	private void OnPressMusicSync(bool _value) { }

	private void OnPressPlayGuide(bool _value) { }

	private void OnPressRhythmbeat(bool _value) { }

	private void OnPressSudden(bool _value) { }

	private void OnPressTapaccuracy(bool _value) { }

	private void OpenCallback(bool _visible) { }

	private void PlayerBulletOpacityValueChange(float _value) { }

	public virtual void Reset(int _tab) { }

	public void Save() { }

	[CompilerGenerated]
	public void set_OnChangeMusicTimingValueCallback(Action<Single> value) { }

	[CompilerGenerated]
	public void set_OnChangeTapTimingValueCallback(Action<Single> value) { }

	[CompilerGenerated]
	public void set_OnDispTapTimingAutoCallback(Action<Boolean> value) { }

	private void SetTimingAutoValue(float _value) { }

	public virtual void SetupDisp() { }

	private void SpeedAutoValueChange(int _value) { }

	private void SpeedLevelValueChange(int _value) { }

	private void SpeedTypeValueChange(int _value) { }

	private void SpeedValueChange(float _value) { }

	private void SuddenValueChange(float _value) { }

	private void TapTimingValueChange(float _value) { }

	public virtual void Update() { }

	public void UpdateMusicTimingValue(float _value) { }

	private void UpdateTab(int _id) { }

	public void UpdateTapTimingValue(float _value) { }

}


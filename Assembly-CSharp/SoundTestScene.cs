//Type is in global namespace

public class SoundTestScene : MainSceneBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<String> <>9__36_0; //Field offset: 0x4
		public static Comparison<String> <>9__37_0; //Field offset: 0x8
		public static Comparison<String> <>9__38_0; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal int <OnTapSe>b__37_0(string a, string b) { }

		internal int <OnTapVO>b__38_0(string a, string b) { }

		internal int <PlayBGM>b__36_0(string a, string b) { }

	}

	[CompilerGenerated]
	private sealed class <CoroutineCheckLatancy>d__40 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SoundTestScene <>4__this; //Field offset: 0x10
		private bool <loop>5__2; //Field offset: 0x14

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
		public <CoroutineCheckLatancy>d__40(int <>1__state) { }

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
	private sealed class <CoroutineLoadCue>d__45 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SoundTestScene <>4__this; //Field offset: 0x10

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
		public <CoroutineLoadCue>d__45(int <>1__state) { }

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

	private static String[] BgmCueSheets; //Field offset: 0x0
	private static String[] SeCueSheets; //Field offset: 0x4
	public static int ForceStopTime; //Field offset: 0x8
	[SerializeField]
	private GameObject PageTopLoading; //Field offset: 0x14
	[SerializeField]
	private GameObject PageTopObj; //Field offset: 0x18
	[SerializeField]
	private GameObject PageCSObj; //Field offset: 0x1C
	[SerializeField]
	private GameObject PlayerObj; //Field offset: 0x20
	[SerializeField]
	private Dropdown DropdownCueSheets; //Field offset: 0x24
	[SerializeField]
	private Dropdown DropdownCue; //Field offset: 0x28
	[SerializeField]
	private Text TextLength; //Field offset: 0x2C
	[SerializeField]
	private Text TextCurrent; //Field offset: 0x30
	[SerializeField]
	private Slider SliderCurrent; //Field offset: 0x34
	[SerializeField]
	private Toggle ToggleLowLatency; //Field offset: 0x38
	[SerializeField]
	private Text TextInitializer; //Field offset: 0x3C
	[SerializeField]
	private InputField InputFieldVO; //Field offset: 0x40
	private CriAtomSource AtomSourceSE; //Field offset: 0x44
	private CriAtomSource AtomSourceBGM; //Field offset: 0x48
	private CriAtomExPlayback Playback; //Field offset: 0x4C
	private List<String> CurrentCueSheetList; //Field offset: 0x50
	private List<String> CurrentCueNameList; //Field offset: 0x54
	private string TargetDir; //Field offset: 0x58
	private bool IsStreamingAcb; //Field offset: 0x5C
	private bool IsBgm; //Field offset: 0x5D
	private bool IsVO; //Field offset: 0x5E
	private string LoadedCueSheet; //Field offset: 0x60
	private string CurrentSheetName; //Field offset: 0x64
	private CueInfo CurrentCueInfo; //Field offset: 0x68
	private uint estimated_latency; //Field offset: 0xF0
	private StringBuilder sb; //Field offset: 0xF4
	private bool initialized; //Field offset: 0xF8
	private long PrevTime; //Field offset: 0x100
	private bool SliderSetNow; //Field offset: 0x108

	private static SoundTestScene() { }

	public SoundTestScene() { }

	[CompilerGenerated]
	private void <DoStart>b__31_0() { }

	[IteratorStateMachine(typeof(<CoroutineCheckLatancy>d__40))]
	private IEnumerator CoroutineCheckLatancy() { }

	[IteratorStateMachine(typeof(<CoroutineLoadCue>d__45))]
	private IEnumerator CoroutineLoadCue() { }

	protected virtual void DoAwake() { }

	protected virtual void DoStart() { }

	protected virtual void DoUpdateMain() { }

	public void OnChangeDropdownQue(int value) { }

	public void OnTapBack() { }

	public void OnTapBack2() { }

	public void OnTapBgm() { }

	public void OnTapBgm2() { }

	public void OnTapLoad() { }

	public void OnTapPause() { }

	public void OnTapPlay() { }

	public void OnTapSe() { }

	public void OnTapStop() { }

	public void OnTapVO() { }

	public void OnValueChangeSlider(float ms) { }

	private void OpenPageCS() { }

	private void OpenPageTop() { }

	public void OpenPlayer() { }

	private void PlayBGM(string bgmPath) { }

	private void SetupInitializerParam() { }

	private void UpdateCueInfo(int index) { }

	private void UpdatePlayPosition() { }

}


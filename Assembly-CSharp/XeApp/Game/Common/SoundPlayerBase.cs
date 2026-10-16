namespace XeApp.Game.Common;

public abstract class SoundPlayerBase : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__24_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <Co_InstallProcess>b__24_0() { }

	}

	[CompilerGenerated]
	private sealed class <Co_ChangeVolume>d__31 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float sec; //Field offset: 0x10
		public SoundPlayerBase <>4__this; //Field offset: 0x14
		public float targetVol; //Field offset: 0x18
		private float <remain>5__2; //Field offset: 0x1C
		private float <baseVolume>5__3; //Field offset: 0x20
		private float <rate>5__4; //Field offset: 0x24

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
		public <Co_ChangeVolume>d__31(int <>1__state) { }

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
	private sealed class <Co_ChangeVolume>d__35 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SoundPlayerBase <>4__this; //Field offset: 0x10
		public float sec; //Field offset: 0x14
		public float targetVol; //Field offset: 0x18
		public Action onEnd; //Field offset: 0x1C

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
		public <Co_ChangeVolume>d__35(int <>1__state) { }

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
	private sealed class <Co_FadeOut>d__33 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SoundPlayerBase <>4__this; //Field offset: 0x10
		public float sec; //Field offset: 0x14
		public Action onStop; //Field offset: 0x18

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
		public <Co_FadeOut>d__33(int <>1__state) { }

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
	private sealed class <Co_InstallProcess>d__24 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SoundPlayerBase <>4__this; //Field offset: 0x10
		public string cueSheetName; //Field offset: 0x14
		public UnityAction onEndCallback; //Field offset: 0x18

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
		public <Co_InstallProcess>d__24(int <>1__state) { }

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

	private Coroutine fadeCoroutine; //Field offset: 0x10
	private IEnumerator changeVolume; //Field offset: 0x14
	[CompilerGenerated]
	private CriAtomExPlayback <Playback>k__BackingField; //Field offset: 0x18

	public string cueSheetName
	{
		 get { } //Length: 147
	}

	public FormatInfo GetInfo
	{
		 get { } //Length: 51
	}

	public long GetTime
	{
		 get { } //Length: 62
	}

	public bool IsPlaying
	{
		 get { } //Length: 34
	}

	public int MillisecLength
	{
		 get { } //Length: 237
	}

	protected private CriAtomExPlayback Playback
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public float SecLength
	{
		 get { } //Length: 44
	}

	public abstract CriAtomSource Source
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	protected SoundPlayerBase() { }

	private void Awake() { }

	public void ChangeCueSheet(string cueSheetName) { }

	protected void ChangeVolume(float sec, float targetVol, Action onEnd = null) { }

	[IteratorStateMachine(typeof(<Co_ChangeVolume>d__35))]
	protected IEnumerator Co_ChangeVolume(float sec, float targetVol, Action onEnd) { }

	[IteratorStateMachine(typeof(<Co_ChangeVolume>d__31))]
	private IEnumerator Co_ChangeVolume(float sec, float targetVol) { }

	[IteratorStateMachine(typeof(<Co_FadeOut>d__33))]
	private IEnumerator Co_FadeOut(float sec, Action onStop = null) { }

	[IteratorStateMachine(typeof(<Co_InstallProcess>d__24))]
	private IEnumerator Co_InstallProcess(string cueSheetName, UnityAction onEndCallback) { }

	protected void FadeOut(float sec, Action onStop = null) { }

	public string get_cueSheetName() { }

	public FormatInfo get_GetInfo() { }

	public long get_GetTime() { }

	public bool get_IsPlaying() { }

	public int get_MillisecLength() { }

	[CompilerGenerated]
	protected CriAtomExPlayback get_Playback() { }

	public float get_SecLength() { }

	public abstract CriAtomSource get_Source() { }

	protected override void OnAwake() { }

	public override void Pause(bool pause) { }

	protected bool PlayCue(string cueName, float vol = 1) { }

	protected bool PlayCue(int cueId, float vol = 1) { }

	public bool RemoveCueSheet() { }

	public bool RequestChangeCueSheet(string cueSheetName, UnityAction onEndCallback) { }

	[CompilerGenerated]
	private void set_Playback(CriAtomExPlayback value) { }

	public abstract void set_Source(CriAtomSource value) { }

	public void SetVolume(float v) { }

	protected bool StopCue(bool ignoresReleaseTime) { }

}


namespace XeApp.Game.Common;

public class BgmPlayer : SoundPlayerBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public Action onStop; //Field offset: 0x8

		public <>c__DisplayClass36_0() { }

		internal void <FadeOut>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <BgmFadeoutAndStop>d__30 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float sec; //Field offset: 0x10
		public BgmPlayer <>4__this; //Field offset: 0x14
		public int index; //Field offset: 0x18
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
		public <BgmFadeoutAndStop>d__30(int <>1__state) { }

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

	internal class VoiceResource
	{
		public string cueSheetName; //Field offset: 0x8
		public CriAtomCueSheet CriAtomCueSheet; //Field offset: 0xC
		public int refCount; //Field offset: 0x10

		public VoiceResource() { }

	}

	public const int CUSTOM_PREVIEW = 524288; //Field offset: 0x0
	public const int CUSTOM_BASE = 262144; //Field offset: 0x0
	public const int SYSGBM_BASE = 65536; //Field offset: 0x0
	public const int MUSIC_BASE = 0; //Field offset: 0x0
	public const int ID_MASK = 65535; //Field offset: 0x0
	public const int PREVIEW = 131072; //Field offset: 0x0
	public const float COMMON_FADEOUT_TIME = 0.5; //Field offset: 0x0
	private static Dictionary<String, VoiceResource> m_resourceMap; //Field offset: 0x0
	private const int MAX_SLOT = 2; //Field offset: 0x0
	private Coroutine bgmFadeoutStopCoroutine; //Field offset: 0x1C
	private CriAtomSource[] bgmSource; //Field offset: 0x20
	private int foregroundIndex; //Field offset: 0x24
	private int fadeoutIndex; //Field offset: 0x28
	private GuardInt CurrentBgmId_; //Field offset: 0x2C

	public private int CurrentBgmId
	{
		 get { } //Length: 79
		private set { } //Length: 76
	}

	public virtual CriAtomSource Source
	{
		 get { } //Length: 36
		 set { } //Length: 97
	}

	private static BgmPlayer() { }

	public BgmPlayer() { }

	private void Add(int index, string name) { }

	public static void AddResource(string name) { }

	[IteratorStateMachine(typeof(<BgmFadeoutAndStop>d__30))]
	private IEnumerator BgmFadeoutAndStop(int index, float sec) { }

	public void ChangeMusicCue(int bgmId) { }

	public void ContinuousPlay(int bgmId) { }

	public static string ConvertBgmIdToCueName(int bgmId) { }

	public static string ConvertBgmIdToCueSheetName(int bgmId) { }

	public void FadeOut(float sec, Action onStop = null) { }

	public int get_CurrentBgmId() { }

	public virtual CriAtomSource get_Source() { }

	public bool IsPlaying() { }

	protected virtual void OnAwake() { }

	public virtual void Pause(bool pause) { }

	public void Play(int bgmId) { }

	private void PlayImpl(int bgmId) { }

	private void Remove(int index, string name) { }

	public static void RemoveResource(string name) { }

	public bool RequestChangeCueSheet(int bgmId, UnityAction onEndCallback = null) { }

	private void set_CurrentBgmId(int value) { }

	public virtual void set_Source(CriAtomSource value) { }

	public void Stop(float stopTime) { }

}


namespace CriWare.CriTimeline.Mana;

public class CriManaMixerBehaviour : PlayableBehaviour
{
	[CompilerGenerated]
	private struct <ProcessFrameOnSeeking>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public CriManaMixerBehaviour <>4__this; //Field offset: 0x14
		public TimelineClip activeClip; //Field offset: 0x18
		public CriManaClipBase clip; //Field offset: 0x1C
		public double frameTime; //Field offset: 0x20
		private bool <movieInfoReplaced>5__2; //Field offset: 0x28
		private bool <whileBreaker>5__3; //Field offset: 0x29
		private TaskAwaiter <>u__1; //Field offset: 0x2C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum ClipState
	{
		Idle = 0,
		Prepare = 1,
		Play = 2,
		Seek = 3,
	}

	private enum MovieMixerState
	{
		Preloading = 0,
		Ready = 1,
		Playing = 2,
		Stopping = 3,
		Stopped = 4,
	}

	private static double cPreloadTimeSec; //Field offset: 0x0
	private static float cFrameSkipTolerance; //Field offset: 0x8
	internal PlayableDirector m_PlayableDirector; //Field offset: 0x8
	internal TimelineClip[] m_clips; //Field offset: 0xC
	internal CriManaMovieMaterialBase m_boundMovieMaterial; //Field offset: 0x10
	internal Dictionary<Int32, GCHandle> m_gcHandleList; //Field offset: 0x14
	internal bool m_frameSync; //Field offset: 0x18
	internal bool m_CheckPosWithinClip; //Field offset: 0x19
	private Nullable<Guid> m_lastClipId; //Field offset: 0x1C
	private double lastPlayedTime; //Field offset: 0x30
	private double m_currentSeekingFrameTime; //Field offset: 0x38
	private float m_originalAudioVolume; //Field offset: 0x40
	private float m_originalSubAudioVolume; //Field offset: 0x44
	private float m_originalExtraAudioVolume; //Field offset: 0x48
	private bool enableTimelineScrubPlayback; //Field offset: 0x4C
	private double m_lastDirectorTime; //Field offset: 0x50
	private MovieMixerState m_movieMixerState; //Field offset: 0x58

	private static bool IsEditMode
	{
		private get { } //Length: 3
	}

	private static CriManaMixerBehaviour() { }

	public CriManaMixerBehaviour() { }

	private void ForceSyncedStop(bool keepLastFrame = false) { }

	private static bool get_IsEditMode() { }

	private bool IsIntermediateState() { }

	private static bool IsPlayerStopped(Player player) { }

	private void KeepAudioVolume(bool fadeAudio) { }

	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	public virtual void OnGraphStart(Playable playable) { }

	public virtual void OnGraphStop(Playable playable) { }

	public virtual void OnPlayableCreate(Playable playable) { }

	public virtual void OnPlayableDestroy(Playable playable) { }

	private void PausePlayer(bool pause) { }

	private bool PlayMovie(CriManaClipBase clipAsset, int startFrame, double startTime) { }

	private bool PrepareMovie(CriManaClipBase clipAsset) { }

	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	[AsyncStateMachine(typeof(<ProcessFrameOnSeeking>d__27))]
	private void ProcessFrameOnSeeking(TimelineClip activeClip, CriManaClipBase clip, double frameTime) { }

	private bool StopForSeekMovie() { }

	private bool StopMovie(bool keepLastFrame = false) { }

}


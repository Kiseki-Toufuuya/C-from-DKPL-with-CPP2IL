namespace DG.Tweening;

public abstract class Tween : ABSSequentiable
{
	public float timeScale; //Field offset: 0x18
	public bool isBackwards; //Field offset: 0x1C
	internal bool isInverted; //Field offset: 0x1D
	public object id; //Field offset: 0x20
	public string stringId; //Field offset: 0x24
	public int intId; //Field offset: 0x28
	public object target; //Field offset: 0x2C
	internal UpdateType updateType; //Field offset: 0x30
	internal bool isIndependentUpdate; //Field offset: 0x34
	public TweenCallback onPlay; //Field offset: 0x38
	public TweenCallback onPause; //Field offset: 0x3C
	public TweenCallback onRewind; //Field offset: 0x40
	public TweenCallback onUpdate; //Field offset: 0x44
	public TweenCallback onStepComplete; //Field offset: 0x48
	public TweenCallback onComplete; //Field offset: 0x4C
	public TweenCallback onKill; //Field offset: 0x50
	public TweenCallback<Int32> onWaypointChange; //Field offset: 0x54
	internal bool isFrom; //Field offset: 0x58
	internal bool isBlendable; //Field offset: 0x59
	internal bool isRecyclable; //Field offset: 0x5A
	internal bool isSpeedBased; //Field offset: 0x5B
	internal bool autoKill; //Field offset: 0x5C
	internal float duration; //Field offset: 0x60
	internal int loops; //Field offset: 0x64
	internal LoopType loopType; //Field offset: 0x68
	internal float delay; //Field offset: 0x6C
	[CompilerGenerated]
	private bool <isRelative>k__BackingField; //Field offset: 0x70
	internal Ease easeType; //Field offset: 0x74
	internal EaseFunction customEase; //Field offset: 0x78
	public float easeOvershootOrAmplitude; //Field offset: 0x7C
	public float easePeriod; //Field offset: 0x80
	public string debugTargetId; //Field offset: 0x84
	internal Type typeofT1; //Field offset: 0x88
	internal Type typeofT2; //Field offset: 0x8C
	internal Type typeofTPlugOptions; //Field offset: 0x90
	[CompilerGenerated]
	private bool <active>k__BackingField; //Field offset: 0x94
	internal bool isSequenced; //Field offset: 0x95
	internal Sequence sequenceParent; //Field offset: 0x98
	internal int activeId; //Field offset: 0x9C
	internal SpecialStartupMode specialStartupMode; //Field offset: 0xA0
	internal bool creationLocked; //Field offset: 0xA4
	internal bool startupDone; //Field offset: 0xA5
	[CompilerGenerated]
	private bool <playedOnce>k__BackingField; //Field offset: 0xA6
	[CompilerGenerated]
	private float <position>k__BackingField; //Field offset: 0xA8
	internal float fullDuration; //Field offset: 0xAC
	internal int completedLoops; //Field offset: 0xB0
	internal bool isPlaying; //Field offset: 0xB4
	internal bool isComplete; //Field offset: 0xB5
	internal float elapsedDelay; //Field offset: 0xB8
	internal bool delayComplete; //Field offset: 0xBC
	internal int miscInt; //Field offset: 0xC0

	public internal bool active
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 17
	}

	public float fullPosition
	{
		 get { } //Length: 143
		 set { } //Length: 40
	}

	public bool hasLoops
	{
		 get { } //Length: 25
	}

	public internal bool isRelative
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public private bool playedOnce
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public internal float position
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 21
	}

	protected Tween() { }

	internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode) { }

	[CompilerGenerated]
	public bool get_active() { }

	public float get_fullPosition() { }

	public bool get_hasLoops() { }

	[CompilerGenerated]
	public bool get_isRelative() { }

	[CompilerGenerated]
	public bool get_playedOnce() { }

	[CompilerGenerated]
	public float get_position() { }

	internal static bool OnTweenCallback(TweenCallback<T> callback, Tween t, T param) { }

	internal static bool OnTweenCallback(TweenCallback callback, Tween t) { }

	internal override void Reset() { }

	[CompilerGenerated]
	internal void set_active(bool value) { }

	public void set_fullPosition(float value) { }

	[CompilerGenerated]
	internal void set_isRelative(bool value) { }

	[CompilerGenerated]
	private void set_playedOnce(bool value) { }

	[CompilerGenerated]
	internal void set_position(float value) { }

	internal abstract bool Startup() { }

	internal override float UpdateDelay(float elapsed) { }

	internal abstract bool Validate() { }

}


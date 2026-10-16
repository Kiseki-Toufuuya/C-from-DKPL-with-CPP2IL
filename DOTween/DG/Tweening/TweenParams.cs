namespace DG.Tweening;

public class TweenParams
{
	public static readonly TweenParams Params; //Field offset: 0x0
	internal object id; //Field offset: 0x8
	internal string stringId; //Field offset: 0xC
	internal int intId; //Field offset: 0x10
	internal object target; //Field offset: 0x14
	internal UpdateType updateType; //Field offset: 0x18
	internal bool isIndependentUpdate; //Field offset: 0x1C
	internal TweenCallback onStart; //Field offset: 0x20
	internal TweenCallback onPlay; //Field offset: 0x24
	internal TweenCallback onRewind; //Field offset: 0x28
	internal TweenCallback onUpdate; //Field offset: 0x2C
	internal TweenCallback onStepComplete; //Field offset: 0x30
	internal TweenCallback onComplete; //Field offset: 0x34
	internal TweenCallback onKill; //Field offset: 0x38
	internal TweenCallback<Int32> onWaypointChange; //Field offset: 0x3C
	internal bool isRecyclable; //Field offset: 0x40
	internal bool isSpeedBased; //Field offset: 0x41
	internal bool autoKill; //Field offset: 0x42
	internal int loops; //Field offset: 0x44
	internal LoopType loopType; //Field offset: 0x48
	internal float delay; //Field offset: 0x4C
	internal bool isRelative; //Field offset: 0x50
	internal Ease easeType; //Field offset: 0x54
	internal EaseFunction customEase; //Field offset: 0x58
	internal float easeOvershootOrAmplitude; //Field offset: 0x5C
	internal float easePeriod; //Field offset: 0x60

	private static TweenParams() { }

	public TweenParams() { }

	public TweenParams Clear() { }

	public TweenParams OnComplete(TweenCallback action) { }

	public TweenParams OnKill(TweenCallback action) { }

	public TweenParams OnPlay(TweenCallback action) { }

	public TweenParams OnRewind(TweenCallback action) { }

	public TweenParams OnStart(TweenCallback action) { }

	public TweenParams OnStepComplete(TweenCallback action) { }

	public TweenParams OnUpdate(TweenCallback action) { }

	public TweenParams OnWaypointChange(TweenCallback<Int32> action) { }

	public TweenParams SetAutoKill(bool autoKillOnCompletion = true) { }

	public TweenParams SetDelay(float delay) { }

	public TweenParams SetEase(AnimationCurve animCurve) { }

	public TweenParams SetEase(Ease ease, Nullable<Single> overshootOrAmplitude = null, Nullable<Single> period = null) { }

	public TweenParams SetEase(EaseFunction customEase) { }

	public TweenParams SetId(int intId) { }

	public TweenParams SetId(string stringId) { }

	public TweenParams SetId(object objectId) { }

	public TweenParams SetLoops(int loops, Nullable<LoopType> loopType = null) { }

	public TweenParams SetRecyclable(bool recyclable = true) { }

	public TweenParams SetRelative(bool isRelative = true) { }

	public TweenParams SetSpeedBased(bool isSpeedBased = true) { }

	public TweenParams SetTarget(object target) { }

	public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false) { }

	public TweenParams SetUpdate(bool isIndependentUpdate) { }

}


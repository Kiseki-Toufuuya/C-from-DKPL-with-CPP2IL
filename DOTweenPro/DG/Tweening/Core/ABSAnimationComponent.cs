namespace DG.Tweening.Core;

[AddComponentMenu(null)]
public abstract class ABSAnimationComponent : MonoBehaviour
{
	public UpdateType updateType; //Field offset: 0x10
	public bool isSpeedBased; //Field offset: 0x14
	public bool hasOnStart; //Field offset: 0x15
	public bool hasOnPlay; //Field offset: 0x16
	public bool hasOnUpdate; //Field offset: 0x17
	public bool hasOnStepComplete; //Field offset: 0x18
	public bool hasOnComplete; //Field offset: 0x19
	public bool hasOnTweenCreated; //Field offset: 0x1A
	public bool hasOnRewind; //Field offset: 0x1B
	public UnityEvent onStart; //Field offset: 0x1C
	public UnityEvent onPlay; //Field offset: 0x20
	public UnityEvent onUpdate; //Field offset: 0x24
	public UnityEvent onStepComplete; //Field offset: 0x28
	public UnityEvent onComplete; //Field offset: 0x2C
	public UnityEvent onTweenCreated; //Field offset: 0x30
	public UnityEvent onRewind; //Field offset: 0x34
	public Tween tween; //Field offset: 0x38

	protected ABSAnimationComponent() { }

	public abstract void DOComplete() { }

	public abstract void DOKill() { }

	public abstract void DOPause() { }

	public abstract void DOPlay() { }

	public abstract void DOPlayBackwards() { }

	public abstract void DOPlayForward() { }

	public abstract void DORestart() { }

	public abstract void DORestart(bool fromHere) { }

	public abstract void DORewind() { }

	public abstract void DOTogglePause() { }

}


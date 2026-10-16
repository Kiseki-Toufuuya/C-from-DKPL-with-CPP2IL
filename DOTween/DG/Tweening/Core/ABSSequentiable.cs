namespace DG.Tweening.Core;

public abstract class ABSSequentiable
{
	internal TweenType tweenType; //Field offset: 0x8
	internal float sequencedPosition; //Field offset: 0xC
	internal float sequencedEndPosition; //Field offset: 0x10
	internal TweenCallback onStart; //Field offset: 0x14

	protected ABSSequentiable() { }

}


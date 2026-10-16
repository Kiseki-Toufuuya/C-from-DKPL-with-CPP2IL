namespace DG.Tweening.Core;

internal class TweenLink
{
	public readonly GameObject target; //Field offset: 0x8
	public readonly LinkBehaviour behaviour; //Field offset: 0xC
	public bool lastSeenActive; //Field offset: 0x10

	public TweenLink(GameObject target, LinkBehaviour behaviour) { }

}


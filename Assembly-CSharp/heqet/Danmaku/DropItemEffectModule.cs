namespace Heqet.Danmaku;

[RequireComponent(typeof(GimmickItem))]
[RequireComponent(typeof(DropMotionBase))]
public class DropItemEffectModule : EffectModuleComponent
{
	[SerializeField]
	private GimmickItem gimmickItem; //Field offset: 0x10
	[SerializeField]
	private DropMotionBase dropMotion; //Field offset: 0x14
	private bool isPlaying; //Field offset: 0x18

	public virtual bool IsStopped
	{
		 get { } //Length: 15
	}

	public DropItemEffectModule() { }

	public virtual bool get_IsStopped() { }

	public virtual void Pause(bool enable) { }

	public virtual void Play() { }

	public virtual void Stop() { }

}


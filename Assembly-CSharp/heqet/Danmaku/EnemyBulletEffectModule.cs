namespace Heqet.Danmaku;

[RequireComponent(typeof(BulletController))]
public class EnemyBulletEffectModule : EffectModuleComponent
{
	[SerializeField]
	private BulletController bulletController; //Field offset: 0x10

	public virtual bool IsStopped
	{
		 get { } //Length: 34
	}

	public EnemyBulletEffectModule() { }

	private void Awake() { }

	public virtual bool get_IsStopped() { }

	public virtual void Pause(bool enable) { }

	public virtual void Play() { }

	public virtual void Stop() { }

}


namespace Heqet.Danmaku;

[ExecuteAlways]
[RequireComponent(typeof(ParticleSystem))]
public class ParticleBullet : MonoBehaviour
{
	internal enum Constraint
	{
		None = 0,
		LookAtTargetOnIgnition = 1,
		LookAtTarget = 2,
		TargetPositionOnIgnition = 3,
		TargetPosition = 4,
		VelocityOffsetAtTargetOnIgnition = 5,
		VelocityOffsetAtTarget = 6,
	}

	private ParticleSystem particle; //Field offset: 0x10
	[CompilerGenerated]
	private BulletController <BulletController>k__BackingField; //Field offset: 0x14
	public Constraint constraint; //Field offset: 0x18
	private readonly Vector3 DEFAULT_POSITION_AT_NULL_TARGET; //Field offset: 0x1C
	[SerializeField]
	private bool ignoreEraser; //Field offset: 0x28
	private Vector3 ignitionPos; //Field offset: 0x2C
	private bool ignition; //Field offset: 0x38

	public BulletController BulletController
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool IgnoreEraser
	{
		 get { } //Length: 11
	}

	public ParticleSystem Particle
	{
		 get { } //Length: 11
	}

	public ParticleBullet() { }

	private void AddsParticleCollisionEventDetector() { }

	private void Awake() { }

	public void DoLateUpdate() { }

	[CompilerGenerated]
	public BulletController get_BulletController() { }

	public bool get_IgnoreEraser() { }

	public ParticleSystem get_Particle() { }

	public bool Ignition() { }

	[CompilerGenerated]
	public void set_BulletController(BulletController value) { }

	private void Start() { }

}


namespace Heqet.Danmaku;

[ExecuteAlways]
public class BulletController : MonoBehaviour, ITimeControl
{
	[SerializeField]
	private ControlType controlType; //Field offset: 0x10
	[SerializeField]
	private GameObject body; //Field offset: 0x14
	[SerializeField]
	private ParticleBullet mainParticleBullet; //Field offset: 0x18
	[SerializeField]
	private int randomSeed; //Field offset: 0x1C
	[SerializeField]
	private float shotInterval; //Field offset: 0x20
	[CompilerGenerated]
	private ShotCategory <ShotCategory>k__BackingField; //Field offset: 0x24
	[FormerlySerializedAs("shotDamage")]
	[SerializeField]
	private float enemyShotDamage; //Field offset: 0x28
	private float shotIntervalTimer; //Field offset: 0x2C
	[SerializeField]
	private float playerShotDamageFactor; //Field offset: 0x30
	[CompilerGenerated]
	private GameObject <TargetObject>k__BackingField; //Field offset: 0x34
	private bool initialized; //Field offset: 0x38
	private List<ParticleBullet> subParticleBulletList; //Field offset: 0x3C
	private bool isPause; //Field offset: 0x40
	private float m_LastPlayableTime; //Field offset: 0x44
	private float m_LastParticleTime; //Field offset: 0x48
	private bool isPlaying; //Field offset: 0x4C

	public GameObject Body
	{
		 get { } //Length: 11
	}

	public ControlType ControlType
	{
		 get { } //Length: 11
	}

	public float EnemyShotDamage
	{
		 get { } //Length: 11
	}

	public ParticleSystem Particle
	{
		 get { } //Length: 23
	}

	public float PlayerShotDamageFactor
	{
		 get { } //Length: 11
	}

	public ShotCategory ShotCategory
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GameObject TargetObject
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public BulletController() { }

	private void Awake() { }

	public void DoLateUpdate() { }

	public void DoUpdateUI(GameObject target) { }

	public GameObject get_Body() { }

	public ControlType get_ControlType() { }

	public float get_EnemyShotDamage() { }

	public ParticleSystem get_Particle() { }

	public float get_PlayerShotDamageFactor() { }

	[CompilerGenerated]
	public ShotCategory get_ShotCategory() { }

	[CompilerGenerated]
	public GameObject get_TargetObject() { }

	private void Initialize() { }

	public bool IsStop() { }

	public override void OnControlTimeStart() { }

	public override void OnControlTimeStop() { }

	public void Pause(bool enable) { }

	[CompilerGenerated]
	public void set_ShotCategory(ShotCategory value) { }

	[CompilerGenerated]
	public void set_TargetObject(GameObject value) { }

	private static void SetRandomSeed(ParticleSystem particleSystem, int randomSeed) { }

	public override void SetTime(double time_) { }

	private void SetupTargetObject() { }

	public void Shot() { }

	private void Simulate(float time, bool restart) { }

	private void Start() { }

	public void Stop(bool force = false) { }

}


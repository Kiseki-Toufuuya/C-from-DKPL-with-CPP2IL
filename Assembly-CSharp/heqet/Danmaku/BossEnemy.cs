namespace Heqet.Danmaku;

[ExecuteAlways]
public class BossEnemy : MonoBehaviour, IEnemy
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TweenCallback <>9__46_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <OnDefeat>b__46_0() { }

	}

	[CompilerGenerated]
	private struct <LoadAsssetAsync>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public BossEnemy <>4__this; //Field offset: 0xC
		public StageController stageController; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum BossDefeatEffects
	{
		boss_defeat_01 = 0,
		boss_defeat_02 = 1,
		boss_defeat_03 = 2,
		boss_defeat_04 = 3,
		boss_defeat_05 = 4,
	}

	internal enum eState
	{
		INIT = 0,
		WAIT = 1,
		MAIN = 2,
		DEAD = 3,
		END = 4,
		NUM = 5,
	}

	internal enum HitEffects
	{
		hit_01 = 0,
		hit_02 = 1,
		hit_03 = 2,
		hit_04 = 3,
		hit_05 = 4,
		hit_06 = 5,
	}

	public static Int32[] ToEffectDefine; //Field offset: 0x0
	public static Int32[] ToEffectDefineFromBossDefeat; //Field offset: 0x4
	private eState state; //Field offset: 0x10
	public int BossID; //Field offset: 0x14
	public Color color; //Field offset: 0x18
	private Color prevColor; //Field offset: 0x28
	[SerializeField]
	private int bossLifeStock; //Field offset: 0x38
	[SerializeField]
	private float bossLife; //Field offset: 0x3C
	[SerializeField]
	private int defeatedScore; //Field offset: 0x40
	private Live2DModel live2DModel; //Field offset: 0x44
	private MeshRenderer bossRender; //Field offset: 0x48
	private BoxCollider bossCollider; //Field offset: 0x4C
	private bool isInitialized; //Field offset: 0x50
	private bool isPlaying; //Field offset: 0x51
	private bool isDone; //Field offset: 0x52
	private bool isSpawn; //Field offset: 0x53
	private bool isDead; //Field offset: 0x54
	private bool isShow; //Field offset: 0x55
	[SerializeField]
	private HitEffects hitEffectId; //Field offset: 0x58
	[SerializeField]
	private BossDefeatEffects deadEffectId; //Field offset: 0x5C
	[SerializeField]
	private EffectBGType cutInEffectBGType; //Field offset: 0x60
	[SerializeField]
	private GameObject live2DScreenRoot; //Field offset: 0x64

	public EffectBGType CutInEffectBGType
	{
		 get { } //Length: 11
	}

	public int DefeatedScore
	{
		 get { } //Length: 11
	}

	public override GameObject GameObject
	{
		 get { } //Length: 16
	}

	public Live2DModel Live2DModel
	{
		 get { } //Length: 11
	}

	private static BossEnemy() { }

	public BossEnemy() { }

	[CompilerGenerated]
	private bool <LoadAsssetAsync>b__35_0() { }

	public EffectBGType get_CutInEffectBGType() { }

	public int get_DefeatedScore() { }

	public override GameObject get_GameObject() { }

	public Live2DModel get_Live2DModel() { }

	public void Hide() { }

	public void Initialize(StageController stageController) { }

	public bool IsDone() { }

	[AsyncStateMachine(typeof(<LoadAsssetAsync>d__35))]
	private UniTask LoadAsssetAsync(StageController stageController) { }

	public void OnDefeat() { }

	public void OnLostLifeStock() { }

	public void OnParticleCollisionAtPosition(GameObject other, Vector3 position) { }

	public void OnPlay() { }

	public void SetAnimationTrigger(string name) { }

	public void SetCollisionEnable(bool enable) { }

	private void SetColor(Color value) { }

	public void Show() { }

	private void Start() { }

	public void StartAnimation(AnimationState state) { }

	public void Terminate() { }

	public void Update() { }

}


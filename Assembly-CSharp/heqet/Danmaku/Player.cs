namespace Heqet.Danmaku;

public class Player : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<AssetBundleLoadAssetOperation> <>9__38_1; //Field offset: 0x4
		public static TweenCallback <>9__49_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <LoadAsssetAsync>b__38_1(AssetBundleLoadAssetOperation ope) { }

		internal void <OnDefeat>b__49_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public AssetBundleLoadAssetOperation ope; //Field offset: 0x8

		public <>c__DisplayClass38_0() { }

		internal bool <LoadAsssetAsync>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_1
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass38_1() { }

		internal bool <LoadAsssetAsync>b__3() { }

	}

	[CompilerGenerated]
	private struct <LoadAsssetAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Player <>4__this; //Field offset: 0xC
		public int mainHeroineId; //Field offset: 0x10
		public CancellationToken ct; //Field offset: 0x14
		private <>c__DisplayClass38_0 <>8__1; //Field offset: 0x18
		private <>c__DisplayClass38_1 <>8__2; //Field offset: 0x1C
		public int subHeroineId; //Field offset: 0x20
		private Awaiter <>u__1; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayFlash>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Player <>4__this; //Field offset: 0xC
		private float <waitTime>5__2; //Field offset: 0x10
		private int <i>5__3; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum AnimationTypes
	{
		Idle = 0,
		MoveLeft = 1,
		MoveRight = 2,
		LeftTurn = 3,
		LeftTurnQuick = 4,
		RightTurn = 5,
		RightTurnQuick = 6,
	}

	internal enum PlayerMoveState
	{
		None = 0,
		Stay = 1,
		MoveLeft = 2,
		MoveRight = 3,
	}

	private const int BOMB_CHECK_LAYERS = 536870912; //Field offset: 0x0
	private const float baseSpeed = 0.05; //Field offset: 0x0
	public const float TakeDamageInvincibleTime = 0.25; //Field offset: 0x0
	public const float LostLifeStockInvincibleTime = 1; //Field offset: 0x0
	public const float UseBombInvincibleTime = 3; //Field offset: 0x0
	public const string BodyCollisionName = "BodyCollision"; //Field offset: 0x0
	public const string EnamyBulletCollisionName = "EnamyBulletCollision"; //Field offset: 0x0
	[SerializeField]
	private Animator animator; //Field offset: 0x10
	[SerializeField]
	private PlayerBulletController playerBulletController; //Field offset: 0x14
	[SerializeField]
	private GameObject enemyBulletEraser; //Field offset: 0x18
	[SerializeField]
	private float showEnemyBulletEraserTime; //Field offset: 0x1C
	[CompilerGenerated]
	private PlayerMoveState <MoveState>k__BackingField; //Field offset: 0x20
	private bool isDone; //Field offset: 0x24
	private bool initialized; //Field offset: 0x25
	private float takeDamageInvincibleTimer; //Field offset: 0x28
	private float lostLifeStockInvincibleTimer; //Field offset: 0x2C
	private float enemyBulletEraserTimer; //Field offset: 0x30
	[CompilerGenerated]
	private bool <IsDead>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private float <MoveSpeed>k__BackingField; //Field offset: 0x38
	private SpriteRenderer playerSprite; //Field offset: 0x3C
	private readonly String[] animationClipNames; //Field offset: 0x40
	private List<String> assetBundleNames; //Field offset: 0x44

	public Animator Animator
	{
		 get { } //Length: 11
	}

	public private bool IsDead
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private float MoveSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public private PlayerMoveState MoveState
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public PlayerBulletController PlayerBulletController
	{
		 get { } //Length: 11
	}

	public Player() { }

	[CompilerGenerated]
	private bool <LoadAsssetAsync>b__38_0() { }

	public void ApplyMoveState(Vector2 move) { }

	public void DoBomb() { }

	public void DoShowEnemyBulletEraser() { }

	public void DoUpdate() { }

	public void DoUpdateUI(GameObject target) { }

	public void GamePause(bool enable) { }

	public void GameStart() { }

	public Animator get_Animator() { }

	[CompilerGenerated]
	public bool get_IsDead() { }

	[CompilerGenerated]
	public float get_MoveSpeed() { }

	[CompilerGenerated]
	public PlayerMoveState get_MoveState() { }

	public PlayerBulletController get_PlayerBulletController() { }

	public void Initialize(int mainHeroineId, int subHeroineId, CancellationToken cancellationToken) { }

	public bool IsDone() { }

	[AsyncStateMachine(typeof(<LoadAsssetAsync>d__38))]
	private UniTask LoadAsssetAsync(int mainHeroineId, int subHeroineId, CancellationToken ct) { }

	public void OnDefeat() { }

	public void OnHitEnemyBullet(GameObject other) { }

	public void OnLostLifeStock() { }

	public void PlayAnimation(AnimationTypes type, bool force = false) { }

	[AsyncStateMachine(typeof(<PlayFlash>d__52))]
	private UniTask PlayFlash() { }

	[CompilerGenerated]
	private void set_IsDead(bool value) { }

	[CompilerGenerated]
	private void set_MoveSpeed(float value) { }

	[CompilerGenerated]
	private void set_MoveState(PlayerMoveState value) { }

	public void Stop() { }

	public void Terminate() { }

}


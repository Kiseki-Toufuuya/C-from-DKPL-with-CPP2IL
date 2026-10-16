namespace Heqet.Danmaku;

public class PlayerBulletController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass14_0() { }

		internal bool <LoadAsssetAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_1
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass14_1() { }

		internal bool <LoadAsssetAsync>b__1() { }

	}

	[CompilerGenerated]
	private struct <LoadAsssetAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public PlayerBulletController <>4__this; //Field offset: 0xC
		public CancellationToken cancellationToken; //Field offset: 0x10
		public int mainHeroineId; //Field offset: 0x14
		private <>c__DisplayClass14_0 <>8__1; //Field offset: 0x18
		public int subHeroineId; //Field offset: 0x1C
		private <>c__DisplayClass14_1 <>8__2; //Field offset: 0x20
		private CancellationTokenSource <ct>5__2; //Field offset: 0x24
		private string <fileName>5__3; //Field offset: 0x28
		private Awaiter <>u__1; //Field offset: 0x2C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int UI_BULLET_PLEVEL = 3; //Field offset: 0x0
	private BulletController mainBullet1; //Field offset: 0x10
	private BulletController mainBullet2; //Field offset: 0x14
	private BulletController mainBullet3; //Field offset: 0x18
	private BulletController mainBullet4; //Field offset: 0x1C
	private BulletController extraBullet; //Field offset: 0x20
	private BulletController[] mainBulletArray; //Field offset: 0x24
	private BulletController subHeroineExtraBullet; //Field offset: 0x28
	private bool isDone; //Field offset: 0x2C
	private bool isGameStart; //Field offset: 0x2D
	private int currentPLevelIndex; //Field offset: 0x30
	private List<String> assetBundleNames; //Field offset: 0x34

	public PlayerBulletController() { }

	private BulletController CreateBulletController(AssetBundleLoadAllAssetOperationBase ope, string fileName) { }

	public void DoUpdate() { }

	public void DoUpdateUI(GameObject target) { }

	public void GamePause(bool enable) { }

	public void GameStart() { }

	public BulletController GetBulletController(PlayerBulletType playerBulletType) { }

	public float GetCurrentBulletDamageFactor(PlayerBulletType playerBulletType) { }

	public void Initialize(int mainHeroineId, int subHeroineId, CancellationToken ct) { }

	public bool IsDone() { }

	[AsyncStateMachine(typeof(<LoadAsssetAsync>d__14))]
	private UniTask LoadAsssetAsync(int mainHeroineId, int subHeroineId, CancellationToken cancellationToken) { }

	public void Shot() { }

	public void ShotForUI() { }

	public void Stop() { }

	public void Terminate() { }

}


namespace Heqet.Danmaku;

public class PlayerController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass23_0() { }

		internal bool <LoadAsssetAsync>b__1() { }

	}

	[CompilerGenerated]
	private struct <LoadAsssetAsync>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public PlayerController <>4__this; //Field offset: 0xC
		private <>c__DisplayClass23_0 <>8__1; //Field offset: 0x10
		public CancellationToken ct; //Field offset: 0x14
		public StageGimmickCalculator sgc; //Field offset: 0x18
		private int <mainHeroineId>5__2; //Field offset: 0x1C
		private int <subHeroineId>5__3; //Field offset: 0x20
		private string <fileName>5__4; //Field offset: 0x24
		private Awaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float speedTuneAmount = 45; //Field offset: 0x0
	private const float positionXLimit = 4.5; //Field offset: 0x0
	[SerializeField]
	private GameObject root; //Field offset: 0x10
	private Player player; //Field offset: 0x14
	private Vector2 inputData; //Field offset: 0x18
	private InputActionReference keyPlayerMove; //Field offset: 0x20
	private InputActionReference keyBomb; //Field offset: 0x24
	[CompilerGenerated]
	private bool <IsInitializing>k__BackingField; //Field offset: 0x28
	private List<String> assetBundleNames; //Field offset: 0x2C
	private bool isDone; //Field offset: 0x30
	private bool isPause; //Field offset: 0x31

	public private bool IsInitializing
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public PlayerMoveState MoveState
	{
		 get { } //Length: 23
	}

	public Player Player
	{
		 get { } //Length: 11
	}

	public GameObject Root
	{
		 get { } //Length: 11
	}

	public PlayerController() { }

	[CompilerGenerated]
	private bool <LoadAsssetAsync>b__23_0() { }

	private void Awake() { }

	public void DoUpdate() { }

	public void GamePause(bool enable) { }

	public void GameStart() { }

	[CompilerGenerated]
	public bool get_IsInitializing() { }

	public PlayerMoveState get_MoveState() { }

	public Player get_Player() { }

	public GameObject get_Root() { }

	public void Initialize(StageGimmickCalculator sgc) { }

	public bool IsDone() { }

	[AsyncStateMachine(typeof(<LoadAsssetAsync>d__23))]
	private UniTask LoadAsssetAsync(StageGimmickCalculator sgc, CancellationToken ct) { }

	public void PlayAnimation(AnimationTypes type, bool force = false) { }

	public void PlayEffect(int effectId, bool constraint = true) { }

	public void PlayTakeItemEffect(int effectId, ALL_SE seId) { }

	[CompilerGenerated]
	private void set_IsInitializing(bool value) { }

	private void SetInputData() { }

	public void Stop() { }

	public void Terminate() { }

}


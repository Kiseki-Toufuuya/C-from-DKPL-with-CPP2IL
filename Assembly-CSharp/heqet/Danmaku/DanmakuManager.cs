namespace Heqet.Danmaku;

public class DanmakuManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__60_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <LoadAsssetAsync>b__60_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public DanmakuManager <>4__this; //Field offset: 0x8
		public TimelineManager tm; //Field offset: 0xC

		public <>c__DisplayClass60_0() { }

		internal bool <LoadAsssetAsync>b__1() { }

		internal bool <LoadAsssetAsync>b__3() { }

		internal bool <LoadAsssetAsync>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_1
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass60_1() { }

		internal bool <LoadAsssetAsync>b__2() { }

	}

	[CompilerGenerated]
	private struct <LoadAsssetAsync>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public DanmakuManager <>4__this; //Field offset: 0xC
		private <>c__DisplayClass60_0 <>8__1; //Field offset: 0x10
		private <>c__DisplayClass60_1 <>8__2; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x18
		private NotesManager <nm>5__2; //Field offset: 0x20
		private MusicManager <mm>5__3; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static DanmakuManager <Instance>k__BackingField; //Field offset: 0x0
	private const float HEIGHT = 6; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IsGameStart>k__BackingField; //Field offset: 0x4
	private string commonAssetBundleName; //Field offset: 0x8
	[CompilerGenerated]
	private DanmakuScene <DanmakuScene>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private RhythmGame <RhythmGame>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private StageGimmickCalculator <StageGimmickCalculator>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private PlayerController <PlayerController>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private UIController <UIController>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private Action <RankUpCallback>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private DanmakuLayer <DanmakuLayer>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private bool <IsGameFinish>k__BackingField; //Field offset: 0x28
	private int currRank; //Field offset: 0x2C
	private int currScore; //Field offset: 0x30
	private int currSpecialScore; //Field offset: 0x34
	private StageController stageController; //Field offset: 0x38
	[CompilerGenerated]
	private HeqetMusicModel <PlayingMusicModel>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private SettingData <PlayingMusicSettingData>k__BackingField; //Field offset: 0x40
	public bool IsEnemyBulletEraserProcessing; //Field offset: 0x44

	public DanmakuLayer DanmakuLayer
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	private DanmakuScene DanmakuScene
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private static DanmakuManager Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public private bool IsGameFinish
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private static bool IsGameStart
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 48
	}

	public static bool IsInitialized
	{
		 get { } //Length: 44
	}

	public private PlayerController PlayerController
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private HeqetMusicModel PlayingMusicModel
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private SettingData PlayingMusicSettingData
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public Action RankUpCallback
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public RhythmGame RhythmGame
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private StageGimmickCalculator StageGimmickCalculator
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public TimelineManager TimelineManager
	{
		 get { } //Length: 40
	}

	public private UIController UIController
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public DanmakuManager() { }

	private void CheckRankUp() { }

	private void CheckScore() { }

	private void CreatePowerItemForScoreRankUp(Vector3 position) { }

	private void CreatePowerItemForSpecialScoreUp(Vector3 position) { }

	public void DoLateUpdate() { }

	public void DoUpdate() { }

	public void GameFinish() { }

	public void GameStart() { }

	[CompilerGenerated]
	public DanmakuLayer get_DanmakuLayer() { }

	[CompilerGenerated]
	private DanmakuScene get_DanmakuScene() { }

	[CompilerGenerated]
	public static DanmakuManager get_Instance() { }

	[CompilerGenerated]
	public bool get_IsGameFinish() { }

	[CompilerGenerated]
	public static bool get_IsGameStart() { }

	public static bool get_IsInitialized() { }

	[CompilerGenerated]
	public PlayerController get_PlayerController() { }

	[CompilerGenerated]
	public HeqetMusicModel get_PlayingMusicModel() { }

	[CompilerGenerated]
	public SettingData get_PlayingMusicSettingData() { }

	[CompilerGenerated]
	public Action get_RankUpCallback() { }

	[CompilerGenerated]
	public RhythmGame get_RhythmGame() { }

	[CompilerGenerated]
	public StageGimmickCalculator get_StageGimmickCalculator() { }

	public TimelineManager get_TimelineManager() { }

	[CompilerGenerated]
	public UIController get_UIController() { }

	public ScoreRankID GetStoryRank() { }

	public void Initialize(DanmakuScene danmakuScene) { }

	public bool IsDone() { }

	[AsyncStateMachine(typeof(<LoadAsssetAsync>d__60))]
	private UniTask LoadAsssetAsync() { }

	public void PlayBGEffect(GameObject owner) { }

	private void PlayPowerItemEffect(Vector3 position) { }

	private void PreCreateEffect() { }

	[CompilerGenerated]
	public void set_DanmakuLayer(DanmakuLayer value) { }

	[CompilerGenerated]
	private void set_DanmakuScene(DanmakuScene value) { }

	[CompilerGenerated]
	private static void set_Instance(DanmakuManager value) { }

	[CompilerGenerated]
	private void set_IsGameFinish(bool value) { }

	[CompilerGenerated]
	private static void set_IsGameStart(bool value) { }

	[CompilerGenerated]
	private void set_PlayerController(PlayerController value) { }

	[CompilerGenerated]
	private void set_PlayingMusicModel(HeqetMusicModel value) { }

	[CompilerGenerated]
	private void set_PlayingMusicSettingData(SettingData value) { }

	[CompilerGenerated]
	public void set_RankUpCallback(Action value) { }

	[CompilerGenerated]
	public void set_RhythmGame(RhythmGame value) { }

	[CompilerGenerated]
	private void set_StageGimmickCalculator(StageGimmickCalculator value) { }

	[CompilerGenerated]
	private void set_UIController(UIController value) { }

	public void SetGameParam(HeqetMusicModel musicModel, SettingData musicSettingData) { }

	public void Terminate() { }

}


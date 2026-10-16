namespace Heqet.Kagura;

public class KaguraManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__40_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <LoadAsssetAsync>b__40_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass40_0() { }

		internal bool <LoadAsssetAsync>b__1() { }

	}

	[CompilerGenerated]
	private struct <LoadAsssetAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public KaguraManager <>4__this; //Field offset: 0xC
		private <>c__DisplayClass40_0 <>8__1; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14
		private NotesManager <nm>5__2; //Field offset: 0x1C
		private MusicManager <mm>5__3; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static KaguraManager <Instance>k__BackingField; //Field offset: 0x0
	private string commonAssetBundleName; //Field offset: 0x8
	[CompilerGenerated]
	private KaguraScene <KaguraScene>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private RhythmGame <RhythmGame>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private StageGimmickCalculator <StageGimmickCalculator>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private UIController <UIController>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private KaguraLayer <KaguraLayer>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <IsGameFinish>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private HeqetMusicModel <PlayingMusicModel>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private SettingData <PlayingMusicSettingData>k__BackingField; //Field offset: 0x28

	public private static KaguraManager Instance
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

	public static bool IsInitialized
	{
		 get { } //Length: 44
	}

	public KaguraLayer KaguraLayer
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private KaguraScene KaguraScene
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

	public private RhythmGame RhythmGame
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private StageGimmickCalculator StageGimmickCalculator
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private UIController UIController
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public KaguraManager() { }

	[CompilerGenerated]
	private bool <LoadAsssetAsync>b__40_2() { }

	[CompilerGenerated]
	private bool <LoadAsssetAsync>b__40_3() { }

	public void DisableKaguraGimmick() { }

	public void DoLateUpdate() { }

	public void DoUpdate() { }

	public void EnableKaguraGimmickMist() { }

	public void EnableKaguraGimmickQuake() { }

	public void EnableKaguraGimmickVenomMist() { }

	public void GameFinish() { }

	[CompilerGenerated]
	public static KaguraManager get_Instance() { }

	[CompilerGenerated]
	public bool get_IsGameFinish() { }

	public static bool get_IsInitialized() { }

	[CompilerGenerated]
	public KaguraLayer get_KaguraLayer() { }

	[CompilerGenerated]
	public KaguraScene get_KaguraScene() { }

	[CompilerGenerated]
	public HeqetMusicModel get_PlayingMusicModel() { }

	[CompilerGenerated]
	public SettingData get_PlayingMusicSettingData() { }

	[CompilerGenerated]
	public RhythmGame get_RhythmGame() { }

	[CompilerGenerated]
	public StageGimmickCalculator get_StageGimmickCalculator() { }

	[CompilerGenerated]
	public UIController get_UIController() { }

	public void Initialize(KaguraScene kaguraScene) { }

	public bool IsDone() { }

	[AsyncStateMachine(typeof(<LoadAsssetAsync>d__40))]
	private UniTask LoadAsssetAsync() { }

	[CompilerGenerated]
	private static void set_Instance(KaguraManager value) { }

	[CompilerGenerated]
	private void set_IsGameFinish(bool value) { }

	[CompilerGenerated]
	public void set_KaguraLayer(KaguraLayer value) { }

	[CompilerGenerated]
	private void set_KaguraScene(KaguraScene value) { }

	[CompilerGenerated]
	private void set_PlayingMusicModel(HeqetMusicModel value) { }

	[CompilerGenerated]
	private void set_PlayingMusicSettingData(SettingData value) { }

	[CompilerGenerated]
	private void set_RhythmGame(RhythmGame value) { }

	[CompilerGenerated]
	private void set_StageGimmickCalculator(StageGimmickCalculator value) { }

	[CompilerGenerated]
	private void set_UIController(UIController value) { }

	public void SetGameParam(HeqetMusicModel musicModel, SettingData musicSettingData) { }

	public static void SetPrologueData() { }

	public void Terminate() { }

}


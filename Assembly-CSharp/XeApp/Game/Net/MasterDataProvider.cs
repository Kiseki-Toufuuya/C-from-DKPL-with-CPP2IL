namespace XeApp.Game.Net;

public class MasterDataProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Version> <>9__238_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <SelectDataVersion>b__238_0(Version a, Version b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass162_0
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass162_0() { }

		internal bool <InitializeHeqet>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass236_0
	{
		public MasterDataProvider <>4__this; //Field offset: 0x8
		public string downloadURL; //Field offset: 0xC
		public string installPath; //Field offset: 0x10

		public <>c__DisplayClass236_0() { }

		internal Task <GetDownloadTarFile>b__0() { }

	}

	[CompilerGenerated]
	private struct <CheckSchemaHash>d__237 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public TarFile tar; //Field offset: 0x10
		private TaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetDownloadTarFile>d__236 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TarFile> <>t__builder; //Field offset: 0x4
		public MasterDataProvider <>4__this; //Field offset: 0x10
		public AssetPathEntry entry; //Field offset: 0x14
		private <>c__DisplayClass236_0 <>8__1; //Field offset: 0x18
		private TaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFile>d__235 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public string url; //Field offset: 0x10
		public string installPath; //Field offset: 0x14
		private UnityWebRequest <req>5__2; //Field offset: 0x18
		private object <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Initialize>d__228 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public string variant; //Field offset: 0x10
		public MasterDataProvider <>4__this; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeHeqet>d__162 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public MasterDataProvider <>4__this; //Field offset: 0xC
		private <>c__DisplayClass162_0 <>8__1; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeLoad>d__229 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public MasterDataProvider <>4__this; //Field offset: 0x10
		private TaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeModelCaches>d__246 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public MasterDataProvider <>4__this; //Field offset: 0x10
		private TaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeRomMessage>d__215 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public MasterDataProvider <>4__this; //Field offset: 0x10
		private TaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Load>d__231 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public MasterDataProvider <>4__this; //Field offset: 0x10
		private long <currentTime>5__2; //Field offset: 0x18
		private TarFile <tar>5__3; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x24
		private TaskAwaiter<AssetPathEntry> <>u__2; //Field offset: 0x28
		private TaskAwaiter<TarFile> <>u__3; //Field offset: 0x2C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadCharacterVoiceMotionText>d__241 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadDanmakuPassAsync>d__242 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadFromTar>d__230 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public MasterDataProvider <>4__this; //Field offset: 0x10
		public TarFile tar; //Field offset: 0x14
		private TaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadGenericConstantAsync>d__243 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadGenericItemAsync>d__244 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadMissionAsync>d__240 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SelectDBEntry>d__234 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AssetPathEntry> <>t__builder; //Field offset: 0x4
		private AssetRootUrlProvider <urlProvider>5__2; //Field offset: 0x10
		private AssetPathProvider <assetPathProvider>5__3; //Field offset: 0x14
		private TaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class Version
	{
		public GuardInt DataVersion; //Field offset: 0x8
		public GuardLong OpenAt; //Field offset: 0x10

		public Version() { }

	}

	private static MasterDataProvider m_instance; //Field offset: 0x0
	[CompilerGenerated]
	private WorldAreaRepository <WorldAreaRepository>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private WorldSpotRepository <WorldSpotRepository>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private WorldStageRepository <WorldStageRepository>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private WorldOpenConditionsRepository <WorldOpenConditionsRepository>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private WorldShopItemRepository <WorldShopItemRepository>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private WorldTreasureBoxRepository <WorldTreasureBoxRepository>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private WorldBoosterRepository <WorldBoosterRepository>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private PowerLevelRepository <PowerLevelRepository>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private HeroineDanmakuParamRepository <HeroineDanmakuParamRepository>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private NotesJudgeRepository <NotesJudgeRepository>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private ComboFactorRepository <ComboFactorRepository>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private HeqetCardRepository <HeqetCardRepository>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private HeqetHeroineRepository <HeqetHeroineRepository>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private SeriesRepository <SeriesRepository>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private CardRequiredExpRepository <CardRequiredExpRepository>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private HeqetMissionRepository <HeqetMissionRepository>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private IngameBGRepository <IngameBGRepository>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private MusicSelectionDummyRepository <MusicSelectionDummyRepository>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private HeqetHelpGroupRepository <HeqetHelpGroupRepository>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private AchievementRepository <AchievementRepository>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private HeqetEmblemRepository <HeqetEmblemRepository>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private HeqetMusicRepository <HeqetMusicRepository>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private HeqetMusicSelectionRepository <HeqetMusicSelectionRepository>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private NotesSkinRepository <NotesSkinRepository>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private HeqetSortFilterRepository <HeqetSortFilterRepository>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private TenFactorRepository <TenFactorRepository>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private ScoreRankRepository <ScoreRankRepository>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private SkillRepository <SkillRepository>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private GimmickRepository <GimmickRepository>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private StageLevelFactorRepository <StageLevelFactorRepository>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	private MusicLevelFactorRepository <MusicLevelFactorRepository>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private StatusIconsRepository <StatusIconsRepository>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private DlcListRepository <DlcListRepository>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private HeqetMusicTitleJpRepository <HeqetMusicTitleJpRepository>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private ExScoreRepository <ExScoreRepository>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private RecommendCardRepository <RecommendCardRepository>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	private RewardMoneyRepository <RewardMoneyRepository>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private HeqetMusicFolderRepository <HeqetMusicFolderRepository>k__BackingField; //Field offset: 0x9C
	[CompilerGenerated]
	private MusicScoreRepository <MusicScoreRepository>k__BackingField; //Field offset: 0xA0
	private DefaultDataScriptableObject defaultDataScriptableObject; //Field offset: 0xA4
	private MusicScoreCountScriptableObject musicScoreCountScriptableObject; //Field offset: 0xA8
	private EpisodeRepository m_episodeRepository; //Field offset: 0xAC
	public Dictionary<Int32, MissionContext> MissionContextMap; //Field offset: 0xB0
	public Dictionary<Int32, Int32> MissionVarientIDToID; //Field offset: 0xB4
	private Dictionary<Int32, GenericItemContext> m_genericItemContextMap; //Field offset: 0xB8
	private Dictionary<Int32, String> m_genericItemMasterNameMap; //Field offset: 0xBC
	private CharacterParameterRepository m_characterParameterRepository; //Field offset: 0xC0
	public Dictionary<Int32, DanmakuPassContext> DanmakuPassContextMap; //Field offset: 0xC4
	private DefaultMasterDataContext m_masterContext; //Field offset: 0xC8
	[CompilerGenerated]
	private readonly List<Version> <Versions>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	private GuardInt <CurrentDataVersion>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private readonly DatelineChecker <DatelineChecker>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private MessageMapContext <RomMessageMapContext>k__BackingField; //Field offset: 0xDC
	[CompilerGenerated]
	private ErrorDataContext <ErrorDataContext>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private MessageMapContext <MasterMessageMapContext>k__BackingField; //Field offset: 0xE4
	[CompilerGenerated]
	private MessageMapContext <MenuMessageMapContext>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private MessageMapContext <HeqetMessageMapContext>k__BackingField; //Field offset: 0xEC
	[CompilerGenerated]
	private TarFile <CurrentTar>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private bool <IsLoadDebugMaster>k__BackingField; //Field offset: 0xF4
	[CompilerGenerated]
	private bool <IsLoaded>k__BackingField; //Field offset: 0xF5
	public List<GuardLong> MasterRevChangeTimes; //Field offset: 0xF8
	public AssetPathEntry SelectedPathEntry; //Field offset: 0xFC

	public private AchievementRepository AchievementRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private CardRequiredExpRepository CardRequiredExpRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CharacterParameterRepository CharacterParameterRepository
	{
		 get { } //Length: 14
	}

	public private ComboFactorRepository ComboFactorRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private GuardInt CurrentDataVersion
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		private set { } //Length: 26
	}

	public TarFile CurrentTar
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public DatelineChecker DatelineChecker
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public DefaultDataScriptableObject DefaultDataScriptableObject
	{
		 get { } //Length: 14
	}

	public DefaultMasterDataContext DefaultMasterDataContext
	{
		 get { } //Length: 14
	}

	public private DlcListRepository DlcListRepository
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public EpisodeRepository EpisodeRepository
	{
		 get { } //Length: 14
	}

	public private ErrorDataContext ErrorDataContext
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private ExScoreRepository ExScoreRepository
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public Dictionary<Int32, GenericItemContext> GenericItemContextMap
	{
		 get { } //Length: 14
	}

	public Dictionary<Int32, String> GenericItemMasterNameMap
	{
		 get { } //Length: 14
	}

	public private GimmickRepository GimmickRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private HeqetCardRepository HeqetCardRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private HeqetEmblemRepository HeqetEmblemRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private HeqetHelpGroupRepository HeqetHelpGroupRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private HeqetHeroineRepository HeqetHeroineRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private MessageMapContext HeqetMessageMapContext
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private HeqetMissionRepository HeqetMissionRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private HeqetMusicFolderRepository HeqetMusicFolderRepository
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private HeqetMusicRepository HeqetMusicRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private HeqetMusicSelectionRepository HeqetMusicSelectionRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private HeqetMusicTitleJpRepository HeqetMusicTitleJpRepository
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private HeqetSortFilterRepository HeqetSortFilterRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private HeroineDanmakuParamRepository HeroineDanmakuParamRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private IngameBGRepository IngameBGRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public static MasterDataProvider Instance
	{
		 get { } //Length: 510
	}

	public bool IsLoadDebugMaster
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public private bool IsLoaded
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public private MessageMapContext MasterMessageMapContext
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private MessageMapContext MenuMessageMapContext
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private MusicLevelFactorRepository MusicLevelFactorRepository
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public MusicScoreCountScriptableObject MusicScoreCountScriptableObject
	{
		 get { } //Length: 14
	}

	public private MusicScoreRepository MusicScoreRepository
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private MusicSelectionDummyRepository MusicSelectionDummyRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private NotesJudgeRepository NotesJudgeRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private NotesSkinRepository NotesSkinRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private PowerLevelRepository PowerLevelRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private RecommendCardRepository RecommendCardRepository
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private RewardMoneyRepository RewardMoneyRepository
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private MessageMapContext RomMessageMapContext
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private ScoreRankRepository ScoreRankRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private SeriesRepository SeriesRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private SkillRepository SkillRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private StageLevelFactorRepository StageLevelFactorRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private StatusIconsRepository StatusIconsRepository
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private TenFactorRepository TenFactorRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public List<Version> Versions
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public private WorldAreaRepository WorldAreaRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private WorldBoosterRepository WorldBoosterRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private WorldOpenConditionsRepository WorldOpenConditionsRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private WorldShopItemRepository WorldShopItemRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private WorldSpotRepository WorldSpotRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private WorldStageRepository WorldStageRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private WorldTreasureBoxRepository WorldTreasureBoxRepository
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public MasterDataProvider() { }

	[AsyncStateMachine(typeof(<CheckSchemaHash>d__237))]
	private Task CheckSchemaHash(TarFile tar) { }

	[CompilerGenerated]
	public AchievementRepository get_AchievementRepository() { }

	[CompilerGenerated]
	public CardRequiredExpRepository get_CardRequiredExpRepository() { }

	public CharacterParameterRepository get_CharacterParameterRepository() { }

	[CompilerGenerated]
	public ComboFactorRepository get_ComboFactorRepository() { }

	[CompilerGenerated]
	public GuardInt get_CurrentDataVersion() { }

	[CompilerGenerated]
	public TarFile get_CurrentTar() { }

	[CompilerGenerated]
	public DatelineChecker get_DatelineChecker() { }

	public DefaultDataScriptableObject get_DefaultDataScriptableObject() { }

	public DefaultMasterDataContext get_DefaultMasterDataContext() { }

	[CompilerGenerated]
	public DlcListRepository get_DlcListRepository() { }

	public EpisodeRepository get_EpisodeRepository() { }

	[CompilerGenerated]
	public ErrorDataContext get_ErrorDataContext() { }

	[CompilerGenerated]
	public ExScoreRepository get_ExScoreRepository() { }

	public Dictionary<Int32, GenericItemContext> get_GenericItemContextMap() { }

	public Dictionary<Int32, String> get_GenericItemMasterNameMap() { }

	[CompilerGenerated]
	public GimmickRepository get_GimmickRepository() { }

	[CompilerGenerated]
	public HeqetCardRepository get_HeqetCardRepository() { }

	[CompilerGenerated]
	public HeqetEmblemRepository get_HeqetEmblemRepository() { }

	[CompilerGenerated]
	public HeqetHelpGroupRepository get_HeqetHelpGroupRepository() { }

	[CompilerGenerated]
	public HeqetHeroineRepository get_HeqetHeroineRepository() { }

	[CompilerGenerated]
	public MessageMapContext get_HeqetMessageMapContext() { }

	[CompilerGenerated]
	public HeqetMissionRepository get_HeqetMissionRepository() { }

	[CompilerGenerated]
	public HeqetMusicFolderRepository get_HeqetMusicFolderRepository() { }

	[CompilerGenerated]
	public HeqetMusicRepository get_HeqetMusicRepository() { }

	[CompilerGenerated]
	public HeqetMusicSelectionRepository get_HeqetMusicSelectionRepository() { }

	[CompilerGenerated]
	public HeqetMusicTitleJpRepository get_HeqetMusicTitleJpRepository() { }

	[CompilerGenerated]
	public HeqetSortFilterRepository get_HeqetSortFilterRepository() { }

	[CompilerGenerated]
	public HeroineDanmakuParamRepository get_HeroineDanmakuParamRepository() { }

	[CompilerGenerated]
	public IngameBGRepository get_IngameBGRepository() { }

	public static MasterDataProvider get_Instance() { }

	[CompilerGenerated]
	public bool get_IsLoadDebugMaster() { }

	[CompilerGenerated]
	public bool get_IsLoaded() { }

	[CompilerGenerated]
	public MessageMapContext get_MasterMessageMapContext() { }

	[CompilerGenerated]
	public MessageMapContext get_MenuMessageMapContext() { }

	[CompilerGenerated]
	public MusicLevelFactorRepository get_MusicLevelFactorRepository() { }

	public MusicScoreCountScriptableObject get_MusicScoreCountScriptableObject() { }

	[CompilerGenerated]
	public MusicScoreRepository get_MusicScoreRepository() { }

	[CompilerGenerated]
	public MusicSelectionDummyRepository get_MusicSelectionDummyRepository() { }

	[CompilerGenerated]
	public NotesJudgeRepository get_NotesJudgeRepository() { }

	[CompilerGenerated]
	public NotesSkinRepository get_NotesSkinRepository() { }

	[CompilerGenerated]
	public PowerLevelRepository get_PowerLevelRepository() { }

	[CompilerGenerated]
	public RecommendCardRepository get_RecommendCardRepository() { }

	[CompilerGenerated]
	public RewardMoneyRepository get_RewardMoneyRepository() { }

	[CompilerGenerated]
	public MessageMapContext get_RomMessageMapContext() { }

	[CompilerGenerated]
	public ScoreRankRepository get_ScoreRankRepository() { }

	[CompilerGenerated]
	public SeriesRepository get_SeriesRepository() { }

	[CompilerGenerated]
	public SkillRepository get_SkillRepository() { }

	[CompilerGenerated]
	public StageLevelFactorRepository get_StageLevelFactorRepository() { }

	[CompilerGenerated]
	public StatusIconsRepository get_StatusIconsRepository() { }

	[CompilerGenerated]
	public TenFactorRepository get_TenFactorRepository() { }

	[CompilerGenerated]
	public List<Version> get_Versions() { }

	[CompilerGenerated]
	public WorldAreaRepository get_WorldAreaRepository() { }

	[CompilerGenerated]
	public WorldBoosterRepository get_WorldBoosterRepository() { }

	[CompilerGenerated]
	public WorldOpenConditionsRepository get_WorldOpenConditionsRepository() { }

	[CompilerGenerated]
	public WorldShopItemRepository get_WorldShopItemRepository() { }

	[CompilerGenerated]
	public WorldSpotRepository get_WorldSpotRepository() { }

	[CompilerGenerated]
	public WorldStageRepository get_WorldStageRepository() { }

	[CompilerGenerated]
	public WorldTreasureBoxRepository get_WorldTreasureBoxRepository() { }

	[AsyncStateMachine(typeof(<GetDownloadTarFile>d__236))]
	private Task<TarFile> GetDownloadTarFile(AssetPathEntry entry) { }

	[AsyncStateMachine(typeof(<GetFile>d__235))]
	private Task GetFile(string url, string installPath) { }

	[AsyncStateMachine(typeof(<Initialize>d__228))]
	public Task Initialize(string variant = null) { }

	[AsyncStateMachine(typeof(<InitializeHeqet>d__162))]
	private UniTask InitializeHeqet() { }

	[AsyncStateMachine(typeof(<InitializeLoad>d__229))]
	public Task InitializeLoad() { }

	[AsyncStateMachine(typeof(<InitializeModelCaches>d__246))]
	private Task InitializeModelCaches() { }

	[AsyncStateMachine(typeof(<InitializeRomMessage>d__215))]
	public Task InitializeRomMessage() { }

	public bool IsAvailableNewDataVersion(long currentTime) { }

	[AsyncStateMachine(typeof(<Load>d__231))]
	public Task Load() { }

	[AsyncStateMachine(typeof(<LoadCharacterVoiceMotionText>d__241))]
	private Task LoadCharacterVoiceMotionText(TarFile tarFile) { }

	[AsyncStateMachine(typeof(<LoadDanmakuPassAsync>d__242))]
	private Task LoadDanmakuPassAsync(TarFile tarFile) { }

	[AsyncStateMachine(typeof(<LoadFromTar>d__230))]
	private Task LoadFromTar(TarFile tar) { }

	[AsyncStateMachine(typeof(<LoadGenericConstantAsync>d__243))]
	private Task LoadGenericConstantAsync(TarFile tarFile) { }

	[AsyncStateMachine(typeof(<LoadGenericItemAsync>d__244))]
	private Task LoadGenericItemAsync(TarFile tarFile) { }

	[AsyncStateMachine(typeof(<LoadMissionAsync>d__240))]
	private Task LoadMissionAsync(TarFile tarFile) { }

	private void LoadRaidBot(TarFile tarFile) { }

	private void SelectDataVersion(long currentTime) { }

	[AsyncStateMachine(typeof(<SelectDBEntry>d__234))]
	private Task<AssetPathEntry> SelectDBEntry(long installTime, bool loadDebug) { }

	[CompilerGenerated]
	private void set_AchievementRepository(AchievementRepository value) { }

	[CompilerGenerated]
	private void set_CardRequiredExpRepository(CardRequiredExpRepository value) { }

	[CompilerGenerated]
	private void set_ComboFactorRepository(ComboFactorRepository value) { }

	[CompilerGenerated]
	private void set_CurrentDataVersion(GuardInt value) { }

	[CompilerGenerated]
	public void set_CurrentTar(TarFile value) { }

	[CompilerGenerated]
	private void set_DlcListRepository(DlcListRepository value) { }

	[CompilerGenerated]
	private void set_ErrorDataContext(ErrorDataContext value) { }

	[CompilerGenerated]
	private void set_ExScoreRepository(ExScoreRepository value) { }

	[CompilerGenerated]
	private void set_GimmickRepository(GimmickRepository value) { }

	[CompilerGenerated]
	private void set_HeqetCardRepository(HeqetCardRepository value) { }

	[CompilerGenerated]
	private void set_HeqetEmblemRepository(HeqetEmblemRepository value) { }

	[CompilerGenerated]
	private void set_HeqetHelpGroupRepository(HeqetHelpGroupRepository value) { }

	[CompilerGenerated]
	private void set_HeqetHeroineRepository(HeqetHeroineRepository value) { }

	[CompilerGenerated]
	private void set_HeqetMessageMapContext(MessageMapContext value) { }

	[CompilerGenerated]
	private void set_HeqetMissionRepository(HeqetMissionRepository value) { }

	[CompilerGenerated]
	private void set_HeqetMusicFolderRepository(HeqetMusicFolderRepository value) { }

	[CompilerGenerated]
	private void set_HeqetMusicRepository(HeqetMusicRepository value) { }

	[CompilerGenerated]
	private void set_HeqetMusicSelectionRepository(HeqetMusicSelectionRepository value) { }

	[CompilerGenerated]
	private void set_HeqetMusicTitleJpRepository(HeqetMusicTitleJpRepository value) { }

	[CompilerGenerated]
	private void set_HeqetSortFilterRepository(HeqetSortFilterRepository value) { }

	[CompilerGenerated]
	private void set_HeroineDanmakuParamRepository(HeroineDanmakuParamRepository value) { }

	[CompilerGenerated]
	private void set_IngameBGRepository(IngameBGRepository value) { }

	[CompilerGenerated]
	public void set_IsLoadDebugMaster(bool value) { }

	[CompilerGenerated]
	private void set_IsLoaded(bool value) { }

	[CompilerGenerated]
	private void set_MasterMessageMapContext(MessageMapContext value) { }

	[CompilerGenerated]
	private void set_MenuMessageMapContext(MessageMapContext value) { }

	[CompilerGenerated]
	private void set_MusicLevelFactorRepository(MusicLevelFactorRepository value) { }

	[CompilerGenerated]
	private void set_MusicScoreRepository(MusicScoreRepository value) { }

	[CompilerGenerated]
	private void set_MusicSelectionDummyRepository(MusicSelectionDummyRepository value) { }

	[CompilerGenerated]
	private void set_NotesJudgeRepository(NotesJudgeRepository value) { }

	[CompilerGenerated]
	private void set_NotesSkinRepository(NotesSkinRepository value) { }

	[CompilerGenerated]
	private void set_PowerLevelRepository(PowerLevelRepository value) { }

	[CompilerGenerated]
	private void set_RecommendCardRepository(RecommendCardRepository value) { }

	[CompilerGenerated]
	private void set_RewardMoneyRepository(RewardMoneyRepository value) { }

	[CompilerGenerated]
	private void set_RomMessageMapContext(MessageMapContext value) { }

	[CompilerGenerated]
	private void set_ScoreRankRepository(ScoreRankRepository value) { }

	[CompilerGenerated]
	private void set_SeriesRepository(SeriesRepository value) { }

	[CompilerGenerated]
	private void set_SkillRepository(SkillRepository value) { }

	[CompilerGenerated]
	private void set_StageLevelFactorRepository(StageLevelFactorRepository value) { }

	[CompilerGenerated]
	private void set_StatusIconsRepository(StatusIconsRepository value) { }

	[CompilerGenerated]
	private void set_TenFactorRepository(TenFactorRepository value) { }

	[CompilerGenerated]
	private void set_WorldAreaRepository(WorldAreaRepository value) { }

	[CompilerGenerated]
	private void set_WorldBoosterRepository(WorldBoosterRepository value) { }

	[CompilerGenerated]
	private void set_WorldOpenConditionsRepository(WorldOpenConditionsRepository value) { }

	[CompilerGenerated]
	private void set_WorldShopItemRepository(WorldShopItemRepository value) { }

	[CompilerGenerated]
	private void set_WorldSpotRepository(WorldSpotRepository value) { }

	[CompilerGenerated]
	private void set_WorldStageRepository(WorldStageRepository value) { }

	[CompilerGenerated]
	private void set_WorldTreasureBoxRepository(WorldTreasureBoxRepository value) { }

}


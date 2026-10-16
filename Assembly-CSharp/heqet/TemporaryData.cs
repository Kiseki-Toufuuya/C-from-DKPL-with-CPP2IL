namespace Heqet;

public class TemporaryData
{
	internal class DanmakuStageData
	{
		internal class BossData
		{
			public bool IsDefeated; //Field offset: 0x8
			public int MaxBossLifeStock; //Field offset: 0xC
			public int BossLifeStock; //Field offset: 0x10
			public float MaxBossLife; //Field offset: 0x14
			public float BossLife; //Field offset: 0x18
			public bool IsBossAttack; //Field offset: 0x1C
			public float TotalDamage; //Field offset: 0x20
			private int invincibleCounter; //Field offset: 0x24

			public bool IsInvincible
			{
				 get { } //Length: 15
			}

			public BossData() { }

			public void BeginInvincible() { }

			public void EndInvincible() { }

			public bool get_IsInvincible() { }

			public void Reset() { }

		}

		public const int MAX_PLAYER_LIFE_STOCK = 9; //Field offset: 0x0
		public const int MAX_PLAYER_LIFE = 99999; //Field offset: 0x0
		public const float PLAYER_DYING_PERCENT = 0.1; //Field offset: 0x0
		public const int MAX_BOMB_STOCK = 5; //Field offset: 0x0
		public const float USE_BOMB_AT_INVINCIBLE_TIME = 3; //Field offset: 0x0
		public const int MAX_BOSS_LIFE_STOCK = 3; //Field offset: 0x0
		public const int MONEY_SMALL_TAKE_COUNT = 1; //Field offset: 0x0
		public const int MONEY_SMALL_VALUE = 10; //Field offset: 0x0
		public const int MONEY_LARGE_TAKE_COUNT = 5; //Field offset: 0x0
		public const int MONEY_LARGE_VALUE = 50; //Field offset: 0x0
		public int MoneyItemTakeCount; //Field offset: 0x8
		public int TenTakeCount; //Field offset: 0xC
		public int MaxPlayerLifeStock; //Field offset: 0x10
		public int PlayerLifeStock; //Field offset: 0x14
		public int MaxPlayerLife; //Field offset: 0x18
		public float PlayerLife; //Field offset: 0x1C
		public bool IsPlayerNoDamage; //Field offset: 0x20
		public int MaxBombStock; //Field offset: 0x24
		public int BombStock; //Field offset: 0x28
		public int BombUsedCount; //Field offset: 0x2C
		public float BombCooldownTimer; //Field offset: 0x30
		private float pLevelAmount; //Field offset: 0x34
		private int pLevel; //Field offset: 0x38
		public UniqueState UniqueState; //Field offset: 0x3C
		public bool IsUsedItem; //Field offset: 0x40
		public float TotalNormalEnemyDamage; //Field offset: 0x44
		public BossData Boss; //Field offset: 0x48
		public bool Is2LaneStyle; //Field offset: 0x4C

		public bool IsPlayerLifeMax
		{
			 get { } //Length: 26
		}

		public int PLevel
		{
			 get { } //Length: 11
		}

		public float PLevelAmount
		{
			 get { } //Length: 11
			 set { } //Length: 43
		}

		public int PLevelIndex
		{
			 get { } //Length: 24
		}

		public DanmakuStageData() { }

		public bool get_IsPlayerLifeMax() { }

		public int get_PLevel() { }

		public float get_PLevelAmount() { }

		public int get_PLevelIndex() { }

		public float GetTotalEnemiesDamage() { }

		public bool IsPlayerDying() { }

		public bool IsPlayerLifeAndStockEmpty() { }

		public void Reset() { }

		public void set_PLevelAmount(float value) { }

	}

	internal class FreemodeData
	{
		public bool IsFromtoStoryMode; //Field offset: 0x8
		public bool IsDirty; //Field offset: 0x9

		public FreemodeData() { }

	}

	internal class GalleryData
	{
		public bool IsDirty; //Field offset: 0x8
		public bool IsFavoriteOnly; //Field offset: 0x9

		public GalleryData() { }

	}

	internal class InGameInfo
	{
		public HeqetGameMode GameMode; //Field offset: 0x8
		private InGameType m_InGameType; //Field offset: 0xC
		public int StoryModeStageId; //Field offset: 0x10
		public int FreeModeMusicId; //Field offset: 0x14
		public int SelectedId; //Field offset: 0x18
		public int Difficulty; //Field offset: 0x1C
		public bool IsSwapJapanese; //Field offset: 0x20
		public List<Int32> BoosetrItemList; //Field offset: 0x24
		public float CurrentNoteSpeed; //Field offset: 0x28
		public bool IsTouchMode; //Field offset: 0x2C
		public LaneMode LaneMode; //Field offset: 0x30

		public InGameType InGameType
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public InGameInfo() { }

		public InGameType get_InGameType() { }

		public void Reset() { }

		public void set_InGameType(InGameType value) { }

	}

	internal class InGameReturnInfo
	{
		public int StoryModeStageId; //Field offset: 0x8
		public bool StageClear; //Field offset: 0xC

		public InGameReturnInfo() { }

		public void Reset() { }

	}

	internal class KaguraStageData
	{
		public const float MAX_GROOVE_GAUGE = 100; //Field offset: 0x0
		public const float START_GROOVE_GAUGE = 30; //Field offset: 0x0
		public const float GROOVE_GAUGE_GAME_CLEAR_BORDER = 80; //Field offset: 0x0
		private float grooveGauge; //Field offset: 0x8

		public float GrooveGauge
		{
			 get { } //Length: 11
			 set { } //Length: 54
		}

		public KaguraStageData() { }

		public float get_GrooveGauge() { }

		public void Reset() { }

		public void set_GrooveGauge(float value) { }

	}

	internal class PlayRecordData
	{
		internal struct ClearCount
		{
			public int stageClear; //Field offset: 0x0
			public int fullCombo; //Field offset: 0x4
			public int allBrilliant; //Field offset: 0x8
			public int framePerfect; //Field offset: 0xC

		}

		internal class Ranking
		{
			internal struct RankingData
			{
				public int count; //Field offset: 0x0
				public int musicId; //Field offset: 0x4
				public int difficulty; //Field offset: 0x8

			}

			public const int RANKING_MAX = 5; //Field offset: 0x0
			public RankingData[] rankingData; //Field offset: 0x8

			public Ranking() { }

			public void Add(int musicId, int difficult, int count) { }

			public void Clear() { }

		}

		public Ranking freeRanking; //Field offset: 0x8
		public ClearCount[] clearCounts; //Field offset: 0xC
		private float totalRatingScore; //Field offset: 0x10
		private int freePlayTotalPlayCount; //Field offset: 0x14
		private int storyPlayTotalPlayCount; //Field offset: 0x18
		public bool IsStoryMode; //Field offset: 0x1C

		public int AllTotalPlayCount
		{
			 get { } //Length: 14
		}

		public int FreePlayTotalPlayCount
		{
			 get { } //Length: 11
		}

		public int StoryPlayTotalPlayCount
		{
			 get { } //Length: 11
		}

		public float TotalRatingScore
		{
			 get { } //Length: 11
		}

		public PlayRecordData() { }

		public void CreateRanking(SerializableDictionary<Int32, MusicPlayRecord> musicPlayRecordData, bool updateRanking = true, LaneMode filter = -1) { }

		public int get_AllTotalPlayCount() { }

		public int get_FreePlayTotalPlayCount() { }

		public int get_StoryPlayTotalPlayCount() { }

		public float get_TotalRatingScore() { }

	}

	internal class PrologueStateData
	{
		public Queue<Int32> Episodes; //Field offset: 0x8

		public bool IsEnable
		{
			 get { } //Length: 56
		}

		public PrologueStateData() { }

		public bool get_IsEnable() { }

	}

	internal class RhythmGameData
	{
		internal class GraphData
		{
			public float time; //Field offset: 0x8
			public float value; //Field offset: 0xC

			public GraphData() { }

		}

		private float score; //Field offset: 0x8
		private int currentCombo; //Field offset: 0xC
		private int maxCombo; //Field offset: 0x10
		private int totalCombo; //Field offset: 0x14
		public int Perfect; //Field offset: 0x18
		public int Brilliant; //Field offset: 0x1C
		public int Great; //Field offset: 0x20
		public int Bad; //Field offset: 0x24
		public int Miss; //Field offset: 0x28
		public bool StageClear; //Field offset: 0x2C
		public bool ResultFramePerfect; //Field offset: 0x2D
		public bool ResultAllBrilliant; //Field offset: 0x2E
		public bool ResultFullCombo; //Field offset: 0x2F
		public Boolean[] RewardReceive; //Field offset: 0x30
		public Boolean[] RewardReceiveIsNew; //Field offset: 0x34
		public Boolean[] MissionClear; //Field offset: 0x38
		public Boolean[] MissionClearIsNew; //Field offset: 0x3C
		public int AcquiredMoney; //Field offset: 0x40
		public float TakeMoneyRate; //Field offset: 0x44
		public int BeforeCardExp; //Field offset: 0x48
		public int AcquiredCardExp; //Field offset: 0x4C
		public float TakeCardExpRate; //Field offset: 0x50
		public bool HighScoreIsNewRecord; //Field offset: 0x54
		public bool MaxComboIsNewRecord; //Field offset: 0x55
		public float CurrentBPM; //Field offset: 0x58
		public float Precision; //Field offset: 0x5C
		public bool PrecisionIsNewRecord; //Field offset: 0x60
		public int FastCount; //Field offset: 0x64
		public int SlowCount; //Field offset: 0x68
		public int recordCombo; //Field offset: 0x6C
		public float recordPrecision; //Field offset: 0x70
		public List<GraphData> GrooveGraphData; //Field offset: 0x74
		public List<GraphData> PrecisionGraphData; //Field offset: 0x78

		public int CurrentCombo
		{
			 get { } //Length: 11
			 set { } //Length: 36
		}

		public int MaxCombo
		{
			 get { } //Length: 11
		}

		public float RealScore
		{
			 get { } //Length: 11
			 set { } //Length: 38
		}

		public int Score
		{
			 get { } //Length: 20
		}

		public int TotalCombo
		{
			 get { } //Length: 11
		}

		public RhythmGameData() { }

		public int get_CurrentCombo() { }

		public int get_MaxCombo() { }

		public float get_RealScore() { }

		public int get_Score() { }

		public int get_TotalCombo() { }

		public int GetNotesJudgeCount(int notesJudgeIndex) { }

		public bool IsAllMissionClear(int stageId) { }

		public void Reset() { }

		public void set_CurrentCombo(int value) { }

		public void set_RealScore(float value) { }

	}

	internal class UniqueState
	{
		private int invincibleCounter; //Field offset: 0x8
		private int poisonedCounter; //Field offset: 0xC
		private int sandstormCounter; //Field offset: 0x10
		private int redNightCounter; //Field offset: 0x14
		public bool IsGiveDamageUp; //Field offset: 0x18
		public bool IsGiveDamageDown; //Field offset: 0x19
		public bool IsTakeDamageUp; //Field offset: 0x1A
		public bool IsTakeDamageDown; //Field offset: 0x1B
		public bool IsNoLifeRecovery; //Field offset: 0x1C
		public bool IsTakeMoneyUp; //Field offset: 0x1D
		public bool IsTakeMoneyDown; //Field offset: 0x1E
		public bool IsPLevelFactorUp; //Field offset: 0x1F
		public bool IsPLevelFactorDown; //Field offset: 0x20
		public bool IsTakeScoreUp; //Field offset: 0x21
		public bool IsTakeScoreDown; //Field offset: 0x22
		public bool IsGrooveGaugeUp; //Field offset: 0x23
		public bool IsTakeExpUp; //Field offset: 0x24
		public bool IsNotesJudgeTimeLoosely; //Field offset: 0x25

		public bool IsInvincible
		{
			 get { } //Length: 15
		}

		public bool IsPoisoned
		{
			 get { } //Length: 15
		}

		public bool IsRedNight
		{
			 get { } //Length: 15
		}

		public bool IsSandstorm
		{
			 get { } //Length: 15
		}

		public UniqueState() { }

		public void BeginInvincible() { }

		public void BeginPoisoned() { }

		public void BeginRedNight() { }

		public void BeginSandstorm() { }

		public void EndInvincible() { }

		public void EndPoisoned() { }

		public void EndRedNight() { }

		public void EndSandstorm() { }

		public bool get_IsInvincible() { }

		public bool get_IsPoisoned() { }

		public bool get_IsRedNight() { }

		public bool get_IsSandstorm() { }

		public void Reset() { }

	}

	private FormationData m_EditFormation; //Field offset: 0x8
	public InGameInfo InGame; //Field offset: 0xC
	public InGameReturnInfo InGameReturn; //Field offset: 0x10
	public RhythmGameData RhythmGame; //Field offset: 0x14
	public KaguraStageData KaguraStage; //Field offset: 0x18
	public PrologueStateData PrologueState; //Field offset: 0x1C
	public FreemodeData Freemode; //Field offset: 0x20
	public GalleryData Gallery; //Field offset: 0x24
	public DanmakuStageData DanmakuStage; //Field offset: 0x28
	public PlayRecordData PlayRecord; //Field offset: 0x2C

	public FormationData Formation
	{
		 get { } //Length: 11
	}

	public TemporaryData() { }

	public FormationData get_Formation() { }

}


namespace Heqet.StageGimmick;

public class StageGimmickCalculator
{
	internal enum HeqetAttribute
	{
		Em = 0,
		Co = 1,
		Ro = 2,
		All = 3,
	}

	public const float MinPowerLevelAmount = 1; //Field offset: 0x0
	public const float MaxPowerLevelAmount = 4; //Field offset: 0x0
	public const int MinPowerLevel = 1; //Field offset: 0x0
	public const int MaxPowerLevel = 4; //Field offset: 0x0
	public const int MaxPowerLevelIndex = 3; //Field offset: 0x0
	public const float EnemyShotBaseDamage = 10; //Field offset: 0x0
	public const float DefaultCardDropRate = 5; //Field offset: 0x0
	public const float MinDecreaseJudgeTimeLag = 0.00833; //Field offset: 0x0
	public const float GROOVEGAUGE_REDUCTION_BAD = -0.8; //Field offset: 0x0
	public const float GROOVEGAUGE_REDUCTION_MISS = -3; //Field offset: 0x0
	private SGParams sgParams; //Field offset: 0x8
	private RhythmGame rhythmGame; //Field offset: 0xC
	private PlayerController playerController; //Field offset: 0x10
	private RhythmGameData rhythmGameData; //Field offset: 0x14
	private KaguraStageData kaguraStageData; //Field offset: 0x18
	private DanmakuStageData danmakuStageData; //Field offset: 0x1C
	private bool isDanmaku; //Field offset: 0x20
	private bool isStoryMode; //Field offset: 0x21
	[CompilerGenerated]
	private Action OnPlayerDefeat; //Field offset: 0x24
	[CompilerGenerated]
	private Action OnPlayerLostLifeStock; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnBossLostLifeStock; //Field offset: 0x2C
	[CompilerGenerated]
	private Action OnBossDefeat; //Field offset: 0x30
	private bool isAttributeAdvantage; //Field offset: 0x34
	private int freeModeExpecteScore; //Field offset: 0x38

	public event Action OnBossDefeat
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public event Action OnBossLostLifeStock
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public event Action OnPlayerDefeat
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public event Action OnPlayerLostLifeStock
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public float BossLife
	{
		 get { } //Length: 30
		 set { } //Length: 29
	}

	public bool IsEnableMineNotes
	{
		 get { } //Length: 30
	}

	public SGParams Params
	{
		 get { } //Length: 11
	}

	public float PlayerLife
	{
		 get { } //Length: 23
		 set { } //Length: 35
	}

	public StageGimmickCalculator() { }

	[CompilerGenerated]
	public void add_OnBossDefeat(Action value) { }

	[CompilerGenerated]
	public void add_OnBossLostLifeStock(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerDefeat(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerLostLifeStock(Action value) { }

	public void AddBomb(int num = 1) { }

	public void AddGrooveGauge(int judge) { }

	public void AddMoney(int value) { }

	public void AddPlayerLifeStock(int num = 1) { }

	public void AddPLevelAmount(float value) { }

	public void AddRhythmGameScore(int judge) { }

	public void AddScoreFixed(float value) { }

	public void AddSTGScore(float value) { }

	public void AddTakeMoneyItemCount(int value) { }

	public void AddTen(GimmickItemType gimmickItemType) { }

	public int ApplyFreeModeExpecteScore(RhythmGame rhythmGame_) { }

	public void ApplyFullComboFlags() { }

	private void ApplyGimmickEffectToParam(GimmickModel gimmickModel) { }

	private bool ApplyGimmickFromAchievement(AchievementType achievementType) { }

	private void ApplyGimmickFromBooster() { }

	private void ApplyGimmickToParam(int gimmickId) { }

	public void ApplyScoreRate(float rate) { }

	private void ApplySkillToParam(int skillId) { }

	private void ApplyStageGimmickEffectToParam() { }

	public void BossEnemyToDamage(BossEnemy bossEnemy, ShotCategory shotCategory) { }

	public int CalcAcquireCardExp(int acquirableExp, int score, bool stageClear) { }

	public int CalcAcquireMoney(int acquirableMoney, int score, int missionClearCount, bool stageClear) { }

	public float CalcMaxBossLife(float baseLife) { }

	public float CalcMaxNormalEnemyLife(float baseLife) { }

	public float CalcPlayerShotToEnemyDamage(ShotCategory shotCategory) { }

	public bool CanUseBomb() { }

	public static bool CheckCardAttribute(int attribute) { }

	public void DoUpdate() { }

	public float get_BossLife() { }

	public bool get_IsEnableMineNotes() { }

	public SGParams get_Params() { }

	public float get_PlayerLife() { }

	public float GetComboCountThresholdForValue() { }

	public int GetFreeModeExpecteScore() { }

	public float GetJudgeTimeLag(NotesJudge notesJudge) { }

	private float GetMissionClearCountFactor(int value) { }

	public float GetNoteSpeedScale(SettingData settingData) { }

	public static bool HeqetMissionEffectCheck(int effectId, int param1, int param2, int param3, RecordData recordData) { }

	public void Initialize(RhythmGame rhythmGame_, PlayerController playerController_ = null, StageParams stageParams = null) { }

	private void Initialize_Achievement() { }

	private void Initialize_DanmakuStageParams() { }

	private void Initialize_KaguraStageParams(RhythmGame rhythmGame_) { }

	public bool IsEnableNotesChangeGimmick(NotesChangeGimmickTypes type) { }

	public void NormalEnemyToDamage(NormalEnemy enemy, ShotCategory shotCategory, bool forceKill = false) { }

	private void OnLaneJudgeBefore(NoteData noteData, int judge) { }

	public void PlayerToDamage(Player player, ShotCategory shotCategory, float baseDamage) { }

	[CompilerGenerated]
	public void remove_OnBossDefeat(Action value) { }

	[CompilerGenerated]
	public void remove_OnBossLostLifeStock(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerDefeat(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerLostLifeStock(Action value) { }

	public void RemovePlayerLifeStock(bool force = true) { }

	public void set_BossLife(float value) { }

	public void set_PlayerLife(float value) { }

	private void SetBossLife(float value) { }

	public void SetPlayerLife(float value, bool force = false, bool immortal = false, bool lifeStockGuard = false) { }

	public void Terminate() { }

	private void UpdateFactorsFromDanmaku() { }

	private void UpdateUniqueStates() { }

	public void UseBomb() { }

}


namespace Heqet.Danmaku;

public class StageController : MonoBehaviour, INotificationReceiver
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public List<Vector3Int> destPosList; //Field offset: 0x8

		public <>c__DisplayClass56_0() { }

		internal void <PlayBulletLostEffects>b__0() { }

	}

	[CompilerGenerated]
	private struct <LoadAsssetAsync>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public StageController <>4__this; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float HEIGHT = 6; //Field offset: 0x0
	public string BossTimelineName; //Field offset: 0x10
	public string BossTrackName; //Field offset: 0x14
	[Header("Pアイテムを生成する特定コンボ倍数")]
	public int ComboMultiple; //Field offset: 0x18
	private TimelineManager timelineManager; //Field offset: 0x1C
	[SerializeField]
	private BossEnemy bossEnemy; //Field offset: 0x20
	[SerializeField]
	private eStageBackground stageBackground; //Field offset: 0x24
	[SerializeField]
	private float stageBackgroundStartTime; //Field offset: 0x28
	private DanmakuBossCutIn bossCutIn; //Field offset: 0x2C
	private bool isDone; //Field offset: 0x30
	private int currCombo; //Field offset: 0x34
	private PropertyName SignalName_ShowBossLifeGauge; //Field offset: 0x38
	private PropertyName SignalName_HideBossLifeGauge; //Field offset: 0x3C
	private PropertyName SignalName_BossCutIn; //Field offset: 0x40
	private PropertyName SignalName_BossAttackActive; //Field offset: 0x44
	private PropertyName SignalName_BossAttackInactive; //Field offset: 0x48
	private PropertyName SignalName_BossAnimationAttack; //Field offset: 0x4C
	private PropertyName SignalName_BossAnimationDamage; //Field offset: 0x50
	private PropertyName SignalName_BossAnimationExtra; //Field offset: 0x54
	private PropertyName SignalName_BossShow; //Field offset: 0x58
	private PropertyName SignalName_BossHide; //Field offset: 0x5C
	private PropertyName SignalName_BossCollisionEnable; //Field offset: 0x60
	private PropertyName SignalName_BossCollisionDisable; //Field offset: 0x64
	private PropertyName SignalName_EnemyBulletEraser; //Field offset: 0x68
	private PropertyName SignalName_NotificationEffect1; //Field offset: 0x6C
	private PropertyName SignalName_NotificationEffect2; //Field offset: 0x70

	public BossEnemy BossEnemy
	{
		 get { } //Length: 11
	}

	public bool IsInitialized
	{
		 get { } //Length: 11
	}

	public eStageBackground StageBackground
	{
		 get { } //Length: 11
	}

	public float StageBackgroundStartTime
	{
		 get { } //Length: 11
	}

	public TimelineManager TimelineManager
	{
		 get { } //Length: 297
	}

	public StageController() { }

	[CompilerGenerated]
	private bool <LoadAsssetAsync>b__22_0() { }

	[CompilerGenerated]
	private void <OnNotify>b__49_0() { }

	public void BossDefeat() { }

	private void CheckCombo() { }

	public void CreatePowerItem(bool isSmall, Vector3 position) { }

	private void CreatePowerItemForCombo(int times, Vector3 position) { }

	public void CreatePowerItemGroup(bool isSmall, Vector3 position) { }

	private void CreateSignalNames() { }

	public void CreatesTenFromActiveBulletInfo(List<ActiveBulletInfo> infoList) { }

	public void CreateTenItem(bool isSmall, Vector3 position) { }

	public void CreateTenItemGroup(bool isSmall, Vector3 position) { }

	public void DoUpdate() { }

	public void EnemyBulletEraser(bool dontDropItem = false) { }

	public BossEnemy get_BossEnemy() { }

	public bool get_IsInitialized() { }

	public eStageBackground get_StageBackground() { }

	public float get_StageBackgroundStartTime() { }

	public TimelineManager get_TimelineManager() { }

	private void InitComboList() { }

	public void Initialize(TimelineManager _timelineManager) { }

	public bool IsDone() { }

	[AsyncStateMachine(typeof(<LoadAsssetAsync>d__22))]
	private UniTask LoadAsssetAsync() { }

	public override void OnNotify(Playable origin, INotification notification, object context) { }

	public void Pause(bool enable) { }

	public void Play() { }

	public void PlayBulletLostEffects(List<ActiveBulletInfo> infoList) { }

	private void PlayPowerItemEffect(Vector3 position) { }

	public void Terminate() { }

}


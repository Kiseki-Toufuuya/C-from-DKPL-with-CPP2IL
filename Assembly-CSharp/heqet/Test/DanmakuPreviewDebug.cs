namespace Heqet.Test;

public class DanmakuPreviewDebug : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public AssetBundleLoadAllAssetOperationBase common; //Field offset: 0x8

		public <>c__DisplayClass51_0() { }

		internal bool <LoadEffect>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass52_0() { }

		internal bool <LoadAllBullet>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public int id; //Field offset: 0x8
		public DanmakuPreviewDebug <>4__this; //Field offset: 0xC

		public <>c__DisplayClass56_0() { }

		internal void <CreateCharacter>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	[CompilerGenerated]
	private struct <LoadAllBullet>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public DanmakuPreviewDebug <>4__this; //Field offset: 0xC
		private <>c__DisplayClass52_0 <>8__1; //Field offset: 0x10
		private Enumerator<Int32, String> <>7__wrap1; //Field offset: 0x14
		private KeyValuePair<Int32, String> <character>5__3; //Field offset: 0x2C
		private string <fileName>5__4; //Field offset: 0x34
		private Awaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadEffect>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public DanmakuPreviewDebug <>4__this; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string PATH = "prefab/danmaku/player/"; //Field offset: 0x0
	private const float SPEED = 0.05; //Field offset: 0x0
	private const float INPUT_SMOOTH_TIME = 0.1; //Field offset: 0x0
	private readonly Dictionary<Int32, String> CHARACTER_DICTIONARY; //Field offset: 0x10
	private readonly Vector3 START_POS; //Field offset: 0x14
	[SerializeField]
	private Camera m_Camera; //Field offset: 0x20
	[SerializeField]
	private Dropdown m_CharacterDropdown; //Field offset: 0x24
	[SerializeField]
	private Dropdown m_SubCharacterDropdown; //Field offset: 0x28
	[SerializeField]
	private Toggle m_FireToggle; //Field offset: 0x2C
	[SerializeField]
	private Toggle m_ExFireToggle; //Field offset: 0x30
	[SerializeField]
	private Toggle m_SubFireToggle; //Field offset: 0x34
	[SerializeField]
	private Toggle m_MoveToggle; //Field offset: 0x38
	[SerializeField]
	private Toggle m_EnemyToggle; //Field offset: 0x3C
	[SerializeField]
	private Toggle m_EffectToggle; //Field offset: 0x40
	[SerializeField]
	private Toggle m_UIShowToggle; //Field offset: 0x44
	[SerializeField]
	private Text m_BulletName; //Field offset: 0x48
	[SerializeField]
	private Animator m_CharacterAnimator; //Field offset: 0x4C
	[SerializeField]
	private Transform m_Root; //Field offset: 0x50
	[SerializeField]
	private Transform m_BulletRoot; //Field offset: 0x54
	[SerializeField]
	private Transform m_EnemyRoot; //Field offset: 0x58
	[SerializeField]
	private GameObject m_Dropdowns; //Field offset: 0x5C
	[SerializeField]
	private GameObject m_Msgs; //Field offset: 0x60
	[SerializeField]
	private GameObject m_Toggles; //Field offset: 0x64
	[SerializeField]
	private GameObject m_RGB; //Field offset: 0x68
	[SerializeField]
	private GameObject m_Mask; //Field offset: 0x6C
	[SerializeField]
	private DanmakuPreviewEnemy m_Enemy; //Field offset: 0x70
	private int m_CurrCharacterIndex; //Field offset: 0x74
	private int m_CurrBulletIndex; //Field offset: 0x78
	private int m_CurrSubCharacterIndex; //Field offset: 0x7C
	private int m_CurrSubBulletIndex; //Field offset: 0x80
	private bool m_IsFire; //Field offset: 0x84
	private bool m_IsExFire; //Field offset: 0x85
	private bool m_IsSubFire; //Field offset: 0x86
	private bool m_IsMove; //Field offset: 0x87
	private bool m_IsShowEnemy; //Field offset: 0x88
	private bool m_IsShowEffect; //Field offset: 0x89
	private bool m_LoadEffectOver; //Field offset: 0x8A
	private bool m_LoadBulletOver; //Field offset: 0x8B
	private bool m_Inited; //Field offset: 0x8C
	private float m_InputVelocityX; //Field offset: 0x90
	private float m_InputVelocityY; //Field offset: 0x94
	private Vector2 m_InputData; //Field offset: 0x98
	private GameObject m_BulletTarget; //Field offset: 0xA0
	private EffectObjectBase m_BombEffect; //Field offset: 0xA4
	private BulletController m_CurrExBullet; //Field offset: 0xA8
	private BulletController m_CurrSubBullet; //Field offset: 0xAC
	private List<BulletController> m_CurrBullets; //Field offset: 0xB0
	private Dictionary<Int32, List`1<BulletController>> m_CharacterBulletDic; //Field offset: 0xB4
	private Dictionary<Int32, BulletController> m_CharacterExBulletDic; //Field offset: 0xB8

	public DanmakuPreviewDebug() { }

	[CompilerGenerated]
	private void <InitToggleSetting>b__54_0(bool b) { }

	private void BulletFire(bool isFire) { }

	private void ChangeBulletIndex(int next) { }

	public void ChangeCameraColor(string hexColor) { }

	private void CharacterMove(bool isMove) { }

	private void CharacterValueChanged(int index) { }

	private void CreateCharacter(int id) { }

	private void ExBulletFire(bool isFire) { }

	private void InitBullet(BulletController bullet) { }

	private void InitCharacter() { }

	private void InitDropdown() { }

	private void InitToggleSetting() { }

	[AsyncStateMachine(typeof(<LoadAllBullet>d__52))]
	private UniTask LoadAllBullet() { }

	[AsyncStateMachine(typeof(<LoadEffect>d__51))]
	private UniTask LoadEffect() { }

	public void NextCharacter() { }

	public void PlayAnimation(string name) { }

	public void PrevCharacter() { }

	private void ResetMainBulletPlay() { }

	private void SetBulletShot(BulletController bullet, bool shot) { }

	private void ShowEffect(bool enable) { }

	private void ShowEnemy(bool enable) { }

	private void Start() { }

	private void SubBulletFire(bool isFire) { }

	private void SubCharacterValueChanged(int index) { }

	private Color ToColor(string color) { }

	private void Update() { }

}


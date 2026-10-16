namespace Heqet.Danmaku;

public class DropMotion : DropMotionBase
{
	private const int CHECK_LAYERS = 268435456; //Field offset: 0x0
	[Header("スケール")]
	[SerializeField]
	private float scale; //Field offset: 0x10
	[Header("プレイヤーに吸収される距離")]
	[SerializeField]
	private float distance; //Field offset: 0x14
	[Header("落ちる加速度")]
	[SerializeField]
	private float fallAddSpeed; //Field offset: 0x18
	[Header("飛ばされる最小スピード")]
	[SerializeField]
	private float dashMinSpeed; //Field offset: 0x1C
	[Header("飛ばされる最大スピード")]
	[SerializeField]
	private float dashMaxSpeed; //Field offset: 0x20
	[SerializeField]
	private UnityEvent OnContact; //Field offset: 0x24
	[SerializeField]
	private UnityEvent OnKill; //Field offset: 0x28
	private float m_Speed; //Field offset: 0x2C
	private float m_DashTime; //Field offset: 0x30
	private float m_Timer; //Field offset: 0x34
	private Vector3 m_StartPos; //Field offset: 0x38
	private bool enableFalling; //Field offset: 0x44
	private bool m_IsEnemyBulletEraserProcessing; //Field offset: 0x45
	private bool isInitialized; //Field offset: 0x46

	public DropMotion() { }

	[CompilerGenerated]
	private void <CheckPlayer>b__17_0() { }

	private bool CheckPlayer() { }

	private void Contact() { }

	public virtual void Initialize(Vector3 startPos) { }

	private void Kill() { }

	private void Update() { }

}


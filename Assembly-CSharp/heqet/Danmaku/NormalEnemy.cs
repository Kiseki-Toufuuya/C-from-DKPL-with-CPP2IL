namespace Heqet.Danmaku;

[RequireComponent(typeof(STGGimmick))]
public class NormalEnemy : MonoBehaviour, IEnemy
{
	private enum DropItemType
	{
		None = 0,
		A_SmallOne = 1,
		B_SmallGroup = 2,
		C_LargeOne = 3,
		D_LargeGrop = 4,
	}

	internal enum HitEffects
	{
		hit_01 = 0,
		hit_02 = 1,
		hit_03 = 2,
		hit_04 = 3,
		hit_05 = 4,
		hit_06 = 5,
	}

	[SerializeField]
	private GameObject displayObject; //Field offset: 0x10
	[SerializeField]
	private float maxLife; //Field offset: 0x14
	[SerializeField]
	private int defeatedScore; //Field offset: 0x18
	[SerializeField]
	private bool enableShot; //Field offset: 0x1C
	[SerializeField]
	private EffectBullets effectBulletId; //Field offset: 0x20
	[SerializeField]
	private HitEffects hitEffectId; //Field offset: 0x24
	[SerializeField]
	private HitEffects deadEffectId; //Field offset: 0x28
	[SerializeField]
	private DropItemType dropItemType; //Field offset: 0x2C
	private float life; //Field offset: 0x30
	private bool isShow; //Field offset: 0x34
	public readonly Int32[] ToEffectDefine; //Field offset: 0x38

	public int DefeatedScore
	{
		 get { } //Length: 11
	}

	public override GameObject GameObject
	{
		 get { } //Length: 16
	}

	public bool IsDead
	{
		 get { } //Length: 18
	}

	public float Life
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public NormalEnemy() { }

	private void Awake() { }

	private void CreateItem(Vector3 position) { }

	public int get_DefeatedScore() { }

	public override GameObject get_GameObject() { }

	public bool get_IsDead() { }

	public float get_Life() { }

	public void Hide() { }

	public void Kill() { }

	private void OnDead() { }

	public void OnParticleCollision(GameObject other) { }

	public void OnTimelineEnd() { }

	public void OnTimelineStart() { }

	public void set_Life(float value) { }

	public void Shot() { }

	public void Show() { }

}


namespace Heqet.Danmaku;

[RequireComponent(typeof(SpriteRenderer))]
public class NormalEnemyAnimation : MonoBehaviour
{
	[SerializeField]
	private List<Sprite> sprites; //Field offset: 0x10
	[SerializeField]
	private float animationSpeedTime; //Field offset: 0x14
	private SpriteRenderer spriteRenderer; //Field offset: 0x18
	private float animationTimer; //Field offset: 0x1C
	private int spriteIndex; //Field offset: 0x20

	public NormalEnemyAnimation() { }

	private void Awake() { }

	private void Update() { }

}


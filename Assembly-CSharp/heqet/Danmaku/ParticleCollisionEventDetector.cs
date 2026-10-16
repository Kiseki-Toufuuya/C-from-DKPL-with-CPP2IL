namespace Heqet.Danmaku;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleCollisionEventDetector : MonoBehaviour
{
	private ParticleSystem particle; //Field offset: 0x10
	private List<ParticleCollisionEvent> collisionEventList; //Field offset: 0x14

	public ParticleCollisionEventDetector() { }

	private void OnParticleCollision(GameObject obj) { }

	private void Start() { }

}


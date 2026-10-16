namespace Heqet;

[RequireComponent(typeof(Collider))]
public class ParticleCollisionDetector : MonoBehaviour
{
	[SerializeField]
	private UnityEvent<GameObject> onParticleCollision; //Field offset: 0x10
	[SerializeField]
	private UnityEvent<GameObject, Vector3> onParticleCollisionAtPosition; //Field offset: 0x14

	public ParticleCollisionDetector() { }

	private void OnParticleCollision(GameObject other) { }

	public void OnParticleCollisionAtPosition(GameObject other, Vector3 position) { }

}


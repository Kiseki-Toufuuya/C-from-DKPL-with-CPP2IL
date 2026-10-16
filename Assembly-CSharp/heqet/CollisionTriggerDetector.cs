namespace Heqet;

[RequireComponent(typeof(Collider))]
public class CollisionTriggerDetector : MonoBehaviour
{
	[SerializeField]
	private UnityEvent<Collider> onTriggerEnter; //Field offset: 0x10
	[SerializeField]
	private UnityEvent<Collider> onTriggerStay; //Field offset: 0x14
	[SerializeField]
	private UnityEvent<Collider> onTriggerExit; //Field offset: 0x18

	public CollisionTriggerDetector() { }

	private void OnTriggerEnter(Collider other) { }

	private void OnTriggerExit(Collider other) { }

	private void OnTriggerStay(Collider other) { }

}


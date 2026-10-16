namespace Heqet;

[ExecuteAlways]
public class AspectKeeper : MonoBehaviour
{
	[SerializeField]
	private Camera targetCamera; //Field offset: 0x10
	[SerializeField]
	private Vector2 aspectVec; //Field offset: 0x14

	public AspectKeeper() { }

	private void Reset() { }

	private void Update() { }

}


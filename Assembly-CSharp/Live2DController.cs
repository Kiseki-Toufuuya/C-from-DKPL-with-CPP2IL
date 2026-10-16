//Type is in global namespace

public class Live2DController : MonoBehaviour
{
	[SerializeField]
	private GameObject model; //Field offset: 0x10
	[SerializeField]
	private RuntimeAnimatorController controller; //Field offset: 0x14
	[SerializeField]
	public Animator animator; //Field offset: 0x18

	public Live2DController() { }

	private void Awake() { }

}


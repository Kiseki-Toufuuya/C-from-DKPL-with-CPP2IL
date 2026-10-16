namespace heqet;

[RequireComponent(typeof(Image))]
public class CursorImageAnimator : MonoBehaviour
{
	[SerializeField]
	private Image image; //Field offset: 0x10
	[SerializeField]
	private float duration; //Field offset: 0x14
	[SerializeField]
	private float minAlpha; //Field offset: 0x18

	public CursorImageAnimator() { }

	private void Awake() { }

	private void Reset() { }

}


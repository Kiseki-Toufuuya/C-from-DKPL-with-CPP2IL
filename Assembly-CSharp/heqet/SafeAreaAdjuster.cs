namespace Heqet;

public class SafeAreaAdjuster : MonoBehaviour
{
	[SerializeField]
	private bool left; //Field offset: 0x10
	[SerializeField]
	private bool right; //Field offset: 0x11
	[SerializeField]
	private bool top; //Field offset: 0x12
	[SerializeField]
	private bool bottom; //Field offset: 0x13
	private Rect safeArea; //Field offset: 0x14

	public SafeAreaAdjuster() { }

	private void Awake() { }

	private void Start() { }

}


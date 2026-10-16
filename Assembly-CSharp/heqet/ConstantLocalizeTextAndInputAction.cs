namespace Heqet;

public class ConstantLocalizeTextAndInputAction : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI label; //Field offset: 0x10
	[SerializeField]
	private string key; //Field offset: 0x14
	[SerializeField]
	private InputActionReference inputAction; //Field offset: 0x18
	[SerializeField]
	private uint compositIndexMask; //Field offset: 0x1C

	public ConstantLocalizeTextAndInputAction() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void Reset() { }

	private void Start() { }

	private void UpdateString(InputDevice currentDevice) { }

}


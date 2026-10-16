//Type is in global namespace

public class TextMeshProSpriteButtonUpdater : MonoBehaviour
{
	[SerializeField]
	private InputActionAsset inputActionAsset; //Field offset: 0x10
	[SerializeField]
	private TMP_SpriteAsset buttonAsset; //Field offset: 0x14
	[SerializeField]
	private TMP_SpriteAsset inputAsset; //Field offset: 0x18
	private InputDevice lastestDevice; //Field offset: 0x1C

	public TextMeshProSpriteButtonUpdater() { }

	private void Awake() { }

	private TMP_SpriteGlyph GetActionGlyph(InputDevice currentDevice, InputAction action) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	private void UpdateSpriteTable(InputDevice device) { }

}


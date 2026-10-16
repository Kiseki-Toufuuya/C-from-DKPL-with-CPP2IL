namespace Heqet;

[RequireComponent(typeof(SpriteRenderer))]
public class InputActionSprite : MonoBehaviour
{
	[SerializeField]
	private TMP_SpriteAsset m_SpriteAsset; //Field offset: 0x10
	[SerializeField]
	private InputActionReference m_InputAction; //Field offset: 0x14
	[SerializeField]
	private SpriteRenderer m_SpriteRendere; //Field offset: 0x18
	private int m_SpriteIndex; //Field offset: 0x1C
	private StringBuilder m_sb; //Field offset: 0x20
	private bool isSetupd; //Field offset: 0x24

	public InputActionSprite() { }

	public void OnDestroy() { }

	private void Reset() { }

	public void Setup() { }

	private void UpdateSprite(InputDevice device) { }

}


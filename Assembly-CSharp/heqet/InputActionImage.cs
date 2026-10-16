namespace Heqet;

public class InputActionImage : Image
{
	[SerializeField]
	private TMP_SpriteAsset m_SpriteAsset; //Field offset: 0xB4
	[SerializeField]
	private InputActionReference m_InputAction; //Field offset: 0xB8
	[SerializeField]
	private float m_SpriteScale; //Field offset: 0xBC
	private int m_SpriteIndex; //Field offset: 0xC0
	private StringBuilder m_sb; //Field offset: 0xC4

	public InputActionImage() { }

	protected virtual void Awake() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnEnable() { }

	private void UpdateSprite(InputDevice device) { }

}


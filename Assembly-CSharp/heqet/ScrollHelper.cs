namespace Heqet;

public class ScrollHelper : MonoBehaviour
{
	private const float PAGE_SCALE = 10; //Field offset: 0x0
	[SerializeField]
	private ScrollRect scrollRect; //Field offset: 0x10
	[SerializeField]
	private InputActionReference nvigationInputAction; //Field offset: 0x14
	[SerializeField]
	private InputActionReference pageScrollNvigationInputAction; //Field offset: 0x18
	[SerializeField]
	public bool isSelectedOnly; //Field offset: 0x1C
	[SerializeField]
	private bool m_disablePageScroll; //Field offset: 0x1D
	private PointerEventData pointerEventData; //Field offset: 0x20

	private bool isCrossAxisPageNavigation
	{
		private get { } //Length: 92
	}

	public ScrollHelper() { }

	private void Awake() { }

	private bool get_isCrossAxisPageNavigation() { }

	private void Update() { }

}


//Type is in global namespace

public class ReturnLastSelection : MonoBehaviour, IPointerUpHandler, IEventSystemHandler
{
	private GameObject lastSelectedGameObject; //Field offset: 0x10
	private Selectable selectable; //Field offset: 0x14

	public ReturnLastSelection() { }

	public bool IsEnableNavigation() { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public void Update() { }

}


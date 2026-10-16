//Type is in global namespace

public class StageSelectOnWheelScroll : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	public Action<PointerEventData> OnScrollCallback; //Field offset: 0x10

	public StageSelectOnWheelScroll() { }

	public override void OnScroll(PointerEventData eventData) { }

}


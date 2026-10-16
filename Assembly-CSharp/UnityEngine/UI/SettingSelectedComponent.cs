namespace UnityEngine.UI;

public class SettingSelectedComponent : MonoBehaviour, ISelectHandler, IEventSystemHandler, IPointerClickHandler, ISubmitHandler
{
	public Action<BaseEventData> onSelect; //Field offset: 0x10
	public Action<BaseEventData> onDeselect; //Field offset: 0x14
	public Action<BaseEventData> onPointerClick; //Field offset: 0x18
	public Action<BaseEventData> onSubmit; //Field offset: 0x1C

	public SettingSelectedComponent() { }

	public void OnDeselect(BaseEventData eventData) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnSelect(BaseEventData eventData) { }

	private override void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(BaseEventData eventData) { }

}


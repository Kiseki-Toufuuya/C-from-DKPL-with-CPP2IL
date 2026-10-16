//Type is in global namespace

public class ListNavigationRoot : SelectableGroup, INestedSelectable
{
	public Action<BaseEventData> onSelect; //Field offset: 0xB8
	public Action<BaseEventData> onDeselect; //Field offset: 0xBC
	public Func<AxisEventData, Boolean> onMove; //Field offset: 0xC0
	public Func<GameObject> getSelectGameobject; //Field offset: 0xC4

	public ListNavigationRoot() { }

	public virtual GameObject GetSelectedGameObject() { }

	public virtual void OnDeselect(BaseEventData eventData) { }

	public virtual void OnMove(AxisEventData eventData) { }

	public virtual void OnSelect(BaseEventData eventData) { }

}


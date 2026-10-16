//Type is in global namespace

public class SelectableGroup : Selectable
{
	public Selectable[] m_selectables; //Field offset: 0xB4

	public SelectableGroup() { }

	private Selectable FindGroupSelectable(GameObject origin, Vector3 dir) { }

	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	public override GameObject GetSelectedGameObject() { }

	private void NavigateGroup(AxisEventData eventData, Selectable sel) { }

	public virtual void OnMove(AxisEventData eventData) { }

}


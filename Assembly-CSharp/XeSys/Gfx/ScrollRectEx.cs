namespace XeSys.Gfx;

public class ScrollRectEx : ScrollRect
{
	private static List<RaycastResult> m_raycastResults; //Field offset: 0x0
	private GameObject m_lastSelectedObj; //Field offset: 0xF4
	[SerializeField]
	private float m_dragDistanceLimit; //Field offset: 0xF8

	private static ScrollRectEx() { }

	public ScrollRectEx() { }

	protected bool checkValidEvent(PointerEventData eventData) { }

	protected PointerEventData copyEventData(PointerEventData original) { }

	protected static RaycastResult getFirstRaycast(List<RaycastResult> results) { }

	protected void notifyClickEvent(RaycastResult raycast, PointerEventData original) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

}


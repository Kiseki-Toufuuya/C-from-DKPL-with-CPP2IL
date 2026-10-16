namespace XeApp.Game;

public class UiScrollListParameter : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IEndDragHandler
{
	public Vector2 CellSize; //Field offset: 0x10
	public Vector2 MarginTop; //Field offset: 0x18
	public Vector2 MarginInterbal; //Field offset: 0x20
	public Vector2 MarginBottom; //Field offset: 0x28
	[HideInInspector]
	private bool isScrollDrag; //Field offset: 0x30
	[HideInInspector]
	private bool isSnap; //Field offset: 0x31
	[HideInInspector]
	private bool isSnapDrag; //Field offset: 0x32

	public bool IsScrollDrag
	{
		 get { } //Length: 84
	}

	public bool IsSnap
	{
		 get { } //Length: 84
	}

	public bool IsSnapDrag
	{
		 get { } //Length: 84
	}

	public UiScrollListParameter() { }

	public bool get_IsScrollDrag() { }

	public bool get_IsSnap() { }

	public bool get_IsSnapDrag() { }

	public override void OnEndDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

}


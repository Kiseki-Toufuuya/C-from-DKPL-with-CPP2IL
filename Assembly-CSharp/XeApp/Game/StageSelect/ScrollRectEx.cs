namespace XeApp.Game.StageSelect;

public class ScrollRectEx : ScrollRect, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	private readonly int POSITION_COLLECT_COUNT; //Field offset: 0xF4
	private readonly string DISABLE_OBJECT_NAME_1; //Field offset: 0xF8
	private readonly string DISABLE_OBJECT_NAME_2; //Field offset: 0xFC
	private readonly float LONG_TAP_TIME; //Field offset: 0x100
	private Vector2 m_PreDragPosition; //Field offset: 0x104
	private Queue<Single> m_PositionQueue; //Field offset: 0x10C
	public InfiniteScroll m_InfiniteScroll; //Field offset: 0x110
	private GameObject m_TouchObject; //Field offset: 0x114
	private Vector2 m_DragPosition; //Field offset: 0x118

	public Vector2 DragPosition
	{
		 get { } //Length: 45
		 set { } //Length: 26
	}

	public GameObject TouchObject
	{
		 get { } //Length: 14
	}

	private eTouchState TouchState
	{
		private get { } //Length: 26
		private set { } //Length: 29
	}

	public ScrollRectEx() { }

	public Vector2 get_DragPosition() { }

	public GameObject get_TouchObject() { }

	private eTouchState get_TouchState() { }

	public float GetAveragePosition() { }

	public string GetTouchObjectName() { }

	public bool IsTouchPanel() { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public void set_DragPosition(Vector2 value) { }

	private void set_TouchState(eTouchState value) { }

	protected virtual void Start() { }

}


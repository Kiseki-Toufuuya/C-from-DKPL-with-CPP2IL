namespace XeSys.uGUI;

public class uGUIDoubleClick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	public float interval; //Field offset: 0x10
	public UnityEvent onDoubleClick; //Field offset: 0x14
	private int mClicks; //Field offset: 0x18
	private float mNextTime; //Field offset: 0x1C

	public uGUIDoubleClick() { }

	private void Awake() { }

	public override void OnPointerDown(PointerEventData ped) { }

	public override void OnPointerUp(PointerEventData ped) { }

}


namespace Heqet.RG;

public class TouchButton : MonoBehaviour
{
	public GameObject CenterObject; //Field offset: 0x10
	public int LaneId; //Field offset: 0x14
	public RectTransform RectTransform; //Field offset: 0x18
	public Collider2D Collider2D; //Field offset: 0x1C
	private int triggerStatus; //Field offset: 0x20
	private bool buttonDownFlag; //Field offset: 0x24
	public int TouchId; //Field offset: 0x28

	public TouchButton() { }

	private void Awake() { }

	public void OnButtonDown() { }

	public void OnButtonUp() { }

	public void onClickAct() { }

	public void OnTouchDown(int touchId) { }

	public void OnTouchUp() { }

	public bool TriggerPress(int laneId) { }

	public bool TriggerPush(int laneId) { }

	public bool TriggerUp(int laneId) { }

	private void Update() { }

}


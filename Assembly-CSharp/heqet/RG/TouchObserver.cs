namespace Heqet.RG;

public class TouchObserver : MonoBehaviour
{
	public List<TouchButton> touchButtons; //Field offset: 0x10
	private bool initialized; //Field offset: 0x14
	private bool isTouchEnable; //Field offset: 0x15
	[CompilerGenerated]
	private bool <IsPauseTouch>k__BackingField; //Field offset: 0x16
	private float eps; //Field offset: 0x18

	public bool IsPauseTouch
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public TouchObserver() { }

	public Vector3 CenterPosition(RectTransform self) { }

	[CompilerGenerated]
	public bool get_IsPauseTouch() { }

	private int GetNearLane(float screenPosX) { }

	public void Initialize() { }

	private void OnFingerDown(Finger finger) { }

	private void OnFingerMove(Finger finger) { }

	private void OnFingerUp(Finger finger) { }

	public void OnPauseTouch() { }

	[CompilerGenerated]
	public void set_IsPauseTouch(bool value) { }

	public void Terminate() { }

	private List<Int32> TouchAct(Vector2 pos) { }

	public void TouchDisable() { }

	public void TouchEnable() { }

	public bool TriggerPress(int laneId) { }

	public bool TriggerPush(int laneId) { }

	public bool TriggerUp(int laneId) { }

}


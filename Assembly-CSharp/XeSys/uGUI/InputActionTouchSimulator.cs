namespace XeSys.uGUI;

public class InputActionTouchSimulator : MonoBehaviour
{
	private enum Phase
	{
		None = 0,
		Press = 1,
	}

	private TouchInfo dummyBeganInfo; //Field offset: 0x10
	private TouchInfo dummyMoveInfo; //Field offset: 0x14
	private TouchInfo dummyEndedInfo; //Field offset: 0x18
	[FormerlySerializedAs("submit")]
	public InputActionReference inputAction; //Field offset: 0x1C
	private Graphic m_graphic; //Field offset: 0x20
	private Phase phase; //Field offset: 0x24

	public InputActionTouchSimulator() { }

	private void Awake() { }

	private void Start() { }

	public void Update() { }

}


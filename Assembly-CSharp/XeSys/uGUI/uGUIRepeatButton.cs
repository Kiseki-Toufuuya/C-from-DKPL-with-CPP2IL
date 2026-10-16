namespace XeSys.uGUI;

public class uGUIRepeatButton : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler
{
	public float interval; //Field offset: 0x10
	public bool callEventFirstPress; //Field offset: 0x14
	public UnityEvent onDown; //Field offset: 0x18
	public UnityEvent onRepeat; //Field offset: 0x1C
	public UnityEvent onUp; //Field offset: 0x20
	public UnityEvent onPress; //Field offset: 0x24
	[CompilerGenerated]
	private bool <pressed>k__BackingField; //Field offset: 0x28
	private float mNextTime; //Field offset: 0x2C

	public private bool pressed
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public uGUIRepeatButton() { }

	private void Awake() { }

	[CompilerGenerated]
	public bool get_pressed() { }

	public override void OnPointerDown(PointerEventData ped) { }

	public override void OnPointerUp(PointerEventData ped) { }

	[CompilerGenerated]
	private void set_pressed(bool value) { }

	private void SetupNextTime() { }

	private void Update() { }

}


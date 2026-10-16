namespace XeSys.uGUI;

public class UGUILongPress : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler
{
	public float interval; //Field offset: 0x10
	public bool callEventFirstPress; //Field offset: 0x14
	public UnityEvent onLongPressDown; //Field offset: 0x18
	public UnityEvent onLongPress; //Field offset: 0x1C
	public UnityEvent onLongPressUp; //Field offset: 0x20
	[CompilerGenerated]
	private bool <pressed>k__BackingField; //Field offset: 0x24
	private float mNextTime; //Field offset: 0x28

	public private bool pressed
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public UGUILongPress() { }

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


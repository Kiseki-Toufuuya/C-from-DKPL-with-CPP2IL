namespace XeSys.uGUI;

public class uGUIClickSwapImage : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public UnityEvent onClick; //Field offset: 0x10
	public Sprite sprite1; //Field offset: 0x14
	public Sprite sprite2; //Field offset: 0x18
	public Image swapImage; //Field offset: 0x1C
	private Button mButton; //Field offset: 0x20

	public uGUIClickSwapImage() { }

	private void Awake() { }

	public override void OnPointerClick(PointerEventData ped) { }

	public void Reset() { }

	public void SetSprite(bool isSprite1) { }

}


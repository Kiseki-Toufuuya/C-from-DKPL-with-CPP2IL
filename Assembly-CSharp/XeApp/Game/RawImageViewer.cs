namespace XeApp.Game;

public class RawImageViewer : MonoBehaviour
{
	[SerializeField]
	private RawImage TargetImage; //Field offset: 0x10
	[SerializeField]
	private Button ButtonClose; //Field offset: 0x14
	[SerializeField]
	private Button ButtonReset; //Field offset: 0x18
	[SerializeField]
	private Button ButtonScaleDown; //Field offset: 0x1C
	[SerializeField]
	private Button ButtonScaleUp; //Field offset: 0x20
	private float zoomScale; //Field offset: 0x24
	private Vector3 offsetMouse; //Field offset: 0x28
	private bool dragging; //Field offset: 0x34

	public RawImageViewer() { }

	private void Awake() { }

	private void OnButtonClose() { }

	private void OnButtonReset() { }

	private void OnButtonScaleDown() { }

	private void OnButtonScaleUp() { }

	public static void OpenWindow(Texture tex) { }

	public void SetTexture(Texture tex) { }

	private void Update() { }

}


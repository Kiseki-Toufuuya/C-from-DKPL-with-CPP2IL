namespace UnityLibrary;

public class FixFullScreenResolution : MonoBehaviour
{
	private readonly float SCREEN_CHECK_TIME; //Field offset: 0x10
	private IntPtr pfw; //Field offset: 0x14
	private IntPtr pfh; //Field offset: 0x18
	private bool fullscreenFixed; //Field offset: 0x1C
	private bool windowedFixed; //Field offset: 0x1D
	private FixFullScreenResolution s_instance; //Field offset: 0x20
	private float timer; //Field offset: 0x24

	public FixFullScreenResolution() { }

	private void Awake() { }

	private void LateUpdate() { }

	private void Start() { }

}


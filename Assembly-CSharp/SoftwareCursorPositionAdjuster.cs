//Type is in global namespace

public class SoftwareCursorPositionAdjuster : MonoBehaviour
{
	[SerializeField]
	private VirtualMouseInput _virtualMouse; //Field offset: 0x10
	[SerializeField]
	private InputSystemUIInputModule _inputSystemUIInputModule; //Field offset: 0x14
	[SerializeField]
	private Canvas _canvas; //Field offset: 0x18
	private float _lastScaleFactor; //Field offset: 0x1C

	private float CurrentScale
	{
		private get { } //Length: 51
	}

	public SoftwareCursorPositionAdjuster() { }

	private void Awake() { }

	private float get_CurrentScale() { }

	private void Update() { }

}


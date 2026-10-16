//Type is in global namespace

public class CinemachineTouchInputMapper : MonoBehaviour
{
	[Tooltip("Sensitivity multiplier for x-axis")]
	public float TouchSensitivityX; //Field offset: 0x10
	[Tooltip("Sensitivity multiplier for y-axis")]
	public float TouchSensitivityY; //Field offset: 0x14
	[Tooltip("Input channel to spoof for X axis")]
	public string TouchXInputMapTo; //Field offset: 0x18
	[Tooltip("Input channel to spoof for Y axis")]
	public string TouchYInputMapTo; //Field offset: 0x1C

	public CinemachineTouchInputMapper() { }

	private float GetInputAxis(string axisName) { }

	private void Start() { }

}


namespace Cinemachine;

public struct CinemachineInputAxisDriver
{
	private const float Epsilon = 0.0001; //Field offset: 0x0
	[Tooltip("Multiply the input by this amount prior to processing.  Controls the input power.")]
	public float multiplier; //Field offset: 0x0
	[Tooltip("The amount of time in seconds it takes to accelerate to a higher speed")]
	public float accelTime; //Field offset: 0x4
	[Tooltip("The amount of time in seconds it takes to decelerate to a lower speed")]
	public float decelTime; //Field offset: 0x8
	[Tooltip("The name of this axis as specified in Unity Input manager. Setting to an empty string will disable the automatic updating of this axis")]
	public string name; //Field offset: 0xC
	[NoSaveDuringPlay]
	[Tooltip("The value of the input axis.  A value of 0 means no input.  You can drive this directly from a custom input system, or you can set the Axis Name and have the value driven by the internal Input Manager")]
	public float inputValue; //Field offset: 0x10
	private float mCurrentSpeed; //Field offset: 0x14

	private float ClampValue(ref AxisBase axis, float v) { }

	public bool Update(float deltaTime, ref AxisBase axis) { }

	public bool Update(float deltaTime, ref AxisState axis) { }

	public void Validate() { }

}


namespace Cinemachine;

[DocumentationSorting(Level::UserRef (2))]
public struct AxisState
{
	internal interface IInputAxisProvider
	{

		public float GetAxisValue(int axis) { }

	}

	[DocumentationSorting(Level::UserRef (2))]
	internal struct Recentering
	{
		[Tooltip("If checked, will enable automatic recentering of the axis. If unchecked, recenting is disabled.")]
		public bool m_enabled; //Field offset: 0x0
		[Tooltip("If no user input has been detected on the axis, the axis will wait this long in seconds before recentering.")]
		public float m_WaitTime; //Field offset: 0x4
		[Tooltip("How long it takes to reach destination once recentering has started.")]
		public float m_RecenteringTime; //Field offset: 0x8
		private float m_LastUpdateTime; //Field offset: 0xC
		private float mLastAxisInputTime; //Field offset: 0x10
		private float mRecenteringVelocity; //Field offset: 0x14
		[FormerlySerializedAs("m_HeadingDefinition")]
		[HideInInspector]
		[SerializeField]
		private int m_LegacyHeadingDefinition; //Field offset: 0x18
		[FormerlySerializedAs("m_VelocityFilterStrength")]
		[HideInInspector]
		[SerializeField]
		private int m_LegacyVelocityFilterStrength; //Field offset: 0x1C

		public Recentering(bool enabled, float waitTime, float recenteringTime) { }

		public void CancelRecentering() { }

		public void CopyStateFrom(ref Recentering other) { }

		public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget) { }

		internal bool LegacyUpgrade(ref int heading, ref int velocityFilter) { }

		public void RecenterNow() { }

		public void Validate() { }

	}

	internal enum SpeedMode
	{
		MaxSpeed = 0,
		InputValueGain = 1,
	}

	private const float Epsilon = 0.0001; //Field offset: 0x0
	[NoSaveDuringPlay]
	[Tooltip("The current value of the axis.")]
	public float Value; //Field offset: 0x0
	[Tooltip("How to interpret the Max Speed setting: in units/second, or as a direct input value multiplier")]
	public SpeedMode m_SpeedMode; //Field offset: 0x4
	[Tooltip("The maximum speed of this axis in units/second, or the input value multiplier, depending on the Speed Mode")]
	public float m_MaxSpeed; //Field offset: 0x8
	[Tooltip("The amount of time in seconds it takes to accelerate to MaxSpeed with the supplied Axis at its maximum value")]
	public float m_AccelTime; //Field offset: 0xC
	[Tooltip("The amount of time in seconds it takes to decelerate the axis to zero if the supplied axis is in a neutral position")]
	public float m_DecelTime; //Field offset: 0x10
	[FormerlySerializedAs("m_AxisName")]
	[Tooltip("The name of this axis as specified in Unity Input manager. Setting to an empty string will disable the automatic updating of this axis")]
	public string m_InputAxisName; //Field offset: 0x14
	[NoSaveDuringPlay]
	[Tooltip("The value of the input axis.  A value of 0 means no input.  You can drive this directly from a custom input system, or you can set the Axis Name and have the value driven by the internal Input Manager")]
	public float m_InputAxisValue; //Field offset: 0x18
	[FormerlySerializedAs("m_InvertAxis")]
	[Tooltip("If checked, then the raw value of the input axis will be inverted before it is used")]
	public bool m_InvertInput; //Field offset: 0x1C
	[Tooltip("The minimum value for the axis")]
	public float m_MinValue; //Field offset: 0x20
	[Tooltip("The maximum value for the axis")]
	public float m_MaxValue; //Field offset: 0x24
	[Tooltip("If checked, then the axis will wrap around at the min/max values, forming a loop")]
	public bool m_Wrap; //Field offset: 0x28
	[Tooltip("Automatic recentering to at-rest position")]
	public Recentering m_Recentering; //Field offset: 0x2C
	private float m_CurrentSpeed; //Field offset: 0x4C
	private float m_LastUpdateTime; //Field offset: 0x50
	private int m_LastUpdateFrame; //Field offset: 0x54
	private IInputAxisProvider m_InputAxisProvider; //Field offset: 0x58
	private int m_InputAxisIndex; //Field offset: 0x5C
	[CompilerGenerated]
	private bool <ValueRangeLocked>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private bool <HasRecentering>k__BackingField; //Field offset: 0x61

	public bool HasInputProvider
	{
		 get { } //Length: 15
	}

	public bool HasRecentering
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool ValueRangeLocked
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public AxisState(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert) { }

	private float ClampValue(float v) { }

	public bool get_HasInputProvider() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_HasRecentering() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_ValueRangeLocked() { }

	private float GetMaxSpeed() { }

	private bool MaxSpeedUpdate(float input, float deltaTime) { }

	public void Reset() { }

	[CompilerGenerated]
	public void set_HasRecentering(bool value) { }

	[CompilerGenerated]
	public void set_ValueRangeLocked(bool value) { }

	public void SetInputAxisProvider(int axis, IInputAxisProvider provider) { }

	public bool Update(float deltaTime) { }

	public void Validate() { }

}


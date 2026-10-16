namespace Cinemachine;

public struct AxisBase
{
	[NoSaveDuringPlay]
	[Tooltip("The current value of the axis.")]
	public float m_Value; //Field offset: 0x0
	[Tooltip("The minimum value for the axis")]
	public float m_MinValue; //Field offset: 0x4
	[Tooltip("The maximum value for the axis")]
	public float m_MaxValue; //Field offset: 0x8
	[Tooltip("If checked, then the axis will wrap around at the min/max values, forming a loop")]
	public bool m_Wrap; //Field offset: 0xC

	public void Validate() { }

}


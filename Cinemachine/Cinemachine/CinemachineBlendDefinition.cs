namespace Cinemachine;

[DocumentationSorting(Level::UserRef (2))]
public struct CinemachineBlendDefinition
{
	[DocumentationSorting(Level::UserRef (2))]
	internal enum Style
	{
		Cut = 0,
		EaseInOut = 1,
		EaseIn = 2,
		EaseOut = 3,
		HardIn = 4,
		HardOut = 5,
		Linear = 6,
		Custom = 7,
	}

	private static AnimationCurve[] sStandardCurves; //Field offset: 0x0
	[Tooltip("Shape of the blend curve")]
	public Style m_Style; //Field offset: 0x0
	[Tooltip("Duration of the blend, in seconds")]
	public float m_Time; //Field offset: 0x4
	public AnimationCurve m_CustomCurve; //Field offset: 0x8

	public AnimationCurve BlendCurve
	{
		 get { } //Length: 174
	}

	public float BlendTime
	{
		 get { } //Length: 20
	}

	public CinemachineBlendDefinition(Style style, float time) { }

	private void CreateStandardCurves() { }

	public AnimationCurve get_BlendCurve() { }

	public float get_BlendTime() { }

}


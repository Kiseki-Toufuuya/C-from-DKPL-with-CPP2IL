namespace Cinemachine;

[DocumentationSorting(Level::UserRef (2))]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineImpulseFixedSignals.html")]
public class CinemachineFixedSignal : SignalSourceAsset
{
	[Tooltip("The raw signal shape along the X axis")]
	public AnimationCurve m_XCurve; //Field offset: 0xC
	[Tooltip("The raw signal shape along the Y axis")]
	public AnimationCurve m_YCurve; //Field offset: 0x10
	[Tooltip("The raw signal shape along the Z axis")]
	public AnimationCurve m_ZCurve; //Field offset: 0x14

	public virtual float SignalDuration
	{
		 get { } //Length: 87
	}

	public CinemachineFixedSignal() { }

	private float AxisDuration(AnimationCurve axis) { }

	private float AxisValue(AnimationCurve axis, float time) { }

	public virtual float get_SignalDuration() { }

	public virtual void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

}


namespace Cinemachine;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/api/Cinemachine.CinemachineIndependentImpulseListener.html")]
[SaveDuringPlay]
public class CinemachineIndependentImpulseListener : MonoBehaviour
{
	private Vector3 impulsePosLastFrame; //Field offset: 0x10
	private Quaternion impulseRotLastFrame; //Field offset: 0x1C
	[CinemachineImpulseChannelProperty]
	[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
	public int m_ChannelMask; //Field offset: 0x2C
	[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
	public float m_Gain; //Field offset: 0x30
	[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
	public bool m_Use2DDistance; //Field offset: 0x34
	[Tooltip("Enable this to process all impulse signals in camera space")]
	public bool m_UseLocalSpace; //Field offset: 0x35
	[Tooltip("This controls the secondary reaction of the listener to the incoming impulse.  The impulse might be for example a sharp shock, and the secondary reaction could be a vibration whose amplitude and duration is controlled by the size of the original impulse.  This allows different listeners to respond in different ways to the same impulse signal.")]
	public ImpulseReaction m_ReactionSettings; //Field offset: 0x38

	public CinemachineIndependentImpulseListener() { }

	private void LateUpdate() { }

	private void OnEnable() { }

	private void Reset() { }

	private void Update() { }

}


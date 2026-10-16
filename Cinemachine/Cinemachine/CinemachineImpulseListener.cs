namespace Cinemachine;

[AddComponentMenu(null)]
[DocumentationSorting(Level::UserRef (2))]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineImpulseListener.html")]
[SaveDuringPlay]
public class CinemachineImpulseListener : CinemachineExtension
{
	internal struct ImpulseReaction
	{
		[NoiseSettingsProperty]
		[Tooltip("Secondary shake that will be triggered by the primary impulse.")]
		public NoiseSettings m_SecondaryNoise; //Field offset: 0x0
		[Tooltip("Gain to apply to the amplitudes defined in the signal source.  1 is normal.  Setting this to 0 completely mutes the signal.")]
		public float m_AmplitudeGain; //Field offset: 0x4
		[Tooltip("Scale factor to apply to the time axis.  1 is normal.  Larger magnitudes will make the signal progress more rapidly.")]
		public float m_FrequencyGain; //Field offset: 0x8
		[Tooltip("How long the secondary reaction lasts.")]
		public float m_Duration; //Field offset: 0xC
		private float m_CurrentAmount; //Field offset: 0x10
		private float m_CurrentTime; //Field offset: 0x14
		private float m_CurrentDamping; //Field offset: 0x18
		private bool m_Initialized; //Field offset: 0x1C
		[HideInInspector]
		[SerializeField]
		private Vector3 m_NoiseOffsets; //Field offset: 0x20

		public bool GetReaction(float deltaTime, Vector3 impulsePos, out Vector3 pos, out Quaternion rot) { }

		public void ReSeed() { }

	}

	[Tooltip("When to apply the impulse reaction.  Default is after the Noise stage.  Modify this if necessary to influence the ordering of extension effects")]
	public Stage m_ApplyAfter; //Field offset: 0x18
	[CinemachineImpulseChannelProperty]
	[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
	public int m_ChannelMask; //Field offset: 0x1C
	[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
	public float m_Gain; //Field offset: 0x20
	[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
	public bool m_Use2DDistance; //Field offset: 0x24
	[Tooltip("Enable this to process all impulse signals in camera space")]
	public bool m_UseCameraSpace; //Field offset: 0x25
	[Tooltip("This controls the secondary reaction of the listener to the incoming impulse.  The impulse might be for example a sharp shock, and the secondary reaction could be a vibration whose amplitude and duration is controlled by the size of the original impulse.  This allows different listeners to respond in different ways to the same impulse signal.")]
	public ImpulseReaction m_ReactionSettings; //Field offset: 0x28

	public CinemachineImpulseListener() { }

	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	private void Reset() { }

}


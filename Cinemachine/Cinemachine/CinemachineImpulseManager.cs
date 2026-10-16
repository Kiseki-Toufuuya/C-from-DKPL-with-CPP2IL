namespace Cinemachine;

[DocumentationSorting(Level::API (1))]
public class CinemachineImpulseManager
{
	internal struct EnvelopeDefinition
	{
		[Tooltip("Normalized curve defining the shape of the start of the envelope.  If blank a default curve will be used")]
		public AnimationCurve m_AttackShape; //Field offset: 0x0
		[Tooltip("Normalized curve defining the shape of the end of the envelope.  If blank a default curve will be used")]
		public AnimationCurve m_DecayShape; //Field offset: 0x4
		[Tooltip("Duration in seconds of the attack.  Attack curve will be scaled to fit.  Must be >= 0.")]
		public float m_AttackTime; //Field offset: 0x8
		[Tooltip("Duration in seconds of the central fully-scaled part of the envelope.  Must be >= 0.")]
		public float m_SustainTime; //Field offset: 0xC
		[Tooltip("Duration in seconds of the decay.  Decay curve will be scaled to fit.  Must be >= 0.")]
		public float m_DecayTime; //Field offset: 0x10
		[Tooltip("If checked, signal amplitude scaling will also be applied to the time envelope of the signal.  Stronger signals will last longer.")]
		public bool m_ScaleWithImpact; //Field offset: 0x14
		[Tooltip("If true, then duration is infinite.")]
		public bool m_HoldForever; //Field offset: 0x15

		public float Duration
		{
			 get { } //Length: 31
		}

		public void ChangeStopTime(float offset, bool forceNoDecay) { }

		public void Clear() { }

		public static EnvelopeDefinition Default() { }

		public float get_Duration() { }

		public float GetValueAt(float offset) { }

		public void Validate() { }

	}

	internal class ImpulseEvent
	{
		internal enum DirectionMode
		{
			Fixed = 0,
			RotateTowardSource = 1,
		}

		internal enum DissipationMode
		{
			LinearDecay = 0,
			SoftDecay = 1,
			ExponentialDecay = 2,
		}

		public float m_StartTime; //Field offset: 0x8
		public EnvelopeDefinition m_Envelope; //Field offset: 0xC
		public ISignalSource6D m_SignalSource; //Field offset: 0x24
		public Vector3 m_Position; //Field offset: 0x28
		public float m_Radius; //Field offset: 0x34
		public DirectionMode m_DirectionMode; //Field offset: 0x38
		public int m_Channel; //Field offset: 0x3C
		public DissipationMode m_DissipationMode; //Field offset: 0x40
		public float m_DissipationDistance; //Field offset: 0x44
		public float m_CustomDissipation; //Field offset: 0x48
		public float m_PropagationSpeed; //Field offset: 0x4C

		public bool Expired
		{
			 get { } //Length: 233
		}

		internal ImpulseEvent() { }

		public void Cancel(float time, bool forceNoDecay) { }

		public void Clear() { }

		public float DistanceDecay(float distance) { }

		public bool get_Expired() { }

		public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot) { }

	}

	private static CinemachineImpulseManager sInstance; //Field offset: 0x0
	private const float Epsilon = 0.0001; //Field offset: 0x0
	private List<ImpulseEvent> m_ExpiredEvents; //Field offset: 0x8
	private List<ImpulseEvent> m_ActiveEvents; //Field offset: 0xC
	public bool IgnoreTimeScale; //Field offset: 0x10

	public float CurrentTime
	{
		 get { } //Length: 85
	}

	public static CinemachineImpulseManager Instance
	{
		 get { } //Length: 100
	}

	private CinemachineImpulseManager() { }

	public void AddImpulseEvent(ImpulseEvent e) { }

	public void Clear() { }

	internal static float EvaluateDissipationScale(float spread, float normalizedDistance) { }

	public float get_CurrentTime() { }

	public static CinemachineImpulseManager get_Instance() { }

	public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot) { }

	[RuntimeInitializeOnLoadMethod]
	private static void InitializeModule() { }

	public ImpulseEvent NewImpulseEvent() { }

}


namespace Cinemachine;

[DocumentationSorting(Level::UserRef (2))]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineNoiseProfiles.html")]
public sealed class NoiseSettings : SignalSourceAsset
{
	[DocumentationSorting(Level::UserRef (2))]
	internal struct NoiseParams
	{
		[Tooltip("The frequency of noise for this channel.  Higher magnitudes vibrate faster.")]
		public float Frequency; //Field offset: 0x0
		[Tooltip("The amplitude of the noise for this channel.  Larger numbers vibrate higher.")]
		public float Amplitude; //Field offset: 0x4
		[Tooltip("If checked, then the amplitude and frequency will not be randomized.")]
		public bool Constant; //Field offset: 0x8

		public float GetValueAt(float time, float timeOffset) { }

	}

	[DocumentationSorting(Level::UserRef (2))]
	internal struct TransformNoiseParams
	{
		[Tooltip("Noise definition for X-axis")]
		public NoiseParams X; //Field offset: 0x0
		[Tooltip("Noise definition for Y-axis")]
		public NoiseParams Y; //Field offset: 0xC
		[Tooltip("Noise definition for Z-axis")]
		public NoiseParams Z; //Field offset: 0x18

		public Vector3 GetValueAt(float time, Vector3 timeOffsets) { }

	}

	[FormerlySerializedAs("m_Position")]
	[Tooltip("These are the noise channels for the virtual camera's position. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
	public TransformNoiseParams[] PositionNoise; //Field offset: 0xC
	[FormerlySerializedAs("m_Orientation")]
	[Tooltip("These are the noise channels for the virtual camera's orientation. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
	public TransformNoiseParams[] OrientationNoise; //Field offset: 0x10

	public virtual float SignalDuration
	{
		 get { } //Length: 3
	}

	public NoiseSettings() { }

	public virtual float get_SignalDuration() { }

	public static Vector3 GetCombinedFilterResults(TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets) { }

	public virtual void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

}


namespace Cinemachine;

[AddComponentMenu(null)]
[DocumentationSorting(Level::UserRef (2))]
[SaveDuringPlay]
public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
{
	[FormerlySerializedAs("m_Definition")]
	[NoiseSettingsProperty]
	[Tooltip("The asset containing the Noise Profile.  Define the frequencies and amplitudes there to make a characteristic noise profile.  Make your own or just use one of the many presets.")]
	public NoiseSettings m_NoiseProfile; //Field offset: 0x14
	[Tooltip("When rotating the camera, offset the camera's pivot position by this much (camera space)")]
	public Vector3 m_PivotOffset; //Field offset: 0x18
	[Tooltip("Gain to apply to the amplitudes defined in the NoiseSettings asset.  1 is normal.  Setting this to 0 completely mutes the noise.")]
	public float m_AmplitudeGain; //Field offset: 0x24
	[Tooltip("Scale factor to apply to the frequencies defined in the NoiseSettings asset.  1 is normal.  Larger magnitudes will make the noise shake more rapidly.")]
	public float m_FrequencyGain; //Field offset: 0x28
	private bool mInitialized; //Field offset: 0x2C
	private float mNoiseTime; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private Vector3 mNoiseOffsets; //Field offset: 0x34

	public virtual bool IsValid
	{
		 get { } //Length: 93
	}

	public virtual Stage Stage
	{
		 get { } //Length: 6
	}

	public CinemachineBasicMultiChannelPerlin() { }

	public virtual bool get_IsValid() { }

	public virtual Stage get_Stage() { }

	private void Initialize() { }

	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	public void ReSeed() { }

}


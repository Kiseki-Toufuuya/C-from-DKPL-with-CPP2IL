namespace Live2D.Cubism.Framework.MouthMovement;

[RequireComponent(typeof(CubismMouthController))]
public sealed class CubismAudioMouthInput : MonoBehaviour
{
	[SerializeField]
	public AudioSource AudioInput; //Field offset: 0x10
	[SerializeField]
	public CubismAudioSamplingQuality SamplingQuality; //Field offset: 0x14
	[Range(1, 10)]
	public float Gain; //Field offset: 0x18
	[Range(0, 1)]
	public float Smoothing; //Field offset: 0x1C
	[CompilerGenerated]
	private Single[] <Samples>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <LastRms>k__BackingField; //Field offset: 0x24
	private float VelocityBuffer; //Field offset: 0x28
	[CompilerGenerated]
	private CubismMouthController <Target>k__BackingField; //Field offset: 0x2C

	private bool IsInitialized
	{
		private get { } //Length: 15
	}

	private float LastRms
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private Single[] Samples
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private CubismMouthController Target
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CubismAudioMouthInput() { }

	private bool get_IsInitialized() { }

	[CompilerGenerated]
	private float get_LastRms() { }

	[CompilerGenerated]
	private Single[] get_Samples() { }

	[CompilerGenerated]
	private CubismMouthController get_Target() { }

	private void OnEnable() { }

	[CompilerGenerated]
	private void set_LastRms(float value) { }

	[CompilerGenerated]
	private void set_Samples(Single[] value) { }

	[CompilerGenerated]
	private void set_Target(CubismMouthController value) { }

	private void TryInitialize() { }

	private void Update() { }

}


namespace Live2D.Cubism.Framework.HarmonicMotion;

public sealed class CubismHarmonicMotionParameter : MonoBehaviour
{
	[SerializeField]
	public int Channel; //Field offset: 0x10
	[SerializeField]
	public CubismHarmonicMotionDirection Direction; //Field offset: 0x14
	[Range(0, 1)]
	[SerializeField]
	public float NormalizedOrigin; //Field offset: 0x18
	[Range(0, 1)]
	[SerializeField]
	public float NormalizedRange; //Field offset: 0x1C
	[Range(0.01, 10)]
	[SerializeField]
	public float Duration; //Field offset: 0x20
	[CompilerGenerated]
	private float <MaximumValue>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private float <MinimumValue>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private float <ValueRange>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private float <T>k__BackingField; //Field offset: 0x30

	private bool IsInitialized
	{
		private get { } //Length: 63
	}

	private float MaximumValue
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private float MinimumValue
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private float T
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private float ValueRange
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public CubismHarmonicMotionParameter() { }

	private void Clamp(ref float origin, ref float range) { }

	internal float Evaluate() { }

	private bool get_IsInitialized() { }

	[CompilerGenerated]
	private float get_MaximumValue() { }

	[CompilerGenerated]
	private float get_MinimumValue() { }

	[CompilerGenerated]
	private float get_T() { }

	[CompilerGenerated]
	private float get_ValueRange() { }

	private void Initialize() { }

	internal void Play(Single[] channelTimescales) { }

	[CompilerGenerated]
	private void set_MaximumValue(float value) { }

	[CompilerGenerated]
	private void set_MinimumValue(float value) { }

	[CompilerGenerated]
	private void set_T(float value) { }

	[CompilerGenerated]
	private void set_ValueRange(float value) { }

}


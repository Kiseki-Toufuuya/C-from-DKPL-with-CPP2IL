namespace Live2D.Cubism.Samples.AsyncBenchmark;

public class TotalElapsedTime : MonoBehaviour
{
	public readonly int UpdateInterval; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	public int ElapsedTime; //Field offset: 0x14
	[CompilerGenerated]
	private float <UpdateIntervalCount>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Text <TotalElapsedTimeText>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private FrameRateUiHolder <FrameRateUiHolder>k__BackingField; //Field offset: 0x20

	private FrameRateUiHolder FrameRateUiHolder
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private Text TotalElapsedTimeText
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private float UpdateIntervalCount
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public TotalElapsedTime() { }

	[CompilerGenerated]
	private FrameRateUiHolder get_FrameRateUiHolder() { }

	[CompilerGenerated]
	private Text get_TotalElapsedTimeText() { }

	[CompilerGenerated]
	private float get_UpdateIntervalCount() { }

	[CompilerGenerated]
	private void set_FrameRateUiHolder(FrameRateUiHolder value) { }

	[CompilerGenerated]
	private void set_TotalElapsedTimeText(Text value) { }

	[CompilerGenerated]
	private void set_UpdateIntervalCount(float value) { }

	private void Start() { }

	private string TimeConversion(int second) { }

	private void Update() { }

}


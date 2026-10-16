namespace Live2D.Cubism.Samples.AsyncBenchmark;

public class FrameRateMeasurer : MonoBehaviour
{
	[SerializeField]
	public int TargetFrameRate; //Field offset: 0x10
	[CompilerGenerated]
	private bool <LessThanTargetFrameRate>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private float <HighestFrameRate>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <CurrentHighestFrameRate>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <PreviousHighestFrameRate>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <LowestFrameRate>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <CurrentLowestFrameRate>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <PreviousLowestFrameRate>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private int <InstancesCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private FpsCounter <FpsCounter>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private BenchmarkController <BenchmarkController>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private ModelSpawner <ModelSpawner>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private TotalElapsedTime <TotalElapsedTime>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private FrameRateUiHolder <FrameRateUiHolder>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private Text <HighestFrameRateUi>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Text <LowestFrameRateUi>k__BackingField; //Field offset: 0x4C

	private BenchmarkController BenchmarkController
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private int CurrentHighestFrameRate
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private int CurrentLowestFrameRate
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private FpsCounter FpsCounter
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private FrameRateUiHolder FrameRateUiHolder
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private float HighestFrameRate
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private Text HighestFrameRateUi
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private int InstancesCount
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private bool LessThanTargetFrameRate
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private float LowestFrameRate
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private Text LowestFrameRateUi
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private ModelSpawner ModelSpawner
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private int PreviousHighestFrameRate
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private int PreviousLowestFrameRate
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private TotalElapsedTime TotalElapsedTime
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public FrameRateMeasurer() { }

	[CompilerGenerated]
	private BenchmarkController get_BenchmarkController() { }

	[CompilerGenerated]
	private int get_CurrentHighestFrameRate() { }

	[CompilerGenerated]
	private int get_CurrentLowestFrameRate() { }

	[CompilerGenerated]
	private FpsCounter get_FpsCounter() { }

	[CompilerGenerated]
	private FrameRateUiHolder get_FrameRateUiHolder() { }

	[CompilerGenerated]
	private float get_HighestFrameRate() { }

	[CompilerGenerated]
	private Text get_HighestFrameRateUi() { }

	[CompilerGenerated]
	private int get_InstancesCount() { }

	[CompilerGenerated]
	private bool get_LessThanTargetFrameRate() { }

	[CompilerGenerated]
	private float get_LowestFrameRate() { }

	[CompilerGenerated]
	private Text get_LowestFrameRateUi() { }

	[CompilerGenerated]
	private ModelSpawner get_ModelSpawner() { }

	[CompilerGenerated]
	private int get_PreviousHighestFrameRate() { }

	[CompilerGenerated]
	private int get_PreviousLowestFrameRate() { }

	[CompilerGenerated]
	private TotalElapsedTime get_TotalElapsedTime() { }

	[CompilerGenerated]
	private void set_BenchmarkController(BenchmarkController value) { }

	[CompilerGenerated]
	private void set_CurrentHighestFrameRate(int value) { }

	[CompilerGenerated]
	private void set_CurrentLowestFrameRate(int value) { }

	[CompilerGenerated]
	private void set_FpsCounter(FpsCounter value) { }

	[CompilerGenerated]
	private void set_FrameRateUiHolder(FrameRateUiHolder value) { }

	[CompilerGenerated]
	private void set_HighestFrameRate(float value) { }

	[CompilerGenerated]
	private void set_HighestFrameRateUi(Text value) { }

	[CompilerGenerated]
	private void set_InstancesCount(int value) { }

	[CompilerGenerated]
	private void set_LessThanTargetFrameRate(bool value) { }

	[CompilerGenerated]
	private void set_LowestFrameRate(float value) { }

	[CompilerGenerated]
	private void set_LowestFrameRateUi(Text value) { }

	[CompilerGenerated]
	private void set_ModelSpawner(ModelSpawner value) { }

	[CompilerGenerated]
	private void set_PreviousHighestFrameRate(int value) { }

	[CompilerGenerated]
	private void set_PreviousLowestFrameRate(int value) { }

	[CompilerGenerated]
	private void set_TotalElapsedTime(TotalElapsedTime value) { }

	private void Start() { }

	private string TimeConversion(int second) { }

	private void Update() { }

}


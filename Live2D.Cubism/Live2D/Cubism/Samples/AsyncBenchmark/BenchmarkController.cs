namespace Live2D.Cubism.Samples.AsyncBenchmark;

public sealed class BenchmarkController : MonoBehaviour
{
	public readonly float SpawnIntervalTimeSecond; //Field offset: 0x10
	[SerializeField]
	public int TargetFrameRate; //Field offset: 0x14
	[SerializeField]
	public Text ReachedElapsedTimeUi; //Field offset: 0x18
	[SerializeField]
	public Text InstancesCountUi; //Field offset: 0x1C
	[CompilerGenerated]
	private float <HighestRecordedFrameRate>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <CanModelSpawn>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private float <SpawnTimeCount>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private float <ElapsedTime>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private FpsCounter <FpsCounter>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private ModelSpawner <ModelSpawner>k__BackingField; //Field offset: 0x34

	private bool CanModelSpawn
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private float ElapsedTime
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private FpsCounter FpsCounter
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private float HighestRecordedFrameRate
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private ModelSpawner ModelSpawner
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private float SpawnTimeCount
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public BenchmarkController() { }

	private void Awake() { }

	[CompilerGenerated]
	private bool get_CanModelSpawn() { }

	[CompilerGenerated]
	private float get_ElapsedTime() { }

	[CompilerGenerated]
	private FpsCounter get_FpsCounter() { }

	[CompilerGenerated]
	private float get_HighestRecordedFrameRate() { }

	[CompilerGenerated]
	private ModelSpawner get_ModelSpawner() { }

	[CompilerGenerated]
	private float get_SpawnTimeCount() { }

	private void ManageSpawn() { }

	private void RecordFrameRate() { }

	[CompilerGenerated]
	private void set_CanModelSpawn(bool value) { }

	[CompilerGenerated]
	private void set_ElapsedTime(float value) { }

	[CompilerGenerated]
	private void set_FpsCounter(FpsCounter value) { }

	[CompilerGenerated]
	private void set_HighestRecordedFrameRate(float value) { }

	[CompilerGenerated]
	private void set_ModelSpawner(ModelSpawner value) { }

	[CompilerGenerated]
	private void set_SpawnTimeCount(float value) { }

	private string TimeConversion(int second) { }

	private void Update() { }

}


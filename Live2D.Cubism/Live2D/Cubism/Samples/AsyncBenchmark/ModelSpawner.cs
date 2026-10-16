namespace Live2D.Cubism.Samples.AsyncBenchmark;

public sealed class ModelSpawner : MonoBehaviour
{
	[SerializeField]
	public GameObject ModelPrefab; //Field offset: 0x10
	[SerializeField]
	public Text ModelCountUi; //Field offset: 0x14
	[CompilerGenerated]
	private int <InstancesCount>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List<GameObject> <Instances>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private BenchmarkController <BenchmarkController>k__BackingField; //Field offset: 0x20

	private BenchmarkController BenchmarkController
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private List<GameObject> Instances
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private int InstancesCount
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public ModelSpawner() { }

	public void DecreaseInstances() { }

	[CompilerGenerated]
	private BenchmarkController get_BenchmarkController() { }

	[CompilerGenerated]
	private List<GameObject> get_Instances() { }

	[CompilerGenerated]
	public int get_InstancesCount() { }

	public void IncreaseInstances() { }

	[CompilerGenerated]
	private void set_BenchmarkController(BenchmarkController value) { }

	[CompilerGenerated]
	private void set_Instances(List<GameObject> value) { }

	[CompilerGenerated]
	private void set_InstancesCount(int value) { }

	private void Start() { }

}


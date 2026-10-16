namespace Live2D.Cubism.Samples.AsyncBenchmark;

public sealed class FpsCounter : MonoBehaviour
{
	[SerializeField]
	public Text FpsUi; //Field offset: 0x10
	[CompilerGenerated]
	private float <Fps>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private float <DeltaTime>k__BackingField; //Field offset: 0x18

	private float DeltaTime
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public private float Fps
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public FpsCounter() { }

	[CompilerGenerated]
	private float get_DeltaTime() { }

	[CompilerGenerated]
	public float get_Fps() { }

	[CompilerGenerated]
	private void set_DeltaTime(float value) { }

	[CompilerGenerated]
	private void set_Fps(float value) { }

	private void Update() { }

}


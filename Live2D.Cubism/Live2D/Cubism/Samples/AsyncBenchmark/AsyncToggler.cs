namespace Live2D.Cubism.Samples.AsyncBenchmark;

public sealed class AsyncToggler : MonoBehaviour
{
	public bool EnableAsync; //Field offset: 0x10
	[CompilerGenerated]
	private bool <LastEnableSync>k__BackingField; //Field offset: 0x11

	private bool LastEnableSync
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public AsyncToggler() { }

	[CompilerGenerated]
	private bool get_LastEnableSync() { }

	private void OnDestroy() { }

	[CompilerGenerated]
	private void set_LastEnableSync(bool value) { }

	private void Update() { }

}


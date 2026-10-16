namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__12_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <ReloadBaseTypes>b__12_0(Type t) { }

	}

	private static PostProcessManager s_Instance; //Field offset: 0x0
	private const int k_MaxLayerCount = 32; //Field offset: 0x0
	private readonly Dictionary<Int32, List`1<PostProcessVolume>> m_SortedVolumes; //Field offset: 0x8
	private readonly List<PostProcessVolume> m_Volumes; //Field offset: 0xC
	private readonly Dictionary<Int32, Boolean> m_SortNeeded; //Field offset: 0x10
	private readonly List<PostProcessEffectSettings> m_BaseSettings; //Field offset: 0x14
	private readonly List<Collider> m_TempColliders; //Field offset: 0x18
	public readonly Dictionary<Type, PostProcessAttribute> settingsTypes; //Field offset: 0x1C

	public static PostProcessManager instance
	{
		 get { } //Length: 495
	}

	private PostProcessManager() { }

	private void CleanBaseTypes() { }

	public static PostProcessManager get_instance() { }

	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = true, bool skipZeroWeight = true) { }

	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer) { }

	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask) { }

	private List<PostProcessVolume> GrabVolumes(LayerMask mask) { }

	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera) { }

	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings) { }

	private void Register(PostProcessVolume volume, int layer) { }

	internal void Register(PostProcessVolume volume) { }

	private void ReloadBaseTypes() { }

	private void ReplaceData(PostProcessLayer postProcessLayer) { }

	internal void SetLayerDirty(int layer) { }

	private static void SortByPriority(List<PostProcessVolume> volumes) { }

	private void Unregister(PostProcessVolume volume, int layer) { }

	internal void Unregister(PostProcessVolume volume) { }

	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera) { }

	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer) { }

}


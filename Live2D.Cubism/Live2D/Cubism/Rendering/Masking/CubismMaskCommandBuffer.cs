namespace Live2D.Cubism.Rendering.Masking;

[ExecuteInEditMode]
public sealed class CubismMaskCommandBuffer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public ICubismMaskCommandSource source; //Field offset: 0x8

		public <>c__DisplayClass16_0() { }

		internal bool <RemoveSource>b__0(ICubismMaskCommandSource s) { }

	}

	[CompilerGenerated]
	private static List<ICubismMaskCommandSource> <Sources>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static CommandBuffer <Buffer>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static CommandBuffer[] <Buffers>k__BackingField; //Field offset: 0x8

	private static CommandBuffer Buffer
	{
		[CompilerGenerated]
		private get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	private static CommandBuffer[] Buffers
	{
		[CompilerGenerated]
		private get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	private static bool ContainsSources
	{
		private get { } //Length: 129
	}

	private static List<ICubismMaskCommandSource> Sources
	{
		[CompilerGenerated]
		private get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public CubismMaskCommandBuffer() { }

	internal static void AddSource(ICubismMaskCommandSource source) { }

	[CompilerGenerated]
	private static CommandBuffer get_Buffer() { }

	[CompilerGenerated]
	private static CommandBuffer[] get_Buffers() { }

	private static bool get_ContainsSources() { }

	[CompilerGenerated]
	private static List<ICubismMaskCommandSource> get_Sources() { }

	private static void Initialize() { }

	private void LateUpdate() { }

	private static void RefreshCommandBuffer() { }

	private static void RefreshCommandBuffers() { }

	internal static void RemoveSource(ICubismMaskCommandSource source) { }

	[CompilerGenerated]
	private static void set_Buffer(CommandBuffer value) { }

	[CompilerGenerated]
	private static void set_Buffers(CommandBuffer[] value) { }

	[CompilerGenerated]
	private static void set_Sources(List<ICubismMaskCommandSource> value) { }

}


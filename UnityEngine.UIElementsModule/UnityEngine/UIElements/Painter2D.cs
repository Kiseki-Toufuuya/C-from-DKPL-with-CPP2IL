namespace UnityEngine.UIElements;

public class Painter2D : IDisposable
{
	private struct Painter2DJob : IJobParallelFor
	{
		[NativeDisableUnsafePtrRestriction]
		public IntPtr painterHandle; //Field offset: 0x0
		[ReadOnly]
		public TempMeshAllocator allocator; //Field offset: 0x4
		[ReadOnly]
		public NativeSlice<Painter2DJobData> jobParameters; //Field offset: 0x8

		public override void Execute(int i) { }

	}

	private struct Painter2DJobData
	{
		public UnsafeMeshGenerationNode node; //Field offset: 0x0
		public int snapshotIndex; //Field offset: 0x4

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static bool <isPainterActive>k__BackingField; //Field offset: 0x0
	private static readonly ProfilerMarker s_StrokeMarker; //Field offset: 0x4
	private static readonly ProfilerMarker s_FillMarker; //Field offset: 0x8
	private MeshGenerationContext m_Ctx; //Field offset: 0x8
	internal DetachedAllocator m_DetachedAllocator; //Field offset: 0xC
	internal SafeHandleAccess m_Handle; //Field offset: 0x10
	private List<Painter2DJobData> m_JobSnapshots; //Field offset: 0x14
	private NativeArray<Painter2DJobData> m_JobParameters; //Field offset: 0x18
	private bool m_Disposed; //Field offset: 0x24
	private MeshGenerationCallback m_OnMeshGenerationDelegate; //Field offset: 0x28

	internal static bool isPainterActive
	{
		[CompilerGenerated]
		internal set { } //Length: 78
	}

	private static Painter2D() { }

	internal Painter2D(MeshGenerationContext ctx) { }

	public Painter2D() { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	private void OnMeshGeneration(MeshGenerationContext ctx, object data) { }

	internal void Reset() { }

	internal void ScheduleJobs(MeshGenerationContext mgc) { }

	[CompilerGenerated]
	internal static void set_isPainterActive(bool value) { }

}


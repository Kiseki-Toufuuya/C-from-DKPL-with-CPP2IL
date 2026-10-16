namespace UnityEngine.UIElements;

public class MeshGenerationContext
{
	[Flags]
	public enum MeshFlags
	{
		None = 0,
		SkipDynamicAtlas = 2,
		IsUsingVectorImageGradients = 4,
		SliceTiled = 8,
	}

	private static readonly ProfilerMarker k_AllocateMarker; //Field offset: 0x0
	private static readonly ProfilerMarker k_DrawVectorImageMarker; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <visualElement>k__BackingField; //Field offset: 0x8
	private Painter2D m_Painter2D; //Field offset: 0xC
	private MeshWriteDataPool m_MeshWriteDataPool; //Field offset: 0x10
	private TempMeshAllocatorImpl m_Allocator; //Field offset: 0x14
	private MeshGenerationDeferrer m_MeshGenerationDeferrer; //Field offset: 0x18
	private MeshGenerationNodeManager m_MeshGenerationNodeManager; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IMeshGenerator <meshGenerator>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EntryRecorder <entryRecorder>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Entry <parentEntry>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x2C

	internal bool disposed
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	internal EntryRecorder entryRecorder
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	internal bool hasPainter2D
	{
		internal get { } //Length: 15
	}

	internal IMeshGenerator meshGenerator
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	public Painter2D painter2D
	{
		 get { } //Length: 417
	}

	internal Entry parentEntry
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private VisualElement visualElement
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private static MeshGenerationContext() { }

	internal MeshGenerationContext(MeshWriteDataPool meshWriteDataPool, EntryRecorder entryRecorder, TempMeshAllocatorImpl allocator, MeshGenerationDeferrer meshGenerationDeferrer, MeshGenerationNodeManager meshGenerationNodeManager) { }

	internal void AddMeshGenerationCallback(MeshGenerationCallback callback, object userData, MeshGenerationCallbackType callbackType, bool isJobDependent) { }

	public void AddMeshGenerationJob(JobHandle jobHandle) { }

	internal void Begin(Entry parentEntry, VisualElement ve) { }

	internal void Dispose() { }

	private void Dispose(bool disposing) { }

	internal void End() { }

	[CompilerGenerated]
	internal bool get_disposed() { }

	[CompilerGenerated]
	internal EntryRecorder get_entryRecorder() { }

	internal bool get_hasPainter2D() { }

	[CompilerGenerated]
	internal IMeshGenerator get_meshGenerator() { }

	public Painter2D get_painter2D() { }

	[CompilerGenerated]
	internal Entry get_parentEntry() { }

	[CompilerGenerated]
	public VisualElement get_visualElement() { }

	public void GetTempMeshAllocator(out TempMeshAllocator allocator) { }

	public void InsertMeshGenerationNode(out MeshGenerationNode node) { }

	internal void InsertUnsafeMeshGenerationNode(out UnsafeMeshGenerationNode node) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	[CompilerGenerated]
	private void set_entryRecorder(EntryRecorder value) { }

	[CompilerGenerated]
	internal void set_meshGenerator(IMeshGenerator value) { }

	[CompilerGenerated]
	private void set_parentEntry(Entry value) { }

	[CompilerGenerated]
	private void set_visualElement(VisualElement value) { }

}


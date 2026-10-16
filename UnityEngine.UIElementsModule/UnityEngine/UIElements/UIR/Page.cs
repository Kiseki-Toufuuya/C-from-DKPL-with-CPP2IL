namespace UnityEngine.UIElements.UIR;

internal class Page : IDisposable
{
	internal class DataSet : IDisposable
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private bool <disposed>k__BackingField; //Field offset: 0x0
		public GPUBuffer<T> gpuData; //Field offset: 0x0
		public NativeArray<T> cpuData; //Field offset: 0x0
		public NativeArray<GfxUpdateBufferRange> updateRanges; //Field offset: 0x0
		public GPUBufferAllocator allocator; //Field offset: 0x0
		private readonly uint m_UpdateRangePoolSize; //Field offset: 0x0
		private uint m_ElemStride; //Field offset: 0x0
		private uint m_UpdateRangeMin; //Field offset: 0x0
		private uint m_UpdateRangeMax; //Field offset: 0x0
		private uint m_UpdateRangesEnqueued; //Field offset: 0x0
		private uint m_UpdateRangesBatchStart; //Field offset: 0x0
		private bool m_UpdateRangesSaturated; //Field offset: 0x0

		protected private bool disposed
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 14
		}

		public DataSet`1(GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize, bool mockBuffer) { }

		public override void Dispose() { }

		public void Dispose(bool disposing) { }

		[CompilerGenerated]
		protected bool get_disposed() { }

		private bool HasMappedBufferRange() { }

		public void RegisterUpdate(uint start, uint size) { }

		private void ResetUpdateState() { }

		public void SendFullRange() { }

		public void SendPartialRanges() { }

		public void SendUpdates() { }

		[CompilerGenerated]
		private void set_disposed(bool value) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x8
	public DataSet<Vertex> vertices; //Field offset: 0xC
	public DataSet<UInt16> indices; //Field offset: 0x10
	public Page next; //Field offset: 0x14
	public int framesEmpty; //Field offset: 0x18

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public bool isEmpty
	{
		 get { } //Length: 99
	}

	public Page(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	public bool get_isEmpty() { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

}


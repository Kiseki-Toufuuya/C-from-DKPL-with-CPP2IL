namespace UnityEngine.UIElements.UIR;

internal class GPUBufferAllocator
{
	private BestFitAllocator m_Low; //Field offset: 0x8
	private BestFitAllocator m_High; //Field offset: 0xC

	public bool isEmpty
	{
		 get { } //Length: 45
	}

	public GPUBufferAllocator(uint maxSize) { }

	public Alloc Allocate(uint size, bool shortLived) { }

	public void Free(Alloc alloc) { }

	public bool get_isEmpty() { }

	private bool HighLowCollide() { }

}


namespace Live2D.Cubism.Core.Unmanaged;

public static class CubismUnmanagedMemory
{
	private struct AllocationItem
	{
		public IntPtr UnalignedAddress; //Field offset: 0x0
		public IntPtr AlignedAddress; //Field offset: 0x4

	}

	[CompilerGenerated]
	private static List<AllocationItem> <Allocations>k__BackingField; //Field offset: 0x0

	private static List<AllocationItem> Allocations
	{
		[CompilerGenerated]
		private get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	private static bool ContainsAllocations
	{
		private get { } //Length: 129
	}

	public static IntPtr Allocate(int size, int align) { }

	public static void Deallocate(IntPtr allocation) { }

	[CompilerGenerated]
	private static List<AllocationItem> get_Allocations() { }

	private static bool get_ContainsAllocations() { }

	[CompilerGenerated]
	private static void set_Allocations(List<AllocationItem> value) { }

	public static void Write(Byte[] source, IntPtr destination) { }

}


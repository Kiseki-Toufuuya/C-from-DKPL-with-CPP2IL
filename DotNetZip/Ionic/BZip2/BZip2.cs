namespace Ionic.BZip2;

internal static class BZip2
{
	public static readonly int BlockSizeMultiple; //Field offset: 0x0
	public static readonly int MinBlockSize; //Field offset: 0x4
	public static readonly int MaxBlockSize; //Field offset: 0x8
	public static readonly int MaxAlphaSize; //Field offset: 0xC
	public static readonly int MaxCodeLength; //Field offset: 0x10
	public static readonly char RUNA; //Field offset: 0x14
	public static readonly char RUNB; //Field offset: 0x16
	public static readonly int NGroups; //Field offset: 0x18
	public static readonly int G_SIZE; //Field offset: 0x1C
	public static readonly int N_ITERS; //Field offset: 0x20
	public static readonly int MaxSelectors; //Field offset: 0x24
	public static readonly int NUM_OVERSHOOT_BYTES; //Field offset: 0x28
	internal static readonly int QSORT_STACK_SIZE; //Field offset: 0x2C

	private static BZip2() { }

	internal static T[][] InitRectangularArray(int d1, int d2) { }

}


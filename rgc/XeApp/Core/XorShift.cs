namespace XeApp.Core;

public class XorShift
{
	private readonly object lockObject; //Field offset: 0x8
	private uint seed; //Field offset: 0xC
	private uint y; //Field offset: 0x10

	public XorShift() { }

	public void Init(uint seed) { }

	public void MakeSwizzleTable(Byte[] dest) { }

	public uint Next() { }

	public float NextFloat() { }

	public int Range(int min, int max) { }

	public static void SwizzleBytes(Byte[] target, Byte[] swizzle, int coef, int offset, int start) { }

}


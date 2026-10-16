namespace XeSys;

public class XorShift128 : Random
{
	private int W; //Field offset: 0x14
	private int X; //Field offset: 0x18
	private int Y; //Field offset: 0x1C
	private int Z; //Field offset: 0x20

	public XorShift128(int x, int y, int z, int w) { }

	public XorShift128() { }

	public XorShift128(int seed) { }

	public virtual int Next() { }

	public virtual int Next(int min, int max) { }

	public virtual int Next(int max) { }

}


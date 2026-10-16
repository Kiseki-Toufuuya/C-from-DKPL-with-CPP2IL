namespace XeSys;

public struct VectorI2
{
	private int mX; //Field offset: 0x0
	private int mY; //Field offset: 0x4

	public int x
	{
		 get { } //Length: 10
		 set { } //Length: 13
	}

	public int y
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public VectorI2(int x_, int y_) { }

	public VectorI2(VectorI2 vec) { }

	public int get_x() { }

	public int get_y() { }

	public static VectorI2 op_Addition(VectorI2 a, VectorI2 b) { }

	public static VectorI2 op_Division(VectorI2 a, int d) { }

	public static VectorI2 op_Multiply(VectorI2 a, VectorI2 b) { }

	public static VectorI2 op_Subtraction(VectorI2 a, VectorI2 b) { }

	public void set_x(int value) { }

	public void set_y(int value) { }

}


namespace XeSys;

public struct VectorI3
{
	public int mX; //Field offset: 0x0
	public int mY; //Field offset: 0x4
	public int mZ; //Field offset: 0x8

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

	public int z
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public VectorI3(int x, int y, int z) { }

	public VectorI3(VectorI3 vec) { }

	public int get_x() { }

	public int get_y() { }

	public int get_z() { }

	public static VectorI3 op_Addition(VectorI3 a, VectorI3 b) { }

	public static VectorI3 op_Division(VectorI3 a, int d) { }

	public static VectorI3 op_Multiply(VectorI3 a, VectorI3 b) { }

	public static VectorI3 op_Subtraction(VectorI3 a, VectorI3 b) { }

	public void set_x(int value) { }

	public void set_y(int value) { }

	public void set_z(int value) { }

}


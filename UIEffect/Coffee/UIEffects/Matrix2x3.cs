namespace Coffee.UIEffects;

public struct Matrix2x3
{
	public float m00; //Field offset: 0x0
	public float m01; //Field offset: 0x4
	public float m02; //Field offset: 0x8
	public float m10; //Field offset: 0xC
	public float m11; //Field offset: 0x10
	public float m12; //Field offset: 0x14

	public Matrix2x3(Rect rect, float cos, float sin) { }

	public static Vector2 op_Multiply(Matrix2x3 m, Vector2 v) { }

}


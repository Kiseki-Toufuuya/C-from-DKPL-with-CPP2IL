//Type is in global namespace

public struct Matrix23
{
	private const int ROW_NUM = 2; //Field offset: 0x0
	private const int COLUMN_NUM = 3; //Field offset: 0x0
	public float _00; //Field offset: 0x0
	public float _01; //Field offset: 0x4
	public float _02; //Field offset: 0x8
	public float _10; //Field offset: 0xC
	public float _11; //Field offset: 0x10
	public float _12; //Field offset: 0x14

	public Matrix23(float initValue) { }

	public Matrix23(float tx, float ty) { }

	public Matrix23(float m00, float m01, float m02, float m10, float m11, float m12) { }

	public void Copy(Matrix23 src) { }

	public void Identity() { }

	public Matrix23 MultiplyMatrix(Matrix23 mtx) { }

	public Vector3 MultiplyVector(Vector3 pos) { }

	public Vector2 MultiplyVector(Vector2 pos) { }

	public static Matrix23 op_Multiply(Matrix23 lhs, Matrix23 rhs) { }

	public static Vector2 op_Multiply(Vector2 pos, Matrix23 mtx) { }

	public void Rotate(float zrad) { }

	public void Scale(float sx, float sy) { }

	public virtual string ToString() { }

	public Matrix4x4 ToUnityMatrix() { }

	public void ToUnityMatrix(ref Matrix4x4 mat) { }

	public void Translate(float tx, float ty) { }

	public void Translate(Vector2 posi) { }

	public void Translate(Vector3 posi) { }

	public void TransRot(Vector2 posi, float zrad) { }

	public void TransRotScale(float transX, float transY, float zrad, Vector2 scale) { }

	public void TransRotScale(Vector2 trans, float zrad, Vector2 scale) { }

	public void TransScale(Vector2 scale, Vector2 trans) { }

	public void TransScale(float sx, float sy, float tx, float ty) { }

}


namespace XeSys;

[Extension]
public static class VectorExtension
{
	private const float ZERO = 1E-06; //Field offset: 0x0

	[Extension]
	public static bool IsZero(Vector3 vec) { }

	[Extension]
	public static bool IsZero(Vector2 vec) { }

}


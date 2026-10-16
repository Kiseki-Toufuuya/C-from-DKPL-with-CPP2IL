namespace XeSys;

[Extension]
public static class CameraExtension
{

	private static Matrix4x4 MakePerspective(float left, float right, float top, float bottom, float near, float far) { }

	[Extension]
	public static void SetProjectionVanishingPoint(Camera cam, Vector2 vanishingOffset) { }

	[Extension]
	public static void SetProjectionVanishingPoint(Camera cam, float x, float y) { }

}


namespace Cinemachine.Utility;

[Extension]
public static class UnityVectorExtensions
{
	public const float Epsilon = 0.0001; //Field offset: 0x0

	[Extension]
	public static Vector2 Abs(Vector2 v) { }

	[Extension]
	public static Vector3 Abs(Vector3 v) { }

	[Extension]
	public static bool AlmostZero(Vector3 v) { }

	public static float Angle(Vector3 v1, Vector3 v2) { }

	[Extension]
	public static float ClosestPointOnSegment(Vector3 p, Vector3 s0, Vector3 s1) { }

	[Extension]
	public static float ClosestPointOnSegment(Vector2 p, Vector2 s0, Vector2 s1) { }

	[Extension]
	internal static void ConservativeSetPositionAndRotation(Transform t, Vector3 pos, Quaternion rot) { }

	[Extension]
	private static float Cross(Vector2 v1, Vector2 v2) { }

	public static int FindIntersection(in Vector2 p1, in Vector2 p2, in Vector2 q1, in Vector2 q2, out Vector2 intersection) { }

	[Extension]
	public static bool IsNaN(Vector2 v) { }

	[Extension]
	public static bool IsNaN(Vector3 v) { }

	[Extension]
	public static bool IsUniform(Vector2 v) { }

	[Extension]
	public static bool IsUniform(Vector3 v) { }

	[Extension]
	public static Vector3 ProjectOntoPlane(Vector3 vector, Vector3 planeNormal) { }

	public static Quaternion SafeFromToRotation(Vector3 v1, Vector3 v2, Vector3 up) { }

	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 up) { }

	public static Vector3 SlerpWithReferenceUp(Vector3 vA, Vector3 vB, float t, Vector3 up) { }

	[Extension]
	public static Vector2 SquareNormalize(Vector2 v) { }

}


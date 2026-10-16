namespace Cinemachine.Utility;

[Extension]
public static class UnityQuaternionExtensions
{

	[Extension]
	public static Quaternion ApplyCameraRotation(Quaternion orient, Vector2 rot, Vector3 worldUp) { }

	[Extension]
	public static Vector2 GetCameraRotationToTarget(Quaternion orient, Vector3 lookAtDir, Vector3 worldUp) { }

	[Extension]
	public static Quaternion Normalized(Quaternion q) { }

	public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up) { }

}


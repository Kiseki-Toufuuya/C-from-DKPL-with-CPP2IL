namespace Cinemachine.Utility;

public static class Damper
{
	private const float Epsilon = 0.0001; //Field offset: 0x0
	public const float kNegligibleResidual = 0.01; //Field offset: 0x0
	private const float kLogNegligibleResidual = -4.6051702; //Field offset: 0x0

	public static float Damp(float initial, float dampTime, float deltaTime) { }

	public static Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	public static Vector3 Damp(Vector3 initial, float dampTime, float deltaTime) { }

	private static float DecayConstant(float time, float residual) { }

	private static float DecayedRemainder(float initial, float decayConstant, float deltaTime) { }

}


namespace UnityEngine.Rendering.PostProcessing;

public static class ColorUtilities
{
	private const float logC_cut = 0.011361; //Field offset: 0x0
	private const float logC_a = 5.555556; //Field offset: 0x0
	private const float logC_b = 0.047996; //Field offset: 0x0
	private const float logC_c = 0.244161; //Field offset: 0x0
	private const float logC_d = 0.386036; //Field offset: 0x0
	private const float logC_e = 5.301883; //Field offset: 0x0
	private const float logC_f = 0.092819; //Field offset: 0x0

	public static Vector3 CIExyToLMS(float x, float y) { }

	public static Vector3 ColorToGain(Vector4 color) { }

	public static Vector3 ColorToInverseGamma(Vector4 color) { }

	public static Vector3 ColorToLift(Vector4 color) { }

	public static Vector3 ComputeColorBalance(float temperature, float tint) { }

	public static float LinearToLogC(float x) { }

	public static float LogCToLinear(float x) { }

	public static float StandardIlluminantY(float x) { }

	public static uint ToHex(Color c) { }

	public static Color ToRGBA(uint hex) { }

}


namespace Live2D.Cubism.Framework;

[Extension]
public static class CubismParameterExtensionMethods
{

	[Extension]
	public static void AddToValue(CubismParameter parameter, float value, float weight = 1) { }

	[Extension]
	public static void BlendToValue(CubismParameter self, CubismParameterBlendMode mode, float value, float weight = 1) { }

	[Extension]
	public static void BlendToValue(CubismParameter[] self, CubismParameterBlendMode mode, float value, float weight = 1) { }

	[Extension]
	public static void MultiplyValueBy(CubismParameter parameter, float value, float weight = 1) { }

	[Extension]
	public static void OverrideValue(CubismParameter parameter, float value, float weight = 1) { }

}


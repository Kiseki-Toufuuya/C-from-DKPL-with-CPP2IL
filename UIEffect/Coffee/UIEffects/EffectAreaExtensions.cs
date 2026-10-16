namespace Coffee.UIEffects;

[Extension]
public static class EffectAreaExtensions
{
	private static readonly Rect rectForCharacter; //Field offset: 0x0
	private static readonly Vector2[] splitedCharacterPosition; //Field offset: 0x10

	private static EffectAreaExtensions() { }

	[Extension]
	public static Rect GetEffectArea(EffectArea area, VertexHelper vh, Rect rectangle, float aspectRatio = -1) { }

	[Extension]
	public static void GetNormalizedFactor(EffectArea area, int index, Matrix2x3 matrix, Vector2 position, bool isText, out Vector2 nomalizedPos) { }

	[Extension]
	public static void GetPositionFactor(EffectArea area, int index, Rect rect, Vector2 position, bool isText, bool isTMPro, out float x, out float y) { }

}


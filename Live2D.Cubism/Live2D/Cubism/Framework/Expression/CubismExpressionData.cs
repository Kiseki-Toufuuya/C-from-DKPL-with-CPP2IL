namespace Live2D.Cubism.Framework.Expression;

public class CubismExpressionData : ScriptableObject
{
	internal struct SerializableExpressionParameter
	{
		[SerializeField]
		public string Id; //Field offset: 0x0
		[SerializeField]
		public float Value; //Field offset: 0x4
		[SerializeField]
		public CubismParameterBlendMode Blend; //Field offset: 0x8

	}

	[SerializeField]
	public string Type; //Field offset: 0xC
	[SerializeField]
	public float FadeInTime; //Field offset: 0x10
	[SerializeField]
	public float FadeOutTime; //Field offset: 0x14
	[SerializeField]
	public SerializableExpressionParameter[] Parameters; //Field offset: 0x18

	public CubismExpressionData() { }

	public static CubismExpressionData CreateInstance(CubismExpressionData expressionData, CubismExp3Json json) { }

	public static CubismExpressionData CreateInstance(CubismExp3Json json) { }

}


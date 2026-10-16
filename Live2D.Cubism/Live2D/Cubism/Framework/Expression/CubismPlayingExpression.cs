namespace Live2D.Cubism.Framework.Expression;

public class CubismPlayingExpression
{
	[SerializeField]
	public string Type; //Field offset: 0x8
	[SerializeField]
	public float FadeInTime; //Field offset: 0xC
	[SerializeField]
	public float FadeOutTime; //Field offset: 0x10
	[Range(0, 1)]
	[SerializeField]
	public float Weight; //Field offset: 0x14
	[SerializeField]
	public float ExpressionUserTime; //Field offset: 0x18
	[SerializeField]
	public float ExpressionStartTime; //Field offset: 0x1C
	[SerializeField]
	public float ExpressionEndTime; //Field offset: 0x20
	[SerializeField]
	public CubismParameter[] Destinations; //Field offset: 0x24
	[SerializeField]
	public Single[] Value; //Field offset: 0x28
	[SerializeField]
	public CubismParameterBlendMode[] Blend; //Field offset: 0x2C
	[HideInInspector]
	public float FadeWeight; //Field offset: 0x30
	[HideInInspector]
	public float FadeInWeight; //Field offset: 0x34
	[HideInInspector]
	public float FadeOutWeight; //Field offset: 0x38

	public CubismPlayingExpression() { }

	public static CubismPlayingExpression Create(CubismModel model, CubismExpressionData expressionData) { }

}


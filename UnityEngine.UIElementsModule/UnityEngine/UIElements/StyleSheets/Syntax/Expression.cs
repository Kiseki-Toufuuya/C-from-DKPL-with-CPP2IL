namespace UnityEngine.UIElements.StyleSheets.Syntax;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class Expression
{
	public ExpressionType type; //Field offset: 0x8
	public ExpressionMultiplier multiplier; //Field offset: 0xC
	public DataType dataType; //Field offset: 0x18
	public ExpressionCombinator combinator; //Field offset: 0x1C
	public Expression[] subExpressions; //Field offset: 0x20
	public string keyword; //Field offset: 0x24

	public Expression(ExpressionType type) { }

}


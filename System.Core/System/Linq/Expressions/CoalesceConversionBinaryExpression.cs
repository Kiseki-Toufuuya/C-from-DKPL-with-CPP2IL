namespace System.Linq.Expressions;

internal sealed class CoalesceConversionBinaryExpression : BinaryExpression
{
	private readonly LambdaExpression _conversion; //Field offset: 0x10

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public virtual Type Type
	{
		 get { } //Length: 40
	}

	internal CoalesceConversionBinaryExpression(Expression left, Expression right, LambdaExpression conversion) { }

	public virtual ExpressionType get_NodeType() { }

	public virtual Type get_Type() { }

	internal virtual LambdaExpression GetConversion() { }

}


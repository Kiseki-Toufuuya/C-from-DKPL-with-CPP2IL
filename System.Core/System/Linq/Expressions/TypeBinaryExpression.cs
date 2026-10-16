namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(TypeBinaryExpressionProxy))]
public sealed class TypeBinaryExpression : Expression
{
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly Type <TypeOperand>k__BackingField; //Field offset: 0x10

	public Expression Expression
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual ExpressionType NodeType
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual Type Type
	{
		 get { } //Length: 43
	}

	public Type TypeOperand
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal TypeBinaryExpression(Expression expression, Type typeOperand, ExpressionType nodeType) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CompilerGenerated]
	public Expression get_Expression() { }

	[CompilerGenerated]
	public virtual ExpressionType get_NodeType() { }

	public virtual Type get_Type() { }

	[CompilerGenerated]
	public Type get_TypeOperand() { }

	public TypeBinaryExpression Update(Expression expression) { }

}


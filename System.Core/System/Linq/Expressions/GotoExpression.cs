namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(GotoExpressionProxy))]
public sealed class GotoExpression : Expression
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly Expression <Value>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly LabelTarget <Target>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly GotoExpressionKind <Kind>k__BackingField; //Field offset: 0x14

	public GotoExpressionKind Kind
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public LabelTarget Target
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public Expression Value
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal GotoExpression(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CompilerGenerated]
	public GotoExpressionKind get_Kind() { }

	public virtual ExpressionType get_NodeType() { }

	[CompilerGenerated]
	public LabelTarget get_Target() { }

	[CompilerGenerated]
	public virtual Type get_Type() { }

	[CompilerGenerated]
	public Expression get_Value() { }

	public GotoExpression Update(LabelTarget target, Expression value) { }

}


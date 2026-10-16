namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(TryExpressionProxy))]
public sealed class TryExpression : Expression
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <Finally>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly Expression <Fault>k__BackingField; //Field offset: 0x18

	public Expression Body
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public Expression Fault
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public Expression Finally
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public ReadOnlyCollection<CatchBlock> Handlers
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public virtual Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal TryExpression(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CompilerGenerated]
	public Expression get_Body() { }

	[CompilerGenerated]
	public Expression get_Fault() { }

	[CompilerGenerated]
	public Expression get_Finally() { }

	[CompilerGenerated]
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	public virtual ExpressionType get_NodeType() { }

	[CompilerGenerated]
	public virtual Type get_Type() { }

	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }

}


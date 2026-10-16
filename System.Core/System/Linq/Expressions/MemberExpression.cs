namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MemberExpressionProxy))]
public class MemberExpression : Expression
{
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x8

	public Expression Expression
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public MemberInfo Member
	{
		 get { } //Length: 28
	}

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	internal MemberExpression(Expression expression) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CompilerGenerated]
	public Expression get_Expression() { }

	public MemberInfo get_Member() { }

	public virtual ExpressionType get_NodeType() { }

	[ExcludeFromCodeCoverage]
	internal override MemberInfo GetMember() { }

	internal static PropertyExpression Make(Expression expression, PropertyInfo property) { }

	internal static FieldExpression Make(Expression expression, FieldInfo field) { }

	public MemberExpression Update(Expression expression) { }

}


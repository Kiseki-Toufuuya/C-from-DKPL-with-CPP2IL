namespace System.Linq.Expressions;

internal sealed class MethodCallExpression4 : MethodCallExpression, IArgumentProvider
{
	private object _arg0; //Field offset: 0xC
	private readonly Expression _arg1; //Field offset: 0x10
	private readonly Expression _arg2; //Field offset: 0x14
	private readonly Expression _arg3; //Field offset: 0x18

	public virtual int ArgumentCount
	{
		 get { } //Length: 6
	}

	public MethodCallExpression4(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}


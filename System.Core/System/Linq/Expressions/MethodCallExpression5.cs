namespace System.Linq.Expressions;

internal sealed class MethodCallExpression5 : MethodCallExpression, IArgumentProvider
{
	private object _arg0; //Field offset: 0xC
	private readonly Expression _arg1; //Field offset: 0x10
	private readonly Expression _arg2; //Field offset: 0x14
	private readonly Expression _arg3; //Field offset: 0x18
	private readonly Expression _arg4; //Field offset: 0x1C

	public virtual int ArgumentCount
	{
		 get { } //Length: 6
	}

	public MethodCallExpression5(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}


namespace System.Linq.Expressions;

internal class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider
{
	private readonly Expression _instance; //Field offset: 0xC

	public InstanceMethodCallExpression(MethodInfo method, Expression instance) { }

	internal virtual Expression GetInstance() { }

}


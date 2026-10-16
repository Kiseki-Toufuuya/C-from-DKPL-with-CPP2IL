namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(RuntimeVariablesExpressionProxy))]
public sealed class RuntimeVariablesExpression : Expression
{
	[CompilerGenerated]
	private readonly ReadOnlyCollection<ParameterExpression> <Variables>k__BackingField; //Field offset: 0x8

	public ReadOnlyCollection<ParameterExpression> Variables
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	[CompilerGenerated]
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

}


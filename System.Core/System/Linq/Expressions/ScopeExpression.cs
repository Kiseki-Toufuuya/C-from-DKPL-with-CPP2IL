namespace System.Linq.Expressions;

internal class ScopeExpression : BlockExpression
{
	private IReadOnlyList<ParameterExpression> _variables; //Field offset: 0x8

	protected IReadOnlyList<ParameterExpression> VariablesList
	{
		 get { } //Length: 11
	}

	internal ScopeExpression(IReadOnlyList<ParameterExpression> variables) { }

	protected IReadOnlyList<ParameterExpression> get_VariablesList() { }

	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables) { }

}


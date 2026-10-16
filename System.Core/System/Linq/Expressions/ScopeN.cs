namespace System.Linq.Expressions;

internal class ScopeN : ScopeExpression
{
	private IReadOnlyList<Expression> _body; //Field offset: 0xC

	protected IReadOnlyList<Expression> Body
	{
		 get { } //Length: 11
	}

	internal virtual int ExpressionCount
	{
		internal get { } //Length: 66
	}

	internal ScopeN(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body) { }

	protected IReadOnlyList<Expression> get_Body() { }

	internal virtual int get_ExpressionCount() { }

	internal virtual Expression GetExpression(int index) { }

	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}


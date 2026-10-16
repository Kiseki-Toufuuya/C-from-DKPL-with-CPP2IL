namespace System.Linq.Expressions.Interpreter;

internal sealed class LocalVariables
{
	private sealed class VariableScope
	{
		public readonly int Start; //Field offset: 0x8
		public int Stop; //Field offset: 0xC
		public readonly LocalVariable Variable; //Field offset: 0x10
		public readonly VariableScope Parent; //Field offset: 0x14
		public List<VariableScope> ChildScopes; //Field offset: 0x18

		public VariableScope(LocalVariable variable, int start, VariableScope parent) { }

	}

	private readonly HybridReferenceDictionary<ParameterExpression, VariableScope> _variables; //Field offset: 0x8
	private Dictionary<ParameterExpression, LocalVariable> _closureVariables; //Field offset: 0xC
	private int _localCount; //Field offset: 0x10
	private int _maxLocalCount; //Field offset: 0x14

	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
	{
		internal get { } //Length: 11
	}

	public int LocalCount
	{
		 get { } //Length: 11
	}

	public LocalVariables() { }

	internal LocalVariable AddClosureVariable(ParameterExpression variable) { }

	internal void Box(ParameterExpression variable, InstructionList instructions) { }

	public LocalDefinition DefineLocal(ParameterExpression variable, int start) { }

	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	public int get_LocalCount() { }

	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) { }

	public void UndefineLocal(LocalDefinition definition, int end) { }

}


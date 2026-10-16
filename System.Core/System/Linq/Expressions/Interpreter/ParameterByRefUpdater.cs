namespace System.Linq.Expressions.Interpreter;

internal sealed class ParameterByRefUpdater : ByRefUpdater
{
	private readonly LocalVariable _parameter; //Field offset: 0xC

	public ParameterByRefUpdater(LocalVariable parameter, int argumentIndex) { }

	public virtual void Update(InterpretedFrame frame, object value) { }

}


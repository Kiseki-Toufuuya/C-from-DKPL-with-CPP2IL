namespace System.Linq.Expressions.Interpreter;

internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction
{
	private readonly ByRefUpdater[] _byrefArgs; //Field offset: 0x10

	public virtual int ProducedStack
	{
		 get { } //Length: 105
	}

	internal ByRefMethodInfoCallInstruction(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}


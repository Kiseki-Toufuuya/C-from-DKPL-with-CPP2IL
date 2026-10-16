namespace System.Linq.Expressions.Interpreter;

internal class MethodInfoCallInstruction : CallInstruction
{
	protected readonly MethodInfo _target; //Field offset: 0x8
	protected readonly int _argumentCount; //Field offset: 0xC

	public virtual int ArgumentCount
	{
		 get { } //Length: 11
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 105
	}

	internal MethodInfoCallInstruction(MethodInfo target, int argumentCount) { }

	public virtual int get_ArgumentCount() { }

	public virtual int get_ProducedStack() { }

	protected Object[] GetArgs(InterpretedFrame frame, int first, int skip) { }

	public virtual int Run(InterpretedFrame frame) { }

	public virtual string ToString() { }

}


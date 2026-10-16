namespace System.Linq.Expressions.Interpreter;

internal sealed class LoadObjectInstruction : Instruction
{
	private readonly object _value; //Field offset: 0x8

	public virtual string InstructionName
	{
		 get { } //Length: 35
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	internal LoadObjectInstruction(object value) { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

	public virtual string ToString() { }

}


namespace System.Linq.Expressions.Interpreter;

internal sealed class StringSwitchInstruction : Instruction
{
	private readonly Dictionary<String, Int32> _cases; //Field offset: 0x8
	private readonly StrongBox<Int32> _nullCase; //Field offset: 0xC

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 35
	}

	internal StringSwitchInstruction(Dictionary<String, Int32> cases, StrongBox<Int32> nullCase) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}


namespace System.Linq.Expressions.Interpreter;

internal sealed class BranchFalseInstruction : OffsetInstruction
{
	private static Instruction[] s_cache; //Field offset: 0x0

	public virtual Instruction[] Cache
	{
		 get { } //Length: 105
	}

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 35
	}

	public BranchFalseInstruction() { }

	public virtual Instruction[] get_Cache() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}


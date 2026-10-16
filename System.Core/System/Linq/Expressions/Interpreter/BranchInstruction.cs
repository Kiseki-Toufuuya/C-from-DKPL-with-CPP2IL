namespace System.Linq.Expressions.Interpreter;

internal class BranchInstruction : OffsetInstruction
{
	private static Instruction[][][] s_caches; //Field offset: 0x0
	internal readonly bool _hasResult; //Field offset: 0xC
	internal readonly bool _hasValue; //Field offset: 0xD

	public virtual Instruction[] Cache
	{
		 get { } //Length: 562
	}

	public virtual int ConsumedStack
	{
		 get { } //Length: 16
	}

	public virtual string InstructionName
	{
		 get { } //Length: 35
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 16
	}

	internal BranchInstruction() { }

	public BranchInstruction(bool hasResult, bool hasValue) { }

	public virtual Instruction[] get_Cache() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}


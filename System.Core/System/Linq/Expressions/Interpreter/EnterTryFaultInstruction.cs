namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction
{
	private TryFaultHandler _tryHandler; //Field offset: 0xC

	internal TryFaultHandler Handler
	{
		internal get { } //Length: 11
	}

	public virtual string InstructionName
	{
		 get { } //Length: 35
	}

	public virtual int ProducedContinuations
	{
		 get { } //Length: 6
	}

	internal EnterTryFaultInstruction(int targetIndex) { }

	internal TryFaultHandler get_Handler() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedContinuations() { }

	public virtual int Run(InterpretedFrame frame) { }

	internal void SetTryHandler(TryFaultHandler tryHandler) { }

}


namespace System.Linq.Expressions.Interpreter;

internal sealed class ArrayByRefUpdater : ByRefUpdater
{
	private readonly LocalDefinition _array; //Field offset: 0xC
	private readonly LocalDefinition _index; //Field offset: 0x14

	public ArrayByRefUpdater(LocalDefinition array, LocalDefinition index, int argumentIndex) { }

	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	public virtual void Update(InterpretedFrame frame, object value) { }

}


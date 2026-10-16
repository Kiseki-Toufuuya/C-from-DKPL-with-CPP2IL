namespace System.Linq.Expressions.Interpreter;

internal sealed class CastToEnumInstruction : CastInstruction
{
	private readonly Type _t; //Field offset: 0x8

	public CastToEnumInstruction(Type t) { }

	public virtual int Run(InterpretedFrame frame) { }

}


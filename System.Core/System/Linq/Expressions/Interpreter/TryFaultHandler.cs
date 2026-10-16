namespace System.Linq.Expressions.Interpreter;

internal sealed class TryFaultHandler
{
	internal readonly int TryStartIndex; //Field offset: 0x8
	internal readonly int TryEndIndex; //Field offset: 0xC
	internal readonly int FinallyStartIndex; //Field offset: 0x10
	internal readonly int FinallyEndIndex; //Field offset: 0x14

	internal TryFaultHandler(int tryStart, int tryEnd, int finallyStart, int finallyEnd) { }

}


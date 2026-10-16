namespace System.Linq.Expressions.Interpreter;

internal sealed class ExceptionFilter
{
	public readonly int LabelIndex; //Field offset: 0x8
	public readonly int StartIndex; //Field offset: 0xC
	public readonly int EndIndex; //Field offset: 0x10

	internal ExceptionFilter(int labelIndex, int start, int end) { }

}


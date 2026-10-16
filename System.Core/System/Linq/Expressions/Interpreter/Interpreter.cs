namespace System.Linq.Expressions.Interpreter;

internal sealed class Interpreter
{
	internal static readonly object NoValue; //Field offset: 0x0
	private readonly InstructionArray _instructions; //Field offset: 0x8
	internal readonly Object[] _objects; //Field offset: 0x20
	internal readonly RuntimeLabel[] _labels; //Field offset: 0x24
	internal readonly DebugInfo[] _debugInfos; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private readonly int <LocalCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly Dictionary<ParameterExpression, LocalVariable> <ClosureVariables>k__BackingField; //Field offset: 0x34

	internal int ClosureSize
	{
		internal get { } //Length: 63
	}

	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal InstructionArray Instructions
	{
		internal get { } //Length: 28
	}

	internal int LocalCount
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal string Name
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	private static Interpreter() { }

	internal Interpreter(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos) { }

	internal int get_ClosureSize() { }

	[CompilerGenerated]
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	internal InstructionArray get_Instructions() { }

	[CompilerGenerated]
	internal int get_LocalCount() { }

	[CompilerGenerated]
	internal string get_Name() { }

	public void Run(InterpretedFrame frame) { }

}


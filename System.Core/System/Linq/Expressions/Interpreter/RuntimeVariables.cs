namespace System.Linq.Expressions.Interpreter;

internal sealed class RuntimeVariables : IRuntimeVariables
{
	private readonly IStrongBox[] _boxes; //Field offset: 0x8

	private RuntimeVariables(IStrongBox[] boxes) { }

	internal static IRuntimeVariables Create(IStrongBox[] boxes) { }

}


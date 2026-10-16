namespace System.Data;

internal sealed class Function
{
	internal static String[] s_functionName; //Field offset: 0x0
	internal readonly string _name; //Field offset: 0x8
	internal readonly FunctionId _id; //Field offset: 0xC
	internal readonly Type _result; //Field offset: 0x10
	internal readonly bool _isValidateArguments; //Field offset: 0x14
	internal readonly bool _isVariantArgumentList; //Field offset: 0x15
	internal readonly int _argumentCount; //Field offset: 0x18
	internal readonly Type[] _parameters; //Field offset: 0x1C

	private static Function() { }

	internal Function(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

}


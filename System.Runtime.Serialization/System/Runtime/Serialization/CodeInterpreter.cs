namespace System.Runtime.Serialization;

internal static class CodeInterpreter
{

	private static bool CanConvert(TypeCode typeCode) { }

	internal static object ConvertValue(object arg, Type source, Type target) { }

	public static object GetMember(MemberInfo memberInfo, object instance) { }

	private static object InternalConvert(object arg, Type source, Type target, bool isAddress) { }

	public static void SetMember(MemberInfo memberInfo, object instance, object value) { }

}


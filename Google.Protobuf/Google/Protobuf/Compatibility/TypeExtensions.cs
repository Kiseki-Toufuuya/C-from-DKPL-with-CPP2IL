namespace Google.Protobuf.Compatibility;

[Extension]
internal static class TypeExtensions
{

	[Extension]
	internal static MethodInfo GetMethod(Type target, string name) { }

	[Extension]
	internal static PropertyInfo GetProperty(Type target, string name) { }

	[Extension]
	internal static bool IsAssignableFrom(Type target, Type c) { }

}


namespace System.Reflection;

[Extension]
public static class RuntimeReflectionExtensions
{

	[Extension]
	public static FieldInfo GetRuntimeField(Type type, string name) { }

	[Extension]
	public static MethodInfo GetRuntimeMethod(Type type, string name, Type[] parameters) { }

	[Extension]
	public static PropertyInfo GetRuntimeProperty(Type type, string name) { }

}


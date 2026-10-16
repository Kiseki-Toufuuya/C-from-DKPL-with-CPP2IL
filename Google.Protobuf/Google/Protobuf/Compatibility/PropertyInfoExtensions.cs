namespace Google.Protobuf.Compatibility;

[Extension]
internal static class PropertyInfoExtensions
{

	[Extension]
	internal static MethodInfo GetGetMethod(PropertyInfo target) { }

	[Extension]
	internal static MethodInfo GetSetMethod(PropertyInfo target) { }

}


namespace Live2D.Cubism.Framework;

[Extension]
internal static class ObjectExtensionMethods
{

	[Extension]
	public static T GetInterface(object self) { }

	[Extension]
	public static bool ImplementsInterface(object self) { }

	[Extension]
	public static object ToNullUnlessImplementsInterface(object self) { }

}


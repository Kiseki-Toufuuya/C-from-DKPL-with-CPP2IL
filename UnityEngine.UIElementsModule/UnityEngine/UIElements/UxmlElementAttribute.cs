namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False)]
public class UxmlElementAttribute : Attribute
{
	public readonly string name; //Field offset: 0x8
	public LibraryVisibility visibility; //Field offset: 0xC
	internal readonly Type[] supportedChildTypes; //Field offset: 0x10

	public UxmlElementAttribute(string uxmlName) { }

	public UxmlElementAttribute(string uxmlName, Type[] supportedTypes) { }

}


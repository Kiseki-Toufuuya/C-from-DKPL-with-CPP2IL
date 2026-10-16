namespace UnityEngine.UIElements;

[AttributeUsage(384, Inherited = False)]
public class UxmlObjectReferenceAttribute : Attribute
{
	public string name; //Field offset: 0x8
	public Type[] types; //Field offset: 0xC

	public UxmlObjectReferenceAttribute() { }

	public UxmlObjectReferenceAttribute(string uxmlName) { }

	public UxmlObjectReferenceAttribute(string uxmlName, Type[] acceptedTypes) { }

}


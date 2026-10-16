namespace UnityEngine.UIElements;

[AttributeUsage(384)]
public class UxmlAttributeAttribute : Attribute
{
	public string name; //Field offset: 0x8
	public String[] obsoleteNames; //Field offset: 0xC

	public UxmlAttributeAttribute() { }

	public UxmlAttributeAttribute(string name) { }

	public UxmlAttributeAttribute(string name, String[] obsoleteNames) { }

}


namespace UnityEngine.UIElements;

[IsReadOnly]
public struct UxmlAttributeNames
{
	public readonly string fieldName; //Field offset: 0x0
	public readonly string uxmlName; //Field offset: 0x4
	public readonly Type typeReference; //Field offset: 0x8
	public readonly String[] obsoleteNames; //Field offset: 0xC

	public UxmlAttributeNames(string fieldName, string uxmlName, Type typeReference = null, String[] obsoleteNames) { }

}


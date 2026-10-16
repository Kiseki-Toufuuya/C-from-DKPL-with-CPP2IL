namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4))]
internal class MenuCategoryAttribute : Attribute
{
	public readonly string category; //Field offset: 0x8

	public MenuCategoryAttribute(string category) { }

}


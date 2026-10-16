namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Class (4))]
internal class EventCategoryAttribute : Attribute
{
	internal EventCategory category; //Field offset: 0x8

	public EventCategoryAttribute(EventCategory category) { }

}


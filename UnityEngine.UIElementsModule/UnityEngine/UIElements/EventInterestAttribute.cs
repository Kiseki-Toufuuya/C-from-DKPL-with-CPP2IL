namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
public class EventInterestAttribute : Attribute
{
	internal Type[] eventTypes; //Field offset: 0x8
	internal EventCategoryFlags categoryFlags; //Field offset: 0xC

	public EventInterestAttribute(Type[] eventTypes) { }

	public EventInterestAttribute(EventInterestOptions interests) { }

	internal EventInterestAttribute(EventInterestOptionsInternal interests) { }

}


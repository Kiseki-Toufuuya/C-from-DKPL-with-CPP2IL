namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4))]
public class TrackBindingTypeAttribute : Attribute
{
	public readonly Type type; //Field offset: 0x8
	public readonly TrackBindingFlags flags; //Field offset: 0xC

	public TrackBindingTypeAttribute(Type type) { }

	public TrackBindingTypeAttribute(Type type, TrackBindingFlags flags) { }

}


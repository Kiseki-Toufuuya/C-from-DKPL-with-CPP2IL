namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = True)]
public class TrackClipTypeAttribute : Attribute
{
	public readonly Type inspectedType; //Field offset: 0x8
	public readonly bool allowAutoCreate; //Field offset: 0xC

	public TrackClipTypeAttribute(Type clipClass) { }

	public TrackClipTypeAttribute(Type clipClass, bool allowAutoCreate) { }

}


namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4))]
[Obsolete("TrackMediaType has been deprecated. It is no longer required, and will be removed in a future release.", False)]
public class TrackMediaType : Attribute
{
	public readonly MediaType m_MediaType; //Field offset: 0x8

	public TrackMediaType(MediaType mt) { }

}


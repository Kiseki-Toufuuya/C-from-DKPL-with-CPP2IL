namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4))]
public class TrackColorAttribute : Attribute
{
	private Color m_Color; //Field offset: 0x8

	public Color color
	{
		 get { } //Length: 18
	}

	public TrackColorAttribute(float r, float g, float b) { }

	public Color get_color() { }

}


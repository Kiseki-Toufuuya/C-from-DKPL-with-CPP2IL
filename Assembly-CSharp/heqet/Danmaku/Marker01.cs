namespace Heqet.Danmaku;

[CustomStyle("Marker01")]
[DisplayName("Heqet/マーカー01")]
public class Marker01 : MarkerBase
{
	public string message; //Field offset: 0x20

	public virtual int ID
	{
		 get { } //Length: 6
	}

	public virtual string Name
	{
		 get { } //Length: 35
	}

	public Marker01() { }

	public virtual int get_ID() { }

	public virtual string get_Name() { }

}


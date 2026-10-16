namespace Heqet.Danmaku;

[CustomStyle("JumpMarker")]
[DisplayName("Heqet/JumpMarker")]
public class JumpMarker : MarkerBase
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

	public JumpMarker() { }

	public virtual int get_ID() { }

	public virtual string get_Name() { }

}


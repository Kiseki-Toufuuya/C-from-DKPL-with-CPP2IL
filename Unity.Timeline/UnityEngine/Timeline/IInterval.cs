namespace UnityEngine.Timeline;

internal interface IInterval
{

	public long intervalEnd
	{
		 get { } //Length: 0
	}

	public long intervalStart
	{
		 get { } //Length: 0
	}

	public long get_intervalEnd() { }

	public long get_intervalStart() { }

}


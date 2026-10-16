namespace XeSys.Gfx;

public class TimeMap
{
	[SerializeField]
	private List<TimeMapData> m_DataList; //Field offset: 0x8

	public List<TimeMapData> DataList
	{
		 get { } //Length: 11
	}

	public int DataListCount
	{
		 get { } //Length: 53
	}

	public TimeMap(int count) { }

	public void AddTimeMapData(TimeMapData data) { }

	public List<TimeMapData> get_DataList() { }

	public int get_DataListCount() { }

	public float GetPlayFrame(float time, float frameSec) { }

	private float GetPlayFrameQuadratic(float time, float start, float end, float strength) { }

}


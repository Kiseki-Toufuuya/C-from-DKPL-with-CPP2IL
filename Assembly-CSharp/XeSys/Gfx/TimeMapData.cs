namespace XeSys.Gfx;

public struct TimeMapData
{
	internal enum TimeMapType
	{
		None = 0,
		Quadratic = 1,
		CustomElm = 2,
	}

	public TimeMapType TmType; //Field offset: 0x0
	public int Strength; //Field offset: 0x4
	public int StartFrame; //Field offset: 0x8
	public int EndFrame; //Field offset: 0xC
	public List<CustomTimeMapElm> CustomTimeMapElmList; //Field offset: 0x10

	public int ElmCount
	{
		 get { } //Length: 53
	}

	public TimeMapData(int start, int end, TimeMapType tmType, int strength, int elemNum) { }

	public void AddCustomTimeMapElm(float point, float next, float prev) { }

	public int get_ElmCount() { }

	public float GetPlayFrameCustom(float time, float start, float end) { }

}


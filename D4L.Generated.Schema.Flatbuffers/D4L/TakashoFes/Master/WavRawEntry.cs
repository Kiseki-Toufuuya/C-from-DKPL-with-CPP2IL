namespace D4L.TakashoFes.Master;

public struct WavRawEntry
{
	private Table __p; //Field offset: 0x0

	public long CuesheetID
	{
		 get { } //Length: 62
	}

	public int DataVersion
	{
		 get { } //Length: 60
	}

	public long DecKey
	{
		 get { } //Length: 62
	}

	public int Enable
	{
		 get { } //Length: 60
	}

	public int ID
	{
		 get { } //Length: 60
	}

	public WavRawEntry __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public long get_CuesheetID() { }

	public int get_DataVersion() { }

	public long get_DecKey() { }

	public int get_Enable() { }

	public int get_ID() { }

}


namespace D4L.TakashoFes.Master;

public struct PKVSRawEntry
{
	private Table __p; //Field offset: 0x0

	public long CloseAt
	{
		 get { } //Length: 62
	}

	public int DataVersion
	{
		 get { } //Length: 60
	}

	public int Enable
	{
		 get { } //Length: 60
	}

	public int ID
	{
		 get { } //Length: 60
	}

	public int ImageId
	{
		 get { } //Length: 60
	}

	public string Label
	{
		 get { } //Length: 48
	}

	public long OpenAt
	{
		 get { } //Length: 62
	}

	public int PKVSType
	{
		 get { } //Length: 60
	}

	public PKVSRawEntry __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public long get_CloseAt() { }

	public int get_DataVersion() { }

	public int get_Enable() { }

	public int get_ID() { }

	public int get_ImageId() { }

	public string get_Label() { }

	public long get_OpenAt() { }

	public int get_PKVSType() { }

}


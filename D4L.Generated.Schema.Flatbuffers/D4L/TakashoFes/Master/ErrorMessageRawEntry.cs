namespace D4L.TakashoFes.Master;

public struct ErrorMessageRawEntry
{
	private Table __p; //Field offset: 0x0

	public string ErrorMessage
	{
		 get { } //Length: 48
	}

	public string ErrorTitle
	{
		 get { } //Length: 48
	}

	public int ID
	{
		 get { } //Length: 60
	}

	public ErrorMessageRawEntry __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public string get_ErrorMessage() { }

	public string get_ErrorTitle() { }

	public int get_ID() { }

}


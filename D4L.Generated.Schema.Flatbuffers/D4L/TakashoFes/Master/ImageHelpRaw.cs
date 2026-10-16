namespace D4L.TakashoFes.Master;

public struct ImageHelpRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public ImageHelpRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<ImageHelpRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static ImageHelpRaw GetRootAsImageHelpRaw(ByteBuffer _bb) { }

	public static ImageHelpRaw GetRootAsImageHelpRaw(ByteBuffer _bb, ImageHelpRaw obj) { }

}


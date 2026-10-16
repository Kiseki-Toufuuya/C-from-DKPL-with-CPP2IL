namespace Ionic.BZip2;

internal class WorkItem
{
	public int index; //Field offset: 0x8
	[CompilerGenerated]
	private BZip2Compressor <Compressor>k__BackingField; //Field offset: 0xC
	public MemoryStream ms; //Field offset: 0x10
	public int ordinal; //Field offset: 0x14
	public BitWriter bw; //Field offset: 0x18

	public private BZip2Compressor Compressor
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public WorkItem(int ix, int blockSize) { }

	[CompilerGenerated]
	public BZip2Compressor get_Compressor() { }

	[CompilerGenerated]
	private void set_Compressor(BZip2Compressor value) { }

}


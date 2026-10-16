namespace CriWare.CriMana;

public class FrameInfo
{
	public int frameNo; //Field offset: 0x8
	public int frameNoPerFile; //Field offset: 0xC
	public uint width; //Field offset: 0x10
	public uint height; //Field offset: 0x14
	public uint dispWidth; //Field offset: 0x18
	public uint dispHeight; //Field offset: 0x1C
	public uint numImages; //Field offset: 0x20
	public uint framerateN; //Field offset: 0x24
	public uint framerateD; //Field offset: 0x28
	private uint _reserved1; //Field offset: 0x2C
	public ulong time; //Field offset: 0x30
	public ulong tunit; //Field offset: 0x38
	public uint cntConcatenatedMovie; //Field offset: 0x40
	private AlphaType alphaType; //Field offset: 0x44
	public uint cntSkippedFrames; //Field offset: 0x48
	public uint totalFramesPerFile; //Field offset: 0x4C
	public ColorSpaceConversionType colorConv; //Field offset: 0x50
	private int padding; //Field offset: 0x54

	public FrameInfo() { }

}


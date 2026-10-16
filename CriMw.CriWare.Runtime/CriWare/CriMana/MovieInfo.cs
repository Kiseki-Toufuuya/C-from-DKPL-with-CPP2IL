namespace CriWare.CriMana;

public class MovieInfo
{
	private uint _reserved1; //Field offset: 0x8
	public uint numAlphaStreams; //Field offset: 0xC
	public uint width; //Field offset: 0x10
	public uint height; //Field offset: 0x14
	public uint dispWidth; //Field offset: 0x18
	public uint dispHeight; //Field offset: 0x1C
	public uint framerateN; //Field offset: 0x20
	public uint framerateD; //Field offset: 0x24
	public uint totalFrames; //Field offset: 0x28
	public CodecType codecType; //Field offset: 0x2C
	public CodecType alphaCodecType; //Field offset: 0x30
	public uint numAudioStreams; //Field offset: 0x34
	public AudioInfo[] audioPrm; //Field offset: 0x38
	public uint numSubtitleChannels; //Field offset: 0x3C
	public uint maxSubtitleSize; //Field offset: 0x40
	public uint maxChunkSize; //Field offset: 0x44

	public internal bool hasAlpha
	{
		 get { } //Length: 15
		internal set { } //Length: 24
	}

	public MovieInfo() { }

	public bool get_hasAlpha() { }

	internal void set_hasAlpha(bool value) { }

}


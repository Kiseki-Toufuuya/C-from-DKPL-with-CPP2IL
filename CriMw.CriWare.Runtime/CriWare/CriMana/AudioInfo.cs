namespace CriWare.CriMana;

public struct AudioInfo
{
	public uint samplingRate; //Field offset: 0x0
	public uint numChannels; //Field offset: 0x4
	public uint totalSamples; //Field offset: 0x8
	public AudioCodecType codecType; //Field offset: 0xC

}


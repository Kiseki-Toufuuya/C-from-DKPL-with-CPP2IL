namespace XeApp.Game.Net;

public class LoadContext
{
	public string Name; //Field offset: 0x8
	public bool IsDone; //Field offset: 0xC
	public bool IsError; //Field offset: 0xD
	public Byte[] RawBytes; //Field offset: 0x10
	public TarFile Tar; //Field offset: 0x14
	public CriAtomCueSheet CueSheet; //Field offset: 0x18

	public LoadContext() { }

}


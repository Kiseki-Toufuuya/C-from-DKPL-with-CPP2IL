namespace XeApp.Core;

public class PhotoContentValue
{
	public int FmtVer; //Field offset: 0x8
	public int Salt; //Field offset: 0xC
	public int RWidth; //Field offset: 0x10
	public int RHeight; //Field offset: 0x14
	public long Date; //Field offset: 0x18
	public string ContentID; //Field offset: 0x20
	public string FileID; //Field offset: 0x24

	public PhotoContentValue() { }

}


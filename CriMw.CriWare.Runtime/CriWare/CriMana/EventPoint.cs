namespace CriWare.CriMana;

public struct EventPoint
{
	public IntPtr cueName; //Field offset: 0x0
	public uint cueNameSize; //Field offset: 0x4
	public ulong time; //Field offset: 0x8
	public ulong tunit; //Field offset: 0x10
	public int type; //Field offset: 0x18
	public IntPtr paramString; //Field offset: 0x1C
	public uint paramStringSize; //Field offset: 0x20
	public uint cntCallback; //Field offset: 0x24

}


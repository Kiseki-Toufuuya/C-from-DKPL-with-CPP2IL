namespace System.Security.Cryptography;

[ComVisible(True)]
public struct DSAParameters
{
	public Byte[] P; //Field offset: 0x0
	public Byte[] Q; //Field offset: 0x4
	public Byte[] G; //Field offset: 0x8
	public Byte[] Y; //Field offset: 0xC
	public Byte[] J; //Field offset: 0x10
	public Byte[] X; //Field offset: 0x14
	public Byte[] Seed; //Field offset: 0x18
	public int Counter; //Field offset: 0x1C

}


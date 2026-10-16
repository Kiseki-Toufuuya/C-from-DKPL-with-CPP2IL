namespace System.Security.Cryptography;

[ComVisible(True)]
public struct RSAParameters
{
	public Byte[] Exponent; //Field offset: 0x0
	public Byte[] Modulus; //Field offset: 0x4
	public Byte[] P; //Field offset: 0x8
	public Byte[] Q; //Field offset: 0xC
	public Byte[] DP; //Field offset: 0x10
	public Byte[] DQ; //Field offset: 0x14
	public Byte[] InverseQ; //Field offset: 0x18
	public Byte[] D; //Field offset: 0x1C

}


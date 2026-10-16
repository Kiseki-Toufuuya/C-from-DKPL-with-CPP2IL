namespace System.Security.Cryptography;

internal class RC2Transform : SymmetricTransform
{
	private static readonly Byte[] pitable; //Field offset: 0x0
	private ushort R0; //Field offset: 0x34
	private ushort R1; //Field offset: 0x36
	private ushort R2; //Field offset: 0x38
	private ushort R3; //Field offset: 0x3A
	private UInt16[] K; //Field offset: 0x3C
	private int j; //Field offset: 0x40

	private static RC2Transform() { }

	public RC2Transform(RC2 rc2Algo, bool encryption, Byte[] key, Byte[] iv) { }

	protected virtual void ECB(Byte[] input, Byte[] output) { }

}


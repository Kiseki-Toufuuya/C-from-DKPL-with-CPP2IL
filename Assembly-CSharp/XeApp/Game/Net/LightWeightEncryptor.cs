namespace XeApp.Game.Net;

public class LightWeightEncryptor : ICustomEncryptor
{
	private readonly Byte[] swizzleBytes; //Field offset: 0x8
	private readonly int Coef; //Field offset: 0xC
	private readonly int Offset; //Field offset: 0x10

	public LightWeightEncryptor(uint seed, int initSpin, int tableSize) { }

	public override void Modify(Byte[] dataBytes, int offset, int count, long streamOffset, int salt) { }

	public override Byte[] Transform(Byte[] inputBytes, int inputOffset, int inputCount) { }

}


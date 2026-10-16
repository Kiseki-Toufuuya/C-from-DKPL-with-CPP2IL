namespace XeApp.Game.Net;

public class RijndaelEncryptor : IDisposable, ICustomEncryptor
{
	private RijndaelManaged rijndael; //Field offset: 0x8
	private ICryptoTransform cryptoTransform; //Field offset: 0xC
	private bool disposedValue; //Field offset: 0x10

	public RijndaelEncryptor(string pw, string salt, bool decrypt) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public override void Modify(Byte[] dataBytes, int offset, int count, long streamOffset, int salt) { }

	public override Byte[] Transform(Byte[] inputBytes, int inputOffset, int inputCount) { }

}


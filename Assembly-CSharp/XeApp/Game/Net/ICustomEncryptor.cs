namespace XeApp.Game.Net;

public interface ICustomEncryptor
{

	public void Modify(Byte[] dataBytes, int offset, int count, long streamOffset, int salt) { }

	public Byte[] Transform(Byte[] inputBytes, int inputOffset, int inputCount) { }

}


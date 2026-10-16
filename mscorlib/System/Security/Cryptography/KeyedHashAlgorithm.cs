namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class KeyedHashAlgorithm : HashAlgorithm
{
	protected Byte[] KeyValue; //Field offset: 0x18

	public override Byte[] Key
	{
		 get { } //Length: 101
		 set { } //Length: 236
	}

	protected KeyedHashAlgorithm() { }

	public static KeyedHashAlgorithm Create() { }

	public static KeyedHashAlgorithm Create(string algName) { }

	protected virtual void Dispose(bool disposing) { }

	public override Byte[] get_Key() { }

	public override void set_Key(Byte[] value) { }

}


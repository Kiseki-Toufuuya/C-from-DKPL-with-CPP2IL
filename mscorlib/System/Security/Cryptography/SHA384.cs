namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class SHA384 : HashAlgorithm
{

	protected SHA384() { }

	public static SHA384 Create() { }

	public static SHA384 Create(string hashName) { }

}


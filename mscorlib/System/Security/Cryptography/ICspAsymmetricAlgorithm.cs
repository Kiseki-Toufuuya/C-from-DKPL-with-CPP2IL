namespace System.Security.Cryptography;

public interface ICspAsymmetricAlgorithm
{

	public CspKeyContainerInfo CspKeyContainerInfo
	{
		 get { } //Length: 0
	}

	public Byte[] ExportCspBlob(bool includePrivateParameters) { }

	public CspKeyContainerInfo get_CspKeyContainerInfo() { }

	public void ImportCspBlob(Byte[] rawData) { }

}


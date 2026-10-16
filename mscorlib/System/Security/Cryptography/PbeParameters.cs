namespace System.Security.Cryptography;

public sealed class PbeParameters
{
	[CompilerGenerated]
	private readonly PbeEncryptionAlgorithm <EncryptionAlgorithm>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly HashAlgorithmName <HashAlgorithm>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly int <IterationCount>k__BackingField; //Field offset: 0x10

	public PbeEncryptionAlgorithm EncryptionAlgorithm
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public HashAlgorithmName HashAlgorithm
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int IterationCount
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public PbeParameters(PbeEncryptionAlgorithm encryptionAlgorithm, HashAlgorithmName hashAlgorithm, int iterationCount) { }

	[CompilerGenerated]
	public PbeEncryptionAlgorithm get_EncryptionAlgorithm() { }

	[CompilerGenerated]
	public HashAlgorithmName get_HashAlgorithm() { }

	[CompilerGenerated]
	public int get_IterationCount() { }

}


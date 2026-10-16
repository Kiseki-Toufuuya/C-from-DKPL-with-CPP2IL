namespace System.Security.Cryptography.X509Certificates;

public sealed class PublicKey
{
	private static Byte[] Empty; //Field offset: 0x0
	private AsnEncodedData _keyValue; //Field offset: 0x8
	private AsnEncodedData _params; //Field offset: 0xC
	private Oid _oid; //Field offset: 0x10

	public AsnEncodedData EncodedKeyValue
	{
		 get { } //Length: 11
	}

	public AsnEncodedData EncodedParameters
	{
		 get { } //Length: 11
	}

	public AsymmetricAlgorithm Key
	{
		 get { } //Length: 358
	}

	public Oid Oid
	{
		 get { } //Length: 11
	}

	private static PublicKey() { }

	public PublicKey(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) { }

	internal static DSA DecodeDSA(Byte[] rawPublicKey, Byte[] rawParameters) { }

	internal static RSA DecodeRSA(Byte[] rawPublicKey) { }

	public AsnEncodedData get_EncodedKeyValue() { }

	public AsnEncodedData get_EncodedParameters() { }

	public AsymmetricAlgorithm get_Key() { }

	public Oid get_Oid() { }

	private static Byte[] GetUnsignedBigInteger(Byte[] integer) { }

}


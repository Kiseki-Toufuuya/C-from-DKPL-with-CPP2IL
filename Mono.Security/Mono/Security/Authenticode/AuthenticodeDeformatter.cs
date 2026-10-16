namespace Mono.Security.Authenticode;

public class AuthenticodeDeformatter : AuthenticodeBase
{
	private string filename; //Field offset: 0x2C
	private Byte[] rawdata; //Field offset: 0x30
	private Byte[] hash; //Field offset: 0x34
	private X509CertificateCollection coll; //Field offset: 0x38
	private ASN1 signedHash; //Field offset: 0x3C
	private DateTime timestamp; //Field offset: 0x40
	private X509Certificate signingCertificate; //Field offset: 0x48
	private int reason; //Field offset: 0x4C
	private bool trustedRoot; //Field offset: 0x50
	private bool trustedTimestampRoot; //Field offset: 0x51
	private Byte[] entry; //Field offset: 0x54
	private X509Chain signerChain; //Field offset: 0x58
	private X509Chain timestampChain; //Field offset: 0x5C

	public Byte[] RawData
	{
		 set { } //Length: 478
	}

	public X509Certificate SigningCertificate
	{
		 get { } //Length: 11
	}

	public AuthenticodeDeformatter() { }

	public AuthenticodeDeformatter(Byte[] rawData) { }

	private bool CheckSignature() { }

	private bool CompareIssuerSerial(string issuer, Byte[] serial, X509Certificate x509) { }

	public X509Certificate get_SigningCertificate() { }

	private void Reset() { }

	public void set_RawData(Byte[] value) { }

	private bool VerifyCounterSignature(SignerInfo cs, Byte[] signature) { }

	private bool VerifySignature(SignedData sd, Byte[] calculatedMessageDigest, HashAlgorithm ha) { }

}


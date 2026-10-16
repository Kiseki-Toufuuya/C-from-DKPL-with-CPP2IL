namespace Mono.Security.X509;

public class X509Certificate : ISerializable
{
	private static string encoding_error; //Field offset: 0x0
	private ASN1 decoder; //Field offset: 0x8
	private Byte[] m_encodedcert; //Field offset: 0xC
	private DateTime m_from; //Field offset: 0x10
	private DateTime m_until; //Field offset: 0x18
	private ASN1 issuer; //Field offset: 0x20
	private string m_issuername; //Field offset: 0x24
	private string m_keyalgo; //Field offset: 0x28
	private Byte[] m_keyalgoparams; //Field offset: 0x2C
	private ASN1 subject; //Field offset: 0x30
	private string m_subject; //Field offset: 0x34
	private Byte[] m_publickey; //Field offset: 0x38
	private Byte[] signature; //Field offset: 0x3C
	private string m_signaturealgo; //Field offset: 0x40
	private Byte[] m_signaturealgoparams; //Field offset: 0x44
	private Byte[] certhash; //Field offset: 0x48
	private RSA _rsa; //Field offset: 0x4C
	private DSA _dsa; //Field offset: 0x50
	private int version; //Field offset: 0x54
	private Byte[] serialnumber; //Field offset: 0x58
	private Byte[] issuerUniqueID; //Field offset: 0x5C
	private Byte[] subjectUniqueID; //Field offset: 0x60
	private X509ExtensionCollection extensions; //Field offset: 0x64

	public DSA DSA
	{
		 get { } //Length: 699
		 set { } //Length: 56
	}

	public X509ExtensionCollection Extensions
	{
		 get { } //Length: 11
	}

	public Byte[] Hash
	{
		 get { } //Length: 529
	}

	public bool IsCurrent
	{
		 get { } //Length: 251
	}

	public bool IsSelfSigned
	{
		 get { } //Length: 269
	}

	public override string IssuerName
	{
		 get { } //Length: 11
	}

	public override string KeyAlgorithm
	{
		 get { } //Length: 11
	}

	public override Byte[] KeyAlgorithmParameters
	{
		 get { } //Length: 101
		 set { } //Length: 27
	}

	public override Byte[] PublicKey
	{
		 get { } //Length: 101
	}

	public override Byte[] RawData
	{
		 get { } //Length: 101
	}

	public override RSA RSA
	{
		 get { } //Length: 387
		 set { } //Length: 56
	}

	public override Byte[] SerialNumber
	{
		 get { } //Length: 101
	}

	public override Byte[] Signature
	{
		 get { } //Length: 877
	}

	public override string SubjectName
	{
		 get { } //Length: 11
	}

	public override DateTime ValidFrom
	{
		 get { } //Length: 14
	}

	public override DateTime ValidUntil
	{
		 get { } //Length: 14
	}

	public int Version
	{
		 get { } //Length: 11
	}

	private static X509Certificate() { }

	public X509Certificate(Byte[] data) { }

	public DSA get_DSA() { }

	public X509ExtensionCollection get_Extensions() { }

	public Byte[] get_Hash() { }

	public bool get_IsCurrent() { }

	public bool get_IsSelfSigned() { }

	public override string get_IssuerName() { }

	public override string get_KeyAlgorithm() { }

	public override Byte[] get_KeyAlgorithmParameters() { }

	public override Byte[] get_PublicKey() { }

	public override Byte[] get_RawData() { }

	public override RSA get_RSA() { }

	public override Byte[] get_SerialNumber() { }

	public override Byte[] get_Signature() { }

	public override string get_SubjectName() { }

	public override DateTime get_ValidFrom() { }

	public override DateTime get_ValidUntil() { }

	public int get_Version() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	private void Parse(Byte[] data) { }

	private static Byte[] PEM(string type, Byte[] data) { }

	public void set_DSA(DSA value) { }

	public override void set_KeyAlgorithmParameters(Byte[] value) { }

	public override void set_RSA(RSA value) { }

	internal bool VerifySignature(DSA dsa) { }

	internal bool VerifySignature(RSA rsa) { }

	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	public bool WasCurrent(DateTime instant) { }

}


namespace System.Security.Cryptography.X509Certificates;

public class X509Certificate2 : X509Certificate
{
	private Byte[] lazyRawData; //Field offset: 0x38
	private Oid lazySignatureAlgorithm; //Field offset: 0x3C
	private int lazyVersion; //Field offset: 0x40
	private X500DistinguishedName lazySubjectName; //Field offset: 0x44
	private X500DistinguishedName lazyIssuerName; //Field offset: 0x48
	private PublicKey lazyPublicKey; //Field offset: 0x4C
	private AsymmetricAlgorithm lazyPrivateKey; //Field offset: 0x50
	private X509ExtensionCollection lazyExtensions; //Field offset: 0x54

	public X509ExtensionCollection Extensions
	{
		 get { } //Length: 733
	}

	public bool HasPrivateKey
	{
		 get { } //Length: 57
	}

	internal X509Certificate2Impl Impl
	{
		internal get { } //Length: 129
	}

	public X500DistinguishedName IssuerName
	{
		 get { } //Length: 98
	}

	public DateTime NotAfter
	{
		 get { } //Length: 16
	}

	public DateTime NotBefore
	{
		 get { } //Length: 16
	}

	public AsymmetricAlgorithm PrivateKey
	{
		 get { } //Length: 354
	}

	public PublicKey PublicKey
	{
		 get { } //Length: 290
	}

	public Byte[] RawData
	{
		 get { } //Length: 107
	}

	public string SerialNumber
	{
		 get { } //Length: 28
	}

	public Oid SignatureAlgorithm
	{
		 get { } //Length: 107
	}

	public X500DistinguishedName SubjectName
	{
		 get { } //Length: 98
	}

	public string Thumbprint
	{
		 get { } //Length: 42
	}

	public int Version
	{
		 get { } //Length: 88
	}

	public X509Certificate2() { }

	public X509Certificate2(Byte[] rawData) { }

	public X509Certificate2(Byte[] rawData, string password) { }

	public X509Certificate2(Byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	internal X509Certificate2(X509Certificate2Impl impl) { }

	public X509Certificate2(X509Certificate certificate) { }

	protected X509Certificate2(SerializationInfo info, StreamingContext context) { }

	private static X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	public X509ExtensionCollection get_Extensions() { }

	public bool get_HasPrivateKey() { }

	internal X509Certificate2Impl get_Impl() { }

	public X500DistinguishedName get_IssuerName() { }

	public DateTime get_NotAfter() { }

	public DateTime get_NotBefore() { }

	public AsymmetricAlgorithm get_PrivateKey() { }

	public PublicKey get_PublicKey() { }

	public Byte[] get_RawData() { }

	public string get_SerialNumber() { }

	public Oid get_SignatureAlgorithm() { }

	public X500DistinguishedName get_SubjectName() { }

	public string get_Thumbprint() { }

	public int get_Version() { }

	public static X509ContentType GetCertContentType(Byte[] rawData) { }

	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	public virtual void Reset() { }

	public virtual string ToString() { }

	public virtual string ToString(bool verbose) { }

	public bool Verify() { }

}


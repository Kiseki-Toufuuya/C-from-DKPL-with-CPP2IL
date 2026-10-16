namespace Mono.Security.X509;

public class X509Store
{
	private string _storePath; //Field offset: 0x8
	private X509CertificateCollection _certificates; //Field offset: 0xC
	private ArrayList _crls; //Field offset: 0x10
	private bool _crl; //Field offset: 0x14
	private bool _newFormat; //Field offset: 0x15

	public X509CertificateCollection Certificates
	{
		 get { } //Length: 46
	}

	public ArrayList Crls
	{
		 get { } //Length: 120
	}

	internal X509Store(string path, bool crl, bool newFormat) { }

	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	private ArrayList BuildCrlsCollection(string storeName) { }

	private bool CheckStore(string path, bool throwException) { }

	public X509CertificateCollection get_Certificates() { }

	public ArrayList get_Crls() { }

	private Byte[] Load(string filename) { }

	private X509Certificate LoadCertificate(string filename) { }

	private X509Crl LoadCrl(string filename) { }

}


namespace Mono.Security;

public sealed class PKCS7
{
	internal class ContentInfo
	{
		private string contentType; //Field offset: 0x8
		private ASN1 content; //Field offset: 0xC

		public ASN1 ASN1
		{
			 get { } //Length: 327
		}

		public ASN1 Content
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public string ContentType
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public ContentInfo() { }

		public ContentInfo(string oid) { }

		public ContentInfo(Byte[] data) { }

		public ContentInfo(ASN1 asn1) { }

		public ASN1 get_ASN1() { }

		public ASN1 get_Content() { }

		public string get_ContentType() { }

		internal ASN1 GetASN1() { }

		public void set_Content(ASN1 value) { }

		public void set_ContentType(string value) { }

	}

	internal class EncryptedData
	{
		private byte _version; //Field offset: 0x8
		private ContentInfo _content; //Field offset: 0xC
		private ContentInfo _encryptionAlgorithm; //Field offset: 0x10
		private Byte[] _encrypted; //Field offset: 0x14

		public Byte[] EncryptedContent
		{
			 get { } //Length: 101
		}

		public ContentInfo EncryptionAlgorithm
		{
			 get { } //Length: 11
		}

		public EncryptedData() { }

		public EncryptedData(ASN1 asn1) { }

		public Byte[] get_EncryptedContent() { }

		public ContentInfo get_EncryptionAlgorithm() { }

	}

	internal class SignedData
	{
		private byte version; //Field offset: 0x8
		private string hashAlgorithm; //Field offset: 0xC
		private ContentInfo contentInfo; //Field offset: 0x10
		private X509CertificateCollection certs; //Field offset: 0x14
		private ArrayList crls; //Field offset: 0x18
		private SignerInfo signerInfo; //Field offset: 0x1C
		private bool mda; //Field offset: 0x20

		public X509CertificateCollection Certificates
		{
			 get { } //Length: 11
		}

		public ContentInfo ContentInfo
		{
			 get { } //Length: 11
		}

		public string HashName
		{
			 set { } //Length: 59
		}

		public SignerInfo SignerInfo
		{
			 get { } //Length: 11
		}

		public SignedData(ASN1 asn1) { }

		public X509CertificateCollection get_Certificates() { }

		public ContentInfo get_ContentInfo() { }

		public SignerInfo get_SignerInfo() { }

		internal string OidToName(string oid) { }

		public void set_HashName(string value) { }

	}

	internal class SignerInfo
	{
		private byte version; //Field offset: 0x8
		private string hashAlgorithm; //Field offset: 0xC
		private ArrayList authenticatedAttributes; //Field offset: 0x10
		private ArrayList unauthenticatedAttributes; //Field offset: 0x14
		private Byte[] signature; //Field offset: 0x18
		private string issuer; //Field offset: 0x1C
		private Byte[] serial; //Field offset: 0x20
		private Byte[] ski; //Field offset: 0x24

		public ArrayList AuthenticatedAttributes
		{
			 get { } //Length: 11
		}

		public string HashName
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public string IssuerName
		{
			 get { } //Length: 11
		}

		public Byte[] SerialNumber
		{
			 get { } //Length: 101
		}

		public Byte[] Signature
		{
			 get { } //Length: 101
		}

		public ArrayList UnauthenticatedAttributes
		{
			 get { } //Length: 11
		}

		public byte Version
		{
			 get { } //Length: 11
		}

		public SignerInfo() { }

		public SignerInfo(ASN1 asn1) { }

		public ArrayList get_AuthenticatedAttributes() { }

		public string get_HashName() { }

		public string get_IssuerName() { }

		public Byte[] get_SerialNumber() { }

		public Byte[] get_Signature() { }

		public ArrayList get_UnauthenticatedAttributes() { }

		public byte get_Version() { }

		public void set_HashName(string value) { }

	}


}


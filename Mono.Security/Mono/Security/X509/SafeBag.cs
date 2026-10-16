namespace Mono.Security.X509;

internal class SafeBag
{
	private string _bagOID; //Field offset: 0x8
	private ASN1 _asn1; //Field offset: 0xC

	public ASN1 ASN1
	{
		 get { } //Length: 11
	}

	public string BagOID
	{
		 get { } //Length: 11
	}

	public SafeBag(string bagOID, ASN1 asn1) { }

	public ASN1 get_ASN1() { }

	public string get_BagOID() { }

}


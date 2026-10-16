namespace Mono.Security.X509.Extensions;

public class AuthorityKeyIdentifierExtension : X509Extension
{
	private Byte[] aki; //Field offset: 0x14

	public Byte[] Identifier
	{
		 get { } //Length: 101
	}

	public AuthorityKeyIdentifierExtension(X509Extension extension) { }

	protected virtual void Decode() { }

	protected virtual void Encode() { }

	public Byte[] get_Identifier() { }

	public virtual string ToString() { }

}


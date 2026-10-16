namespace Mono.Security.X509.Extensions;

public class BasicConstraintsExtension : X509Extension
{
	private bool cA; //Field offset: 0x14
	private int pathLenConstraint; //Field offset: 0x18

	public bool CertificateAuthority
	{
		 get { } //Length: 11
	}

	public BasicConstraintsExtension(X509Extension extension) { }

	protected virtual void Decode() { }

	protected virtual void Encode() { }

	public bool get_CertificateAuthority() { }

	public virtual string ToString() { }

}


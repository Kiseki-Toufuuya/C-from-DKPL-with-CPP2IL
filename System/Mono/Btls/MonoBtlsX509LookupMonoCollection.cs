namespace Mono.Btls;

internal class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
{
	private Int64[] hashes; //Field offset: 0x24
	private MonoBtlsX509[] certificates; //Field offset: 0x28
	private X509CertificateCollection collection; //Field offset: 0x2C
	private MonoBtlsX509TrustKind trust; //Field offset: 0x30

	internal MonoBtlsX509LookupMonoCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	protected virtual void Close() { }

	private void Initialize() { }

	protected virtual MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

}


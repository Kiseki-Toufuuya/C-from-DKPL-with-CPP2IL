namespace System.Net;

internal class ServerCertValidationCallback
{
	private class CallbackContext
	{
		internal readonly object request; //Field offset: 0x8
		internal readonly X509Certificate certificate; //Field offset: 0xC
		internal readonly X509Chain chain; //Field offset: 0x10
		internal readonly SslPolicyErrors sslPolicyErrors; //Field offset: 0x14
		internal bool result; //Field offset: 0x18

		internal CallbackContext(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	}

	private readonly RemoteCertificateValidationCallback m_ValidationCallback; //Field offset: 0x8
	private readonly ExecutionContext m_Context; //Field offset: 0xC

	internal RemoteCertificateValidationCallback ValidationCallback
	{
		internal get { } //Length: 11
	}

	internal ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback) { }

	internal void Callback(object state) { }

	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}


namespace Mono.Http;

internal class NtlmSession
{
	private MessageBase message; //Field offset: 0x8

	public NtlmSession() { }

	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

}


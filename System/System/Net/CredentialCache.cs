namespace System.Net;

public class CredentialCache
{

	public static ICredentials DefaultCredentials
	{
		 get { } //Length: 60
	}

	public static NetworkCredential DefaultNetworkCredentials
	{
		 get { } //Length: 60
	}

	public static ICredentials get_DefaultCredentials() { }

	public static NetworkCredential get_DefaultNetworkCredentials() { }

}


namespace Mono.Security.Interface;

public class ValidationResult
{
	private bool trusted; //Field offset: 0x8
	private bool user_denied; //Field offset: 0x9
	private int error_code; //Field offset: 0xC
	private Nullable<MonoSslPolicyErrors> policy_errors; //Field offset: 0x10

	public bool Trusted
	{
		 get { } //Length: 11
	}

	public bool UserDenied
	{
		 get { } //Length: 11
	}

	public ValidationResult(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	public bool get_Trusted() { }

	public bool get_UserDenied() { }

}


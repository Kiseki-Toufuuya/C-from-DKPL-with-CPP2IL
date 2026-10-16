namespace Unity.Services.Core;

internal class ExternalUserIdProperty
{
	[CompilerGenerated]
	private Action<String> UserIdChanged; //Field offset: 0x8
	private string m_UserId; //Field offset: 0xC

	public event Action<String> UserIdChanged
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	public string UserId
	{
		 get { } //Length: 11
		 set { } //Length: 53
	}

	public ExternalUserIdProperty() { }

	[CompilerGenerated]
	public void add_UserIdChanged(Action<String> value) { }

	public string get_UserId() { }

	[CompilerGenerated]
	public void remove_UserIdChanged(Action<String> value) { }

	public void set_UserId(string value) { }

}


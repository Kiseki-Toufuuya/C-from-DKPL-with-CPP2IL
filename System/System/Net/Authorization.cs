namespace System.Net;

public class Authorization
{
	private string m_Message; //Field offset: 0x8
	private bool m_Complete; //Field offset: 0xC
	internal string ModuleAuthenticationType; //Field offset: 0x10

	public bool Complete
	{
		 get { } //Length: 11
	}

	public string Message
	{
		 get { } //Length: 11
	}

	public Authorization(string token) { }

	public Authorization(string token, bool finished) { }

	public bool get_Complete() { }

	public string get_Message() { }

}


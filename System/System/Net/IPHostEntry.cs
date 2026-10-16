namespace System.Net;

public class IPHostEntry
{
	private string hostName; //Field offset: 0x8
	private String[] aliases; //Field offset: 0xC
	private IPAddress[] addressList; //Field offset: 0x10
	internal bool isTrustedHost; //Field offset: 0x14

	public IPAddress[] AddressList
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public String[] Aliases
	{
		 set { } //Length: 27
	}

	public string HostName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public IPHostEntry() { }

	public IPAddress[] get_AddressList() { }

	public string get_HostName() { }

	public void set_AddressList(IPAddress[] value) { }

	public void set_Aliases(String[] value) { }

	public void set_HostName(string value) { }

}


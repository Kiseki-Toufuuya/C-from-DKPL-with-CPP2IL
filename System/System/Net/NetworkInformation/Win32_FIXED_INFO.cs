namespace System.Net.NetworkInformation;

internal struct Win32_FIXED_INFO
{
	public string HostName; //Field offset: 0x0
	public string DomainName; //Field offset: 0x4
	public IntPtr CurrentDnsServer; //Field offset: 0x8
	public Win32_IP_ADDR_STRING DnsServerList; //Field offset: 0xC
	public NetBiosNodeType NodeType; //Field offset: 0x1C
	public string ScopeId; //Field offset: 0x20
	public uint EnableRouting; //Field offset: 0x24
	public uint EnableProxy; //Field offset: 0x28
	public uint EnableDns; //Field offset: 0x2C

}


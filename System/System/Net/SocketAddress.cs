namespace System.Net;

[DefaultMember("Item")]
public class SocketAddress
{
	internal int m_Size; //Field offset: 0x8
	internal Byte[] m_Buffer; //Field offset: 0xC
	private bool m_changed; //Field offset: 0x10
	private int m_hash; //Field offset: 0x14

	public AddressFamily Family
	{
		 get { } //Length: 52
	}

	public byte Item
	{
		 get { } //Length: 94
	}

	public int Size
	{
		 get { } //Length: 11
	}

	public SocketAddress(AddressFamily family, int size) { }

	internal SocketAddress(IPAddress ipAddress) { }

	internal SocketAddress(IPAddress ipaddress, int port) { }

	public virtual bool Equals(object comparand) { }

	public AddressFamily get_Family() { }

	public byte get_Item(int offset) { }

	public int get_Size() { }

	public virtual int GetHashCode() { }

	internal IPAddress GetIPAddress() { }

	internal IPEndPoint GetIPEndPoint() { }

	public virtual string ToString() { }

}


namespace System.Net;

public class IPEndPoint : EndPoint
{
	internal static IPEndPoint Any; //Field offset: 0x0
	internal static IPEndPoint IPv6Any; //Field offset: 0x4
	private IPAddress _address; //Field offset: 0x8
	private int _port; //Field offset: 0xC

	public IPAddress Address
	{
		 get { } //Length: 11
	}

	public virtual AddressFamily AddressFamily
	{
		 get { } //Length: 37
	}

	public int Port
	{
		 get { } //Length: 11
	}

	private static IPEndPoint() { }

	public IPEndPoint(IPAddress address, int port) { }

	public virtual EndPoint Create(SocketAddress socketAddress) { }

	public virtual bool Equals(object comparand) { }

	public IPAddress get_Address() { }

	public virtual AddressFamily get_AddressFamily() { }

	public int get_Port() { }

	public virtual int GetHashCode() { }

	public virtual SocketAddress Serialize() { }

	public virtual string ToString() { }

}


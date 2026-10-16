namespace HostIO;

public class Client
{
	private int port; //Field offset: 0x8
	private string host; //Field offset: 0xC
	private Byte[] header; //Field offset: 0x10
	private Byte[] recvBuffer; //Field offset: 0x14
	private TcpClient client; //Field offset: 0x18
	private NetworkStream ns; //Field offset: 0x1C
	private RPCCommand rpcCommand; //Field offset: 0x20
	private Byte[] recvData; //Field offset: 0x24
	private int returnCode; //Field offset: 0x28

	public Client(string host, int port) { }

	public void Disconnect() { }

	private bool ReadData(NetworkStream ns) { }

	private int RPCCall(CommandID cmd, byte option, Byte[] sendData) { }

	public String[] SimpleDirGetFiles(string dir, string searchOption) { }

	public int SimpleEcho(string str) { }

	public void SimpleFileAppend(string path, Byte[] writeBytes) { }

	public Byte[] SimpleFileRead(string path) { }

	public void SimpleFileWrite(string path, Byte[] writeBytes) { }

	public void SimpleLog(string path, string log) { }

	public bool StartConnection() { }

}


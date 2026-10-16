namespace HostIO;

internal class RPCCommand
{
	internal enum CommandID
	{
		Nop = 0,
		Disconnect = 1,
		Echo = 2,
		FileOpen = 3,
		FileClose = 4,
		FileRead = 5,
		FileWrite = 6,
		DirGetFiles = 7,
	}

	private sealed class RPCAction : MulticastDelegate
	{

		public RPCAction(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(byte option, Byte[] dataBytes, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(byte option, Byte[] dataBytes) { }

	}

	private sealed class RPCRequest : MulticastDelegate
	{

		public RPCRequest(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(byte option, Byte[] dataBytes, AsyncCallback callback, object object) { }

		public override Byte[] EndInvoke(IAsyncResult result) { }

		public override Byte[] Invoke(byte option, Byte[] dataBytes) { }

	}

	public const int POS_SIGNATURE_0 = 0; //Field offset: 0x0
	public const int POS_SIGNATURE_1 = 1; //Field offset: 0x0
	public const int POS_COMMAND = 2; //Field offset: 0x0
	public const int POS_OPTION = 3; //Field offset: 0x0
	public const int POS_RETURN = 8; //Field offset: 0x0
	public const int POS_DATASIZE = 12; //Field offset: 0x0
	public const int HEADER_SIZE = 16; //Field offset: 0x0
	public const byte SIGNATURE_0 = 69; //Field offset: 0x0
	public const byte SIGNATURE_1 = 118; //Field offset: 0x0
	private Byte[] sendData; //Field offset: 0x8
	private string fileServerBaseDir; //Field offset: 0xC
	private int returnCode; //Field offset: 0x10
	private FileStream fs; //Field offset: 0x14
	private Dictionary<Byte, RPCAction> serverActionMap; //Field offset: 0x18
	private Dictionary<Byte, RPCRequest> clientRequestMap; //Field offset: 0x1C

	public string FileServerBaseDir
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int ReturnCode
	{
		 get { } //Length: 11
	}

	public Byte[] SendData
	{
		 get { } //Length: 11
	}

	public RPCCommand() { }

	private bool ActionDirGetFiles(byte option, Byte[] dataBytes) { }

	private bool ActionDisconnect(byte option, Byte[] dataBytes) { }

	private bool ActionEcho(byte option, Byte[] dataBytes) { }

	private bool ActionFileClose(byte option, Byte[] dataBytes) { }

	private bool ActionFileOpen(byte option, Byte[] dataBytes) { }

	private bool ActionFileRead(byte option, Byte[] dataBytes) { }

	private bool ActionFileWrite(byte option, Byte[] dataBytes) { }

	private bool ActionNop(byte option, Byte[] dataBytes) { }

	public bool Dispatch(byte cmd, byte option, Byte[] dataBytes) { }

	public string get_FileServerBaseDir() { }

	public int get_ReturnCode() { }

	public Byte[] get_SendData() { }

	public static bool IsValidHeader(Byte[] header) { }

	private Byte[] MakeHeader(CommandID id, byte option, Byte[] dataBytes) { }

	public void Recv(byte cmd, byte option, int ret, Byte[] dataBytes) { }

	private Byte[] RequesDirGetFiles(byte option, Byte[] dataBytes) { }

	public Byte[] Request(byte cmd, byte option, Byte[] dataBytes) { }

	private Byte[] RequestDisconnect(byte option, Byte[] dataBytes) { }

	private Byte[] RequestEcho(byte option, Byte[] dataBytes) { }

	private Byte[] RequestFileClose(byte option, Byte[] dataBytes) { }

	private Byte[] RequestFileOpen(byte option, Byte[] dataBytes) { }

	private Byte[] RequestFileRead(byte option, Byte[] dataBytes) { }

	private Byte[] RequestFileWrite(byte option, Byte[] dataBytes) { }

	private Byte[] RequestNop(byte option, Byte[] dataBytes) { }

	public void set_FileServerBaseDir(string value) { }

}


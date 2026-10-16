namespace System;

internal class TermInfoDriver : IConsoleDriver
{
	private static Int32* native_terminal_size; //Field offset: 0x0
	private static int terminal_size; //Field offset: 0x4
	private static readonly String[] locations; //Field offset: 0x8
	private static readonly Int32[] _consoleColorToAnsiCode; //Field offset: 0xC
	private TermInfoReader reader; //Field offset: 0x8
	private int cursorLeft; //Field offset: 0xC
	private int cursorTop; //Field offset: 0x10
	private string title; //Field offset: 0x14
	private string titleFormat; //Field offset: 0x18
	private bool cursorVisible; //Field offset: 0x1C
	private string csrVisible; //Field offset: 0x20
	private string csrInvisible; //Field offset: 0x24
	private string clear; //Field offset: 0x28
	private string bell; //Field offset: 0x2C
	private string term; //Field offset: 0x30
	private StreamReader stdin; //Field offset: 0x34
	private CStreamWriter stdout; //Field offset: 0x38
	private int windowWidth; //Field offset: 0x3C
	private int windowHeight; //Field offset: 0x40
	private int bufferHeight; //Field offset: 0x44
	private int bufferWidth; //Field offset: 0x48
	private Char[] buffer; //Field offset: 0x4C
	private int readpos; //Field offset: 0x50
	private int writepos; //Field offset: 0x54
	private string keypadXmit; //Field offset: 0x58
	private string keypadLocal; //Field offset: 0x5C
	private bool inited; //Field offset: 0x60
	private object initLock; //Field offset: 0x64
	private bool initKeys; //Field offset: 0x68
	private string origPair; //Field offset: 0x6C
	private string origColors; //Field offset: 0x70
	private string cursorAddress; //Field offset: 0x74
	private ConsoleColor fgcolor; //Field offset: 0x78
	private string setfgcolor; //Field offset: 0x7C
	private string setbgcolor; //Field offset: 0x80
	private int maxColors; //Field offset: 0x84
	private bool noGetPosition; //Field offset: 0x88
	private Hashtable keymap; //Field offset: 0x8C
	private ByteMatcher rootmap; //Field offset: 0x90
	private int rl_startx; //Field offset: 0x94
	private int rl_starty; //Field offset: 0x98
	private Byte[] control_characters; //Field offset: 0x9C
	private Char[] echobuf; //Field offset: 0xA0
	private int echon; //Field offset: 0xA4

	public override bool Initialized
	{
		 get { } //Length: 11
	}

	public override int WindowHeight
	{
		 get { } //Length: 41
	}

	public override int WindowWidth
	{
		 get { } //Length: 41
	}

	private static TermInfoDriver() { }

	public TermInfoDriver(string term) { }

	private void AddStringMapping(TermInfoStrings s) { }

	private void AddToBuffer(int b) { }

	private void AdjustBuffer() { }

	private void CheckWindowDimensions() { }

	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	private void CreateKeyMap() { }

	private void Echo(ConsoleKeyInfo key) { }

	private void EchoFlush() { }

	public override bool get_Initialized() { }

	public override int get_WindowHeight() { }

	public override int get_WindowWidth() { }

	private void GetCursorPosition() { }

	private object GetKeyFromBuffer(bool cooked) { }

	private void IncrementX() { }

	public override void Init() { }

	private void InitKeys() { }

	private bool InputPending() { }

	public bool IsSpecialKey(char c) { }

	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	private void QueueEcho(char c) { }

	public int Read(out Char[] dest, int index, int count) { }

	public override ConsoleKeyInfo ReadKey(bool intercept) { }

	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	public override string ReadLine() { }

	public string ReadToEnd() { }

	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	private static string SearchTerminfo(string term) { }

	public override void SetCursorPosition(int left, int top) { }

	private static string TryTermInfoDir(string dir, string term) { }

	private void WriteConsole(string str) { }

	public void WriteSpecialKey(char c) { }

	public void WriteSpecialKey(ConsoleKeyInfo key) { }

}


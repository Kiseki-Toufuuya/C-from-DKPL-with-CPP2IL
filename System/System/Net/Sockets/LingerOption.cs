namespace System.Net.Sockets;

public class LingerOption
{
	private bool enabled; //Field offset: 0x8
	private int lingerTime; //Field offset: 0xC

	public bool Enabled
	{
		 set { } //Length: 14
	}

	public int LingerTime
	{
		 set { } //Length: 14
	}

	public LingerOption(bool enable, int seconds) { }

	public void set_Enabled(bool value) { }

	public void set_LingerTime(int value) { }

}


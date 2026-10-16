namespace System.Net;

internal class ReceiveState
{
	internal ResponseDescription Resp; //Field offset: 0x8
	internal int ValidThrough; //Field offset: 0xC
	internal Byte[] Buffer; //Field offset: 0x10
	internal CommandStream Connection; //Field offset: 0x14

	internal ReceiveState(CommandStream connection) { }

}


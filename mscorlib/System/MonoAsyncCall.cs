namespace System;

internal class MonoAsyncCall
{
	private object msg; //Field offset: 0x8
	private IntPtr cb_method; //Field offset: 0xC
	private object cb_target; //Field offset: 0x10
	private object state; //Field offset: 0x14
	private object res; //Field offset: 0x18
	private object out_args; //Field offset: 0x1C

	public MonoAsyncCall() { }

}


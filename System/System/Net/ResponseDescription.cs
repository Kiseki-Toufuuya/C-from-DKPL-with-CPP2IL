namespace System.Net;

internal class ResponseDescription
{
	internal bool Multiline; //Field offset: 0x8
	internal int Status; //Field offset: 0xC
	internal string StatusDescription; //Field offset: 0x10
	internal StringBuilder StatusBuffer; //Field offset: 0x14
	internal string StatusCodeString; //Field offset: 0x18

	internal bool InvalidStatusCode
	{
		internal get { } //Length: 28
	}

	internal bool PermanentFailure
	{
		internal get { } //Length: 31
	}

	internal bool PositiveCompletion
	{
		internal get { } //Length: 31
	}

	internal bool PositiveIntermediate
	{
		internal get { } //Length: 28
	}

	internal bool TransientFailure
	{
		internal get { } //Length: 31
	}

	public ResponseDescription() { }

	internal bool get_InvalidStatusCode() { }

	internal bool get_PermanentFailure() { }

	internal bool get_PositiveCompletion() { }

	internal bool get_PositiveIntermediate() { }

	internal bool get_TransientFailure() { }

}


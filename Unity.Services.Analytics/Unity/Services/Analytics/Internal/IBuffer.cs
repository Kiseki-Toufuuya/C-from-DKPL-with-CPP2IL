namespace Unity.Services.Analytics.Internal;

internal interface IBuffer
{

	public int Length
	{
		 get { } //Length: 0
	}

	public void ClearBuffer() { }

	public void ClearBuffer(long upTo) { }

	public void ClearDiskCache() { }

	public void FlushToDisk() { }

	public int get_Length() { }

	public void LoadFromDisk() { }

	public void PushBool(string name, bool value) { }

	public void PushDouble(string name, double value) { }

	public void PushEndEvent() { }

	public void PushInt64(string name, long value) { }

	public void PushStandardEventStart(string name, int version) { }

	public void PushString(string name, string value) { }

	public Byte[] Serialize() { }

}


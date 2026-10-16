namespace Ionic.Zip;

public class ZipProgressEventArgs : EventArgs
{
	private int _entriesTotal; //Field offset: 0x8
	private bool _cancel; //Field offset: 0xC
	private ZipEntry _latestEntry; //Field offset: 0x10
	private ZipProgressEventType _flavor; //Field offset: 0x14
	private string _archiveName; //Field offset: 0x18
	private long _bytesTransferred; //Field offset: 0x20
	private long _totalBytesToTransfer; //Field offset: 0x28

	public string ArchiveName
	{
		 set { } //Length: 27
	}

	public long BytesTransferred
	{
		 set { } //Length: 20
	}

	public bool Cancel
	{
		 get { } //Length: 11
	}

	public ZipEntry CurrentEntry
	{
		 set { } //Length: 27
	}

	public int EntriesTotal
	{
		 set { } //Length: 14
	}

	public ZipProgressEventType EventType
	{
		 set { } //Length: 14
	}

	public long TotalBytesToTransfer
	{
		 set { } //Length: 20
	}

	internal ZipProgressEventArgs() { }

	internal ZipProgressEventArgs(string archiveName, ZipProgressEventType flavor) { }

	public bool get_Cancel() { }

	public void set_ArchiveName(string value) { }

	public void set_BytesTransferred(long value) { }

	public void set_CurrentEntry(ZipEntry value) { }

	public void set_EntriesTotal(int value) { }

	public void set_EventType(ZipProgressEventType value) { }

	public void set_TotalBytesToTransfer(long value) { }

}


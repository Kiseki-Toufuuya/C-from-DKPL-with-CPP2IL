namespace CriWare;

public class CriFsLoadFileRequest : CriFsRequest
{
	private enum Phase
	{
		Stop = 0,
		Bind = 1,
		Load = 2,
		Done = 3,
		Error = 4,
	}

	[CompilerGenerated]
	private string <path>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Byte[] <bytes>k__BackingField; //Field offset: 0x2C
	private Phase phase; //Field offset: 0x30
	private CriFsBinder refBinder; //Field offset: 0x34
	private CriFsBinder newBinder; //Field offset: 0x38
	private uint bindId; //Field offset: 0x3C
	private CriFsLoader loader; //Field offset: 0x40
	private int readUnitSize; //Field offset: 0x44
	private long fileSize; //Field offset: 0x48

	public private Byte[] bytes
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private string path
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CriFsLoadFileRequest(CriFsBinder srcBinder, string path, DoneDelegate doneDelegate, int readUnitSize) { }

	protected virtual void Dispose(bool disposing) { }

	[CompilerGenerated]
	public Byte[] get_bytes() { }

	[CompilerGenerated]
	public string get_path() { }

	private void OnError() { }

	[CompilerGenerated]
	private void set_bytes(Byte[] value) { }

	[CompilerGenerated]
	private void set_path(string value) { }

	public virtual void Stop() { }

	public virtual void Update() { }

	private void UpdateBinder() { }

	private void UpdateLoader() { }

}


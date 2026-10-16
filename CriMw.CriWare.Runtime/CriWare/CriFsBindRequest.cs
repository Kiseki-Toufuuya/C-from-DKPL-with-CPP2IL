namespace CriWare;

public class CriFsBindRequest : CriFsRequest
{
	internal enum BindType
	{
		Cpk = 0,
		Directory = 1,
		File = 2,
	}

	[CompilerGenerated]
	private string <path>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private uint <bindId>k__BackingField; //Field offset: 0x2C

	public private uint bindId
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private string path
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CriFsBindRequest(BindType type, CriFsBinder targetBinder, CriFsBinder srcBinder, string path) { }

	protected virtual void Dispose(bool disposing) { }

	[CompilerGenerated]
	public uint get_bindId() { }

	[CompilerGenerated]
	public string get_path() { }

	[CompilerGenerated]
	private void set_bindId(uint value) { }

	[CompilerGenerated]
	private void set_path(string value) { }

	public virtual void Stop() { }

	public virtual void Update() { }

}


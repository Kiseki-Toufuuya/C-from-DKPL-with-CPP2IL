namespace CriWare;

public class CriFsWebInstallRequest : CriFsInstallRequest
{
	private CriFsWebInstaller installer; //Field offset: 0x34
	private uint crc32; //Field offset: 0x38
	private bool crc32_set; //Field offset: 0x3C

	public CriFsWebInstallRequest(string srcPath, string dstPath, DoneDelegate doneDelegate) { }

	protected virtual void Dispose(bool disposing) { }

	public bool GetCRC32(out uint ret_val) { }

	public virtual void Stop() { }

	public virtual void Update() { }

}


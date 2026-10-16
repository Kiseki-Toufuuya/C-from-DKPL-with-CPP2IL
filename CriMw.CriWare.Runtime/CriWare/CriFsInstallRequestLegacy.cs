namespace CriWare;

[Obsolete("CriFsInstallRequestLegacy is no longer working. Use CriFsWebInstallRequest instead.")]
public class CriFsInstallRequestLegacy : CriFsInstallRequest
{
	private CriFsInstaller installer; //Field offset: 0x34

	public CriFsInstallRequestLegacy(CriFsBinder srcBinder, string srcPath, string dstPath, DoneDelegate doneDelegate, int installBufferSize) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Stop() { }

	public virtual void Update() { }

}


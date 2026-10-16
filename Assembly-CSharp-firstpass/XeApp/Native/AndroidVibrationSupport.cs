namespace XeApp.Native;

public class AndroidVibrationSupport : IDisposable
{
	private bool _disposed; //Field offset: 0x8

	public AndroidVibrationSupport() { }

	public void CallRegisteredVibration(int id) { }

	public void Cancel() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public int GetVibrationType() { }

	public void Init() { }

	public void RegisterOneShot(int id, long milliseconds, int amplitude) { }

	public void RegisterWaveFormt(int id, string timings, string amplitudes, int repeat) { }

}


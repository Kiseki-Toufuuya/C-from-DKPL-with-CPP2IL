namespace Steamworks;

public abstract class Callback
{

	internal abstract void OnRunCallback(IntPtr pvParam) { }

	internal abstract void SetUnregistered() { }

}


namespace System.Runtime.Remoting.Lifetime;

internal class LeaseManager
{
	private ArrayList _objects; //Field offset: 0x8
	private Timer _timer; //Field offset: 0xC

	public LeaseManager() { }

	public void ManageLeases(object state) { }

	public void SetPollTime(TimeSpan timeSpan) { }

	public void StartManager() { }

	public void StopManager() { }

	public void TrackLifetime(ServerIdentity identity) { }

}


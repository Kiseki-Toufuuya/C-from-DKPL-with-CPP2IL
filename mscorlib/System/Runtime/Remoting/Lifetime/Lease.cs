namespace System.Runtime.Remoting.Lifetime;

internal class Lease : MarshalByRefObject, ILease
{
	private sealed class RenewalDelegate : MulticastDelegate
	{

		public RenewalDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

		public override TimeSpan EndInvoke(IAsyncResult result) { }

		public override TimeSpan Invoke(ILease lease) { }

	}

	private DateTime _leaseExpireTime; //Field offset: 0x10
	private LeaseState _currentState; //Field offset: 0x18
	private TimeSpan _initialLeaseTime; //Field offset: 0x20
	private TimeSpan _renewOnCallTime; //Field offset: 0x28
	private TimeSpan _sponsorshipTimeout; //Field offset: 0x30
	private ArrayList _sponsors; //Field offset: 0x38
	private Queue _renewingSponsors; //Field offset: 0x3C
	private RenewalDelegate _renewalDelegate; //Field offset: 0x40

	public override TimeSpan CurrentLeaseTime
	{
		 get { } //Length: 88
	}

	public override LeaseState CurrentState
	{
		 get { } //Length: 11
	}

	public override TimeSpan RenewOnCallTime
	{
		 get { } //Length: 14
	}

	public Lease() { }

	public void Activate() { }

	private void CheckNextSponsor() { }

	public override TimeSpan get_CurrentLeaseTime() { }

	public override LeaseState get_CurrentState() { }

	public override TimeSpan get_RenewOnCallTime() { }

	private void ProcessSponsorResponse(object state, bool timedOut) { }

	public override TimeSpan Renew(TimeSpan renewalTime) { }

	public override void Unregister(ISponsor obj) { }

	internal void UpdateState() { }

}


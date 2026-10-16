//Type is in global namespace

internal sealed class CinemachineMixer : PlayableBehaviour
{
	internal sealed class MasterDirectorDelegate : MulticastDelegate
	{

		public MasterDirectorDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override PlayableDirector EndInvoke(IAsyncResult result) { }

		public override PlayableDirector Invoke() { }

	}

	public static MasterDirectorDelegate GetMasterPlayableDirector; //Field offset: 0x0
	private ICameraOverrideStack m_BrainOverrideStack; //Field offset: 0x8
	private int m_BrainOverrideId; //Field offset: 0xC
	private bool m_PreviewPlay; //Field offset: 0x10

	public CinemachineMixer() { }

	private float GetDeltaTime(float deltaTime) { }

	public virtual void OnPlayableDestroy(Playable playable) { }

	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}


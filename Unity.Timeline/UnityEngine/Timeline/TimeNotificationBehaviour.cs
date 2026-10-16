namespace UnityEngine.Timeline;

public class TimeNotificationBehaviour : PlayableBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<NotificationEntry> <>9__12_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <SortNotifications>b__12_0(NotificationEntry x, NotificationEntry y) { }

	}

	private struct NotificationEntry
	{
		public double time; //Field offset: 0x0
		public INotification payload; //Field offset: 0x8
		public bool notificationFired; //Field offset: 0xC
		public NotificationFlags flags; //Field offset: 0xE

		public bool prewarm
		{
			 get { } //Length: 15
		}

		public bool triggerInEditor
		{
			 get { } //Length: 15
		}

		public bool triggerOnce
		{
			 get { } //Length: 15
		}

		public bool get_prewarm() { }

		public bool get_triggerInEditor() { }

		public bool get_triggerOnce() { }

	}

	private readonly List<NotificationEntry> m_Notifications; //Field offset: 0x8
	private double m_PreviousTime; //Field offset: 0x10
	private bool m_NeedSortNotifications; //Field offset: 0x18
	private Playable m_TimeSource; //Field offset: 0x1C

	public Playable timeSource
	{
		 set { } //Length: 20
	}

	public TimeNotificationBehaviour() { }

	public void AddNotification(double time, INotification payload, NotificationFlags flags = 2) { }

	private static bool CanRestoreNotification(NotificationEntry e, FrameData info, double currentTime, double previousTime) { }

	public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode) { }

	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	public virtual void OnGraphStart(Playable playable) { }

	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	private static void Restore_internal(ref NotificationEntry e) { }

	public void set_timeSource(Playable value) { }

	private void SortNotifications() { }

	private void SyncDurationWithExternalSource(Playable playable) { }

	private static void Trigger_internal(Playable playable, PlayableOutput output, ref NotificationEntry e) { }

	private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState) { }

}


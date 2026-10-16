namespace UnityEngine.Timeline;

[CustomStyle("SignalEmitter")]
[ExcludeFromPreset]
public class SignalEmitter : Marker, INotification, INotificationOptionProvider
{
	[SerializeField]
	private bool m_Retroactive; //Field offset: 0x20
	[SerializeField]
	private bool m_EmitOnce; //Field offset: 0x21
	[SerializeField]
	private SignalAsset m_Asset; //Field offset: 0x24

	public SignalAsset asset
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool emitOnce
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool retroactive
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private override PropertyName UnityEngine.Playables.INotification.id
	{
		private get { } //Length: 165
	}

	private override NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.flags
	{
		private get { } //Length: 41
	}

	public SignalEmitter() { }

	public SignalAsset get_asset() { }

	public bool get_emitOnce() { }

	public bool get_retroactive() { }

	public void set_asset(SignalAsset value) { }

	public void set_emitOnce(bool value) { }

	public void set_retroactive(bool value) { }

	private override PropertyName UnityEngine.Playables.INotification.get_id() { }

	private override NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.get_flags() { }

}


namespace Heqet.Danmaku;

public class PlayEffect : MonoBehaviour, INotificationReceiver
{
	[SerializeField]
	public string effectName; //Field offset: 0x10
	private PropertyName SignalName_PlayEffect; //Field offset: 0x14

	public PlayEffect() { }

	private void Awake() { }

	public override void OnNotify(Playable origin, INotification notification, object context) { }

	public void Play(string name) { }

}


namespace Heqet.Danmaku;

[ExecuteAlways]
public class MyNotificationReceiver : MonoBehaviour, INotificationReceiver
{

	public MyNotificationReceiver() { }

	public override void OnNotify(Playable origin, INotification notification, object context) { }

}


namespace Heqet.Danmaku;

public class TimelineObjectFactory : MonoBehaviour
{
	internal enum ObjectType
	{
		Unknown = 0,
		MoveQuickly1 = 1,
		MoveQuickly2 = 2,
		MoveQuickly3 = 3,
	}

	private static TimelineObjectFactory instance; //Field offset: 0x0
	[SerializeField]
	private GameObject dynamicObject; //Field offset: 0x10
	[SerializeField]
	private GameObject moveQuickly1Prefab; //Field offset: 0x14
	[SerializeField]
	private GameObject moveQuickly2Prefab; //Field offset: 0x18
	[SerializeField]
	private GameObject moveQuickly3Prefab; //Field offset: 0x1C

	public static TimelineObjectFactory Instance
	{
		 get { } //Length: 125
	}

	public TimelineObjectFactory() { }

	public GameObject CreateSTGGimmick(int id) { }

	public static TimelineObjectFactory get_Instance() { }

}


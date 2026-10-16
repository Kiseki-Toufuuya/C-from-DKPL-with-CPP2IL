namespace XeSys.Gfx;

[DisallowMultipleComponent]
public class GameObjectOrderManager : MonoBehaviour
{
	internal interface ISortTarget
	{

		public GameObject GetObject
		{
			 get { } //Length: 0
		}

		public int Priority
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		public GameObject get_GetObject() { }

		public int get_Priority() { }

		public void set_Priority(int value) { }

	}

	private readonly List<ISortTarget> m_sortListFar; //Field offset: 0x10
	private readonly List<ISortTarget> m_sortListNear; //Field offset: 0x14
	private bool m_isRequestSort; //Field offset: 0x18

	public GameObjectOrderManager() { }

	public void Attach(GameObject go) { }

	private void DelaySort() { }

	public void Detach(GameObject go) { }

	public static int GetDirectIndex(GameObject go) { }

	private void LateUpdate() { }

	private static int PrioritySortFar(ISortTarget l, ISortTarget r) { }

	private static int PrioritySortNear(ISortTarget l, ISortTarget r) { }

	public void RequestPrioritySort() { }

	public static void SetDirectIndex(GameObject go, int index) { }

	public static void SetDirectLast(GameObject go) { }

	public static void SetDirectTop(GameObject go) { }

}


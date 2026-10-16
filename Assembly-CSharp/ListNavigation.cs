//Type is in global namespace

public class ListNavigation : MonoBehaviour, IMoveHandler, IEventSystemHandler, INestedSelectable
{
	public Action<AxisEventData> onMove; //Field offset: 0x10
	public Func<GameObject> getSelectGameobject; //Field offset: 0x14
	public Action<AxisEventData> onMovePage; //Field offset: 0x18
	public InputActionReference extraPageNavigationInputAction; //Field offset: 0x1C
	private AxisEventData eventData; //Field offset: 0x20

	public ListNavigation() { }

	public static int GetGridIndex(MoveDirection dir, int index, int maxIndex, int maxX, int maxY, int offsetX = 1, int offsetY = 1, bool isRound = true, bool isNewline = false, Func<Int32, Boolean> ValidateFunc = null) { }

	public static int GetGridNewLineIndex(MoveDirection dir, int nowIndex, int maxIndex, int maxX, int maxY, int offsetX = 1, int offsetY = 1, bool isRound = true, Func<Int32, Boolean> ValidateFunc = null) { }

	public override GameObject GetSelectedGameObject() { }

	public void OnDestroy() { }

	private void OnExtraPageMove(CallbackContext context) { }

	public override void OnMove(AxisEventData eventData) { }

	public void Start() { }

}


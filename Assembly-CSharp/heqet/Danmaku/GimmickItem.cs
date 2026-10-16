namespace Heqet.Danmaku;

public class GimmickItem : MonoBehaviour
{
	[SerializeField]
	private GimmickItemType itemType; //Field offset: 0x10
	[SerializeField]
	private GameObject displayObject; //Field offset: 0x14
	private bool isInitialized; //Field offset: 0x18
	private BoxCollider itemCollider; //Field offset: 0x1C

	public bool IsActive
	{
		 get { } //Length: 34
	}

	public GimmickItemType ItemType
	{
		 get { } //Length: 11
	}

	public GimmickItem() { }

	public void ActivateCollider() { }

	public void Awake() { }

	private void CheckStageItem() { }

	public bool get_IsActive() { }

	public GimmickItemType get_ItemType() { }

	public void Hide() { }

	private void Initialize() { }

	public void InvokeItem() { }

	public void OnTimelineEnd() { }

	public void OnTimelineStart() { }

	public void OnTriggerEnter(Collider other) { }

	public void Show() { }

	private void TakeDropReward() { }

}


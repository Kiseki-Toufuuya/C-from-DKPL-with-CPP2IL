//Type is in global namespace

public class TakashoProbNode : MonoBehaviour
{
	[SerializeField]
	private Text Text_ProductID; //Field offset: 0x10
	[SerializeField]
	private Text Text_Label; //Field offset: 0x14
	[SerializeField]
	private Text Text_Name; //Field offset: 0x18
	[SerializeField]
	private Text Text_Percent; //Field offset: 0x1C

	public TakashoProbNode() { }

	private void Awake() { }

	public void InitItem(int rarityLabel, string itemName, string prob) { }

	public void InitLabel(string label, string prob) { }

	public void InitProductID(string prodId) { }

}


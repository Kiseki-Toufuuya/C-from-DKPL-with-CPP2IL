namespace Heqet;

public class CreditDialog : MonoBehaviour
{
	[SerializeField]
	private CreditScriptableObject creditScriptableObject; //Field offset: 0x10
	[SerializeField]
	private RectTransform contentRectTransform; //Field offset: 0x14

	public CreditDialog() { }

	public void GetLineItem(out List<Data[]>& lineListArray) { }

}


namespace Heqet.WorldMap.UI;

public class DifficultyButton : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI m_TitleText; //Field offset: 0x10
	[SerializeField]
	private TextMeshProUGUI m_NumText; //Field offset: 0x14
	[SerializeField]
	private AtlasImage m_SelectImage; //Field offset: 0x18
	private Color m_originColor; //Field offset: 0x1C

	public DifficultyButton() { }

	private void Awake() { }

	public void SetScoreLevelText(string level) { }

	public void SetSelect(bool isSelect) { }

}


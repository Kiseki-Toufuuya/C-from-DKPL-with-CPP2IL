namespace XeSys;

public class DebugCheatObject_Slider : MonoBehaviour
{
	[SerializeField]
	private Slider m_slider; //Field offset: 0x10
	[SerializeField]
	private Text m_textTitle; //Field offset: 0x14
	[SerializeField]
	private Text m_textValue; //Field offset: 0x18

	public Slider slider
	{
		 get { } //Length: 11
	}

	public Text titleText
	{
		 get { } //Length: 11
	}

	public Text valueText
	{
		 get { } //Length: 11
	}

	public DebugCheatObject_Slider() { }

	public Slider get_slider() { }

	public Text get_titleText() { }

	public Text get_valueText() { }

}


namespace Heqet;

public class SettingKaguraDispComponent : MonoBehaviour
{
	[SerializeField]
	private Sprite m_RadioButtonOn; //Field offset: 0x10
	[SerializeField]
	private Sprite m_RadioButtonOff; //Field offset: 0x14

	public Sprite RadioButtonOFF
	{
		 get { } //Length: 11
	}

	public Sprite RadioButtonOn
	{
		 get { } //Length: 11
	}

	public SettingKaguraDispComponent() { }

	private void Awake() { }

	public Sprite get_RadioButtonOFF() { }

	public Sprite get_RadioButtonOn() { }

	private void Start() { }

}


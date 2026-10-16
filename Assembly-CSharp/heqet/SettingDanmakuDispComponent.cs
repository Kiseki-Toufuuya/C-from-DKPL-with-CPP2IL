namespace Heqet;

public class SettingDanmakuDispComponent : MonoBehaviour
{
	[SerializeField]
	private Sprite m_RadioButtonOn; //Field offset: 0x10
	[SerializeField]
	private Sprite m_RadioButtonOff; //Field offset: 0x14

	public Sprite RadioButtonOff
	{
		 get { } //Length: 11
	}

	public Sprite RadioButtonOn
	{
		 get { } //Length: 11
	}

	public SettingDanmakuDispComponent() { }

	private void Awake() { }

	public Sprite get_RadioButtonOff() { }

	public Sprite get_RadioButtonOn() { }

	private void Start() { }

}


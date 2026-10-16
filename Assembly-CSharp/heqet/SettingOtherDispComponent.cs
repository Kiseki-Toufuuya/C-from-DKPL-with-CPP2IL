namespace Heqet;

public class SettingOtherDispComponent : MonoBehaviour
{
	[SerializeField]
	private Sprite m_RadioButtonOn; //Field offset: 0x10
	[SerializeField]
	private Sprite m_RadioButtonOff; //Field offset: 0x14
	[SerializeField]
	private List<HeqetNavigationTest> m_Navigation; //Field offset: 0x18

	public List<HeqetNavigationTest> Navigation
	{
		 get { } //Length: 11
	}

	public Sprite RadioButtonOFF
	{
		 get { } //Length: 11
	}

	public Sprite RadioButtonOn
	{
		 get { } //Length: 11
	}

	public SettingOtherDispComponent() { }

	private void Awake() { }

	public List<HeqetNavigationTest> get_Navigation() { }

	public Sprite get_RadioButtonOFF() { }

	public Sprite get_RadioButtonOn() { }

	public string GetParentName(GameObject _obj, string _pass) { }

	private void OnValidate() { }

}


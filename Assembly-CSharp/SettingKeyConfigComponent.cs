//Type is in global namespace

public class SettingKeyConfigComponent : MonoBehaviour
{
	[InputControl]
	[SerializeField]
	private string _cancelControlPath; //Field offset: 0x10
	[InputControl]
	[SerializeField]
	private List<String> _ignoreControlPath; //Field offset: 0x14

	public string CancelControlPath
	{
		 get { } //Length: 11
	}

	public List<String> IgnoreControlPath
	{
		 get { } //Length: 11
	}

	public SettingKeyConfigComponent() { }

	private void Awake() { }

	public string get_CancelControlPath() { }

	public List<String> get_IgnoreControlPath() { }

}


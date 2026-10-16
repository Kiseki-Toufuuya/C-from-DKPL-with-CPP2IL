namespace CriWare;

public class CriMonoBehaviourManager : MonoBehaviour
{
	private static CriMonoBehaviourManager _instance; //Field offset: 0x0
	private static List<CriMonoBehaviour> criMonoBehaviourList; //Field offset: 0x4

	public static CriMonoBehaviourManager instance
	{
		 get { } //Length: 212
	}

	private static CriMonoBehaviourManager() { }

	public CriMonoBehaviourManager() { }

	private void Awake() { }

	public static void CreateInstance() { }

	public static CriMonoBehaviourManager get_instance() { }

	private static int GetIndex(CriMonoBehaviour criMonoBehaviour) { }

	private void LateUpdate() { }

	public bool Register(CriMonoBehaviour criMonoBehaviour) { }

	public static bool UnRegister(CriMonoBehaviour criMonoBehaviour) { }

	private void Update() { }

}


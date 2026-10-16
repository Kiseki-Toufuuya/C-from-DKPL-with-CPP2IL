namespace XeApp.Game;

public class Toast : MonoBehaviour
{
	[CompilerGenerated]
	private static Toast <Instance>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private Text ToastText; //Field offset: 0x10
	[SerializeField]
	private GameObject ImageRoot; //Field offset: 0x14
	public Queue<String> TextQueue; //Field offset: 0x18
	private float displayTime; //Field offset: 0x1C
	private int step; //Field offset: 0x20

	public private static Toast Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public Toast() { }

	private void Awake() { }

	[CompilerGenerated]
	public static Toast get_Instance() { }

	public static void Post(string msg) { }

	[CompilerGenerated]
	private static void set_Instance(Toast value) { }

	private void Update() { }

}


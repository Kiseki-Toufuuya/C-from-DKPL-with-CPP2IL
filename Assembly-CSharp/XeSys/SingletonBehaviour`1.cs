namespace XeSys;

public abstract class SingletonBehaviour : MonoBehaviour
{
	private static T mInstance; //Field offset: 0x0

	public static bool HasInstance
	{
		 get { } //Length: 122
	}

	public static T Instance
	{
		 get { } //Length: 610
	}

	protected SingletonBehaviour`1() { }

	protected override void Awake() { }

	protected bool CheckInstance() { }

	public static bool get_HasInstance() { }

	public static T get_Instance() { }

	private void OnDestroy() { }

	public static void Release() { }

}


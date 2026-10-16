namespace XeSys;

public abstract class SingletonMonoBehaviour : MonoBehaviour
{
	private static T mInstance; //Field offset: 0x0
	private static bool mApplicationIsQuitting; //Field offset: 0x0

	public static T Instance
	{
		 get { } //Length: 1220
	}

	protected SingletonMonoBehaviour`1() { }

	public static T get_Instance() { }

	private void OnDestroy() { }

	public static void Release() { }

}


namespace XeSys;

public abstract class Singleton
{
	protected static T instance; //Field offset: 0x0

	public static T Instance
	{
		 get { } //Length: 58
	}

	protected Singleton`1() { }

	public static T Create() { }

	public static T get_Instance() { }

	public static void Release() { }

}


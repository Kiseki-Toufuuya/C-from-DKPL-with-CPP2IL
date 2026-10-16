namespace UnityEngine;

internal class AndroidJavaRunnableProxy : AndroidJavaProxy
{
	private AndroidJavaRunnable mRunnable; //Field offset: 0x10

	public AndroidJavaRunnableProxy(AndroidJavaRunnable runnable) { }

	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	public void run() { }

}

